namespace Xpto.UI
{
    partial class FrmCustomerRegister
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
            txtName = new TextBox();
            lblName = new Label();
            lblNickname = new Label();
            txtNickname = new TextBox();
            lblIdentity = new Label();
            lblNote = new Label();
            txtNote = new TextBox();
            dtpBirthDate = new DateTimePicker();
            lblBirthDate = new Label();
            lblPersonType = new Label();
            cboPersonType = new ComboBox();
            btnSaveCustomer = new Button();
            btnExit = new Button();
            btnDeleteCustomer = new Button();
            lblHeader = new Label();
            tabCliente = new TabControl();
            tabPageCustomer = new TabPage();
            txtIdentity = new MaskedTextBox();
            tabPageAddress = new TabPage();
            btnDeleteAddress = new Button();
            btnSaveAddress = new Button();
            txtAddressNote = new TextBox();
            lblAddressNote = new Label();
            cboState = new ComboBox();
            lblState = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtDistrict = new TextBox();
            lblDistrict = new Label();
            txtAddressNumber = new MaskedTextBox();
            lblStreetNumber = new Label();
            txtComplement = new TextBox();
            lblComplement = new Label();
            txtStreet = new TextBox();
            lblStreet = new Label();
            btnSearchZipCode = new Button();
            txtZipCode = new MaskedTextBox();
            lblZipCode = new Label();
            lblAddressType = new Label();
            cboAddressType = new ComboBox();
            tabPagePhone = new TabPage();
            btnDeletePhone = new Button();
            btnSavePhone = new Button();
            txtPhoneNote = new TextBox();
            lblPhoneNote = new Label();
            txtPhoneNumber = new MaskedTextBox();
            lblPhoneNumber = new Label();
            lblPhoneDDD = new Label();
            txtPhoneDDD = new MaskedTextBox();
            lblPhoneType = new Label();
            cboPhoneType = new ComboBox();
            tabPageEmail = new TabPage();
            BtnDeleteEmail = new Button();
            btnSaveEmail = new Button();
            lblEmailNote = new Label();
            txtEmailNote = new TextBox();
            txtEmailAddress = new TextBox();
            lblEmailAddress = new Label();
            lblEmailType = new Label();
            cboEmailType = new ComboBox();
            tabCliente.SuspendLayout();
            tabPageCustomer.SuspendLayout();
            tabPageAddress.SuspendLayout();
            tabPagePhone.SuspendLayout();
            tabPageEmail.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.ForeColor = SystemColors.Desktop;
            txtName.Location = new Point(6, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(751, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nome";
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Location = new Point(6, 53);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(86, 15);
            lblNickname.TabIndex = 3;
            lblNickname.Text = "Nome Fantasia";
            // 
            // txtNickname
            // 
            txtNickname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNickname.ForeColor = SystemColors.Desktop;
            txtNickname.Location = new Point(6, 72);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(751, 23);
            txtNickname.TabIndex = 2;
            // 
            // lblIdentity
            // 
            lblIdentity.AutoSize = true;
            lblIdentity.Location = new Point(6, 100);
            lblIdentity.Name = "lblIdentity";
            lblIdentity.Size = new Size(60, 15);
            lblIdentity.TabIndex = 5;
            lblIdentity.Text = "CPF/CNPJ";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(6, 144);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(69, 15);
            lblNote.TabIndex = 7;
            lblNote.Text = "Observação";
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.ForeColor = SystemColors.Desktop;
            txtNote.Location = new Point(6, 164);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(751, 23);
            txtNote.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(6, 208);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(142, 23);
            dtpBirthDate.TabIndex = 8;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(6, 190);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(114, 15);
            lblBirthDate.TabIndex = 9;
            lblBirthDate.Text = "Data de Nascimento";
            // 
            // lblPersonType
            // 
            lblPersonType.AutoSize = true;
            lblPersonType.Location = new Point(6, 236);
            lblPersonType.Name = "lblPersonType";
            lblPersonType.Size = new Size(85, 15);
            lblPersonType.TabIndex = 10;
            lblPersonType.Text = "Tipo de Pessoa";
            // 
            // cboPersonType
            // 
            cboPersonType.FormattingEnabled = true;
            cboPersonType.Items.AddRange(new object[] { "PF", "PJ" });
            cboPersonType.Location = new Point(6, 254);
            cboPersonType.Name = "cboPersonType";
            cboPersonType.Size = new Size(121, 23);
            cboPersonType.TabIndex = 11;
            cboPersonType.Text = "PF";
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveCustomer.Location = new Point(6, 305);
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.Size = new Size(75, 23);
            btnSaveCustomer.TabIndex = 12;
            btnSaveCustomer.Text = "Salvar";
            btnSaveCustomer.UseVisualStyleBackColor = true;
            btnSaveCustomer.Click += btnSaveCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(710, 573);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 13;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteCustomer.Location = new Point(87, 305);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(75, 23);
            btnDeleteCustomer.TabIndex = 14;
            btnDeleteCustomer.Text = "Excluir";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("LEMON MILK Medium", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(256, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(258, 29);
            lblHeader.TabIndex = 15;
            lblHeader.Text = "CADASTRO DO CLIENTE";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabCliente
            // 
            tabCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabCliente.Controls.Add(tabPageCustomer);
            tabCliente.Controls.Add(tabPageAddress);
            tabCliente.Controls.Add(tabPagePhone);
            tabCliente.Controls.Add(tabPageEmail);
            tabCliente.Location = new Point(12, 41);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(771, 526);
            tabCliente.TabIndex = 19;
            // 
            // tabPageCustomer
            // 
            tabPageCustomer.Controls.Add(txtIdentity);
            tabPageCustomer.Controls.Add(lblName);
            tabPageCustomer.Controls.Add(txtName);
            tabPageCustomer.Controls.Add(btnDeleteCustomer);
            tabPageCustomer.Controls.Add(txtNickname);
            tabPageCustomer.Controls.Add(lblIdentity);
            tabPageCustomer.Controls.Add(btnSaveCustomer);
            tabPageCustomer.Controls.Add(lblNickname);
            tabPageCustomer.Controls.Add(cboPersonType);
            tabPageCustomer.Controls.Add(txtNote);
            tabPageCustomer.Controls.Add(lblPersonType);
            tabPageCustomer.Controls.Add(lblNote);
            tabPageCustomer.Controls.Add(lblBirthDate);
            tabPageCustomer.Controls.Add(dtpBirthDate);
            tabPageCustomer.Location = new Point(4, 24);
            tabPageCustomer.Name = "tabPageCustomer";
            tabPageCustomer.Padding = new Padding(3);
            tabPageCustomer.Size = new Size(763, 498);
            tabPageCustomer.TabIndex = 0;
            tabPageCustomer.Text = "Cliente";
            tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // txtIdentity
            // 
            txtIdentity.Location = new Point(6, 118);
            txtIdentity.Mask = "00000000000000";
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Size = new Size(751, 23);
            txtIdentity.TabIndex = 12;
            // 
            // tabPageAddress
            // 
            tabPageAddress.Controls.Add(btnDeleteAddress);
            tabPageAddress.Controls.Add(btnSaveAddress);
            tabPageAddress.Controls.Add(txtAddressNote);
            tabPageAddress.Controls.Add(lblAddressNote);
            tabPageAddress.Controls.Add(cboState);
            tabPageAddress.Controls.Add(lblState);
            tabPageAddress.Controls.Add(txtCity);
            tabPageAddress.Controls.Add(lblCity);
            tabPageAddress.Controls.Add(txtDistrict);
            tabPageAddress.Controls.Add(lblDistrict);
            tabPageAddress.Controls.Add(txtAddressNumber);
            tabPageAddress.Controls.Add(lblStreetNumber);
            tabPageAddress.Controls.Add(txtComplement);
            tabPageAddress.Controls.Add(lblComplement);
            tabPageAddress.Controls.Add(txtStreet);
            tabPageAddress.Controls.Add(lblStreet);
            tabPageAddress.Controls.Add(btnSearchZipCode);
            tabPageAddress.Controls.Add(txtZipCode);
            tabPageAddress.Controls.Add(lblZipCode);
            tabPageAddress.Controls.Add(lblAddressType);
            tabPageAddress.Controls.Add(cboAddressType);
            tabPageAddress.Location = new Point(4, 24);
            tabPageAddress.Name = "tabPageAddress";
            tabPageAddress.Padding = new Padding(3);
            tabPageAddress.Size = new Size(763, 498);
            tabPageAddress.TabIndex = 1;
            tabPageAddress.Text = "Endereço";
            tabPageAddress.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAddress
            // 
            btnDeleteAddress.Location = new Point(87, 306);
            btnDeleteAddress.Name = "btnDeleteAddress";
            btnDeleteAddress.Size = new Size(75, 23);
            btnDeleteAddress.TabIndex = 21;
            btnDeleteAddress.Text = "Excluir";
            btnDeleteAddress.UseVisualStyleBackColor = true;
            btnDeleteAddress.Click += btnDeleteAddress_Click;
            // 
            // btnSaveAddress
            // 
            btnSaveAddress.Location = new Point(6, 306);
            btnSaveAddress.Name = "btnSaveAddress";
            btnSaveAddress.Size = new Size(75, 23);
            btnSaveAddress.TabIndex = 20;
            btnSaveAddress.Text = "Salvar";
            btnSaveAddress.UseVisualStyleBackColor = true;
            btnSaveAddress.Click += btnSaveAddress_Click;
            // 
            // txtAddressNote
            // 
            txtAddressNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddressNote.Location = new Point(136, 266);
            txtAddressNote.Multiline = true;
            txtAddressNote.Name = "txtAddressNote";
            txtAddressNote.Size = new Size(621, 23);
            txtAddressNote.TabIndex = 19;
            // 
            // lblAddressNote
            // 
            lblAddressNote.AutoSize = true;
            lblAddressNote.Location = new Point(136, 248);
            lblAddressNote.Name = "lblAddressNote";
            lblAddressNote.Size = new Size(69, 15);
            lblAddressNote.TabIndex = 18;
            lblAddressNote.Text = "Observação";
            // 
            // cboState
            // 
            cboState.FormattingEnabled = true;
            cboState.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboState.Location = new Point(6, 266);
            cboState.Name = "cboState";
            cboState.Size = new Size(121, 23);
            cboState.TabIndex = 17;
            cboState.Text = "SP";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(6, 248);
            lblState.Name = "lblState";
            lblState.Size = new Size(21, 15);
            lblState.TabIndex = 16;
            lblState.Text = "UF";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(381, 218);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(376, 23);
            txtCity.TabIndex = 15;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(381, 200);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(44, 15);
            lblCity.TabIndex = 14;
            lblCity.Text = "Cidade";
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new Point(6, 218);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(369, 23);
            txtDistrict.TabIndex = 13;
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(6, 200);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(38, 15);
            lblDistrict.TabIndex = 12;
            lblDistrict.Text = "Bairro";
            // 
            // txtAddressNumber
            // 
            txtAddressNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddressNumber.Location = new Point(644, 121);
            txtAddressNumber.Mask = "00000";
            txtAddressNumber.Name = "txtAddressNumber";
            txtAddressNumber.Size = new Size(113, 23);
            txtAddressNumber.TabIndex = 11;
            txtAddressNumber.ValidatingType = typeof(int);
            // 
            // lblStreetNumber
            // 
            lblStreetNumber.AutoSize = true;
            lblStreetNumber.Location = new Point(644, 103);
            lblStreetNumber.Name = "lblStreetNumber";
            lblStreetNumber.Size = new Size(51, 15);
            lblStreetNumber.TabIndex = 10;
            lblStreetNumber.Text = "Numero";
            // 
            // txtComplement
            // 
            txtComplement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtComplement.Location = new Point(6, 170);
            txtComplement.Name = "txtComplement";
            txtComplement.Size = new Size(751, 23);
            txtComplement.TabIndex = 9;
            // 
            // lblComplement
            // 
            lblComplement.AutoSize = true;
            lblComplement.Location = new Point(6, 152);
            lblComplement.Name = "lblComplement";
            lblComplement.Size = new Size(84, 15);
            lblComplement.TabIndex = 8;
            lblComplement.Text = "Complemento";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(6, 122);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(632, 23);
            txtStreet.TabIndex = 7;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(6, 104);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(69, 15);
            lblStreet.TabIndex = 6;
            lblStreet.Text = "Logradouro";
            // 
            // btnSearchZipCode
            // 
            btnSearchZipCode.Location = new Point(136, 74);
            btnSearchZipCode.Name = "btnSearchZipCode";
            btnSearchZipCode.Size = new Size(95, 23);
            btnSearchZipCode.TabIndex = 5;
            btnSearchZipCode.Text = "Pesquisar CEP";
            btnSearchZipCode.UseVisualStyleBackColor = true;
            btnSearchZipCode.Click += btnSearchZipCode_Click;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(6, 74);
            txtZipCode.Mask = "00000000";
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(124, 23);
            txtZipCode.TabIndex = 4;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(6, 56);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(28, 15);
            lblZipCode.TabIndex = 3;
            lblZipCode.Text = "CEP";
            // 
            // lblAddressType
            // 
            lblAddressType.AutoSize = true;
            lblAddressType.Location = new Point(6, 9);
            lblAddressType.Name = "lblAddressType";
            lblAddressType.Size = new Size(30, 15);
            lblAddressType.TabIndex = 1;
            lblAddressType.Text = "Tipo";
            // 
            // cboAddressType
            // 
            cboAddressType.FormattingEnabled = true;
            cboAddressType.Items.AddRange(new object[] { "Residencial", "Comercial" });
            cboAddressType.Location = new Point(6, 27);
            cboAddressType.Name = "cboAddressType";
            cboAddressType.Size = new Size(124, 23);
            cboAddressType.TabIndex = 0;
            cboAddressType.Text = "Residencial";
            // 
            // tabPagePhone
            // 
            tabPagePhone.Controls.Add(btnDeletePhone);
            tabPagePhone.Controls.Add(btnSavePhone);
            tabPagePhone.Controls.Add(txtPhoneNote);
            tabPagePhone.Controls.Add(lblPhoneNote);
            tabPagePhone.Controls.Add(txtPhoneNumber);
            tabPagePhone.Controls.Add(lblPhoneNumber);
            tabPagePhone.Controls.Add(lblPhoneDDD);
            tabPagePhone.Controls.Add(txtPhoneDDD);
            tabPagePhone.Controls.Add(lblPhoneType);
            tabPagePhone.Controls.Add(cboPhoneType);
            tabPagePhone.Location = new Point(4, 24);
            tabPagePhone.Name = "tabPagePhone";
            tabPagePhone.Padding = new Padding(3);
            tabPagePhone.Size = new Size(763, 498);
            tabPagePhone.TabIndex = 2;
            tabPagePhone.Text = "Telefone";
            tabPagePhone.UseVisualStyleBackColor = true;
            // 
            // btnDeletePhone
            // 
            btnDeletePhone.Location = new Point(87, 126);
            btnDeletePhone.Name = "btnDeletePhone";
            btnDeletePhone.Size = new Size(75, 23);
            btnDeletePhone.TabIndex = 9;
            btnDeletePhone.Text = "Excluir";
            btnDeletePhone.UseVisualStyleBackColor = true;
            btnDeletePhone.Click += btnDeletePhone_Click;
            // 
            // btnSavePhone
            // 
            btnSavePhone.Location = new Point(6, 126);
            btnSavePhone.Name = "btnSavePhone";
            btnSavePhone.Size = new Size(75, 23);
            btnSavePhone.TabIndex = 8;
            btnSavePhone.Text = "Salvar";
            btnSavePhone.UseVisualStyleBackColor = true;
            btnSavePhone.Click += btnSavePhone_Click;
            // 
            // txtPhoneNote
            // 
            txtPhoneNote.Location = new Point(6, 75);
            txtPhoneNote.Multiline = true;
            txtPhoneNote.Name = "txtPhoneNote";
            txtPhoneNote.Size = new Size(751, 23);
            txtPhoneNote.TabIndex = 7;
            // 
            // lblPhoneNote
            // 
            lblPhoneNote.AutoSize = true;
            lblPhoneNote.Location = new Point(6, 57);
            lblPhoneNote.Name = "lblPhoneNote";
            lblPhoneNote.Size = new Size(69, 15);
            lblPhoneNote.TabIndex = 6;
            lblPhoneNote.Text = "Observação";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(250, 27);
            txtPhoneNumber.Mask = "000000000";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.ValidatingType = typeof(int);
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(250, 9);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(51, 15);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Telefone";
            // 
            // lblPhoneDDD
            // 
            lblPhoneDDD.AutoSize = true;
            lblPhoneDDD.Location = new Point(139, 9);
            lblPhoneDDD.Name = "lblPhoneDDD";
            lblPhoneDDD.Size = new Size(31, 15);
            lblPhoneDDD.TabIndex = 3;
            lblPhoneDDD.Text = "DDD";
            // 
            // txtPhoneDDD
            // 
            txtPhoneDDD.Location = new Point(139, 27);
            txtPhoneDDD.Mask = "00";
            txtPhoneDDD.Name = "txtPhoneDDD";
            txtPhoneDDD.Size = new Size(100, 23);
            txtPhoneDDD.TabIndex = 2;
            txtPhoneDDD.ValidatingType = typeof(int);
            // 
            // lblPhoneType
            // 
            lblPhoneType.AutoSize = true;
            lblPhoneType.Location = new Point(6, 9);
            lblPhoneType.Name = "lblPhoneType";
            lblPhoneType.Size = new Size(30, 15);
            lblPhoneType.TabIndex = 1;
            lblPhoneType.Text = "Tipo";
            // 
            // cboPhoneType
            // 
            cboPhoneType.FormattingEnabled = true;
            cboPhoneType.Items.AddRange(new object[] { "Celular", "Fixo" });
            cboPhoneType.Location = new Point(6, 27);
            cboPhoneType.Name = "cboPhoneType";
            cboPhoneType.Size = new Size(121, 23);
            cboPhoneType.TabIndex = 0;
            cboPhoneType.Text = "Celular";
            // 
            // tabPageEmail
            // 
            tabPageEmail.Controls.Add(BtnDeleteEmail);
            tabPageEmail.Controls.Add(btnSaveEmail);
            tabPageEmail.Controls.Add(lblEmailNote);
            tabPageEmail.Controls.Add(txtEmailNote);
            tabPageEmail.Controls.Add(txtEmailAddress);
            tabPageEmail.Controls.Add(lblEmailAddress);
            tabPageEmail.Controls.Add(lblEmailType);
            tabPageEmail.Controls.Add(cboEmailType);
            tabPageEmail.Location = new Point(4, 24);
            tabPageEmail.Name = "tabPageEmail";
            tabPageEmail.Padding = new Padding(3);
            tabPageEmail.Size = new Size(763, 498);
            tabPageEmail.TabIndex = 3;
            tabPageEmail.Text = "Email";
            tabPageEmail.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteEmail
            // 
            BtnDeleteEmail.Location = new Point(87, 126);
            BtnDeleteEmail.Name = "BtnDeleteEmail";
            BtnDeleteEmail.Size = new Size(75, 23);
            BtnDeleteEmail.TabIndex = 8;
            BtnDeleteEmail.Text = "Excluir";
            BtnDeleteEmail.UseVisualStyleBackColor = true;
            BtnDeleteEmail.Click += BtnDeleteEmail_Click;
            // 
            // btnSaveEmail
            // 
            btnSaveEmail.Location = new Point(6, 126);
            btnSaveEmail.Name = "btnSaveEmail";
            btnSaveEmail.Size = new Size(75, 23);
            btnSaveEmail.TabIndex = 7;
            btnSaveEmail.Text = "Salvar";
            btnSaveEmail.UseVisualStyleBackColor = true;
            btnSaveEmail.Click += btnSaveEmail_Click;
            // 
            // lblEmailNote
            // 
            lblEmailNote.AutoSize = true;
            lblEmailNote.Location = new Point(6, 57);
            lblEmailNote.Name = "lblEmailNote";
            lblEmailNote.Size = new Size(69, 15);
            lblEmailNote.TabIndex = 6;
            lblEmailNote.Text = "Observação";
            // 
            // txtEmailNote
            // 
            txtEmailNote.Location = new Point(6, 75);
            txtEmailNote.Name = "txtEmailNote";
            txtEmailNote.Size = new Size(751, 23);
            txtEmailNote.TabIndex = 5;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(139, 27);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(382, 23);
            txtEmailAddress.TabIndex = 4;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(139, 9);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(36, 15);
            lblEmailAddress.TabIndex = 3;
            lblEmailAddress.Text = "Email";
            // 
            // lblEmailType
            // 
            lblEmailType.AutoSize = true;
            lblEmailType.Location = new Point(6, 9);
            lblEmailType.Name = "lblEmailType";
            lblEmailType.Size = new Size(30, 15);
            lblEmailType.TabIndex = 1;
            lblEmailType.Text = "Tipo";
            // 
            // cboEmailType
            // 
            cboEmailType.FormattingEnabled = true;
            cboEmailType.Items.AddRange(new object[] { "Pessoal", "Profissional" });
            cboEmailType.Location = new Point(6, 27);
            cboEmailType.Name = "cboEmailType";
            cboEmailType.Size = new Size(121, 23);
            cboEmailType.TabIndex = 0;
            cboEmailType.Text = "Pessoal";
            // 
            // FrmCustomerRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 608);
            Controls.Add(tabCliente);
            Controls.Add(lblHeader);
            Controls.Add(btnExit);
            Name = "FrmCustomerRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro";
            tabCliente.ResumeLayout(false);
            tabPageCustomer.ResumeLayout(false);
            tabPageCustomer.PerformLayout();
            tabPageAddress.ResumeLayout(false);
            tabPageAddress.PerformLayout();
            tabPagePhone.ResumeLayout(false);
            tabPagePhone.PerformLayout();
            tabPageEmail.ResumeLayout(false);
            tabPageEmail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblNickname;
        private TextBox txtNickname;
        private Label lblIdentity;
        private Label lblNote;
        private TextBox txtNote;
        private DateTimePicker dtpBirthDate;
        private Label lblBirthDate;
        private Label lblPersonType;
        private ComboBox cboPersonType;
        private Button btnSaveCustomer;
        private Button btnExit;
        private Button btnDeleteCustomer;
        private Label lblHeader;
        private TabControl tabCliente;
        private TabPage tabPageCustomer;
        private TabPage tabPageAddress;
        private MaskedTextBox txtZipCode;
        private Label lblZipCode;
        private Label lblAddressType;
        private ComboBox cboAddressType;
        private Button btnSearchZipCode;
        private TextBox txtComplement;
        private Label lblComplement;
        private TextBox txtStreet;
        private Label lblStreet;
        private MaskedTextBox txtAddressNumber;
        private Label lblStreetNumber;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtDistrict;
        private Label lblDistrict;
        private ComboBox cboState;
        private Label lblState;
        private TextBox txtAddressNote;
        private Label lblAddressNote;
        private MaskedTextBox txtIdentity;
        private TabPage tabPagePhone;
        private TabPage tabPageEmail;
        private TextBox txtPhoneNote;
        private Label lblPhoneNote;
        private MaskedTextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private Label lblPhoneDDD;
        private MaskedTextBox txtPhoneDDD;
        private Label lblPhoneType;
        private ComboBox cboPhoneType;
        private Label lblEmailNote;
        private TextBox txtEmailNote;
        private TextBox txtEmailAddress;
        private Label lblEmailAddress;
        private Label lblEmailType;
        private ComboBox cboEmailType;
        private Button btnDeleteAddress;
        private Button btnSaveAddress;
        private Button btnDeletePhone;
        private Button btnSavePhone;
        private Button BtnDeleteEmail;
        private Button btnSaveEmail;
    }
}