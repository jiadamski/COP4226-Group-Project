using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BikeStore.Classes;

namespace BikeStore
{
    public partial class frmOrderDetails : Form
    {
        private const decimal SALES_TAX_RATE = 0.08m;
        private const decimal SHIPPING_RATE = 0.025m;
        private readonly int? salesOrderId;
        private int? selectedProductId = null;
        private readonly BindingList<OrderItem> basket = new BindingList<OrderItem>();

        public int? SavedOrderId { get; private set; }

        private class OrderItem
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }

            public decimal LineTotal
            {
                get { return Quantity * UnitPrice; }
            }
        }


        public frmOrderDetails()
        {
            InitializeComponent();
        }

        public frmOrderDetails(int orderId) : this()
        {
            salesOrderId = orderId;
        }

        private void cboPymtMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCreditCard = cboPymtMethod.Text.Trim().Equals("Credit Card", StringComparison.OrdinalIgnoreCase);

            lblApprovalCode.Visible = isCreditCard;
            txtCCApprovalCode.Visible = isCreditCard;

            if (!isCreditCard)
                txtCCApprovalCode.Clear();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCustomers();
                ConfigureOrderItemsGrid();

                ApplyGridStyle(dgvProducts);

                lblTax.Text = $"Sales Tax ({SALES_TAX_RATE:P2})";

                if (!salesOrderId.HasValue)
                {
                    lblOrderNumber_1.Text = "Automatic";

                    dtpOrderDate.Value = DateTime.Today;
                    dtpDueDate.Value = DateTime.Today;
                    dtpShipDate.Value = DateTime.Today;
                    dtpShipDate.Checked = false;

                    cboStatus.SelectedIndex = 0;
                }
                else
                {
                    LoadOrder(salesOrderId.Value);
                    cboPymtMethod.SelectedIndex = -1;
                    this.Text = "Bike Store | Edit Order";
                    btnProcessPayment.Text = "Update Order";
                }

                nudItemQuantity.Minimum = 1;
                nudItemQuantity.Maximum = 32767;
                nudItemQuantity.Value = 1;

                nudItemQuantity.Visible = false;
                lblUnitPrice_1.Visible = false;
                btnAddToOrder.Enabled = false;

                cboPymtMethod_SelectedIndexChanged(cboPymtMethod, EventArgs.Empty);

                CalculateOrderTotals();
                UpdateCartButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to initialize order form: " + ex.Message, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomers()
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                var customers = db.Customers
                    .AsNoTracking()
                    .OrderBy(c => c.LastName)
                    .ThenBy(c => c.FirstName)
                    .ToList()
                    .GroupBy(c => c.CustomerID)
                    .Select(g => g.First())
                    .Select(c => new
                    {
                        c.CustomerID,
                        CustomerName = string.Join(" ",
                            new[]
                            {
                        c.FirstName,
                        c.MiddleName,
                        c.LastName
                            }.Where(n => !string.IsNullOrWhiteSpace(n)))
                    })
                    .ToList();

                cboCustomer.DataSource = null;
                cboCustomer.Items.Clear();

                cboCustomer.DisplayMember = "CustomerName";
                cboCustomer.ValueMember = "CustomerID";
                cboCustomer.DataSource = customers;

                cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
                cboCustomer.SelectedIndex = -1;
            }
        }


        private void LoadCustomerAddresses(int customerId)
        {
            using (var db = new BikeStoreEntities())
            {
                var addresses = (
                    from ca in db.CustomerAddresses
                    join a in db.Addresses
                        on ca.AddressID equals a.AddressID
                    where ca.CustomerID == customerId
                    orderby a.AddressLine1
                    select new
                    {
                        a.AddressID,
                        a.AddressLine1,
                        a.AddressLine2,
                        a.City,
                        a.StateProvince,
                        a.PostalCode
                    })
                    .ToList()
                    .Select(a => new
                    {
                        a.AddressID,
                        FullAddress = string.Join(", ",
                            new[]
                            {
                        a.AddressLine1,
                        a.AddressLine2,
                        a.City,
                        a.StateProvince,
                        a.PostalCode
                            }.Where(s => !string.IsNullOrWhiteSpace(s)))
                    })
                    .ToList();

                cboBillAddress.DisplayMember = "FullAddress";
                cboBillAddress.ValueMember = "AddressID";
                cboBillAddress.DataSource = addresses;
                cboBillAddress.DropDownStyle = ComboBoxStyle.DropDownList;
                cboBillAddress.SelectedIndex = -1;

                cboShipAddress.DisplayMember = "FullAddress";
                cboShipAddress.ValueMember = "AddressID";
                cboShipAddress.DataSource = addresses.ToList();
                cboShipAddress.DropDownStyle = ComboBoxStyle.DropDownList;
                cboShipAddress.SelectedIndex = -1;
            }
        }


        private void LoadOrder(int orderId)
        {
            using (var db = new BikeStoreEntities())
            {
                var order = db.SalesOrderHeaders
                    .AsNoTracking()
                    .FirstOrDefault(o => o.SalesOrderID == orderId);

                if (order == null)
                    throw new InvalidOperationException(
                        "The selected order could not be found.");

                var details = db.SalesOrderDetails
                    .AsNoTracking()
                    .Where(d => d.SalesOrderID == orderId)
                    .Select(d => new
                    {
                        d.ProductID,
                        ProductName = d.Product.Name,
                        d.OrderQty,
                        d.UnitPrice
                    })
                    .ToList();

                lblOrderNumber_1.Text = order.SalesOrderNumber;

                dtpOrderDate.Value = order.OrderDate;
                dtpDueDate.Value = order.DueDate;

                dtpShipDate.Checked = order.ShipDate.HasValue;

                if (order.ShipDate.HasValue)
                    dtpShipDate.Value = order.ShipDate.Value;

                chkOnlineOrder.Checked = order.OnlineOrderFlag;

                cboStatus.SelectedIndex = order.Status - 1;

                cboCustomer.SelectedValue = order.CustomerID;


                LoadCustomerAddresses(order.CustomerID);

                cboBillAddress.SelectedValue =
                    order.BillToAddressID;

                cboShipAddress.SelectedValue =
                    order.ShipToAddressID;


                if (!string.IsNullOrWhiteSpace(order.ShipMethod) &&
                    !cboShippingMethod.Items.Contains(order.ShipMethod))
                {
                    cboShippingMethod.Items.Add(order.ShipMethod);
                }

                cboShippingMethod.SelectedItem = order.ShipMethod;
                txtComment.Text = order.Comment ?? "";
                txtCCApprovalCode.Text = order.CreditCardApprovalCode == "N/A" ? "" : order.CreditCardApprovalCode ?? "";

                basket.Clear();

                foreach (var detail in details)
                {
                    basket.Add(new OrderItem
                    {
                        ProductID = detail.ProductID,
                        ProductName = detail.ProductName,
                        Quantity = detail.OrderQty,
                        UnitPrice = detail.UnitPrice
                    });
                }

                CalculateOrderTotals();

                dgvOrderItems.ClearSelection();
                dgvOrderItems.CurrentCell = null;

                UpdateCartButtons();
            }
        }


        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedValue is int customerId)
            {
                LoadCustomerAddresses(customerId);
            }
            else
            {
                cboBillAddress.DataSource = null;
                cboShipAddress.DataSource = null;
            }
        }


        private void SearchProducts()
        {
            try
            {
                string searchText = txtProductName.Text.Trim();

                using (var db = new BikeStoreEntities())
                {
                    var products = db.Products
                        .AsNoTracking()
                        .Where(p => p.Name.Contains(searchText))
                        .OrderBy(p => p.Name)
                        .Select(p => new
                        {
                            p.ProductID,
                            ProductName = p.Name,
                            UnitPrice = p.ListPrice
                        })
                        .ToList();

                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = products;
                }

                ConfigureProductsGrid();
                dgvProducts.ClearSelection();
                dgvProducts.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search products: " + ex.Message, "Product Search",  MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }


        private void ApplyGridStyle(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;

            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid.RowHeadersVisible = false;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;

            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            grid.GridColor = Color.FromArgb(220, 224, 230);
            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 248);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            grid.DefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);
            grid.RowTemplate.Height = 28;

            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 28;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(201, 207, 216);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            grid.ColumnHeadersDefaultCellStyle.Font =  new Font("Segoe UI", 9, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(201, 207, 216);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);
        }



        private void ConfigureProductsGrid()
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ApplyGridStyle(dgvProducts);
            dgvProducts.ColumnHeadersHeight = 35;

            if (dgvProducts.Columns.Contains("ProductID"))
            {
                dgvProducts.Columns["ProductID"].HeaderText = "Product ID";
                dgvProducts.Columns["ProductID"].FillWeight = 20;
            }

            if (dgvProducts.Columns.Contains("ProductName"))
            {
                dgvProducts.Columns["ProductName"].HeaderText = "Product Name";
                dgvProducts.Columns["ProductName"].FillWeight = 65;
            }

            if (dgvProducts.Columns.Contains("UnitPrice"))
            {
                var column = dgvProducts.Columns["UnitPrice"];
                column.HeaderText = "Unit Price";
                column.FillWeight = 25;
                column.DefaultCellStyle.Format = "C2";
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            bool productSelected = dgvProducts.SelectedRows.Count > 0;

            nudItemQuantity.Visible = productSelected;
            lblUnitPrice_1.Visible = productSelected;
            btnAddToOrder.Enabled = productSelected;

            if (!productSelected)
            {
                selectedProductId = null;
                lblUnitPrice_1.Text = "";
                return;
            }

            DataGridViewRow row = dgvProducts.SelectedRows[0];

            if (row.Cells["ProductID"].Value == null ||  row.Cells["UnitPrice"].Value == null)
                return;

            int productId = Convert.ToInt32( row.Cells["ProductID"].Value);

            if (selectedProductId != productId)
            {
                selectedProductId = productId;
                nudItemQuantity.Value = 1;
            }

            decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);

            lblUnitPrice_1.Text = (unitPrice * nudItemQuantity.Value).ToString("C2");
        }


        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchProducts();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void nudItemQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                lblUnitPrice_1.Text = "";
                return;
            }

            decimal unitPrice = Convert.ToDecimal(dgvProducts.SelectedRows[0].Cells["UnitPrice"].Value);

            decimal lineTotal = unitPrice * nudItemQuantity.Value;

            lblUnitPrice_1.Text = lineTotal.ToString("C2");
        }


        private void ConfigureOrderItemsGrid()
        {
            dgvOrderItems.AutoGenerateColumns = true;
            dgvOrderItems.DataSource = basket;

            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ApplyGridStyle(dgvOrderItems);

            dgvOrderItems.ColumnHeadersHeight = 35;

            if (dgvOrderItems.Columns.Contains("ProductID"))
                dgvOrderItems.Columns["ProductID"].Visible = false;

            if (dgvOrderItems.Columns.Contains("ProductName"))
            {
                dgvOrderItems.Columns["ProductName"].HeaderText = "Product Name";
                dgvOrderItems.Columns["ProductName"].FillWeight = 55;
            }

            if (dgvOrderItems.Columns.Contains("Quantity"))
            {
                dgvOrderItems.Columns["Quantity"].HeaderText = "Qty";
                dgvOrderItems.Columns["Quantity"].FillWeight = 15;
            }

            if (dgvOrderItems.Columns.Contains("UnitPrice"))
            {
                var column = dgvOrderItems.Columns["UnitPrice"];

                column.HeaderText = "Unit Price";
                column.FillWeight = 20;
                column.DefaultCellStyle.Format = "C2";
            }

            if (dgvOrderItems.Columns.Contains("LineTotal"))
            {
                var column = dgvOrderItems.Columns["LineTotal"];

                column.HeaderText = "Line Total";
                column.FillWeight = 20;
                column.DefaultCellStyle.Format = "C2";
            }

            dgvOrderItems.ClearSelection();
            dgvOrderItems.CurrentCell = null;
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
                return;

            DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

            int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

            string productName = Convert.ToString(selectedRow.Cells["ProductName"].Value);

            decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value);

            int quantity = Convert.ToInt32(nudItemQuantity.Value);

            OrderItem existingItem = basket.FirstOrDefault(item => item.ProductID == productId);

            if (existingItem != null)
            {
                if (existingItem.Quantity + quantity > 1000)
                {
                    MessageBox.Show("The maximum quantity per product is 1000.", "Quantity Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                existingItem.Quantity += quantity;

                basket.ResetBindings();
            }
            else
            {
                basket.Add(new OrderItem
                {
                    ProductID = productId,
                    ProductName = productName,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                });
            }

            CalculateOrderTotals();

            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;

            nudItemQuantity.Value = 1;

            btnAddToOrder.Enabled = false;

            dgvOrderItems.ClearSelection();
            dgvOrderItems.CurrentCell = null;

            UpdateCartButtons();
        }

        private (decimal Subtotal, decimal Tax, decimal Shipping) GetOrderTotals()
        {
            decimal subtotal = basket.Sum(item => item.LineTotal);

            decimal tax = Math.Round(subtotal * SALES_TAX_RATE, 2, MidpointRounding.AwayFromZero);

            decimal freight = Math.Round(subtotal * SHIPPING_RATE, 2, MidpointRounding.AwayFromZero);

            return (subtotal, tax, freight);
        }


        private void CalculateOrderTotals()
        {
            var totals = GetOrderTotals();

            lblSubtotal_1.Text = totals.Subtotal.ToString("C2");
            lblTax_1.Text = totals.Tax.ToString("C2");
            lblShipping_1.Text = totals.Shipping.ToString("C2");

            lblTotalDue_1.Text = (totals.Subtotal + totals.Tax + totals.Shipping).ToString("C2");
        }

        private OrderItem GetSelectedCartItem()
        {
            if (dgvOrderItems.SelectedRows.Count == 0)
                return null;

            return dgvOrderItems.SelectedRows[0].DataBoundItem as OrderItem;
        }



        private void UpdateCartButtons()
        {
            bool itemSelected = GetSelectedCartItem() != null;

            btnEditItem.Enabled = itemSelected;
            btnRemoveItem.Enabled = itemSelected;
            btnClearItems.Enabled = basket.Count > 0;
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            OrderItem item = GetSelectedCartItem();

            if (item == null)
                return;

            using (Form editForm = new Form())
            {
                editForm.Text = "Edit Item Quantity";
                editForm.StartPosition = FormStartPosition.CenterParent;
                editForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                editForm.ClientSize = new Size(300, 135);
                editForm.MaximizeBox = false;
                editForm.MinimizeBox = false;

                Label lblQuantity = new Label
                {
                    Text = "Quantity:",
                    Location = new Point(20, 25),
                    AutoSize = true
                };

                NumericUpDown nudQuantity = new NumericUpDown
                {
                    Location = new Point(110, 22),
                    Width = 150,
                    Minimum = 1,
                    Maximum = 1000,
                    Value = item.Quantity
                };

                Button btnSave = new Button
                {
                    Text = "Save",
                    Location = new Point(110, 75),
                    DialogResult = DialogResult.OK
                };

                Button btnCancel = new Button
                {
                    Text = "Cancel",
                    Location = new Point(195, 75),
                    DialogResult = DialogResult.Cancel
                };

                editForm.Controls.Add(lblQuantity);
                editForm.Controls.Add(nudQuantity);
                editForm.Controls.Add(btnSave);
                editForm.Controls.Add(btnCancel);

                editForm.AcceptButton = btnSave;
                editForm.CancelButton = btnCancel;

                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    item.Quantity = (int)nudQuantity.Value;

                    basket.ResetBindings();
                    CalculateOrderTotals();
                }
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            OrderItem item = GetSelectedCartItem();

            if (item == null)
                return;

            DialogResult result = MessageBox.Show($"Remove {item.ProductName} from the order?", "Confirm Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question,  MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            basket.Remove(item);

            CalculateOrderTotals();

            dgvOrderItems.ClearSelection();
            dgvOrderItems.CurrentCell = null;

            UpdateCartButtons();
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            if (basket.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Are you sure you want to remove all items from this order?", "Confirm Clear Items", MessageBoxButtons.YesNo,  MessageBoxIcon.Warning,  MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            basket.Clear();

            CalculateOrderTotals();
            UpdateCartButtons();
        }

        private void dgvOrderItems_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCartButtons();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you sure you want to cancel? This order will be lost.", "Cancel Order", MessageBoxButtons.YesNo,  MessageBoxIcon.Question,  MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }


        private bool ValidateOrder()
        {
            if (!salesOrderId.HasValue && cboCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a customer.", "Missing Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cboCustomer.Focus();
                return false;
            }

            if (cboBillAddress.SelectedIndex < 0 || cboShipAddress.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both billing and shipping addresses.", "Missing Address",  MessageBoxButtons.OK,  MessageBoxIcon.Warning);
                return false;
            }

            if (basket.Count == 0)
            {
                MessageBox.Show( "Please add at least one product to the order.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an order status.",  "Missing Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpDueDate.Value.Date < dtpOrderDate.Value.Date)
            {
                MessageBox.Show("The due date cannot be earlier than the order date.", "Invalid Due Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboPymtMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a payment method.", "Missing Payment Method", MessageBoxButtons.OK,  MessageBoxIcon.Warning);

                cboPymtMethod.Focus();
                return false;
            }

            if (cboPymtMethod.Text.Trim().Equals("Credit Card", StringComparison.OrdinalIgnoreCase)  && string.IsNullOrWhiteSpace(txtCCApprovalCode.Text))
            {
                MessageBox.Show("Please enter the credit card approval code.", "Missing Approval Code",  MessageBoxButtons.OK,  MessageBoxIcon.Warning);

                txtCCApprovalCode.Focus();
                return false;
            }

            if (cboShippingMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a shipping method.", "Missing Shipping Method", MessageBoxButtons.OK,  MessageBoxIcon.Warning);

                cboShippingMethod.Focus();
                return false;
            }

            if (dtpShipDate.Checked && dtpShipDate.Value.Date < dtpOrderDate.Value.Date)
            {
                MessageBox.Show("The shipping date cannot be earlier than the order date.", "Invalid Shipping Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpShipDate.Focus();
                return false;
            }

            return true;
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder())
                return;

            bool isEditing = salesOrderId.HasValue;

            string action = isEditing ? "update" : "create";

            DialogResult result = MessageBox.Show($"Are you sure you want to {action} this order?", "Confirm Order",  MessageBoxButtons.YesNo,  MessageBoxIcon.Question,  MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                string orderNumber;

                if (isEditing)
                {
                    UpdateOrder();

                    SavedOrderId = salesOrderId.Value;
                    orderNumber = lblOrderNumber_1.Text;
                }
                else
                {
                    int orderId = SaveOrder();

                    SavedOrderId = orderId;
                    orderNumber = $"SO{orderId}";
                }

                MessageBox.Show($"Order {orderNumber} was " + (isEditing ? "updated" : "created") + " successfully!", "Order Saved", MessageBoxButtons.OK,   MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save the order:\n\n" + ex.GetBaseException().Message, "Save Error",  MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }


        private int SaveOrder()
        {
            if (salesOrderId.HasValue)
                throw new InvalidOperationException("Updating existing orders is not implemented yet.");

           var totals = GetOrderTotals();

            string approvalCode = cboPymtMethod.Text.Trim().Equals("Credit Card", StringComparison.OrdinalIgnoreCase)
                ? txtCCApprovalCode.Text.Trim()
                : "N/A";

            using (var db = new BikeStoreEntities())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var order = new SalesOrderHeader
                    {
                        CustomerID = Convert.ToInt32(
                            cboCustomer.SelectedValue),

                        OrderDate = dtpOrderDate.Value,
                        DueDate = dtpDueDate.Value,

                        ShipDate = dtpShipDate.Checked ? (DateTime?)dtpShipDate.Value : null,

                        OnlineOrderFlag = chkOnlineOrder.Checked,

                        Status = checked((byte)(cboStatus.SelectedIndex + 1)),

                        BillToAddressID = Convert.ToInt32(cboBillAddress.SelectedValue),

                        ShipToAddressID = Convert.ToInt32(cboShipAddress.SelectedValue),

                        ShipMethod = cboShippingMethod.Text.Trim(),

                        CreditCardApprovalCode = approvalCode,

                        SubTotal = totals.Subtotal,
                        TaxAmt = totals.Tax,
                        Freight = totals.Shipping,

                        Comment = txtComment.Text.Trim(),
                        ModifiedDate = DateTime.Now
                    };

                    db.SalesOrderHeaders.Add(order);

                    db.SaveChanges();

                    foreach (var item in basket)
                    {
                        db.SalesOrderDetails.Add(
                            new SalesOrderDetail
                            {
                                SalesOrderID = order.SalesOrderID,
                                ProductID = item.ProductID,
                                OrderQty = checked((short)item.Quantity),
                                UnitPrice = item.UnitPrice,
                                UnitPriceDiscount = 0.00m,
                                rowguid = Guid.NewGuid(),
                                ModifiedDate = DateTime.Now
                            });
                    }

                    db.SaveChanges();

                    transaction.Commit();

                    return order.SalesOrderID;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }


        private void UpdateOrder()
        {
            if (!salesOrderId.HasValue)
                throw new InvalidOperationException("No existing order was selected.");

            var totals = GetOrderTotals();

            using (var db = new BikeStoreEntities())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var order = db.SalesOrderHeaders.FirstOrDefault(o => o.SalesOrderID == salesOrderId.Value);

                    if (order == null)
                        throw new InvalidOperationException(
                            "The selected order no longer exists.");

                    order.CustomerID = Convert.ToInt32(cboCustomer.SelectedValue);

                    order.OrderDate = dtpOrderDate.Value;
                    order.DueDate = dtpDueDate.Value;

                    order.ShipDate = dtpShipDate.Checked  ? (DateTime?)dtpShipDate.Value : null;

                    order.OnlineOrderFlag = chkOnlineOrder.Checked;

                    order.Status = checked((byte)(cboStatus.SelectedIndex + 1));

                    order.BillToAddressID = Convert.ToInt32(cboBillAddress.SelectedValue);

                    order.ShipToAddressID = Convert.ToInt32(cboShipAddress.SelectedValue);

                    order.ShipMethod = cboShippingMethod.Text.Trim();

                    if (cboPymtMethod.SelectedIndex >= 0)
                    {
                        bool isCreditCard = cboPymtMethod.Text.Trim().Equals("Credit Card", StringComparison.OrdinalIgnoreCase);
                        order.CreditCardApprovalCode = isCreditCard  ? txtCCApprovalCode.Text.Trim() : "N/A";
                    }

                    order.SubTotal = totals.Subtotal;
                    order.TaxAmt = totals.Tax;
                    order.Freight = totals.Shipping;

                    order.Comment = txtComment.Text.Trim();
                    order.ModifiedDate = DateTime.Now;

                    var existingDetails = db.SalesOrderDetails.Where(d => d.SalesOrderID == order.SalesOrderID).ToList();

                    db.SalesOrderDetails.RemoveRange(existingDetails);

                    db.SaveChanges();

                    foreach (var item in basket)
                    {
                        db.SalesOrderDetails.Add(new SalesOrderDetail
                        {
                            SalesOrderID = order.SalesOrderID,
                            ProductID = item.ProductID,
                            OrderQty = checked((short)item.Quantity),
                            UnitPrice = item.UnitPrice,
                            UnitPriceDiscount = 0.00m,
                            rowguid = Guid.NewGuid(),
                            ModifiedDate = DateTime.Now
                        });
                    }

                    db.SaveChanges();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }


    }
}