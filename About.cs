using System.Windows.Forms;

namespace EnvEditor
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Hide();
        }
    }
}
