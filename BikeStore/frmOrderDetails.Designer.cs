namespace BikeStore
{
    partial class frmOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderDetails));
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.cboShippingMethod = new System.Windows.Forms.ComboBox();
            this.lblShipMethod = new System.Windows.Forms.Label();
            this.chkOnlineOrder = new System.Windows.Forms.CheckBox();
            this.cboShipAddress = new System.Windows.Forms.ComboBox();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.cboBillAddress = new System.Windows.Forms.ComboBox();
            this.lblBillToAddress = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpShipDate = new System.Windows.Forms.DateTimePicker();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderNumber_1 = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.grpProductSearch = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.grpAddToOrder = new System.Windows.Forms.GroupBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblUnitPrice_1 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.nudItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpOrderItems = new System.Windows.Forms.GroupBox();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.grpComments = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.grpOrderTotals = new System.Windows.Forms.GroupBox();
            this.lblSubtotal_1 = new System.Windows.Forms.Label();
            this.lblTax_1 = new System.Windows.Forms.Label();
            this.lblTotalDue_1 = new System.Windows.Forms.Label();
            this.lblShipping_1 = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cboPymtMethod = new System.Windows.Forms.ComboBox();
            this.lblApprovalCode = new System.Windows.Forms.Label();
            this.txtCCApprovalCode = new System.Windows.Forms.TextBox();
            this.grpOrderInfo.SuspendLayout();
            this.grpProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpAddToOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemQuantity)).BeginInit();
            this.grpOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.grpComments.SuspendLayout();
            this.grpOrderTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.cboShippingMethod);
            this.grpOrderInfo.Controls.Add(this.lblShipMethod);
            this.grpOrderInfo.Controls.Add(this.chkOnlineOrder);
            this.grpOrderInfo.Controls.Add(this.cboShipAddress);
            this.grpOrderInfo.Controls.Add(this.lblShipAddress);
            this.grpOrderInfo.Controls.Add(this.cboBillAddress);
            this.grpOrderInfo.Controls.Add(this.lblBillToAddress);
            this.grpOrderInfo.Controls.Add(this.cboCustomer);
            this.grpOrderInfo.Controls.Add(this.lblCustomer);
            this.grpOrderInfo.Controls.Add(this.cboStatus);
            this.grpOrderInfo.Controls.Add(this.lblStatus);
            this.grpOrderInfo.Controls.Add(this.dtpShipDate);
            this.grpOrderInfo.Controls.Add(this.lblShipDate);
            this.grpOrderInfo.Controls.Add(this.dtpDueDate);
            this.grpOrderInfo.Controls.Add(this.lblDueDate);
            this.grpOrderInfo.Controls.Add(this.dtpOrderDate);
            this.grpOrderInfo.Controls.Add(this.lblOrderDate);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumber_1);
            this.grpOrderInfo.Controls.Add(this.lblOrderNumber);
            this.grpOrderInfo.Location = new System.Drawing.Point(12, 12);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(1156, 100);
            this.grpOrderInfo.TabIndex = 0;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // cboShippingMethod
            // 
            this.cboShippingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShippingMethod.FormattingEnabled = true;
            this.cboShippingMethod.Items.AddRange(new object[] {
            "CARGO TRANSPORT 5",
            "USPS",
            "UPS",
            "FEDEX"});
            this.cboShippingMethod.Location = new System.Drawing.Point(1027, 26);
            this.cboShippingMethod.Name = "cboShippingMethod";
            this.cboShippingMethod.Size = new System.Drawing.Size(119, 21);
            this.cboShippingMethod.TabIndex = 18;
            // 
            // lblShipMethod
            // 
            this.lblShipMethod.AutoSize = true;
            this.lblShipMethod.Location = new System.Drawing.Point(954, 29);
            this.lblShipMethod.Name = "lblShipMethod";
            this.lblShipMethod.Size = new System.Drawing.Size(67, 13);
            this.lblShipMethod.TabIndex = 17;
            this.lblShipMethod.Text = "Ship Method";
            // 
            // chkOnlineOrder
            // 
            this.chkOnlineOrder.AutoSize = true;
            this.chkOnlineOrder.Location = new System.Drawing.Point(1055, 62);
            this.chkOnlineOrder.Name = "chkOnlineOrder";
            this.chkOnlineOrder.Size = new System.Drawing.Size(91, 17);
            this.chkOnlineOrder.TabIndex = 16;
            this.chkOnlineOrder.Text = "Online Order?";
            this.chkOnlineOrder.UseVisualStyleBackColor = true;
            // 
            // cboShipAddress
            // 
            this.cboShipAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShipAddress.FormattingEnabled = true;
            this.cboShipAddress.Location = new System.Drawing.Point(765, 60);
            this.cboShipAddress.Name = "cboShipAddress";
            this.cboShipAddress.Size = new System.Drawing.Size(252, 21);
            this.cboShipAddress.TabIndex = 15;
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Location = new System.Drawing.Point(678, 63);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(81, 13);
            this.lblShipAddress.TabIndex = 14;
            this.lblShipAddress.Text = "Ship to Address";
            // 
            // cboBillAddress
            // 
            this.cboBillAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBillAddress.FormattingEnabled = true;
            this.cboBillAddress.Location = new System.Drawing.Point(400, 60);
            this.cboBillAddress.Name = "cboBillAddress";
            this.cboBillAddress.Size = new System.Drawing.Size(252, 21);
            this.cboBillAddress.TabIndex = 13;
            // 
            // lblBillToAddress
            // 
            this.lblBillToAddress.AutoSize = true;
            this.lblBillToAddress.Location = new System.Drawing.Point(321, 63);
            this.lblBillToAddress.Name = "lblBillToAddress";
            this.lblBillToAddress.Size = new System.Drawing.Size(73, 13);
            this.lblBillToAddress.TabIndex = 12;
            this.lblBillToAddress.Text = "Bill to Address";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(85, 60);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(217, 21);
            this.cboCustomer.TabIndex = 11;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(28, 63);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "Customer";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "In Process",
            "Approved",
            "Backordered",
            "Rejected",
            "Shipped",
            "Shipped"});
            this.cboStatus.Location = new System.Drawing.Point(814, 25);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(771, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // dtpShipDate
            // 
            this.dtpShipDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShipDate.Location = new System.Drawing.Point(638, 25);
            this.dtpShipDate.Name = "dtpShipDate";
            this.dtpShipDate.ShowCheckBox = true;
            this.dtpShipDate.Size = new System.Drawing.Size(105, 20);
            this.dtpShipDate.TabIndex = 7;
            // 
            // lblShipDate
            // 
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(584, 28);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(54, 13);
            this.lblShipDate.TabIndex = 6;
            this.lblShipDate.Text = "Ship Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(463, 26);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(105, 20);
            this.dtpDueDate.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(404, 27);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "Due Date";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(274, 25);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(105, 20);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(209, 28);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblOrderNumber_1
            // 
            this.lblOrderNumber_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderNumber_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber_1.Location = new System.Drawing.Point(85, 27);
            this.lblOrderNumber_1.Name = "lblOrderNumber_1";
            this.lblOrderNumber_1.Size = new System.Drawing.Size(103, 18);
            this.lblOrderNumber_1.TabIndex = 1;
            this.lblOrderNumber_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(6, 28);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // grpProductSearch
            // 
            this.grpProductSearch.Controls.Add(this.dgvProducts);
            this.grpProductSearch.Controls.Add(this.btnSearchProduct);
            this.grpProductSearch.Controls.Add(this.txtProductName);
            this.grpProductSearch.Controls.Add(this.lblProductName);
            this.grpProductSearch.Location = new System.Drawing.Point(12, 129);
            this.grpProductSearch.Name = "grpProductSearch";
            this.grpProductSearch.Size = new System.Drawing.Size(701, 189);
            this.grpProductSearch.TabIndex = 16;
            this.grpProductSearch.TabStop = false;
            this.grpProductSearch.Text = "Product Search";
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 59);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(689, 120);
            this.dgvProducts.TabIndex = 17;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(451, 21);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(109, 23);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(323, 20);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(28, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // grpAddToOrder
            // 
            this.grpAddToOrder.Controls.Add(this.btnAddToOrder);
            this.grpAddToOrder.Controls.Add(this.lblUnitPrice_1);
            this.grpAddToOrder.Controls.Add(this.lblUnitPrice);
            this.grpAddToOrder.Controls.Add(this.nudItemQuantity);
            this.grpAddToOrder.Controls.Add(this.lblQuantity);
            this.grpAddToOrder.Location = new System.Drawing.Point(734, 129);
            this.grpAddToOrder.Name = "grpAddToOrder";
            this.grpAddToOrder.Size = new System.Drawing.Size(434, 189);
            this.grpAddToOrder.TabIndex = 0;
            this.grpAddToOrder.TabStop = false;
            this.grpAddToOrder.Text = "Add to Order";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Enabled = false;
            this.btnAddToOrder.Location = new System.Drawing.Point(305, 126);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(119, 32);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblUnitPrice_1
            // 
            this.lblUnitPrice_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnitPrice_1.Location = new System.Drawing.Point(259, 59);
            this.lblUnitPrice_1.Name = "lblUnitPrice_1";
            this.lblUnitPrice_1.Size = new System.Drawing.Size(100, 23);
            this.lblUnitPrice_1.TabIndex = 3;
            this.lblUnitPrice_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnitPrice_1.Visible = false;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(200, 64);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.Visible = false;
            // 
            // nudItemQuantity
            // 
            this.nudItemQuantity.Location = new System.Drawing.Point(92, 62);
            this.nudItemQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudItemQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemQuantity.Name = "nudItemQuantity";
            this.nudItemQuantity.Size = new System.Drawing.Size(62, 20);
            this.nudItemQuantity.TabIndex = 1;
            this.nudItemQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudItemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemQuantity.Visible = false;
            this.nudItemQuantity.ValueChanged += new System.EventHandler(this.nudItemQuantity_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(40, 64);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Visible = false;
            // 
            // grpOrderItems
            // 
            this.grpOrderItems.Controls.Add(this.btnEditItem);
            this.grpOrderItems.Controls.Add(this.dgvOrderItems);
            this.grpOrderItems.Controls.Add(this.btnRemoveItem);
            this.grpOrderItems.Controls.Add(this.btnClearItems);
            this.grpOrderItems.Location = new System.Drawing.Point(12, 334);
            this.grpOrderItems.Name = "grpOrderItems";
            this.grpOrderItems.Size = new System.Drawing.Size(1156, 146);
            this.grpOrderItems.TabIndex = 17;
            this.grpOrderItems.TabStop = false;
            this.grpOrderItems.Text = "Order Items";
            // 
            // btnEditItem
            // 
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Location = new System.Drawing.Point(1049, 21);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(97, 32);
            this.btnEditItem.TabIndex = 5;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(6, 19);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.Size = new System.Drawing.Size(1027, 120);
            this.dgvOrderItems.TabIndex = 18;
            this.dgvOrderItems.SelectionChanged += new System.EventHandler(this.dgvOrderItems_SelectionChanged);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(1049, 59);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(97, 32);
            this.btnRemoveItem.TabIndex = 6;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.Enabled = false;
            this.btnClearItems.Location = new System.Drawing.Point(1049, 97);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(97, 32);
            this.btnClearItems.TabIndex = 7;
            this.btnClearItems.Text = "Clear Items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // grpComments
            // 
            this.grpComments.Controls.Add(this.txtComment);
            this.grpComments.Location = new System.Drawing.Point(12, 496);
            this.grpComments.Name = "grpComments";
            this.grpComments.Size = new System.Drawing.Size(574, 117);
            this.grpComments.TabIndex = 18;
            this.grpComments.TabStop = false;
            this.grpComments.Text = "Notes";
            // 
            // txtComment
            // 
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Location = new System.Drawing.Point(9, 19);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(559, 88);
            this.txtComment.TabIndex = 0;
            // 
            // grpOrderTotals
            // 
            this.grpOrderTotals.Controls.Add(this.lblSubtotal_1);
            this.grpOrderTotals.Controls.Add(this.lblTax_1);
            this.grpOrderTotals.Controls.Add(this.lblTotalDue_1);
            this.grpOrderTotals.Controls.Add(this.lblShipping_1);
            this.grpOrderTotals.Controls.Add(this.lblTotalDue);
            this.grpOrderTotals.Controls.Add(this.lblShipping);
            this.grpOrderTotals.Controls.Add(this.lblTax);
            this.grpOrderTotals.Controls.Add(this.lblSubtotal);
            this.grpOrderTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderTotals.Location = new System.Drawing.Point(620, 496);
            this.grpOrderTotals.Name = "grpOrderTotals";
            this.grpOrderTotals.Size = new System.Drawing.Size(317, 117);
            this.grpOrderTotals.TabIndex = 19;
            this.grpOrderTotals.TabStop = false;
            this.grpOrderTotals.Text = "Order Totals";
            // 
            // lblSubtotal_1
            // 
            this.lblSubtotal_1.Location = new System.Drawing.Point(206, 21);
            this.lblSubtotal_1.Name = "lblSubtotal_1";
            this.lblSubtotal_1.Size = new System.Drawing.Size(74, 16);
            this.lblSubtotal_1.TabIndex = 30;
            this.lblSubtotal_1.Text = "$0.00";
            this.lblSubtotal_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTax_1
            // 
            this.lblTax_1.Location = new System.Drawing.Point(206, 43);
            this.lblTax_1.Name = "lblTax_1";
            this.lblTax_1.Size = new System.Drawing.Size(74, 16);
            this.lblTax_1.TabIndex = 29;
            this.lblTax_1.Text = "$0.00";
            this.lblTax_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalDue_1
            // 
            this.lblTotalDue_1.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblTotalDue_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalDue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalDue_1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalDue_1.Location = new System.Drawing.Point(183, 87);
            this.lblTotalDue_1.Name = "lblTotalDue_1";
            this.lblTotalDue_1.Size = new System.Drawing.Size(97, 20);
            this.lblTotalDue_1.TabIndex = 28;
            this.lblTotalDue_1.Text = "$0.00";
            this.lblTotalDue_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblShipping_1
            // 
            this.lblShipping_1.Location = new System.Drawing.Point(206, 66);
            this.lblShipping_1.Name = "lblShipping_1";
            this.lblShipping_1.Size = new System.Drawing.Size(74, 16);
            this.lblShipping_1.TabIndex = 27;
            this.lblShipping_1.Text = "$0.00";
            this.lblShipping_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblTotalDue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalDue.Location = new System.Drawing.Point(22, 84);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(275, 23);
            this.lblTotalDue.TabIndex = 23;
            this.lblTotalDue.Text = "Total Due: ";
            this.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(22, 66);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(113, 13);
            this.lblShipping.TabIndex = 22;
            this.lblShipping.Text = "Shipping / Freight:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(22, 43);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(32, 13);
            this.lblTax.TabIndex = 21;
            this.lblTax.Text = "Tax:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(22, 21);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(58, 13);
            this.lblSubtotal.TabIndex = 20;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.Location = new System.Drawing.Point(958, 575);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(117, 32);
            this.btnProcessPayment.TabIndex = 19;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = true;
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1081, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(968, 518);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(90, 13);
            this.lblPaymentMethod.TabIndex = 21;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // cboPymtMethod
            // 
            this.cboPymtMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPymtMethod.FormattingEnabled = true;
            this.cboPymtMethod.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Credit Card"});
            this.cboPymtMethod.Location = new System.Drawing.Point(1058, 515);
            this.cboPymtMethod.Name = "cboPymtMethod";
            this.cboPymtMethod.Size = new System.Drawing.Size(100, 21);
            this.cboPymtMethod.TabIndex = 22;
            this.cboPymtMethod.SelectedIndexChanged += new System.EventHandler(this.cboPymtMethod_SelectedIndexChanged);
            // 
            // lblApprovalCode
            // 
            this.lblApprovalCode.AutoSize = true;
            this.lblApprovalCode.Location = new System.Drawing.Point(978, 541);
            this.lblApprovalCode.Name = "lblApprovalCode";
            this.lblApprovalCode.Size = new System.Drawing.Size(80, 13);
            this.lblApprovalCode.TabIndex = 23;
            this.lblApprovalCode.Text = "Approval Code:";
            this.lblApprovalCode.Visible = false;
            // 
            // txtCCApprovalCode
            // 
            this.txtCCApprovalCode.Location = new System.Drawing.Point(1058, 539);
            this.txtCCApprovalCode.Name = "txtCCApprovalCode";
            this.txtCCApprovalCode.Size = new System.Drawing.Size(100, 20);
            this.txtCCApprovalCode.TabIndex = 24;
            this.txtCCApprovalCode.Visible = false;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 622);
            this.Controls.Add(this.txtCCApprovalCode);
            this.Controls.Add(this.lblApprovalCode);
            this.Controls.Add(this.cboPymtMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.btnProcessPayment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpOrderTotals);
            this.Controls.Add(this.grpComments);
            this.Controls.Add(this.grpOrderItems);
            this.Controls.Add(this.grpProductSearch);
            this.Controls.Add(this.grpAddToOrder);
            this.Controls.Add(this.grpOrderInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bike Store | New Order";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.grpProductSearch.ResumeLayout(false);
            this.grpProductSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpAddToOrder.ResumeLayout(false);
            this.grpAddToOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemQuantity)).EndInit();
            this.grpOrderItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.grpComments.ResumeLayout(false);
            this.grpComments.PerformLayout();
            this.grpOrderTotals.ResumeLayout(false);
            this.grpOrderTotals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.Label lblOrderNumber_1;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpShipDate;
        private System.Windows.Forms.Label lblShipDate;
        private System.Windows.Forms.ComboBox cboShipAddress;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.ComboBox cboBillAddress;
        private System.Windows.Forms.Label lblBillToAddress;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox grpProductSearch;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox grpAddToOrder;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice_1;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.NumericUpDown nudItemQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.GroupBox grpOrderItems;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.GroupBox grpOrderTotals;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cboPymtMethod;
        private System.Windows.Forms.Label lblApprovalCode;
        private System.Windows.Forms.TextBox txtCCApprovalCode;
        private System.Windows.Forms.CheckBox chkOnlineOrder;
        private System.Windows.Forms.Label lblTotalDue_1;
        private System.Windows.Forms.Label lblShipping_1;
        private System.Windows.Forms.Label lblSubtotal_1;
        private System.Windows.Forms.Label lblTax_1;
        private System.Windows.Forms.ComboBox cboShippingMethod;
        private System.Windows.Forms.Label lblShipMethod;
    }
}