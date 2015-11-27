namespace EnvEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader PathItem;
            this.BUp = new System.Windows.Forms.Button();
            this.BDown = new System.Windows.Forms.Button();
            this.PathItems = new System.Windows.Forms.ListView();
            this.BImport = new System.Windows.Forms.Button();
            this.BExport = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.Variables = new System.Windows.Forms.ComboBox();
            this.BHelp = new System.Windows.Forms.Button();
            this.VariableType = new System.Windows.Forms.Label();
            this.RBSystem = new System.Windows.Forms.RadioButton();
            this.RBUser = new System.Windows.Forms.RadioButton();
            this.VariableName = new System.Windows.Forms.Label();
            this.BDiscard = new System.Windows.Forms.Button();
            this.SDialog = new System.Windows.Forms.SaveFileDialog();
            this.ODialog = new System.Windows.Forms.OpenFileDialog();
            this.CBUserOnly = new System.Windows.Forms.CheckBox();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BAdd = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            PathItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathItem
            // 
            PathItem.Text = "Variable items";
            PathItem.Width = 356;
            // 
            // BUp
            // 
            this.BUp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BUp.Location = new System.Drawing.Point(527, 158);
            this.BUp.Name = "BUp";
            this.BUp.Size = new System.Drawing.Size(30, 34);
            this.BUp.TabIndex = 1;
            this.BUp.Text = "↑";
            this.BUp.UseVisualStyleBackColor = true;
            this.BUp.Click += new System.EventHandler(this.BUp_Click);
            // 
            // BDown
            // 
            this.BDown.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDown.Location = new System.Drawing.Point(527, 192);
            this.BDown.Name = "BDown";
            this.BDown.Size = new System.Drawing.Size(30, 34);
            this.BDown.TabIndex = 2;
            this.BDown.Text = "↓";
            this.BDown.UseVisualStyleBackColor = true;
            this.BDown.Click += new System.EventHandler(this.BDown_Click);
            // 
            // PathItems
            // 
            this.PathItems.AutoArrange = false;
            this.PathItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            PathItem});
            this.PathItems.Font = new System.Drawing.Font("Tahoma", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathItems.FullRowSelect = true;
            this.PathItems.LabelEdit = true;
            this.PathItems.Location = new System.Drawing.Point(138, 10);
            this.PathItems.Name = "PathItems";
            this.PathItems.Size = new System.Drawing.Size(382, 392);
            this.PathItems.TabIndex = 3;
            this.PathItems.UseCompatibleStateImageBehavior = false;
            this.PathItems.View = System.Windows.Forms.View.Details;
            this.PathItems.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.PathItems_AfterLabelEdit);
            this.PathItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.PathItems_ColumnClick);
            this.PathItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PathItems_ItemSelectionChanged);
            this.PathItems.DoubleClick += new System.EventHandler(this.PathItems_DoubleClick);
            this.PathItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PathItems_KeyUp);
            this.PathItems.Resize += new System.EventHandler(this.PathItems_Resize);
            // 
            // BImport
            // 
            this.BImport.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BImport.Location = new System.Drawing.Point(8, 373);
            this.BImport.Name = "BImport";
            this.BImport.Size = new System.Drawing.Size(120, 30);
            this.BImport.TabIndex = 4;
            this.BImport.Text = "Import variables";
            this.BImport.UseVisualStyleBackColor = true;
            this.BImport.Click += new System.EventHandler(this.BImport_Click);
            // 
            // BExport
            // 
            this.BExport.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExport.Location = new System.Drawing.Point(8, 340);
            this.BExport.Name = "BExport";
            this.BExport.Size = new System.Drawing.Size(120, 30);
            this.BExport.TabIndex = 5;
            this.BExport.Text = "Export variables";
            this.BExport.UseVisualStyleBackColor = true;
            this.BExport.Click += new System.EventHandler(this.BExport_Click);
            // 
            // BSave
            // 
            this.BSave.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSave.Location = new System.Drawing.Point(8, 200);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(120, 30);
            this.BSave.TabIndex = 6;
            this.BSave.Text = "Save changes";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BEdit
            // 
            this.BEdit.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEdit.Location = new System.Drawing.Point(527, 34);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(30, 34);
            this.BEdit.TabIndex = 8;
            this.BEdit.Text = "I";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BDelete
            // 
            this.BDelete.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDelete.Location = new System.Drawing.Point(527, 72);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(30, 34);
            this.BDelete.TabIndex = 9;
            this.BDelete.Text = "✖";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // Variables
            // 
            this.Variables.DisplayMember = "Path";
            this.Variables.Font = new System.Drawing.Font("Tahoma", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Variables.FormattingEnabled = true;
            this.Variables.Location = new System.Drawing.Point(8, 110);
            this.Variables.Name = "Variables";
            this.Variables.Size = new System.Drawing.Size(121, 22);
            this.Variables.TabIndex = 11;
            this.Variables.SelectedValueChanged += new System.EventHandler(this.Variables_SelectedValueChanged);
            this.Variables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Variables_KeyPress);
            // 
            // BHelp
            // 
            this.BHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.882353F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BHelp.Location = new System.Drawing.Point(527, 368);
            this.BHelp.Name = "BHelp";
            this.BHelp.Size = new System.Drawing.Size(30, 34);
            this.BHelp.TabIndex = 12;
            this.BHelp.Text = "?";
            this.BHelp.UseVisualStyleBackColor = true;
            this.BHelp.Click += new System.EventHandler(this.BHelp_Click);
            // 
            // VariableType
            // 
            this.VariableType.AutoSize = true;
            this.VariableType.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariableType.Location = new System.Drawing.Point(6, 10);
            this.VariableType.Name = "VariableType";
            this.VariableType.Size = new System.Drawing.Size(112, 13);
            this.VariableType.TabIndex = 13;
            this.VariableType.Text = "Variables to show:";
            // 
            // RBSystem
            // 
            this.RBSystem.AutoSize = true;
            this.RBSystem.Font = new System.Drawing.Font("Tahoma", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBSystem.Location = new System.Drawing.Point(22, 31);
            this.RBSystem.Name = "RBSystem";
            this.RBSystem.Size = new System.Drawing.Size(59, 17);
            this.RBSystem.TabIndex = 14;
            this.RBSystem.Text = "system";
            this.RBSystem.UseVisualStyleBackColor = true;
            this.RBSystem.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // RBUser
            // 
            this.RBUser.AutoSize = true;
            this.RBUser.Checked = true;
            this.RBUser.Font = new System.Drawing.Font("Tahoma", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBUser.Location = new System.Drawing.Point(22, 55);
            this.RBUser.Name = "RBUser";
            this.RBUser.Size = new System.Drawing.Size(46, 17);
            this.RBUser.TabIndex = 15;
            this.RBUser.TabStop = true;
            this.RBUser.Text = "user";
            this.RBUser.UseVisualStyleBackColor = true;
            this.RBUser.CheckedChanged += new System.EventHandler(this.RB_CheckedChanged);
            // 
            // VariableName
            // 
            this.VariableName.AutoSize = true;
            this.VariableName.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariableName.Location = new System.Drawing.Point(6, 88);
            this.VariableName.Name = "VariableName";
            this.VariableName.Size = new System.Drawing.Size(94, 13);
            this.VariableName.TabIndex = 16;
            this.VariableName.Text = "Variable name:";
            // 
            // BDiscard
            // 
            this.BDiscard.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDiscard.Location = new System.Drawing.Point(8, 233);
            this.BDiscard.Name = "BDiscard";
            this.BDiscard.Size = new System.Drawing.Size(120, 30);
            this.BDiscard.TabIndex = 17;
            this.BDiscard.Text = "Discard changes";
            this.BDiscard.UseVisualStyleBackColor = true;
            this.BDiscard.Click += new System.EventHandler(this.BDiscard_Click);
            // 
            // SDialog
            // 
            this.SDialog.DefaultExt = "*.xml";
            this.SDialog.Filter = "XML File|*.xml";
            this.SDialog.SupportMultiDottedExtensions = true;
            // 
            // ODialog
            // 
            this.ODialog.AddExtension = false;
            this.ODialog.Filter = "XML File|*.xml";
            // 
            // CBUserOnly
            // 
            this.CBUserOnly.AutoSize = true;
            this.CBUserOnly.Checked = true;
            this.CBUserOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBUserOnly.Font = new System.Drawing.Font("Verdana", 7.058824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBUserOnly.Location = new System.Drawing.Point(11, 302);
            this.CBUserOnly.Name = "CBUserOnly";
            this.CBUserOnly.Size = new System.Drawing.Size(118, 28);
            this.CBUserOnly.TabIndex = 18;
            this.CBUserOnly.Text = "include user \nvariables only";
            this.CBUserOnly.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.Status.Location = new System.Drawing.Point(0, 410);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(566, 22);
            this.Status.TabIndex = 19;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // BAdd
            // 
            this.BAdd.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.Location = new System.Drawing.Point(8, 140);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(43, 30);
            this.BAdd.TabIndex = 20;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BRemove
            // 
            this.BRemove.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRemove.Location = new System.Drawing.Point(57, 140);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(71, 30);
            this.BRemove.TabIndex = 21;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = true;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 432);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.CBUserOnly);
            this.Controls.Add(this.BDiscard);
            this.Controls.Add(this.VariableName);
            this.Controls.Add(this.RBUser);
            this.Controls.Add(this.RBSystem);
            this.Controls.Add(this.VariableType);
            this.Controls.Add(this.BHelp);
            this.Controls.Add(this.Variables);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BExport);
            this.Controls.Add(this.BImport);
            this.Controls.Add(this.PathItems);
            this.Controls.Add(this.BDown);
            this.Controls.Add(this.BUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnvEditor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUp;
        private System.Windows.Forms.Button BDown;
        private System.Windows.Forms.ListView PathItems;
        private System.Windows.Forms.Button BImport;
        private System.Windows.Forms.Button BExport;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.ComboBox Variables;
        private System.Windows.Forms.Button BHelp;
        private System.Windows.Forms.Label VariableType;
        private System.Windows.Forms.RadioButton RBSystem;
        private System.Windows.Forms.RadioButton RBUser;
        private System.Windows.Forms.Label VariableName;
        private System.Windows.Forms.Button BDiscard;
        private System.Windows.Forms.SaveFileDialog SDialog;
        private System.Windows.Forms.OpenFileDialog ODialog;
        private System.Windows.Forms.CheckBox CBUserOnly;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BRemove;
    }
}

