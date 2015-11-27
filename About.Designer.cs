namespace EnvEditor
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.GHotkeys = new System.Windows.Forms.GroupBox();
            this.LHotkeys = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.GHotkeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // GHotkeys
            // 
            this.GHotkeys.Controls.Add(this.LHotkeys);
            this.GHotkeys.Location = new System.Drawing.Point(10, 37);
            this.GHotkeys.Name = "GHotkeys";
            this.GHotkeys.Size = new System.Drawing.Size(314, 151);
            this.GHotkeys.TabIndex = 0;
            this.GHotkeys.TabStop = false;
            this.GHotkeys.Text = "Hotkeys";
            // 
            // LHotkeys
            // 
            this.LHotkeys.AutoSize = true;
            this.LHotkeys.Font = new System.Drawing.Font("Tahoma", 9.176471F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LHotkeys.Location = new System.Drawing.Point(16, 25);
            this.LHotkeys.Name = "LHotkeys";
            this.LHotkeys.Size = new System.Drawing.Size(259, 112);
            this.LHotkeys.TabIndex = 0;
            this.LHotkeys.Text = resources.GetString("LHotkeys.Text");
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(14, 9);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(172, 13);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author: Tolik Boiko, Ukraine.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 198);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.GHotkeys);
            this.Font = new System.Drawing.Font("Verdana", 7.764706F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.About_KeyUp);
            this.GHotkeys.ResumeLayout(false);
            this.GHotkeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GHotkeys;
        private System.Windows.Forms.Label LHotkeys;
        private System.Windows.Forms.Label Author;
    }
}