namespace BikeStore
{
    partial class frmCustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManagement));
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.toolStripCustomers = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.statusStripCustomers = new System.Windows.Forms.StatusStrip();
            this.tslblTotalCustomers = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpSearchCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerCompany = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerCompany = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerMiddleName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.txtCustomerMiddleName = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.toolStripCustomers.SuspendLayout();
            this.statusStripCustomers.SuspendLayout();
            this.grpSearchCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 100);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1584, 739);
            this.dgvCustomers.TabIndex = 2;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // toolStripCustomers
            // 
            this.toolStripCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripSeparator2,
            this.tsbEdit,
            this.toolStripSeparator4,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbSearch,
            this.toolStripSeparator6,
            this.tsbClear,
            this.toolStripSeparator3,
            this.tsbRefresh,
            this.toolStripSeparator5,
            this.tsbClose});
            this.toolStripCustomers.Location = new System.Drawing.Point(0, 0);
            this.toolStripCustomers.Name = "toolStripCustomers";
            this.toolStripCustomers.Size = new System.Drawing.Size(1584, 25);
            this.toolStripCustomers.TabIndex = 0;
            this.toolStripCustomers.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::BikeStore.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(104, 22);
            this.tsbAdd.Text = "Add Customer";
            this.tsbAdd.ToolTipText = "Add User";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::BikeStore.Properties.Resources.edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(102, 22);
            this.tsbEdit.Text = "Edit Customer";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::BikeStore.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(115, 22);
            this.tsbDelete.Text = "Delete Customer";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::BikeStore.Properties.Resources.search_exact;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(117, 22);
            this.tsbSearch.Text = "Search Customer";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbClear
            // 
            this.tsbClear.Image = global::BikeStore.Properties.Resources.clear_exact;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(85, 22);
            this.tsbClear.Text = "Clear fields";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::BikeStore.Properties.Resources.refresh_matched;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(97, 22);
            this.tsbRefresh.Text = "Refresh Users";
            this.tsbRefresh.ToolTipText = "Refresh Customers";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::BikeStore.Properties.Resources.exit_matched;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(106, 22);
            this.tsbClose.Text = "Return to Main";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // statusStripCustomers
            // 
            this.statusStripCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTotalCustomers});
            this.statusStripCustomers.Location = new System.Drawing.Point(0, 839);
            this.statusStripCustomers.Name = "statusStripCustomers";
            this.statusStripCustomers.Size = new System.Drawing.Size(1584, 22);
            this.statusStripCustomers.TabIndex = 3;
            this.statusStripCustomers.Text = "statusStrip1";
            // 
            // tslblTotalCustomers
            // 
            this.tslblTotalCustomers.Name = "tslblTotalCustomers";
            this.tslblTotalCustomers.Size = new System.Drawing.Size(99, 17);
            this.tslblTotalCustomers.Text = "Total Customers: ";
            // 
            // grpSearchCustomer
            // 
            this.grpSearchCustomer.AutoSize = true;
            this.grpSearchCustomer.Controls.Add(this.lblCustomerAddress);
            this.grpSearchCustomer.Controls.Add(this.lblCustomerEmail);
            this.grpSearchCustomer.Controls.Add(this.lblCustomerCompany);
            this.grpSearchCustomer.Controls.Add(this.txtCustomerAddress);
            this.grpSearchCustomer.Controls.Add(this.txtCustomerEmail);
            this.grpSearchCustomer.Controls.Add(this.txtCustomerCompany);
            this.grpSearchCustomer.Controls.Add(this.lblCustomerLastName);
            this.grpSearchCustomer.Controls.Add(this.txtCustomerLastName);
            this.grpSearchCustomer.Controls.Add(this.lblCustomerMiddleName);
            this.grpSearchCustomer.Controls.Add(this.lblCustomerFirstName);
            this.grpSearchCustomer.Controls.Add(this.txtCustomerMiddleName);
            this.grpSearchCustomer.Controls.Add(this.txtCustomerFirstName);
            this.grpSearchCustomer.Controls.Add(this.txtCustomerID);
            this.grpSearchCustomer.Controls.Add(this.lblCustomerID);
            this.grpSearchCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchCustomer.Location = new System.Drawing.Point(0, 25);
            this.grpSearchCustomer.Name = "grpSearchCustomer";
            this.grpSearchCustomer.Size = new System.Drawing.Size(1584, 75);
            this.grpSearchCustomer.TabIndex = 1;
            this.grpSearchCustomer.TabStop = false;
            this.grpSearchCustomer.Text = "Search Customers";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(666, 20);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(45, 13);
            this.lblCustomerAddress.TabIndex = 10;
            this.lblCustomerAddress.Text = "Address";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(936, 20);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(73, 13);
            this.lblCustomerEmail.TabIndex = 12;
            this.lblCustomerEmail.Text = "Email Address";
            // 
            // lblCustomerCompany
            // 
            this.lblCustomerCompany.AutoSize = true;
            this.lblCustomerCompany.Location = new System.Drawing.Point(465, 20);
            this.lblCustomerCompany.Name = "lblCustomerCompany";
            this.lblCustomerCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCustomerCompany.TabIndex = 8;
            this.lblCustomerCompany.Text = "Company";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(666, 36);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(245, 20);
            this.txtCustomerAddress.TabIndex = 11;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(936, 36);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(201, 20);
            this.txtCustomerEmail.TabIndex = 13;
            // 
            // txtCustomerCompany
            // 
            this.txtCustomerCompany.Location = new System.Drawing.Point(462, 36);
            this.txtCustomerCompany.Name = "txtCustomerCompany";
            this.txtCustomerCompany.Size = new System.Drawing.Size(178, 20);
            this.txtCustomerCompany.TabIndex = 9;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(299, 20);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(58, 13);
            this.lblCustomerLastName.TabIndex = 6;
            this.lblCustomerLastName.Text = "Last Name";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(299, 36);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(136, 20);
            this.txtCustomerLastName.TabIndex = 7;
            // 
            // lblCustomerMiddleName
            // 
            this.lblCustomerMiddleName.AutoSize = true;
            this.lblCustomerMiddleName.Location = new System.Drawing.Point(202, 20);
            this.lblCustomerMiddleName.Name = "lblCustomerMiddleName";
            this.lblCustomerMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblCustomerMiddleName.TabIndex = 4;
            this.lblCustomerMiddleName.Text = "Middle Name";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AccessibleDescription = "";
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(77, 20);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblCustomerFirstName.TabIndex = 2;
            this.lblCustomerFirstName.Text = "First Name";
            // 
            // txtCustomerMiddleName
            // 
            this.txtCustomerMiddleName.Location = new System.Drawing.Point(202, 36);
            this.txtCustomerMiddleName.Name = "txtCustomerMiddleName";
            this.txtCustomerMiddleName.Size = new System.Drawing.Size(75, 20);
            this.txtCustomerMiddleName.TabIndex = 5;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(77, 36);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(103, 20);
            this.txtCustomerFirstName.TabIndex = 3;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(12, 36);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(45, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 20);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(18, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "ID";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.grpSearchCustomer);
            this.Controls.Add(this.toolStripCustomers);
            this.Controls.Add(this.statusStripCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bike Store | Customer Management";
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.toolStripCustomers.ResumeLayout(false);
            this.toolStripCustomers.PerformLayout();
            this.statusStripCustomers.ResumeLayout(false);
            this.statusStripCustomers.PerformLayout();
            this.grpSearchCustomer.ResumeLayout(false);
            this.grpSearchCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.ToolStrip toolStripCustomers;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.StatusStrip statusStripCustomers;
        private System.Windows.Forms.ToolStripStatusLabel tslblTotalCustomers;
        private System.Windows.Forms.GroupBox grpSearchCustomer;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerMiddleName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerCompany;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblCustomerMiddleName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerCompany;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}