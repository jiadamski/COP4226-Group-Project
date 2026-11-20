namespace BikeStore
{
    partial class frmMaintenance
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
            this.tbCtlMaintenance = new System.Windows.Forms.TabControl();
            this.tbPgAddCustomer = new System.Windows.Forms.TabPage();
            this.txtACNewCustomerID = new System.Windows.Forms.TextBox();
            this.lblACNewCustomerID = new System.Windows.Forms.Label();
            this.tbPgAddProduct = new System.Windows.Forms.TabPage();
            this.tbPgSearchCustomer = new System.Windows.Forms.TabPage();
            this.tbPgSearchProduct = new System.Windows.Forms.TabPage();
            this.lblACTitle = new System.Windows.Forms.Label();
            this.txtACTitle = new System.Windows.Forms.TextBox();
            this.lblACFirstName = new System.Windows.Forms.Label();
            this.txtACFirstName = new System.Windows.Forms.TextBox();
            this.lblACMiddleName = new System.Windows.Forms.Label();
            this.txtACMiddleName = new System.Windows.Forms.TextBox();
            this.lblACLastName = new System.Windows.Forms.Label();
            this.txtACLastName = new System.Windows.Forms.TextBox();
            this.lblACSuffix = new System.Windows.Forms.Label();
            this.txtACSuffix = new System.Windows.Forms.TextBox();
            this.lblACEmailAddress = new System.Windows.Forms.Label();
            this.lblACCompanyName = new System.Windows.Forms.Label();
            this.txtACEmailAddress = new System.Windows.Forms.TextBox();
            this.txtACCOmpanyName = new System.Windows.Forms.TextBox();
            this.lblACPhoneNumber = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblACAddress = new System.Windows.Forms.Label();
            this.lblACAddressLineOne = new System.Windows.Forms.Label();
            this.txtACAddressLineOne = new System.Windows.Forms.TextBox();
            this.lblACAddressLineTwo = new System.Windows.Forms.Label();
            this.txtACAddressLineTwo = new System.Windows.Forms.TextBox();
            this.lblACCity = new System.Windows.Forms.Label();
            this.lblACStateProvince = new System.Windows.Forms.Label();
            this.lblACCountryRegion = new System.Windows.Forms.Label();
            this.lblACPostalCode = new System.Windows.Forms.Label();
            this.txtACCity = new System.Windows.Forms.TextBox();
            this.txtACStateProvince = new System.Windows.Forms.TextBox();
            this.txtACCountryRegion = new System.Windows.Forms.TextBox();
            this.txtACPostalCode = new System.Windows.Forms.TextBox();
            this.txtAPNewProductID = new System.Windows.Forms.TextBox();
            this.lblAPNewProductID = new System.Windows.Forms.Label();
            this.lblAPNewProductName = new System.Windows.Forms.Label();
            this.txtAPNewProductName = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblAPProductCategory = new System.Windows.Forms.Label();
            this.lblAPProductModel = new System.Windows.Forms.Label();
            this.lblAPColor = new System.Windows.Forms.Label();
            this.lblAPStandardCost = new System.Windows.Forms.Label();
            this.lblAPListPrice = new System.Windows.Forms.Label();
            this.lblAPSize = new System.Windows.Forms.Label();
            this.lblAPWeight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblAPProductNumber = new System.Windows.Forms.Label();
            this.lblAPProductDescription = new System.Windows.Forms.Label();
            this.txtAPProductNumber = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbCtlMaintenance.SuspendLayout();
            this.tbPgAddCustomer.SuspendLayout();
            this.tbPgAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtlMaintenance
            // 
            this.tbCtlMaintenance.Controls.Add(this.tbPgAddCustomer);
            this.tbCtlMaintenance.Controls.Add(this.tbPgAddProduct);
            this.tbCtlMaintenance.Controls.Add(this.tbPgSearchCustomer);
            this.tbCtlMaintenance.Controls.Add(this.tbPgSearchProduct);
            this.tbCtlMaintenance.Location = new System.Drawing.Point(2, 43);
            this.tbCtlMaintenance.Name = "tbCtlMaintenance";
            this.tbCtlMaintenance.SelectedIndex = 0;
            this.tbCtlMaintenance.Size = new System.Drawing.Size(1170, 554);
            this.tbCtlMaintenance.TabIndex = 0;
            // 
            // tbPgAddCustomer
            // 
            this.tbPgAddCustomer.Controls.Add(this.txtACPostalCode);
            this.tbPgAddCustomer.Controls.Add(this.txtACCountryRegion);
            this.tbPgAddCustomer.Controls.Add(this.txtACStateProvince);
            this.tbPgAddCustomer.Controls.Add(this.txtACCity);
            this.tbPgAddCustomer.Controls.Add(this.lblACPostalCode);
            this.tbPgAddCustomer.Controls.Add(this.lblACCountryRegion);
            this.tbPgAddCustomer.Controls.Add(this.lblACStateProvince);
            this.tbPgAddCustomer.Controls.Add(this.lblACCity);
            this.tbPgAddCustomer.Controls.Add(this.txtACAddressLineTwo);
            this.tbPgAddCustomer.Controls.Add(this.lblACAddressLineTwo);
            this.tbPgAddCustomer.Controls.Add(this.txtACAddressLineOne);
            this.tbPgAddCustomer.Controls.Add(this.lblACAddressLineOne);
            this.tbPgAddCustomer.Controls.Add(this.lblACAddress);
            this.tbPgAddCustomer.Controls.Add(this.textBox7);
            this.tbPgAddCustomer.Controls.Add(this.lblACPhoneNumber);
            this.tbPgAddCustomer.Controls.Add(this.txtACCOmpanyName);
            this.tbPgAddCustomer.Controls.Add(this.txtACEmailAddress);
            this.tbPgAddCustomer.Controls.Add(this.lblACCompanyName);
            this.tbPgAddCustomer.Controls.Add(this.lblACEmailAddress);
            this.tbPgAddCustomer.Controls.Add(this.txtACSuffix);
            this.tbPgAddCustomer.Controls.Add(this.lblACSuffix);
            this.tbPgAddCustomer.Controls.Add(this.txtACLastName);
            this.tbPgAddCustomer.Controls.Add(this.lblACLastName);
            this.tbPgAddCustomer.Controls.Add(this.txtACMiddleName);
            this.tbPgAddCustomer.Controls.Add(this.lblACMiddleName);
            this.tbPgAddCustomer.Controls.Add(this.txtACFirstName);
            this.tbPgAddCustomer.Controls.Add(this.lblACFirstName);
            this.tbPgAddCustomer.Controls.Add(this.txtACTitle);
            this.tbPgAddCustomer.Controls.Add(this.lblACTitle);
            this.tbPgAddCustomer.Controls.Add(this.txtACNewCustomerID);
            this.tbPgAddCustomer.Controls.Add(this.lblACNewCustomerID);
            this.tbPgAddCustomer.Location = new System.Drawing.Point(4, 25);
            this.tbPgAddCustomer.Name = "tbPgAddCustomer";
            this.tbPgAddCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgAddCustomer.Size = new System.Drawing.Size(1162, 525);
            this.tbPgAddCustomer.TabIndex = 0;
            this.tbPgAddCustomer.Text = "Add New Customer";
            this.tbPgAddCustomer.UseVisualStyleBackColor = true;
            // 
            // txtACNewCustomerID
            // 
            this.txtACNewCustomerID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtACNewCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtACNewCustomerID.Enabled = false;
            this.txtACNewCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACNewCustomerID.Location = new System.Drawing.Point(514, 23);
            this.txtACNewCustomerID.Name = "txtACNewCustomerID";
            this.txtACNewCustomerID.Size = new System.Drawing.Size(189, 27);
            this.txtACNewCustomerID.TabIndex = 1;
            // 
            // lblACNewCustomerID
            // 
            this.lblACNewCustomerID.AutoSize = true;
            this.lblACNewCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACNewCustomerID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblACNewCustomerID.Location = new System.Drawing.Point(311, 23);
            this.lblACNewCustomerID.Name = "lblACNewCustomerID";
            this.lblACNewCustomerID.Size = new System.Drawing.Size(187, 25);
            this.lblACNewCustomerID.TabIndex = 0;
            this.lblACNewCustomerID.Text = "New Customer ID:";
            // 
            // tbPgAddProduct
            // 
            this.tbPgAddProduct.Controls.Add(this.comboBox1);
            this.tbPgAddProduct.Controls.Add(this.textBox9);
            this.tbPgAddProduct.Controls.Add(this.txtAPProductNumber);
            this.tbPgAddProduct.Controls.Add(this.lblAPProductDescription);
            this.tbPgAddProduct.Controls.Add(this.lblAPProductNumber);
            this.tbPgAddProduct.Controls.Add(this.textBox8);
            this.tbPgAddProduct.Controls.Add(this.textBox6);
            this.tbPgAddProduct.Controls.Add(this.textBox5);
            this.tbPgAddProduct.Controls.Add(this.textBox4);
            this.tbPgAddProduct.Controls.Add(this.textBox3);
            this.tbPgAddProduct.Controls.Add(this.textBox2);
            this.tbPgAddProduct.Controls.Add(this.textBox1);
            this.tbPgAddProduct.Controls.Add(this.lblAPWeight);
            this.tbPgAddProduct.Controls.Add(this.lblAPSize);
            this.tbPgAddProduct.Controls.Add(this.lblAPListPrice);
            this.tbPgAddProduct.Controls.Add(this.lblAPStandardCost);
            this.tbPgAddProduct.Controls.Add(this.lblAPColor);
            this.tbPgAddProduct.Controls.Add(this.lblAPProductModel);
            this.tbPgAddProduct.Controls.Add(this.lblAPProductCategory);
            this.tbPgAddProduct.Controls.Add(this.txtAPNewProductName);
            this.tbPgAddProduct.Controls.Add(this.lblAPNewProductName);
            this.tbPgAddProduct.Controls.Add(this.txtAPNewProductID);
            this.tbPgAddProduct.Controls.Add(this.lblAPNewProductID);
            this.tbPgAddProduct.Location = new System.Drawing.Point(4, 25);
            this.tbPgAddProduct.Name = "tbPgAddProduct";
            this.tbPgAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgAddProduct.Size = new System.Drawing.Size(1162, 525);
            this.tbPgAddProduct.TabIndex = 1;
            this.tbPgAddProduct.Text = "Add New Product";
            this.tbPgAddProduct.UseVisualStyleBackColor = true;
            // 
            // tbPgSearchCustomer
            // 
            this.tbPgSearchCustomer.Location = new System.Drawing.Point(4, 25);
            this.tbPgSearchCustomer.Name = "tbPgSearchCustomer";
            this.tbPgSearchCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgSearchCustomer.Size = new System.Drawing.Size(1162, 525);
            this.tbPgSearchCustomer.TabIndex = 2;
            this.tbPgSearchCustomer.Text = "Search Existing Customer";
            this.tbPgSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // tbPgSearchProduct
            // 
            this.tbPgSearchProduct.Location = new System.Drawing.Point(4, 25);
            this.tbPgSearchProduct.Name = "tbPgSearchProduct";
            this.tbPgSearchProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgSearchProduct.Size = new System.Drawing.Size(1162, 525);
            this.tbPgSearchProduct.TabIndex = 3;
            this.tbPgSearchProduct.Text = "Search Existing Product";
            this.tbPgSearchProduct.UseVisualStyleBackColor = true;
            // 
            // lblACTitle
            // 
            this.lblACTitle.AutoSize = true;
            this.lblACTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTitle.Location = new System.Drawing.Point(85, 87);
            this.lblACTitle.Name = "lblACTitle";
            this.lblACTitle.Size = new System.Drawing.Size(46, 20);
            this.lblACTitle.TabIndex = 2;
            this.lblACTitle.Text = "Title:";
            // 
            // txtACTitle
            // 
            this.txtACTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACTitle.Location = new System.Drawing.Point(186, 80);
            this.txtACTitle.Name = "txtACTitle";
            this.txtACTitle.Size = new System.Drawing.Size(133, 27);
            this.txtACTitle.TabIndex = 3;
            // 
            // lblACFirstName
            // 
            this.lblACFirstName.AutoSize = true;
            this.lblACFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACFirstName.Location = new System.Drawing.Point(43, 133);
            this.lblACFirstName.Name = "lblACFirstName";
            this.lblACFirstName.Size = new System.Drawing.Size(97, 20);
            this.lblACFirstName.TabIndex = 4;
            this.lblACFirstName.Text = "First Name:";
            // 
            // txtACFirstName
            // 
            this.txtACFirstName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACFirstName.Location = new System.Drawing.Point(186, 126);
            this.txtACFirstName.Name = "txtACFirstName";
            this.txtACFirstName.Size = new System.Drawing.Size(283, 27);
            this.txtACFirstName.TabIndex = 5;
            // 
            // lblACMiddleName
            // 
            this.lblACMiddleName.AutoSize = true;
            this.lblACMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACMiddleName.Location = new System.Drawing.Point(28, 185);
            this.lblACMiddleName.Name = "lblACMiddleName";
            this.lblACMiddleName.Size = new System.Drawing.Size(112, 20);
            this.lblACMiddleName.TabIndex = 6;
            this.lblACMiddleName.Text = "Middle Name:";
            // 
            // txtACMiddleName
            // 
            this.txtACMiddleName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACMiddleName.Location = new System.Drawing.Point(186, 178);
            this.txtACMiddleName.Name = "txtACMiddleName";
            this.txtACMiddleName.Size = new System.Drawing.Size(283, 27);
            this.txtACMiddleName.TabIndex = 7;
            // 
            // lblACLastName
            // 
            this.lblACLastName.AutoSize = true;
            this.lblACLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACLastName.Location = new System.Drawing.Point(35, 231);
            this.lblACLastName.Name = "lblACLastName";
            this.lblACLastName.Size = new System.Drawing.Size(96, 20);
            this.lblACLastName.TabIndex = 8;
            this.lblACLastName.Text = "Last Name:";
            // 
            // txtACLastName
            // 
            this.txtACLastName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACLastName.Location = new System.Drawing.Point(186, 224);
            this.txtACLastName.Name = "txtACLastName";
            this.txtACLastName.Size = new System.Drawing.Size(283, 27);
            this.txtACLastName.TabIndex = 9;
            // 
            // lblACSuffix
            // 
            this.lblACSuffix.AutoSize = true;
            this.lblACSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACSuffix.Location = new System.Drawing.Point(75, 282);
            this.lblACSuffix.Name = "lblACSuffix";
            this.lblACSuffix.Size = new System.Drawing.Size(56, 20);
            this.lblACSuffix.TabIndex = 10;
            this.lblACSuffix.Text = "Suffix:";
            // 
            // txtACSuffix
            // 
            this.txtACSuffix.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACSuffix.Location = new System.Drawing.Point(186, 275);
            this.txtACSuffix.Name = "txtACSuffix";
            this.txtACSuffix.Size = new System.Drawing.Size(133, 27);
            this.txtACSuffix.TabIndex = 11;
            // 
            // lblACEmailAddress
            // 
            this.lblACEmailAddress.AutoSize = true;
            this.lblACEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACEmailAddress.Location = new System.Drawing.Point(604, 106);
            this.lblACEmailAddress.Name = "lblACEmailAddress";
            this.lblACEmailAddress.Size = new System.Drawing.Size(123, 20);
            this.lblACEmailAddress.TabIndex = 12;
            this.lblACEmailAddress.Text = "Email Address:";
            // 
            // lblACCompanyName
            // 
            this.lblACCompanyName.AutoSize = true;
            this.lblACCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCompanyName.Location = new System.Drawing.Point(594, 152);
            this.lblACCompanyName.Name = "lblACCompanyName";
            this.lblACCompanyName.Size = new System.Drawing.Size(133, 20);
            this.lblACCompanyName.TabIndex = 13;
            this.lblACCompanyName.Text = "Company Name:";
            // 
            // txtACEmailAddress
            // 
            this.txtACEmailAddress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACEmailAddress.Location = new System.Drawing.Point(749, 99);
            this.txtACEmailAddress.Name = "txtACEmailAddress";
            this.txtACEmailAddress.Size = new System.Drawing.Size(283, 27);
            this.txtACEmailAddress.TabIndex = 14;
            // 
            // txtACCOmpanyName
            // 
            this.txtACCOmpanyName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACCOmpanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACCOmpanyName.Location = new System.Drawing.Point(749, 152);
            this.txtACCOmpanyName.Name = "txtACCOmpanyName";
            this.txtACCOmpanyName.Size = new System.Drawing.Size(283, 27);
            this.txtACCOmpanyName.TabIndex = 15;
            // 
            // lblACPhoneNumber
            // 
            this.lblACPhoneNumber.AutoSize = true;
            this.lblACPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACPhoneNumber.Location = new System.Drawing.Point(594, 204);
            this.lblACPhoneNumber.Name = "lblACPhoneNumber";
            this.lblACPhoneNumber.Size = new System.Drawing.Size(125, 20);
            this.lblACPhoneNumber.TabIndex = 16;
            this.lblACPhoneNumber.Text = "Phone Number:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(749, 204);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(203, 27);
            this.textBox7.TabIndex = 17;
            // 
            // lblACAddress
            // 
            this.lblACAddress.AutoSize = true;
            this.lblACAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACAddress.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblACAddress.Location = new System.Drawing.Point(480, 307);
            this.lblACAddress.Name = "lblACAddress";
            this.lblACAddress.Size = new System.Drawing.Size(89, 22);
            this.lblACAddress.TabIndex = 18;
            this.lblACAddress.Text = "Address:";
            // 
            // lblACAddressLineOne
            // 
            this.lblACAddressLineOne.AutoSize = true;
            this.lblACAddressLineOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACAddressLineOne.Location = new System.Drawing.Point(70, 382);
            this.lblACAddressLineOne.Name = "lblACAddressLineOne";
            this.lblACAddressLineOne.Size = new System.Drawing.Size(127, 20);
            this.lblACAddressLineOne.TabIndex = 19;
            this.lblACAddressLineOne.Text = "Address Line 1:";
            // 
            // txtACAddressLineOne
            // 
            this.txtACAddressLineOne.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACAddressLineOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACAddressLineOne.Location = new System.Drawing.Point(215, 375);
            this.txtACAddressLineOne.Name = "txtACAddressLineOne";
            this.txtACAddressLineOne.Size = new System.Drawing.Size(283, 27);
            this.txtACAddressLineOne.TabIndex = 20;
            // 
            // lblACAddressLineTwo
            // 
            this.lblACAddressLineTwo.AutoSize = true;
            this.lblACAddressLineTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACAddressLineTwo.Location = new System.Drawing.Point(70, 435);
            this.lblACAddressLineTwo.Name = "lblACAddressLineTwo";
            this.lblACAddressLineTwo.Size = new System.Drawing.Size(127, 20);
            this.lblACAddressLineTwo.TabIndex = 21;
            this.lblACAddressLineTwo.Text = "Address Line 2:";
            // 
            // txtACAddressLineTwo
            // 
            this.txtACAddressLineTwo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACAddressLineTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACAddressLineTwo.Location = new System.Drawing.Point(215, 428);
            this.txtACAddressLineTwo.Name = "txtACAddressLineTwo";
            this.txtACAddressLineTwo.Size = new System.Drawing.Size(283, 27);
            this.txtACAddressLineTwo.TabIndex = 22;
            // 
            // lblACCity
            // 
            this.lblACCity.AutoSize = true;
            this.lblACCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCity.Location = new System.Drawing.Point(724, 336);
            this.lblACCity.Name = "lblACCity";
            this.lblACCity.Size = new System.Drawing.Size(43, 20);
            this.lblACCity.TabIndex = 23;
            this.lblACCity.Text = "City:";
            // 
            // lblACStateProvince
            // 
            this.lblACStateProvince.AutoSize = true;
            this.lblACStateProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACStateProvince.Location = new System.Drawing.Point(644, 375);
            this.lblACStateProvince.Name = "lblACStateProvince";
            this.lblACStateProvince.Size = new System.Drawing.Size(123, 20);
            this.lblACStateProvince.TabIndex = 24;
            this.lblACStateProvince.Text = "State/Province:";
            // 
            // lblACCountryRegion
            // 
            this.lblACCountryRegion.AutoSize = true;
            this.lblACCountryRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACCountryRegion.Location = new System.Drawing.Point(638, 411);
            this.lblACCountryRegion.Name = "lblACCountryRegion";
            this.lblACCountryRegion.Size = new System.Drawing.Size(129, 20);
            this.lblACCountryRegion.TabIndex = 25;
            this.lblACCountryRegion.Text = "Country/Region:";
            // 
            // lblACPostalCode
            // 
            this.lblACPostalCode.AutoSize = true;
            this.lblACPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACPostalCode.Location = new System.Drawing.Point(662, 453);
            this.lblACPostalCode.Name = "lblACPostalCode";
            this.lblACPostalCode.Size = new System.Drawing.Size(105, 20);
            this.lblACPostalCode.TabIndex = 26;
            this.lblACPostalCode.Text = "Postal Code:";
            // 
            // txtACCity
            // 
            this.txtACCity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACCity.Location = new System.Drawing.Point(795, 333);
            this.txtACCity.Name = "txtACCity";
            this.txtACCity.Size = new System.Drawing.Size(283, 27);
            this.txtACCity.TabIndex = 27;
            // 
            // txtACStateProvince
            // 
            this.txtACStateProvince.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACStateProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACStateProvince.Location = new System.Drawing.Point(795, 372);
            this.txtACStateProvince.Name = "txtACStateProvince";
            this.txtACStateProvince.Size = new System.Drawing.Size(283, 27);
            this.txtACStateProvince.TabIndex = 28;
            // 
            // txtACCountryRegion
            // 
            this.txtACCountryRegion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACCountryRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACCountryRegion.Location = new System.Drawing.Point(795, 408);
            this.txtACCountryRegion.Name = "txtACCountryRegion";
            this.txtACCountryRegion.Size = new System.Drawing.Size(283, 27);
            this.txtACCountryRegion.TabIndex = 29;
            // 
            // txtACPostalCode
            // 
            this.txtACPostalCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtACPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACPostalCode.Location = new System.Drawing.Point(795, 453);
            this.txtACPostalCode.Name = "txtACPostalCode";
            this.txtACPostalCode.Size = new System.Drawing.Size(283, 27);
            this.txtACPostalCode.TabIndex = 30;
            // 
            // txtAPNewProductID
            // 
            this.txtAPNewProductID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAPNewProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAPNewProductID.Enabled = false;
            this.txtAPNewProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPNewProductID.Location = new System.Drawing.Point(507, 25);
            this.txtAPNewProductID.Name = "txtAPNewProductID";
            this.txtAPNewProductID.Size = new System.Drawing.Size(189, 27);
            this.txtAPNewProductID.TabIndex = 3;
            // 
            // lblAPNewProductID
            // 
            this.lblAPNewProductID.AutoSize = true;
            this.lblAPNewProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPNewProductID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAPNewProductID.Location = new System.Drawing.Point(333, 25);
            this.lblAPNewProductID.Name = "lblAPNewProductID";
            this.lblAPNewProductID.Size = new System.Drawing.Size(168, 25);
            this.lblAPNewProductID.TabIndex = 2;
            this.lblAPNewProductID.Text = "New Product ID:";
            // 
            // lblAPNewProductName
            // 
            this.lblAPNewProductName.AutoSize = true;
            this.lblAPNewProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPNewProductName.Location = new System.Drawing.Point(38, 89);
            this.lblAPNewProductName.Name = "lblAPNewProductName";
            this.lblAPNewProductName.Size = new System.Drawing.Size(159, 20);
            this.lblAPNewProductName.TabIndex = 4;
            this.lblAPNewProductName.Text = "New Product Name:";
            // 
            // txtAPNewProductName
            // 
            this.txtAPNewProductName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAPNewProductName.Enabled = false;
            this.txtAPNewProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPNewProductName.Location = new System.Drawing.Point(213, 82);
            this.txtAPNewProductName.Name = "txtAPNewProductName";
            this.txtAPNewProductName.Size = new System.Drawing.Size(315, 27);
            this.txtAPNewProductName.TabIndex = 5;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblAPProductCategory
            // 
            this.lblAPProductCategory.AutoSize = true;
            this.lblAPProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPProductCategory.Location = new System.Drawing.Point(53, 132);
            this.lblAPProductCategory.Name = "lblAPProductCategory";
            this.lblAPProductCategory.Size = new System.Drawing.Size(144, 20);
            this.lblAPProductCategory.TabIndex = 6;
            this.lblAPProductCategory.Text = "Product Category:";
            // 
            // lblAPProductModel
            // 
            this.lblAPProductModel.AutoSize = true;
            this.lblAPProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPProductModel.Location = new System.Drawing.Point(75, 179);
            this.lblAPProductModel.Name = "lblAPProductModel";
            this.lblAPProductModel.Size = new System.Drawing.Size(122, 20);
            this.lblAPProductModel.TabIndex = 7;
            this.lblAPProductModel.Text = "Product Model:";
            // 
            // lblAPColor
            // 
            this.lblAPColor.AutoSize = true;
            this.lblAPColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPColor.Location = new System.Drawing.Point(143, 230);
            this.lblAPColor.Name = "lblAPColor";
            this.lblAPColor.Size = new System.Drawing.Size(54, 20);
            this.lblAPColor.TabIndex = 8;
            this.lblAPColor.Text = "Color:";
            // 
            // lblAPStandardCost
            // 
            this.lblAPStandardCost.AutoSize = true;
            this.lblAPStandardCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPStandardCost.Location = new System.Drawing.Point(75, 278);
            this.lblAPStandardCost.Name = "lblAPStandardCost";
            this.lblAPStandardCost.Size = new System.Drawing.Size(121, 20);
            this.lblAPStandardCost.TabIndex = 9;
            this.lblAPStandardCost.Text = "Standard Cost:";
            // 
            // lblAPListPrice
            // 
            this.lblAPListPrice.AutoSize = true;
            this.lblAPListPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPListPrice.Location = new System.Drawing.Point(110, 324);
            this.lblAPListPrice.Name = "lblAPListPrice";
            this.lblAPListPrice.Size = new System.Drawing.Size(86, 20);
            this.lblAPListPrice.TabIndex = 10;
            this.lblAPListPrice.Text = "List Price:";
            // 
            // lblAPSize
            // 
            this.lblAPSize.AutoSize = true;
            this.lblAPSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPSize.Location = new System.Drawing.Point(143, 371);
            this.lblAPSize.Name = "lblAPSize";
            this.lblAPSize.Size = new System.Drawing.Size(47, 20);
            this.lblAPSize.TabIndex = 11;
            this.lblAPSize.Text = "Size:";
            // 
            // lblAPWeight
            // 
            this.lblAPWeight.AutoSize = true;
            this.lblAPWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPWeight.Location = new System.Drawing.Point(124, 415);
            this.lblAPWeight.Name = "lblAPWeight";
            this.lblAPWeight.Size = new System.Drawing.Size(66, 20);
            this.lblAPWeight.TabIndex = 12;
            this.lblAPWeight.Text = "Weight:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(213, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 27);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(213, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 27);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(213, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 27);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(213, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 27);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(213, 317);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 27);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(213, 364);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(172, 27);
            this.textBox6.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(213, 408);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(172, 27);
            this.textBox8.TabIndex = 19;
            // 
            // lblAPProductNumber
            // 
            this.lblAPProductNumber.AutoSize = true;
            this.lblAPProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPProductNumber.Location = new System.Drawing.Point(648, 85);
            this.lblAPProductNumber.Name = "lblAPProductNumber";
            this.lblAPProductNumber.Size = new System.Drawing.Size(136, 20);
            this.lblAPProductNumber.TabIndex = 20;
            this.lblAPProductNumber.Text = "Product Number:";
            // 
            // lblAPProductDescription
            // 
            this.lblAPProductDescription.AutoSize = true;
            this.lblAPProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPProductDescription.Location = new System.Drawing.Point(648, 142);
            this.lblAPProductDescription.Name = "lblAPProductDescription";
            this.lblAPProductDescription.Size = new System.Drawing.Size(163, 20);
            this.lblAPProductDescription.TabIndex = 21;
            this.lblAPProductDescription.Text = "Product Description:";
            // 
            // txtAPProductNumber
            // 
            this.txtAPProductNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAPProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPProductNumber.Location = new System.Drawing.Point(813, 78);
            this.txtAPProductNumber.Name = "txtAPProductNumber";
            this.txtAPProductNumber.Size = new System.Drawing.Size(172, 27);
            this.txtAPProductNumber.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(652, 179);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(403, 259);
            this.textBox9.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(828, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.tbCtlMaintenance);
            this.Name = "frmMaintenance";
            this.Text = "frmMaintenance";
            this.tbCtlMaintenance.ResumeLayout(false);
            this.tbPgAddCustomer.ResumeLayout(false);
            this.tbPgAddCustomer.PerformLayout();
            this.tbPgAddProduct.ResumeLayout(false);
            this.tbPgAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtlMaintenance;
        private System.Windows.Forms.TabPage tbPgAddCustomer;
        private System.Windows.Forms.TabPage tbPgAddProduct;
        private System.Windows.Forms.TabPage tbPgSearchCustomer;
        private System.Windows.Forms.TabPage tbPgSearchProduct;
        private System.Windows.Forms.Label lblACNewCustomerID;
        private System.Windows.Forms.TextBox txtACNewCustomerID;
        private System.Windows.Forms.TextBox txtACTitle;
        private System.Windows.Forms.Label lblACTitle;
        private System.Windows.Forms.TextBox txtACFirstName;
        private System.Windows.Forms.Label lblACFirstName;
        private System.Windows.Forms.TextBox txtACMiddleName;
        private System.Windows.Forms.Label lblACMiddleName;
        private System.Windows.Forms.Label lblACLastName;
        private System.Windows.Forms.TextBox txtACLastName;
        private System.Windows.Forms.Label lblACSuffix;
        private System.Windows.Forms.TextBox txtACSuffix;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblACPhoneNumber;
        private System.Windows.Forms.TextBox txtACCOmpanyName;
        private System.Windows.Forms.TextBox txtACEmailAddress;
        private System.Windows.Forms.Label lblACCompanyName;
        private System.Windows.Forms.Label lblACEmailAddress;
        private System.Windows.Forms.Label lblACAddress;
        private System.Windows.Forms.Label lblACAddressLineOne;
        private System.Windows.Forms.Label lblACPostalCode;
        private System.Windows.Forms.Label lblACCountryRegion;
        private System.Windows.Forms.Label lblACStateProvince;
        private System.Windows.Forms.Label lblACCity;
        private System.Windows.Forms.TextBox txtACAddressLineTwo;
        private System.Windows.Forms.Label lblACAddressLineTwo;
        private System.Windows.Forms.TextBox txtACAddressLineOne;
        private System.Windows.Forms.TextBox txtACPostalCode;
        private System.Windows.Forms.TextBox txtACCountryRegion;
        private System.Windows.Forms.TextBox txtACStateProvince;
        private System.Windows.Forms.TextBox txtACCity;
        private System.Windows.Forms.TextBox txtAPNewProductID;
        private System.Windows.Forms.Label lblAPNewProductID;
        private System.Windows.Forms.TextBox txtAPNewProductName;
        private System.Windows.Forms.Label lblAPNewProductName;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblAPSize;
        private System.Windows.Forms.Label lblAPListPrice;
        private System.Windows.Forms.Label lblAPStandardCost;
        private System.Windows.Forms.Label lblAPColor;
        private System.Windows.Forms.Label lblAPProductModel;
        private System.Windows.Forms.Label lblAPProductCategory;
        private System.Windows.Forms.Label lblAPWeight;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAPProductNumber;
        private System.Windows.Forms.Label lblAPProductDescription;
        private System.Windows.Forms.Label lblAPProductNumber;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}