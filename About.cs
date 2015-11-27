using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
