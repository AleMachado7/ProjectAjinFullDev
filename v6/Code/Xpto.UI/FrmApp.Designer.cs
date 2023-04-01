namespace Xpto.UI
{
    partial class FrmApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmRegister = new ToolStripMenuItem();
            tsmCustomerSearch = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmRegister });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(560, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmRegister
            // 
            tsmRegister.DropDownItems.AddRange(new ToolStripItem[] { tsmCustomerSearch });
            tsmRegister.Name = "tsmRegister";
            tsmRegister.Size = new Size(66, 20);
            tsmRegister.Text = "Cadastro";
            // 
            // tsmCustomerSearch
            // 
            tsmCustomerSearch.Name = "tsmCustomerSearch";
            tsmCustomerSearch.Size = new Size(180, 22);
            tsmCustomerSearch.Text = "Cliente";
            tsmCustomerSearch.Click += tsmCustomerSearch_Click;
            // 
            // FrmApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 378);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FrmApp";
            Text = "Xpto";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmRegister;
        private ToolStripMenuItem tsmCustomerSearch;
    }
}