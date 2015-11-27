using System;
using System.Text;
using System.Windows.Forms;

namespace EnvEditor
{
    public partial class MainForm : Form
    {
        private About about = new About();
        private VariableManager manager = new VariableManager();

        private bool sortAscending = true;

        private VariableType currentVarType = EnvEditor.VariableType.User;
        private string currentVar = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Auxiliary methods

        /// <summary>
        /// Enables or disables "Save" and "Discard" buttons depending on $state value.
        /// </summary>
        private void Changed(bool state)
        {
            BSave.Enabled = state;
            BDiscard.Enabled = state;
        }

        /// <summary>
        /// Returns -1 if there is 0 or more than 1 selected items in PathItems list
        /// else returns the single selected line index.
        /// </summary>
        private int GetSelectedIndex()
        {
            return (PathItems.SelectedIndices.Count == 1) ? PathItems.SelectedIndices[0] : -1;
        }

        /// <summary>
        /// Exchanges the values of two PathItem lines.
        /// </summary>
        /// <param name="index_1">First line index</param>
        /// <param name="index_2">Second line index</param>
        private void SwapPathItemsLines(int index_1, int index_2)
        {
            var items = PathItems.Items;
            var tmp = items[index_1].Text;

            items[index_1].Text = items[index_2].Text;
            items[index_2].Text = tmp;
        }

        /// <summary>
        /// Clears the PathItems list saving the last empty line
        /// used for adding new path items.
        /// </summary>
        private void ClearPathItems()
        {
            PathItems.Items.Clear();
            PathItems.Items.Add("<new item>");
        }

        /// <summary>
        /// Shifts all selected lines in the PathItems list up or down.
        /// </summary>
        /// <param name="delta">Shift length</param>
        private void ShiftSelectedPathItems(int delta)
        {
            int selectedCount = PathItems.SelectedIndices.Count;
            if (selectedCount == 0)
                return;

            /* Get selected lines' indicies */
            var selected = new int[selectedCount];
            PathItems.SelectedIndices.CopyTo(selected, 0);

            /* Exit if the first selected line is on the top of PathItems list while moving up
             * or when the last selected line is on the bottom of PathItems list while shifting down */
            if ((delta <= 0 && selected[0] == 0) ||
                (delta > 0 && (selected[selectedCount - 1] == 0 ||
                               selected[selectedCount - 1] == PathItems.Items.Count - 1)))
            {
                PathItems.Select();
                return;
            }

            /* Shift all selected lines up */
            int line = (delta > 0) ? (selectedCount - 1) : 0;
            do
            {
                SwapPathItemsLines(selected[line], selected[line] += delta);
                line -= delta;
            }
            while (line != -1 && line != selectedCount);

            /* Update selected lines */
            PathItems.SelectedItems.Clear();
            foreach (var index in selected)
                PathItems.SelectedIndices.Add(index);

            /* Set the first or last selected line to be visible and have focus */
            PathItems.Select();
            PathItems.Items[selected[0]].Focused = true;
            PathItems.Items[selected[(delta > 0) ? (selectedCount - 1) : 0]].EnsureVisible();

            Changed(true);
        }

        /// <summary>
        /// Loads user/system environmental variable names into the Variables combobox.
        /// </summary>
        private void LoadVariableNames(VariableType type)
        {
            Variables.Items.Clear();
            Variables.Items.AddRange(manager.GetVariableNames(type));
        }

        /// <summary>
        /// Parses the specified $variable into the PathItems list. 
        /// </summary>
        /// <param name="variable">Environmental variable name</param>
        private void LoadVariable(string variable)
        {
            var value = manager.GetVariableValue(currentVarType, variable) as string;
            if (value == null)
                return;

            PathItems.Items.Clear();
            foreach (var item in value.Split(';'))
                PathItems.Items.Add(item.TrimEnd('\\'));
            PathItems.Items.Add("<new value>");
        }

        /// <summary>
        /// Saves the specified variable from the current key to registry.
        /// </summary>
        /// <param name="variable">Environment variable name</param>
        private void SaveVariable(string variable)
        {
            if (PathItems.Items.Count == 0)
                return;

            var value = new StringBuilder();
            foreach (ListViewItem item in PathItems.Items)
            {
                value.Append(item.Text);
                value.Append(';');
            }
            manager.SetVariableValue(currentVarType, variable, value.ToString(0, value.Length - 13));
        }

        #endregion

        #region Control event handlers

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Variables.Text))
            {
                StatusLabel.Text = "Can't create a variable with an empty name.";
                Variables.Text = currentVar;
                return;
            }

            if (Variables.Items.Contains(Variables.Text))
            {
                StatusLabel.Text = $"Variable '{currentVar}' already exists.";
            }
            else
            {
                /* Adding new variable value to the registry key */
                currentVar = Variables.Text;
                manager.NewVariable(currentVarType, currentVar);

                /* Adding new variable name to combobox */
                Variables.SelectedIndex = Variables.Items.Add(currentVar);
                StatusLabel.Text = $"A new variable '{currentVar}' created.";
            }
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            var varName = Variables.Text;
            if (Variables.Items.Contains(varName))
            {
                /* Removing selected variable from registry and combobox */
                manager.RemoveVariable(currentVarType, varName);
                Variables.Items.Remove(varName);

                /* Loading the other variable from combobox if exists */
                if (Variables.Items.Count == 0)
                    currentVar = "";
                else
                    Variables.SelectedIndex = 0;

                StatusLabel.Text = $"Variable '{varName}' removed.";
            }
            else
                StatusLabel.Text = $"Variable '{varName}' doesn't exist.";
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            SaveVariable(currentVar);
        }

        private void BDiscard_Click(object sender, EventArgs e)
        {
            Variables.Text = currentVar;
            LoadVariable(currentVar);
        }

        private void BExport_Click(object sender, EventArgs e)
        {
            if (SDialog.ShowDialog() == DialogResult.OK)
            {
                manager.ExportVariables(SDialog.FileName, CBUserOnly.Checked);
                StatusLabel.Text = "Export done.";
            }
        }

        private void BImport_Click(object sender, EventArgs e)
        {
            if (ODialog.ShowDialog() == DialogResult.OK)
            {
                manager.ImportVariables(ODialog.FileName, CBUserOnly.Checked);
                StatusLabel.Text = "Import done.";
            }
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {
                if (selectedIndex == PathItems.Items.Count - 1)
                    PathItems.Items[selectedIndex].Text = "";
                PathItems.Items[selectedIndex].BeginEdit();
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            var lastItem = PathItems.Items[PathItems.Items.Count - 1];
            if (lastItem.Selected)
                lastItem.Selected = false;

            if (PathItems.SelectedIndices.Count != 0)
                Changed(true);

            foreach (ListViewItem item in PathItems.SelectedItems)
                item.Remove();
        }

        private void BUp_Click(object sender, EventArgs e)
        {
            ShiftSelectedPathItems(-1);
        }

        private void BDown_Click(object sender, EventArgs e)
        {
            ShiftSelectedPathItems(1);
        }

        private void BHelp_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void PathItems_Resize(object sender, EventArgs e)
        {
            Native.ShowScrollBar(PathItems.Handle, 0, false);
        }

        private void PathItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            PathItems.Sorting = (sortAscending) ? SortOrder.Ascending : SortOrder.Descending;
            sortAscending = !sortAscending;
        }

        private void PathItems_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    BEdit_Click(null, null);
                    break;

                case Keys.Delete:
                    BDelete_Click(null, null);
                    break;
            }
        }

        private void PathItems_DoubleClick(object sender, EventArgs e)
        {
            BEdit_Click(null, null);
        }

        private void PathItems_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            var originalText = PathItems.Items[e.Item].Text;
            var editedText = e.Label;

            if (e.Item == PathItems.Items.Count - 1)
            {
                if (editedText == null || editedText == "")                 //check if the last item has been changed
                {
                    e.CancelEdit = true;
                    PathItems.Items[e.Item].Text = "<new value>";
                    return;
                }
                else
                {
                    Changed(true);                                          //if it was add a new empty line
                    PathItems.Items.Add("<new value>");
                    return;
                }
            }

            if (editedText != originalText)
                Changed(true);
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSystem.Checked)
                LoadVariableNames(EnvEditor.VariableType.System);
            else
                LoadVariableNames(EnvEditor.VariableType.User);

            Variables.SelectedIndex = 0;
        }

        private void Variables_SelectedValueChanged(object sender, EventArgs e)
        {
            Changed(false);
            ClearPathItems();

            currentVar = Variables.Text;
            LoadVariable(currentVar);
        }

        private void Variables_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                BAdd_Click(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PathItems.Columns[0].Width = PathItems.Width;
            RB_CheckedChanged(null, null);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                about.ShowDialog();
        }

        private void PathItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if ((e.ItemIndex == PathItems.Items.Count - 1) && (PathItems.SelectedIndices.Count >= 2))
                e.Item.Selected = false;
        }

        #endregion
    }
}
