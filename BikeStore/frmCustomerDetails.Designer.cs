namespace BikeStore
{
    partial class frmCustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDetails));
            this.tcCustomerInfo = new System.Windows.Forms.TabControl();
            this.tabCustomerInfo = new System.Windows.Forms.TabPage();
            this.txtCustomerSalesperson = new System.Windows.Forms.TextBox();
            this.mtxtCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.cboCustomerTitle = new System.Windows.Forms.ComboBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerMiddleName = new System.Windows.Forms.TextBox();
            this.txtCustomerCompany = new System.Windows.Forms.TextBox();
            this.txtCustomerSuffix = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblSalesperson = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCustomerSuffix = new System.Windows.Forms.Label();
            this.lblCustomerMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCustomerTittle = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.tabCustomerAddresses = new System.Windows.Forms.TabPage();
            this.dgvAddresses = new System.Windows.Forms.DataGridView();
            this.tsAddresses = new System.Windows.Forms.ToolStrip();
            this.tsbAddAddress = new System.Windows.Forms.ToolStripButton();
            this.tsbEditAddress = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAddress = new System.Windows.Forms.ToolStripButton();
            this.tsbRefreshAddresses = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tcCustomerInfo.SuspendLayout();
            this.tabCustomerInfo.SuspendLayout();
            this.tabCustomerAddresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).BeginInit();
            this.tsAddresses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCustomerInfo
            // 
            this.tcCustomerInfo.Controls.Add(this.tabCustomerInfo);
            this.tcCustomerInfo.Controls.Add(this.tabCustomerAddresses);
            this.tcCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.tcCustomerInfo.Name = "tcCustomerInfo";
            this.tcCustomerInfo.SelectedIndex = 0;
            this.tcCustomerInfo.Size = new System.Drawing.Size(444, 237);
            this.tcCustomerInfo.TabIndex = 0;
            // 
            // tabCustomerInfo
            // 
            this.tabCustomerInfo.Controls.Add(this.txtCustomerSalesperson);
            this.tabCustomerInfo.Controls.Add(this.mtxtCustomerPhone);
            this.tabCustomerInfo.Controls.Add(this.txtCustomerEmail);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerPhone);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerEmail);
            this.tabCustomerInfo.Controls.Add(this.cboCustomerTitle);
            this.tabCustomerInfo.Controls.Add(this.txtCustomerLastName);
            this.tabCustomerInfo.Controls.Add(this.txtCustomerFirstName);
            this.tabCustomerInfo.Controls.Add(this.txtCustomerMiddleName);
            this.tabCustomerInfo.Controls.Add(this.txtCustomerCompany);
            this.tabCustomerInfo.Controls.Add(this.txtCustomerSuffix);
            this.tabCustomerInfo.Controls.Add(this.txtCustomerID);
            this.tabCustomerInfo.Controls.Add(this.lblSalesperson);
            this.tabCustomerInfo.Controls.Add(this.lblCompany);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerSuffix);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerMiddleName);
            this.tabCustomerInfo.Controls.Add(this.lblLastName);
            this.tabCustomerInfo.Controls.Add(this.lblFirstName);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerTittle);
            this.tabCustomerInfo.Controls.Add(this.lblCustomerID);
            this.tabCustomerInfo.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerInfo.Name = "tabCustomerInfo";
            this.tabCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerInfo.Size = new System.Drawing.Size(436, 211);
            this.tabCustomerInfo.TabIndex = 0;
            this.tabCustomerInfo.Text = "Customer Information";
            this.tabCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // txtCustomerSalesperson
            // 
            this.txtCustomerSalesperson.Location = new System.Drawing.Point(299, 124);
            this.txtCustomerSalesperson.Name = "txtCustomerSalesperson";
            this.txtCustomerSalesperson.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerSalesperson.TabIndex = 15;
            // 
            // mtxtCustomerPhone
            // 
            this.mtxtCustomerPhone.Location = new System.Drawing.Point(299, 157);
            this.mtxtCustomerPhone.Mask = "(999) 000-0000";
            this.mtxtCustomerPhone.Name = "mtxtCustomerPhone";
            this.mtxtCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.mtxtCustomerPhone.TabIndex = 19;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(96, 157);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerEmail.TabIndex = 17;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(215, 160);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(78, 13);
            this.lblCustomerPhone.TabIndex = 18;
            this.lblCustomerPhone.Text = "Phone Number";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(17, 160);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(73, 13);
            this.lblCustomerEmail.TabIndex = 16;
            this.lblCustomerEmail.Text = "Email Address";
            // 
            // cboCustomerTitle
            // 
            this.cboCustomerTitle.FormattingEnabled = true;
            this.cboCustomerTitle.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Miss",
            "Ms",
            "Sir",
            "Madam"});
            this.cboCustomerTitle.Location = new System.Drawing.Point(299, 32);
            this.cboCustomerTitle.Name = "cboCustomerTitle";
            this.cboCustomerTitle.Size = new System.Drawing.Size(67, 21);
            this.cboCustomerTitle.TabIndex = 3;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(96, 92);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLastName.TabIndex = 9;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(96, 62);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerFirstName.TabIndex = 5;
            // 
            // txtCustomerMiddleName
            // 
            this.txtCustomerMiddleName.Location = new System.Drawing.Point(299, 59);
            this.txtCustomerMiddleName.Name = "txtCustomerMiddleName";
            this.txtCustomerMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerMiddleName.TabIndex = 7;
            // 
            // txtCustomerCompany
            // 
            this.txtCustomerCompany.Location = new System.Drawing.Point(96, 124);
            this.txtCustomerCompany.Name = "txtCustomerCompany";
            this.txtCustomerCompany.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCompany.TabIndex = 13;
            // 
            // txtCustomerSuffix
            // 
            this.txtCustomerSuffix.Location = new System.Drawing.Point(299, 89);
            this.txtCustomerSuffix.Name = "txtCustomerSuffix";
            this.txtCustomerSuffix.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerSuffix.TabIndex = 11;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(96, 29);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(67, 20);
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalesperson
            // 
            this.lblSalesperson.AutoSize = true;
            this.lblSalesperson.Location = new System.Drawing.Point(228, 124);
            this.lblSalesperson.Name = "lblSalesperson";
            this.lblSalesperson.Size = new System.Drawing.Size(65, 13);
            this.lblSalesperson.TabIndex = 14;
            this.lblSalesperson.Text = "Salesperson";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(39, 127);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 12;
            this.lblCompany.Text = "Company";
            // 
            // lblCustomerSuffix
            // 
            this.lblCustomerSuffix.AutoSize = true;
            this.lblCustomerSuffix.Location = new System.Drawing.Point(260, 92);
            this.lblCustomerSuffix.Name = "lblCustomerSuffix";
            this.lblCustomerSuffix.Size = new System.Drawing.Size(33, 13);
            this.lblCustomerSuffix.TabIndex = 10;
            this.lblCustomerSuffix.Text = "Suffix";
            // 
            // lblCustomerMiddleName
            // 
            this.lblCustomerMiddleName.AutoSize = true;
            this.lblCustomerMiddleName.Location = new System.Drawing.Point(224, 62);
            this.lblCustomerMiddleName.Name = "lblCustomerMiddleName";
            this.lblCustomerMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblCustomerMiddleName.TabIndex = 6;
            this.lblCustomerMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(32, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(33, 65);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblCustomerTittle
            // 
            this.lblCustomerTittle.AutoSize = true;
            this.lblCustomerTittle.Location = new System.Drawing.Point(263, 35);
            this.lblCustomerTittle.Name = "lblCustomerTittle";
            this.lblCustomerTittle.Size = new System.Drawing.Size(30, 13);
            this.lblCustomerTittle.TabIndex = 2;
            this.lblCustomerTittle.Text = "Tittle";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(25, 32);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // tabCustomerAddresses
            // 
            this.tabCustomerAddresses.Controls.Add(this.dgvAddresses);
            this.tabCustomerAddresses.Controls.Add(this.tsAddresses);
            this.tabCustomerAddresses.Location = new System.Drawing.Point(4, 22);
            this.tabCustomerAddresses.Name = "tabCustomerAddresses";
            this.tabCustomerAddresses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerAddresses.Size = new System.Drawing.Size(436, 211);
            this.tabCustomerAddresses.TabIndex = 1;
            this.tabCustomerAddresses.Text = "Addresses";
            this.tabCustomerAddresses.UseVisualStyleBackColor = true;
            // 
            // dgvAddresses
            // 
            this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddresses.Location = new System.Drawing.Point(3, 28);
            this.dgvAddresses.Name = "dgvAddresses";
            this.dgvAddresses.Size = new System.Drawing.Size(430, 180);
            this.dgvAddresses.TabIndex = 1;
            this.dgvAddresses.SelectionChanged += new System.EventHandler(this.dgvAddresses_SelectionChanged);
            // 
            // tsAddresses
            // 
            this.tsAddresses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAddress,
            this.tsbEditAddress,
            this.tsbDeleteAddress,
            this.tsbRefreshAddresses});
            this.tsAddresses.Location = new System.Drawing.Point(3, 3);
            this.tsAddresses.Name = "tsAddresses";
            this.tsAddresses.Size = new System.Drawing.Size(430, 25);
            this.tsAddresses.TabIndex = 0;
            this.tsAddresses.Text = "toolStrip1";
            // 
            // tsbAddAddress
            // 
            this.tsbAddAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAddress.Image = global::BikeStore.Properties.Resources.add;
            this.tsbAddAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAddress.Name = "tsbAddAddress";
            this.tsbAddAddress.Size = new System.Drawing.Size(23, 22);
            this.tsbAddAddress.Text = "New Address";
            this.tsbAddAddress.Click += new System.EventHandler(this.tsbAddAddress_Click);
            // 
            // tsbEditAddress
            // 
            this.tsbEditAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditAddress.Image = global::BikeStore.Properties.Resources.edit;
            this.tsbEditAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditAddress.Name = "tsbEditAddress";
            this.tsbEditAddress.Size = new System.Drawing.Size(23, 22);
            this.tsbEditAddress.Text = "Edit Existing Address";
            this.tsbEditAddress.Click += new System.EventHandler(this.tsbEditAddress_Click);
            // 
            // tsbDeleteAddress
            // 
            this.tsbDeleteAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteAddress.Image = global::BikeStore.Properties.Resources.delete;
            this.tsbDeleteAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAddress.Name = "tsbDeleteAddress";
            this.tsbDeleteAddress.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteAddress.Text = "Delete Address";
            this.tsbDeleteAddress.Click += new System.EventHandler(this.tsbDeleteAddress_Click);
            // 
            // tsbRefreshAddresses
            // 
            this.tsbRefreshAddresses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshAddresses.Image = global::BikeStore.Properties.Resources.refresh_matched;
            this.tsbRefreshAddresses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshAddresses.Name = "tsbRefreshAddresses";
            this.tsbRefreshAddresses.Size = new System.Drawing.Size(23, 22);
            this.tsbRefreshAddresses.Text = "Refresh";
            this.tsbRefreshAddresses.Click += new System.EventHandler(this.tsbRefreshAddresses_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 305);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tcCustomerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bike Store | Customer Management";
            this.Load += new System.EventHandler(this.frmCustomerDetails_Load);
            this.tcCustomerInfo.ResumeLayout(false);
            this.tabCustomerInfo.ResumeLayout(false);
            this.tabCustomerInfo.PerformLayout();
            this.tabCustomerAddresses.ResumeLayout(false);
            this.tabCustomerAddresses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).EndInit();
            this.tsAddresses.ResumeLayout(false);
            this.tsAddresses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCustomerInfo;
        private System.Windows.Forms.TabPage tabCustomerInfo;
        private System.Windows.Forms.ComboBox cboCustomerTitle;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerMiddleName;
        private System.Windows.Forms.TextBox txtCustomerCompany;
        private System.Windows.Forms.TextBox txtCustomerSuffix;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblSalesperson;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCustomerSuffix;
        private System.Windows.Forms.Label lblCustomerMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCustomerTittle;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.MaskedTextBox mtxtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerSalesperson;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabCustomerAddresses;
        private System.Windows.Forms.ToolStrip tsAddresses;
        private System.Windows.Forms.DataGridView dgvAddresses;
        private System.Windows.Forms.ToolStripButton tsbAddAddress;
        private System.Windows.Forms.ToolStripButton tsbEditAddress;
        private System.Windows.Forms.ToolStripButton tsbDeleteAddress;
        private System.Windows.Forms.ToolStripButton tsbRefreshAddresses;
    }
}