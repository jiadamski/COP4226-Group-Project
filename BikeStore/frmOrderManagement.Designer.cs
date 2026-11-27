namespace BikeStore
{
    partial class frmOrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderManagement));
            this.tsOrders = new System.Windows.Forms.ToolStrip();
            this.tsbNewOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEditOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeleteOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearchOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdateStatus = new System.Windows.Forms.ToolStripSplitButton();
            this.inProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backorderedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefreshOrders = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.statusStripOrders = new System.Windows.Forms.StatusStrip();
            this.tsslTotalOrders = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslOrderStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpSearchOrder = new System.Windows.Forms.GroupBox();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.grpOrderDate = new System.Windows.Forms.GroupBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pnlReceipt = new System.Windows.Forms.Panel();
            this.lblCCApprovalCode_1 = new System.Windows.Forms.Label();
            this.lblCCApprovalCode = new System.Windows.Forms.Label();
            this.chkRcptOnlineOrder = new System.Windows.Forms.CheckBox();
            this.txtRcptComments = new System.Windows.Forms.TextBox();
            this.lblRcptComments = new System.Windows.Forms.Label();
            this.lblRcptTotalDue_1 = new System.Windows.Forms.Label();
            this.lblRcptShipping_1 = new System.Windows.Forms.Label();
            this.lblRcptTax_1 = new System.Windows.Forms.Label();
            this.lblRcptSubtotal_1 = new System.Windows.Forms.Label();
            this.lblRcptThankyou = new System.Windows.Forms.Label();
            this.lblRcptSubtotal = new System.Windows.Forms.Label();
            this.lblRcptTotalDue = new System.Windows.Forms.Label();
            this.lblRcptTax = new System.Windows.Forms.Label();
            this.lblRcptDivider = new System.Windows.Forms.Label();
            this.dgvRcptItems = new System.Windows.Forms.DataGridView();
            this.lblRcptItemsOrdered = new System.Windows.Forms.Label();
            this.lblRcptShipping = new System.Windows.Forms.Label();
            this.lblRcptShipDate_1 = new System.Windows.Forms.Label();
            this.lblRcptShipDate = new System.Windows.Forms.Label();
            this.txtRcptSAddress = new System.Windows.Forms.TextBox();
            this.lblRcptSAddress = new System.Windows.Forms.Label();
            this.txtRcptBAddress = new System.Windows.Forms.TextBox();
            this.lblRcptBAddress = new System.Windows.Forms.Label();
            this.lblRcptCustomerName_1 = new System.Windows.Forms.Label();
            this.lblRcptCustomerName = new System.Windows.Forms.Label();
            this.lblRcptStatus_1 = new System.Windows.Forms.Label();
            this.lblRcptStatus = new System.Windows.Forms.Label();
            this.lblRcptOrderDate_1 = new System.Windows.Forms.Label();
            this.lblRcptOrderDate = new System.Windows.Forms.Label();
            this.lblRcptOrder_1 = new System.Windows.Forms.Label();
            this.lblRcptOrder = new System.Windows.Forms.Label();
            this.lblRcptSubTitle = new System.Windows.Forms.Label();
            this.lblReceiptTitle = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.tsOrders.SuspendLayout();
            this.statusStripOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpSearchOrder.SuspendLayout();
            this.grpOrderDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRcptItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tsOrders
            // 
            this.tsOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewOrder,
            this.toolStripSeparator6,
            this.tsbEditOrder,
            this.toolStripSeparator7,
            this.tsbDeleteOrder,
            this.toolStripSeparator8,
            this.tsbSearchOrder,
            this.toolStripSeparator3,
            this.tsbClear,
            this.toolStripSeparator4,
            this.tsbUpdateStatus,
            this.toolStripSeparator5,
            this.tsbRefreshOrders,
            this.toolStripSeparator1,
            this.tsbClose});
            this.tsOrders.Location = new System.Drawing.Point(0, 0);
            this.tsOrders.Name = "tsOrders";
            this.tsOrders.Size = new System.Drawing.Size(1180, 25);
            this.tsOrders.TabIndex = 0;
            this.tsOrders.Text = "tsOrders";
            // 
            // tsbNewOrder
            // 
            this.tsbNewOrder.Image = global::BikeStore.Properties.Resources.add;
            this.tsbNewOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewOrder.Name = "tsbNewOrder";
            this.tsbNewOrder.Size = new System.Drawing.Size(84, 22);
            this.tsbNewOrder.Text = "New Order";
            this.tsbNewOrder.Click += new System.EventHandler(this.tsbNewOrder_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEditOrder
            // 
            this.tsbEditOrder.Image = global::BikeStore.Properties.Resources.edit;
            this.tsbEditOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditOrder.Name = "tsbEditOrder";
            this.tsbEditOrder.Size = new System.Drawing.Size(80, 22);
            this.tsbEditOrder.Text = "Edit Order";
            this.tsbEditOrder.Click += new System.EventHandler(this.tsbEditOrder_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDeleteOrder
            // 
            this.tsbDeleteOrder.Image = global::BikeStore.Properties.Resources.delete;
            this.tsbDeleteOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteOrder.Name = "tsbDeleteOrder";
            this.tsbDeleteOrder.Size = new System.Drawing.Size(93, 22);
            this.tsbDeleteOrder.Text = "Delete Order";
            this.tsbDeleteOrder.Click += new System.EventHandler(this.tsbDeleteOrder_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSearchOrder
            // 
            this.tsbSearchOrder.Image = global::BikeStore.Properties.Resources.search_exact;
            this.tsbSearchOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchOrder.Name = "tsbSearchOrder";
            this.tsbSearchOrder.Size = new System.Drawing.Size(95, 22);
            this.tsbSearchOrder.Text = "Search Order";
            this.tsbSearchOrder.Click += new System.EventHandler(this.tsbSearchOrder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClear
            // 
            this.tsbClear.Image = global::BikeStore.Properties.Resources.clear_exact;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(87, 22);
            this.tsbClear.Text = "Clear Fields";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUpdateStatus
            // 
            this.tsbUpdateStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inProcessToolStripMenuItem,
            this.approvedToolStripMenuItem,
            this.backorderedToolStripMenuItem,
            this.rejectedToolStripMenuItem,
            this.shippedToolStripMenuItem,
            this.cancelledToolStripMenuItem});
            this.tsbUpdateStatus.Image = global::BikeStore.Properties.Resources.shipping_status_simple;
            this.tsbUpdateStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateStatus.Name = "tsbUpdateStatus";
            this.tsbUpdateStatus.Size = new System.Drawing.Size(112, 22);
            this.tsbUpdateStatus.Text = "Update Status";
            // 
            // inProcessToolStripMenuItem
            // 
            this.inProcessToolStripMenuItem.Name = "inProcessToolStripMenuItem";
            this.inProcessToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.inProcessToolStripMenuItem.Text = "In Process";
            this.inProcessToolStripMenuItem.Click += new System.EventHandler(this.inProcessToolStripMenuItem_Click_1);
            // 
            // approvedToolStripMenuItem
            // 
            this.approvedToolStripMenuItem.Name = "approvedToolStripMenuItem";
            this.approvedToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.approvedToolStripMenuItem.Text = "Approved";
            this.approvedToolStripMenuItem.Click += new System.EventHandler(this.approvedToolStripMenuItem_Click);
            // 
            // backorderedToolStripMenuItem
            // 
            this.backorderedToolStripMenuItem.Name = "backorderedToolStripMenuItem";
            this.backorderedToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.backorderedToolStripMenuItem.Text = "Backordered";
            this.backorderedToolStripMenuItem.Click += new System.EventHandler(this.backorderedToolStripMenuItem_Click_1);
            // 
            // rejectedToolStripMenuItem
            // 
            this.rejectedToolStripMenuItem.Name = "rejectedToolStripMenuItem";
            this.rejectedToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.rejectedToolStripMenuItem.Text = "Rejected";
            this.rejectedToolStripMenuItem.Click += new System.EventHandler(this.rejectedToolStripMenuItem_Click);
            // 
            // shippedToolStripMenuItem
            // 
            this.shippedToolStripMenuItem.Name = "shippedToolStripMenuItem";
            this.shippedToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.shippedToolStripMenuItem.Text = "Shipped";
            this.shippedToolStripMenuItem.Click += new System.EventHandler(this.shippedToolStripMenuItem_Click_1);
            // 
            // cancelledToolStripMenuItem
            // 
            this.cancelledToolStripMenuItem.Name = "cancelledToolStripMenuItem";
            this.cancelledToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cancelledToolStripMenuItem.Text = "Cancelled";
            this.cancelledToolStripMenuItem.Click += new System.EventHandler(this.cancelledToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefreshOrders
            // 
            this.tsbRefreshOrders.Image = global::BikeStore.Properties.Resources.refresh_matched;
            this.tsbRefreshOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshOrders.Name = "tsbRefreshOrders";
            this.tsbRefreshOrders.Size = new System.Drawing.Size(104, 22);
            this.tsbRefreshOrders.Text = "Refresh Orders";
            this.tsbRefreshOrders.Click += new System.EventHandler(this.tsbRefreshOrders_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::BikeStore.Properties.Resources.exit_matched;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(45, 22);
            this.tsbClose.Text = "Exit";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // statusStripOrders
            // 
            this.statusStripOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalOrders,
            this.tsslOrderStatus});
            this.statusStripOrders.Location = new System.Drawing.Point(0, 839);
            this.statusStripOrders.Name = "statusStripOrders";
            this.statusStripOrders.Size = new System.Drawing.Size(1180, 22);
            this.statusStripOrders.TabIndex = 4;
            this.statusStripOrders.Text = "statusStrip1";
            // 
            // tsslTotalOrders
            // 
            this.tsslTotalOrders.Name = "tsslTotalOrders";
            this.tsslTotalOrders.Size = new System.Drawing.Size(77, 17);
            this.tsslTotalOrders.Text = "Total Orders: ";
            // 
            // tsslOrderStatus
            // 
            this.tsslOrderStatus.Name = "tsslOrderStatus";
            this.tsslOrderStatus.Size = new System.Drawing.Size(75, 17);
            this.tsslOrderStatus.Text = "Order Status:";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvOrders.Location = new System.Drawing.Point(0, 136);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(850, 703);
            this.dgvOrders.TabIndex = 5;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grpSearchOrder);
            this.grpSearch.Controls.Add(this.grpOrderDate);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 25);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1180, 111);
            this.grpSearch.TabIndex = 6;
            this.grpSearch.TabStop = false;
            // 
            // grpSearchOrder
            // 
            this.grpSearchOrder.Controls.Add(this.cboOrderStatus);
            this.grpSearchOrder.Controls.Add(this.txtCustomer);
            this.grpSearchOrder.Controls.Add(this.txtOrderNumber);
            this.grpSearchOrder.Controls.Add(this.lblStatus);
            this.grpSearchOrder.Controls.Add(this.lblCustomer);
            this.grpSearchOrder.Controls.Add(this.lblOrderNumber);
            this.grpSearchOrder.Location = new System.Drawing.Point(12, 20);
            this.grpSearchOrder.Name = "grpSearchOrder";
            this.grpSearchOrder.Size = new System.Drawing.Size(675, 78);
            this.grpSearchOrder.TabIndex = 11;
            this.grpSearchOrder.TabStop = false;
            this.grpSearchOrder.Text = "Search Orders";
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Items.AddRange(new object[] {
            "In Process",
            "Approved",
            "Backordered",
            "Rejected",
            "Shipped",
            "Cancelled"});
            this.cboOrderStatus.Location = new System.Drawing.Point(516, 37);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(121, 21);
            this.cboOrderStatus.TabIndex = 12;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(190, 38);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(282, 20);
            this.txtCustomer.TabIndex = 11;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(31, 39);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(121, 20);
            this.txtOrderNumber.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(513, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(187, 19);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Customer";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(31, 20);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNumber.TabIndex = 7;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // grpOrderDate
            // 
            this.grpOrderDate.Controls.Add(this.dtpDateTo);
            this.grpOrderDate.Controls.Add(this.lblDateTo);
            this.grpOrderDate.Controls.Add(this.lblDateFrom);
            this.grpOrderDate.Controls.Add(this.dtpDateFrom);
            this.grpOrderDate.Location = new System.Drawing.Point(693, 19);
            this.grpOrderDate.Name = "grpOrderDate";
            this.grpOrderDate.Size = new System.Drawing.Size(475, 79);
            this.grpOrderDate.TabIndex = 10;
            this.grpOrderDate.TabStop = false;
            this.grpOrderDate.Text = "Order Date";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(270, 40);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(168, 20);
            this.dtpDateTo.TabIndex = 8;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(267, 21);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(20, 13);
            this.lblDateTo.TabIndex = 9;
            this.lblDateTo.Text = "To";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(36, 20);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(30, 13);
            this.lblDateFrom.TabIndex = 3;
            this.lblDateFrom.Text = "From";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(39, 40);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(168, 20);
            this.dtpDateFrom.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BikeStore.Properties.Resources._6137260;
            this.pictureBox1.Location = new System.Drawing.Point(887, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(893, 548);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(247, 179);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "Click on an order to view the invoice/receipt summary.";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReceipt
            // 
            this.pnlReceipt.BackColor = System.Drawing.Color.Transparent;
            this.pnlReceipt.Controls.Add(this.lblCCApprovalCode_1);
            this.pnlReceipt.Controls.Add(this.lblCCApprovalCode);
            this.pnlReceipt.Controls.Add(this.chkRcptOnlineOrder);
            this.pnlReceipt.Controls.Add(this.txtRcptComments);
            this.pnlReceipt.Controls.Add(this.lblRcptComments);
            this.pnlReceipt.Controls.Add(this.lblRcptTotalDue_1);
            this.pnlReceipt.Controls.Add(this.lblRcptShipping_1);
            this.pnlReceipt.Controls.Add(this.lblRcptTax_1);
            this.pnlReceipt.Controls.Add(this.lblRcptSubtotal_1);
            this.pnlReceipt.Controls.Add(this.lblRcptThankyou);
            this.pnlReceipt.Controls.Add(this.lblRcptSubtotal);
            this.pnlReceipt.Controls.Add(this.lblRcptTotalDue);
            this.pnlReceipt.Controls.Add(this.lblRcptTax);
            this.pnlReceipt.Controls.Add(this.lblRcptDivider);
            this.pnlReceipt.Controls.Add(this.dgvRcptItems);
            this.pnlReceipt.Controls.Add(this.lblRcptItemsOrdered);
            this.pnlReceipt.Controls.Add(this.lblRcptShipping);
            this.pnlReceipt.Controls.Add(this.lblRcptShipDate_1);
            this.pnlReceipt.Controls.Add(this.lblRcptShipDate);
            this.pnlReceipt.Controls.Add(this.txtRcptSAddress);
            this.pnlReceipt.Controls.Add(this.lblRcptSAddress);
            this.pnlReceipt.Controls.Add(this.txtRcptBAddress);
            this.pnlReceipt.Controls.Add(this.lblRcptBAddress);
            this.pnlReceipt.Controls.Add(this.lblRcptCustomerName_1);
            this.pnlReceipt.Controls.Add(this.lblRcptCustomerName);
            this.pnlReceipt.Controls.Add(this.lblRcptStatus_1);
            this.pnlReceipt.Controls.Add(this.lblRcptStatus);
            this.pnlReceipt.Controls.Add(this.lblRcptOrderDate_1);
            this.pnlReceipt.Controls.Add(this.lblRcptOrderDate);
            this.pnlReceipt.Controls.Add(this.lblRcptOrder_1);
            this.pnlReceipt.Controls.Add(this.lblRcptOrder);
            this.pnlReceipt.Controls.Add(this.lblRcptSubTitle);
            this.pnlReceipt.Controls.Add(this.lblReceiptTitle);
            this.pnlReceipt.Controls.Add(this.lblStoreName);
            this.pnlReceipt.Location = new System.Drawing.Point(856, 139);
            this.pnlReceipt.Name = "pnlReceipt";
            this.pnlReceipt.Size = new System.Drawing.Size(318, 700);
            this.pnlReceipt.TabIndex = 10;
            this.pnlReceipt.Visible = false;
            // 
            // lblCCApprovalCode_1
            // 
            this.lblCCApprovalCode_1.Location = new System.Drawing.Point(195, 651);
            this.lblCCApprovalCode_1.Name = "lblCCApprovalCode_1";
            this.lblCCApprovalCode_1.Size = new System.Drawing.Size(100, 13);
            this.lblCCApprovalCode_1.TabIndex = 35;
            this.lblCCApprovalCode_1.Text = "74125676";
            this.lblCCApprovalCode_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCCApprovalCode
            // 
            this.lblCCApprovalCode.AutoSize = true;
            this.lblCCApprovalCode.Location = new System.Drawing.Point(20, 651);
            this.lblCCApprovalCode.Name = "lblCCApprovalCode";
            this.lblCCApprovalCode.Size = new System.Drawing.Size(131, 13);
            this.lblCCApprovalCode.TabIndex = 34;
            this.lblCCApprovalCode.Text = "Credit card Approval Code";
            // 
            // chkRcptOnlineOrder
            // 
            this.chkRcptOnlineOrder.Enabled = false;
            this.chkRcptOnlineOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRcptOnlineOrder.Location = new System.Drawing.Point(207, 161);
            this.chkRcptOnlineOrder.Name = "chkRcptOnlineOrder";
            this.chkRcptOnlineOrder.Size = new System.Drawing.Size(87, 24);
            this.chkRcptOnlineOrder.TabIndex = 33;
            this.chkRcptOnlineOrder.Text = "Online Order";
            this.chkRcptOnlineOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRcptOnlineOrder.UseVisualStyleBackColor = true;
            // 
            // txtRcptComments
            // 
            this.txtRcptComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRcptComments.Location = new System.Drawing.Point(23, 505);
            this.txtRcptComments.Multiline = true;
            this.txtRcptComments.Name = "txtRcptComments";
            this.txtRcptComments.ReadOnly = true;
            this.txtRcptComments.Size = new System.Drawing.Size(272, 39);
            this.txtRcptComments.TabIndex = 32;
            // 
            // lblRcptComments
            // 
            this.lblRcptComments.AutoSize = true;
            this.lblRcptComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptComments.Location = new System.Drawing.Point(20, 489);
            this.lblRcptComments.Name = "lblRcptComments";
            this.lblRcptComments.Size = new System.Drawing.Size(64, 13);
            this.lblRcptComments.TabIndex = 31;
            this.lblRcptComments.Text = "Comments";
            // 
            // lblRcptTotalDue_1
            // 
            this.lblRcptTotalDue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptTotalDue_1.Location = new System.Drawing.Point(195, 629);
            this.lblRcptTotalDue_1.Name = "lblRcptTotalDue_1";
            this.lblRcptTotalDue_1.Size = new System.Drawing.Size(100, 35);
            this.lblRcptTotalDue_1.TabIndex = 30;
            this.lblRcptTotalDue_1.Text = "$15.00";
            this.lblRcptTotalDue_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRcptShipping_1
            // 
            this.lblRcptShipping_1.Location = new System.Drawing.Point(195, 606);
            this.lblRcptShipping_1.Name = "lblRcptShipping_1";
            this.lblRcptShipping_1.Size = new System.Drawing.Size(100, 13);
            this.lblRcptShipping_1.TabIndex = 29;
            this.lblRcptShipping_1.Text = "$15.00";
            this.lblRcptShipping_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRcptTax_1
            // 
            this.lblRcptTax_1.Location = new System.Drawing.Point(195, 593);
            this.lblRcptTax_1.Name = "lblRcptTax_1";
            this.lblRcptTax_1.Size = new System.Drawing.Size(100, 13);
            this.lblRcptTax_1.TabIndex = 28;
            this.lblRcptTax_1.Text = "$67.20";
            this.lblRcptTax_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRcptSubtotal_1
            // 
            this.lblRcptSubtotal_1.Location = new System.Drawing.Point(195, 580);
            this.lblRcptSubtotal_1.Name = "lblRcptSubtotal_1";
            this.lblRcptSubtotal_1.Size = new System.Drawing.Size(100, 13);
            this.lblRcptSubtotal_1.TabIndex = 27;
            this.lblRcptSubtotal_1.Text = "$960.00";
            this.lblRcptSubtotal_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRcptThankyou
            // 
            this.lblRcptThankyou.AutoSize = true;
            this.lblRcptThankyou.Location = new System.Drawing.Point(79, 679);
            this.lblRcptThankyou.Name = "lblRcptThankyou";
            this.lblRcptThankyou.Size = new System.Drawing.Size(158, 13);
            this.lblRcptThankyou.TabIndex = 26;
            this.lblRcptThankyou.Text = "Thank you for shopping with us!";
            // 
            // lblRcptSubtotal
            // 
            this.lblRcptSubtotal.AutoSize = true;
            this.lblRcptSubtotal.Location = new System.Drawing.Point(20, 580);
            this.lblRcptSubtotal.Name = "lblRcptSubtotal";
            this.lblRcptSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblRcptSubtotal.TabIndex = 25;
            this.lblRcptSubtotal.Text = "Subtotal";
            // 
            // lblRcptTotalDue
            // 
            this.lblRcptTotalDue.AutoSize = true;
            this.lblRcptTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptTotalDue.Location = new System.Drawing.Point(20, 629);
            this.lblRcptTotalDue.Name = "lblRcptTotalDue";
            this.lblRcptTotalDue.Size = new System.Drawing.Size(92, 16);
            this.lblRcptTotalDue.TabIndex = 24;
            this.lblRcptTotalDue.Text = "TOTAL DUE";
            // 
            // lblRcptTax
            // 
            this.lblRcptTax.AutoSize = true;
            this.lblRcptTax.Location = new System.Drawing.Point(20, 593);
            this.lblRcptTax.Name = "lblRcptTax";
            this.lblRcptTax.Size = new System.Drawing.Size(25, 13);
            this.lblRcptTax.TabIndex = 23;
            this.lblRcptTax.Text = "Tax";
            // 
            // lblRcptDivider
            // 
            this.lblRcptDivider.Location = new System.Drawing.Point(4, 558);
            this.lblRcptDivider.Name = "lblRcptDivider";
            this.lblRcptDivider.Size = new System.Drawing.Size(311, 16);
            this.lblRcptDivider.TabIndex = 22;
            this.lblRcptDivider.Text = "=================================================================================" +
    "=========";
            this.lblRcptDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRcptItems
            // 
            this.dgvRcptItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRcptItems.Location = new System.Drawing.Point(6, 317);
            this.dgvRcptItems.Name = "dgvRcptItems";
            this.dgvRcptItems.Size = new System.Drawing.Size(306, 163);
            this.dgvRcptItems.TabIndex = 21;
            // 
            // lblRcptItemsOrdered
            // 
            this.lblRcptItemsOrdered.AutoSize = true;
            this.lblRcptItemsOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptItemsOrdered.Location = new System.Drawing.Point(104, 301);
            this.lblRcptItemsOrdered.Name = "lblRcptItemsOrdered";
            this.lblRcptItemsOrdered.Size = new System.Drawing.Size(110, 13);
            this.lblRcptItemsOrdered.TabIndex = 20;
            this.lblRcptItemsOrdered.Text = "ITEMS ORDERED";
            // 
            // lblRcptShipping
            // 
            this.lblRcptShipping.AutoSize = true;
            this.lblRcptShipping.Location = new System.Drawing.Point(20, 606);
            this.lblRcptShipping.Name = "lblRcptShipping";
            this.lblRcptShipping.Size = new System.Drawing.Size(91, 13);
            this.lblRcptShipping.TabIndex = 19;
            this.lblRcptShipping.Text = "Shipping / Freight";
            // 
            // lblRcptShipDate_1
            // 
            this.lblRcptShipDate_1.AutoSize = true;
            this.lblRcptShipDate_1.Location = new System.Drawing.Point(230, 136);
            this.lblRcptShipDate_1.Name = "lblRcptShipDate_1";
            this.lblRcptShipDate_1.Size = new System.Drawing.Size(65, 13);
            this.lblRcptShipDate_1.TabIndex = 17;
            this.lblRcptShipDate_1.Text = "06/12/2026";
            // 
            // lblRcptShipDate
            // 
            this.lblRcptShipDate.AutoSize = true;
            this.lblRcptShipDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptShipDate.Location = new System.Drawing.Point(230, 123);
            this.lblRcptShipDate.Name = "lblRcptShipDate";
            this.lblRcptShipDate.Size = new System.Drawing.Size(73, 13);
            this.lblRcptShipDate.TabIndex = 16;
            this.lblRcptShipDate.Text = "SHIP DATE";
            // 
            // txtRcptSAddress
            // 
            this.txtRcptSAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRcptSAddress.Location = new System.Drawing.Point(166, 222);
            this.txtRcptSAddress.Multiline = true;
            this.txtRcptSAddress.Name = "txtRcptSAddress";
            this.txtRcptSAddress.ReadOnly = true;
            this.txtRcptSAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRcptSAddress.Size = new System.Drawing.Size(124, 67);
            this.txtRcptSAddress.TabIndex = 15;
            // 
            // lblRcptSAddress
            // 
            this.lblRcptSAddress.AutoSize = true;
            this.lblRcptSAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptSAddress.Location = new System.Drawing.Point(163, 206);
            this.lblRcptSAddress.Name = "lblRcptSAddress";
            this.lblRcptSAddress.Size = new System.Drawing.Size(129, 13);
            this.lblRcptSAddress.TabIndex = 14;
            this.lblRcptSAddress.Text = "SHIPPING ADDRESS";
            // 
            // txtRcptBAddress
            // 
            this.txtRcptBAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRcptBAddress.Location = new System.Drawing.Point(22, 222);
            this.txtRcptBAddress.Multiline = true;
            this.txtRcptBAddress.Name = "txtRcptBAddress";
            this.txtRcptBAddress.ReadOnly = true;
            this.txtRcptBAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRcptBAddress.Size = new System.Drawing.Size(124, 67);
            this.txtRcptBAddress.TabIndex = 13;
            // 
            // lblRcptBAddress
            // 
            this.lblRcptBAddress.AutoSize = true;
            this.lblRcptBAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptBAddress.Location = new System.Drawing.Point(19, 206);
            this.lblRcptBAddress.Name = "lblRcptBAddress";
            this.lblRcptBAddress.Size = new System.Drawing.Size(118, 13);
            this.lblRcptBAddress.TabIndex = 12;
            this.lblRcptBAddress.Text = "BILLING ADDRESS";
            // 
            // lblRcptCustomerName_1
            // 
            this.lblRcptCustomerName_1.AutoSize = true;
            this.lblRcptCustomerName_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptCustomerName_1.Location = new System.Drawing.Point(23, 179);
            this.lblRcptCustomerName_1.Name = "lblRcptCustomerName_1";
            this.lblRcptCustomerName_1.Size = new System.Drawing.Size(70, 13);
            this.lblRcptCustomerName_1.TabIndex = 10;
            this.lblRcptCustomerName_1.Text = "Daniel Adrian";
            // 
            // lblRcptCustomerName
            // 
            this.lblRcptCustomerName.AutoSize = true;
            this.lblRcptCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptCustomerName.Location = new System.Drawing.Point(19, 166);
            this.lblRcptCustomerName.Name = "lblRcptCustomerName";
            this.lblRcptCustomerName.Size = new System.Drawing.Size(76, 13);
            this.lblRcptCustomerName.TabIndex = 9;
            this.lblRcptCustomerName.Text = "CUSTOMER";
            // 
            // lblRcptStatus_1
            // 
            this.lblRcptStatus_1.AutoSize = true;
            this.lblRcptStatus_1.Location = new System.Drawing.Point(144, 136);
            this.lblRcptStatus_1.Name = "lblRcptStatus_1";
            this.lblRcptStatus_1.Size = new System.Drawing.Size(46, 13);
            this.lblRcptStatus_1.TabIndex = 8;
            this.lblRcptStatus_1.Text = "Shipped";
            // 
            // lblRcptStatus
            // 
            this.lblRcptStatus.AccessibleDescription = "";
            this.lblRcptStatus.AutoSize = true;
            this.lblRcptStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptStatus.Location = new System.Drawing.Point(144, 123);
            this.lblRcptStatus.Name = "lblRcptStatus";
            this.lblRcptStatus.Size = new System.Drawing.Size(56, 13);
            this.lblRcptStatus.TabIndex = 7;
            this.lblRcptStatus.Text = "STATUS";
            // 
            // lblRcptOrderDate_1
            // 
            this.lblRcptOrderDate_1.AutoSize = true;
            this.lblRcptOrderDate_1.Location = new System.Drawing.Point(19, 136);
            this.lblRcptOrderDate_1.Name = "lblRcptOrderDate_1";
            this.lblRcptOrderDate_1.Size = new System.Drawing.Size(65, 13);
            this.lblRcptOrderDate_1.TabIndex = 6;
            this.lblRcptOrderDate_1.Text = "06/01/2026";
            // 
            // lblRcptOrderDate
            // 
            this.lblRcptOrderDate.AutoSize = true;
            this.lblRcptOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptOrderDate.Location = new System.Drawing.Point(19, 123);
            this.lblRcptOrderDate.Name = "lblRcptOrderDate";
            this.lblRcptOrderDate.Size = new System.Drawing.Size(88, 13);
            this.lblRcptOrderDate.TabIndex = 5;
            this.lblRcptOrderDate.Text = "ORDER DATE";
            // 
            // lblRcptOrder_1
            // 
            this.lblRcptOrder_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRcptOrder_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptOrder_1.Location = new System.Drawing.Point(154, 87);
            this.lblRcptOrder_1.Name = "lblRcptOrder_1";
            this.lblRcptOrder_1.Size = new System.Drawing.Size(140, 20);
            this.lblRcptOrder_1.TabIndex = 4;
            this.lblRcptOrder_1.Text = "Order Number";
            this.lblRcptOrder_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRcptOrder
            // 
            this.lblRcptOrder.AutoSize = true;
            this.lblRcptOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptOrder.Location = new System.Drawing.Point(19, 94);
            this.lblRcptOrder.Name = "lblRcptOrder";
            this.lblRcptOrder.Size = new System.Drawing.Size(63, 13);
            this.lblRcptOrder.TabIndex = 3;
            this.lblRcptOrder.Text = "ORDER #";
            // 
            // lblRcptSubTitle
            // 
            this.lblRcptSubTitle.AutoSize = true;
            this.lblRcptSubTitle.Location = new System.Drawing.Point(78, 60);
            this.lblRcptSubTitle.Name = "lblRcptSubTitle";
            this.lblRcptSubTitle.Size = new System.Drawing.Size(158, 13);
            this.lblRcptSubTitle.TabIndex = 2;
            this.lblRcptSubTitle.Text = "Order confirmation and summary";
            // 
            // lblReceiptTitle
            // 
            this.lblReceiptTitle.AutoSize = true;
            this.lblReceiptTitle.Location = new System.Drawing.Point(112, 47);
            this.lblReceiptTitle.Name = "lblReceiptTitle";
            this.lblReceiptTitle.Size = new System.Drawing.Size(90, 13);
            this.lblReceiptTitle.TabIndex = 1;
            this.lblReceiptTitle.Text = "SALES RECEIPT";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(93, 12);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(131, 24);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "BIKE STORE";
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 861);
            this.Controls.Add(this.pnlReceipt);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.statusStripOrders);
            this.Controls.Add(this.tsOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bike Store | Order Management";
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            this.tsOrders.ResumeLayout(false);
            this.tsOrders.PerformLayout();
            this.statusStripOrders.ResumeLayout(false);
            this.statusStripOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearchOrder.ResumeLayout(false);
            this.grpSearchOrder.PerformLayout();
            this.grpOrderDate.ResumeLayout(false);
            this.grpOrderDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlReceipt.ResumeLayout(false);
            this.pnlReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRcptItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsOrders;
        private System.Windows.Forms.ToolStripButton tsbNewOrder;
        private System.Windows.Forms.ToolStripButton tsbEditOrder;
        private System.Windows.Forms.ToolStripButton tsbRefreshOrders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.StatusStrip statusStripOrders;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.GroupBox grpOrderDate;
        private System.Windows.Forms.GroupBox grpSearchOrder;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.ToolStripStatusLabel tsslOrderStatus;
        private System.Windows.Forms.ToolStripButton tsbSearchOrder;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbDeleteOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Panel pnlReceipt;
        private System.Windows.Forms.Label lblCCApprovalCode_1;
        private System.Windows.Forms.Label lblCCApprovalCode;
        private System.Windows.Forms.CheckBox chkRcptOnlineOrder;
        private System.Windows.Forms.TextBox txtRcptComments;
        private System.Windows.Forms.Label lblRcptComments;
        private System.Windows.Forms.Label lblRcptTotalDue_1;
        private System.Windows.Forms.Label lblRcptShipping_1;
        private System.Windows.Forms.Label lblRcptTax_1;
        private System.Windows.Forms.Label lblRcptSubtotal_1;
        private System.Windows.Forms.Label lblRcptThankyou;
        private System.Windows.Forms.Label lblRcptSubtotal;
        private System.Windows.Forms.Label lblRcptTotalDue;
        private System.Windows.Forms.Label lblRcptTax;
        private System.Windows.Forms.Label lblRcptDivider;
        private System.Windows.Forms.DataGridView dgvRcptItems;
        private System.Windows.Forms.Label lblRcptItemsOrdered;
        private System.Windows.Forms.Label lblRcptShipping;
        private System.Windows.Forms.Label lblRcptShipDate_1;
        private System.Windows.Forms.Label lblRcptShipDate;
        private System.Windows.Forms.TextBox txtRcptSAddress;
        private System.Windows.Forms.Label lblRcptSAddress;
        private System.Windows.Forms.TextBox txtRcptBAddress;
        private System.Windows.Forms.Label lblRcptBAddress;
        private System.Windows.Forms.Label lblRcptCustomerName_1;
        private System.Windows.Forms.Label lblRcptCustomerName;
        private System.Windows.Forms.Label lblRcptStatus_1;
        private System.Windows.Forms.Label lblRcptStatus;
        private System.Windows.Forms.Label lblRcptOrderDate_1;
        private System.Windows.Forms.Label lblRcptOrderDate;
        private System.Windows.Forms.Label lblRcptOrder_1;
        private System.Windows.Forms.Label lblRcptOrder;
        private System.Windows.Forms.Label lblRcptSubTitle;
        private System.Windows.Forms.Label lblReceiptTitle;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.ToolStripSplitButton tsbUpdateStatus;
        private System.Windows.Forms.ToolStripMenuItem inProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backorderedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelledToolStripMenuItem;
    }
}