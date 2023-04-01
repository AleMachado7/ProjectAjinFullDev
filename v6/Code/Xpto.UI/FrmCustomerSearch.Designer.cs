namespace Xpto.UI
{
    partial class FrmCustomerSearch
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
            dgvSearch = new DataGridView();
            btnNew = new Button();
            btnExit = new Button();
            gbCustomerSearch = new GroupBox();
            btnCustomerSearch = new Button();
            txtSearchBoxCustomerCode = new MaskedTextBox();
            lblSearchBoxCode = new Label();
            lblSearchBoxName = new Label();
            txtSearchBoxCustomerName = new TextBox();
            txtSearchBoxIdentity = new TextBox();
            lblSearchBoxIndentity = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            gbCustomerSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSearch
            // 
            dgvSearch.AllowUserToAddRows = false;
            dgvSearch.AllowUserToDeleteRows = false;
            dgvSearch.AllowUserToOrderColumns = true;
            dgvSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvSearch.GridColor = SystemColors.Control;
            dgvSearch.Location = new Point(12, 99);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.ReadOnly = true;
            dgvSearch.RowTemplate.Height = 25;
            dgvSearch.Size = new Size(1117, 480);
            dgvSearch.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.DodgerBlue;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnNew.FlatAppearance.MouseDownBackColor = SystemColors.MenuHighlight;
            btnNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(973, 585);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 31);
            btnNew.TabIndex = 2;
            btnNew.Text = "Novo";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.BackColor = Color.LightCoral;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1054, 585);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 31);
            btnExit.TabIndex = 3;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // gbCustomerSearch
            // 
            gbCustomerSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbCustomerSearch.Controls.Add(btnCustomerSearch);
            gbCustomerSearch.Controls.Add(txtSearchBoxCustomerCode);
            gbCustomerSearch.Controls.Add(lblSearchBoxCode);
            gbCustomerSearch.Controls.Add(lblSearchBoxName);
            gbCustomerSearch.Controls.Add(txtSearchBoxCustomerName);
            gbCustomerSearch.Controls.Add(txtSearchBoxIdentity);
            gbCustomerSearch.Controls.Add(lblSearchBoxIndentity);
            gbCustomerSearch.Location = new Point(12, 12);
            gbCustomerSearch.Name = "gbCustomerSearch";
            gbCustomerSearch.Size = new Size(1117, 81);
            gbCustomerSearch.TabIndex = 23;
            gbCustomerSearch.TabStop = false;
            gbCustomerSearch.Text = "Busca de Cliente";
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.Location = new Point(611, 40);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(111, 23);
            btnCustomerSearch.TabIndex = 26;
            btnCustomerSearch.Text = "Consultar Cliente";
            btnCustomerSearch.UseVisualStyleBackColor = true;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // txtSearchBoxCustomerCode
            // 
            txtSearchBoxCustomerCode.Location = new Point(468, 41);
            txtSearchBoxCustomerCode.Mask = "00000";
            txtSearchBoxCustomerCode.Name = "txtSearchBoxCustomerCode";
            txtSearchBoxCustomerCode.Size = new Size(103, 23);
            txtSearchBoxCustomerCode.TabIndex = 25;
            txtSearchBoxCustomerCode.ValidatingType = typeof(int);
            // 
            // lblSearchBoxCode
            // 
            lblSearchBoxCode.AutoSize = true;
            lblSearchBoxCode.Location = new Point(468, 23);
            lblSearchBoxCode.Name = "lblSearchBoxCode";
            lblSearchBoxCode.Size = new Size(103, 15);
            lblSearchBoxCode.TabIndex = 24;
            lblSearchBoxCode.Text = "Código do Cliente";
            // 
            // lblSearchBoxName
            // 
            lblSearchBoxName.AutoSize = true;
            lblSearchBoxName.Location = new Point(157, 23);
            lblSearchBoxName.Name = "lblSearchBoxName";
            lblSearchBoxName.Size = new Size(40, 15);
            lblSearchBoxName.TabIndex = 23;
            lblSearchBoxName.Text = "Nome";
            // 
            // txtSearchBoxCustomerName
            // 
            txtSearchBoxCustomerName.Location = new Point(157, 41);
            txtSearchBoxCustomerName.Name = "txtSearchBoxCustomerName";
            txtSearchBoxCustomerName.Size = new Size(288, 23);
            txtSearchBoxCustomerName.TabIndex = 22;
            // 
            // txtSearchBoxIdentity
            // 
            txtSearchBoxIdentity.Location = new Point(6, 41);
            txtSearchBoxIdentity.Name = "txtSearchBoxIdentity";
            txtSearchBoxIdentity.Size = new Size(125, 23);
            txtSearchBoxIdentity.TabIndex = 20;
            // 
            // lblSearchBoxIndentity
            // 
            lblSearchBoxIndentity.AutoSize = true;
            lblSearchBoxIndentity.Location = new Point(6, 23);
            lblSearchBoxIndentity.Name = "lblSearchBoxIndentity";
            lblSearchBoxIndentity.Size = new Size(60, 15);
            lblSearchBoxIndentity.TabIndex = 21;
            lblSearchBoxIndentity.Text = "CPF/CNPJ";
            // 
            // FrmCustomerSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 628);
            Controls.Add(gbCustomerSearch);
            Controls.Add(btnExit);
            Controls.Add(btnNew);
            Controls.Add(dgvSearch);
            Name = "FrmCustomerSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCustomerSearch";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            gbCustomerSearch.ResumeLayout(false);
            gbCustomerSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSearch;
        private Button btnNew;
        private Button btnExit;
        private GroupBox gbCustomerSearch;
        private Button btnCustomerSearch;
        private MaskedTextBox txtSearchBoxCustomerCode;
        private Label lblSearchBoxCode;
        private Label lblSearchBoxName;
        private TextBox txtSearchBoxCustomerName;
        private TextBox txtSearchBoxIdentity;
        private Label lblSearchBoxIndentity;
    }
}