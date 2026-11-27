using BikeStore.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class frmOrderManagement : Form
    {
        private bool isLoadingOrders;
        private bool isInitializing = true;

        public frmOrderManagement()
        {
            InitializeComponent();
            Shown += frmOrderManagement_Shown;
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            pnlReceipt.Visible = false;
            ConfigureOrdersGrid();
            ConfigureReceiptGrid();
            LoadOrders();
        }

        private void frmOrderManagement_Shown(object sender, EventArgs e)
        {
            dgvOrders.ClearSelection();
            dgvOrders.CurrentCell = null;
            ClearReceipt();
            UpdateOrderStatusBar();
            isInitializing = false;
        }

        private void ConfigureOrdersGrid()
        {
            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.MultiSelect = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.AutoGenerateColumns = true;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ScrollBars = ScrollBars.Both;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrders.GridColor = Color.FromArgb(220, 224, 230);
            dgvOrders.RowTemplate.Height = 28;
            dgvOrders.RowsDefaultCellStyle.BackColor = Color.White;
            dgvOrders.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 237, 243);
            dgvOrders.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvOrders.DefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvOrders.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);
            dgvOrders.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrders.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
            dgvOrders.ColumnHeadersVisible = true;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrders.ColumnHeadersHeight = 28;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(201, 207, 216);
            dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvOrders.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrders.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(201, 207, 216);
            dgvOrders.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);
            dgvOrders.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void LoadOrders()
        {
            try
            {
                BindOrders(Order.GetOrders());
            }
            catch (Exception ex)
            {
                BindOrders(new List<Order>());
                MessageBox.Show("Unable to load orders: " + ex.Message,
                    "Order Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureOrderColumns()
        {
            if (dgvOrders.Columns.Count == 0) return;

            string[] visibleColumns = {
                "SalesOrderNumber", "CustomerName", "OrderDate", "DueDate",
                "ShipDate", "Status", "TotalDue"
            };
            foreach (DataGridViewColumn column in dgvOrders.Columns)
                column.Visible = visibleColumns.Contains(column.Name);

            var number = dgvOrders.Columns["SalesOrderNumber"];
            var customer = dgvOrders.Columns["CustomerName"];
            var orderDate = dgvOrders.Columns["OrderDate"];
            var dueDate = dgvOrders.Columns["DueDate"];
            var shipDate = dgvOrders.Columns["ShipDate"];
            var status = dgvOrders.Columns["Status"];
            var total = dgvOrders.Columns["TotalDue"];

            number.HeaderText = "Order Number";
            number.FillWeight = 15;
            customer.HeaderText = "Customer Name";
            customer.FillWeight = 25;
            customer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            orderDate.HeaderText = "Order Date";
            orderDate.FillWeight = 13;
            dueDate.HeaderText = "Due Date";
            dueDate.FillWeight = 13;
            shipDate.HeaderText = "Ship Date";
            shipDate.FillWeight = 13;
            status.HeaderText = "Status";
            status.FillWeight = 13;
            total.HeaderText = "Total Due";
            total.FillWeight = 15;
            total.DefaultCellStyle.Format = "C2";
            total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (var column in new[] { orderDate, dueDate, shipDate })
                column.DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void UpdateOrderStatusBar()
        {
            tsslTotalOrders.Text = "Total Orders: " + dgvOrders.Rows.Count;
            tsslOrderStatus.Text = dgvOrders.SelectedRows.Count > 0
                ? "Order Status: " + Convert.ToString(dgvOrders.SelectedRows[0].Cells["Status"].Value)
                : "Order Status: None Selected";
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoadingOrders || isInitializing) return;
            UpdateOrderStatusBar();
            if (dgvOrders.SelectedRows.Count == 0)
            {
                ClearReceipt();
                return;
            }

            object id = dgvOrders.SelectedRows[0].Cells["SalesOrderID"].Value;
            if (id == null || id == DBNull.Value)
            {
                ClearReceipt();
                return;
            }
            LoadReceipt(Convert.ToInt32(id));
        }

        private void ClearReceipt()
        {
            pnlReceipt.Visible = false;
            lblRcptOrder_1.Text = "";
            lblRcptOrderDate_1.Text = "";
            lblRcptShipDate_1.Text = "";
            lblRcptStatus_1.Text = "";
            lblRcptCustomerName_1.Text = "";
            chkRcptOnlineOrder.Checked = false;
            txtRcptBAddress.Clear();
            txtRcptSAddress.Clear();
            dgvRcptItems.DataSource = null;
            lblRcptSubtotal_1.Text = "$0.00";
            lblRcptTax_1.Text = "$0.00";
            lblRcptShipping_1.Text = "$0.00";
            lblRcptTotalDue_1.Text = "$0.00";
            lblCCApprovalCode_1.Text = "";

        }

        private void LoadReceipt(int salesOrderId)
        {
            try
            {
                using (var db = new BikeStoreEntities())
                {
                    var order = db.SalesOrderHeaders.AsNoTracking()
                        .FirstOrDefault(o => o.SalesOrderID == salesOrderId);
                    if (order == null)
                    {
                        ClearReceipt();
                        return;
                    }

                    var customer = db.Customers.AsNoTracking()
                        .FirstOrDefault(c => c.CustomerID == order.CustomerID);
                    var billing = db.Addresses.AsNoTracking()
                        .FirstOrDefault(a => a.AddressID == order.BillToAddressID);
                    var shipping = db.Addresses.AsNoTracking()
                        .FirstOrDefault(a => a.AddressID == order.ShipToAddressID);

                    var items = (
                        from detail in db.SalesOrderDetails.AsNoTracking()
                        join product in db.Products.AsNoTracking()
                            on detail.ProductID equals product.ProductID
                        where detail.SalesOrderID == salesOrderId
                        orderby detail.SalesOrderDetailID
                        select new
                        {
                            Product = product.Name,
                            Qty = detail.OrderQty,
                            UnitPrice = detail.UnitPrice,
                            Amount = detail.LineTotal
                        }).ToList();

                    lblRcptOrder_1.Text = order.SalesOrderNumber;
                    lblRcptOrderDate_1.Text = order.OrderDate.ToString("MM/dd/yyyy");
                    lblRcptShipDate_1.Text = order.ShipDate.HasValue ? order.ShipDate.Value.ToString("MM/dd/yyyy") : "Not Shipped";

                    lblRcptStatus_1.Text = dgvOrders.SelectedRows.Count > 0 ? Convert.ToString(dgvOrders.SelectedRows[0].Cells["Status"].Value) : "";
                    chkRcptOnlineOrder.Checked = order.OnlineOrderFlag;
                    chkRcptOnlineOrder.Enabled = false;
                    lblRcptCustomerName_1.Text = customer == null ? "" : string.Join(" ",
                        new[] { customer.FirstName, customer.MiddleName, customer.LastName }
                            .Where(n => !string.IsNullOrWhiteSpace(n)));
                    txtRcptBAddress.Text = FormatReceiptAddress(billing);
                    txtRcptSAddress.Text = FormatReceiptAddress(shipping);

                    dgvRcptItems.DataSource = null;
                    dgvRcptItems.DataSource = items;
                    ConfigureReceiptColumns();
                    dgvRcptItems.ClearSelection();
                    dgvRcptItems.CurrentCell = null;

                    lblRcptSubtotal_1.Text = order.SubTotal.ToString("C2");
                    lblRcptTax_1.Text = order.TaxAmt.ToString("C2");
                    lblRcptShipping_1.Text = order.Freight.ToString("C2");
                    lblRcptTotalDue_1.Text = order.TotalDue.ToString("C2");
                    lblCCApprovalCode_1.Text = string.IsNullOrWhiteSpace(order.CreditCardApprovalCode) ? "N/A" : order.CreditCardApprovalCode;
                    pnlReceipt.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ClearReceipt();
                MessageBox.Show("Unable to load receipt: " + ex.Message, "Receipt Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string FormatReceiptAddress(Address address)
        {
            if (address == null) return "Address not available";
            string street = address.AddressLine1 ?? "";
            if (!string.IsNullOrWhiteSpace(address.AddressLine2))
                street += Environment.NewLine + address.AddressLine2;
            return street + Environment.NewLine + address.City + ", " + address.StateProvince + " " + address.PostalCode + Environment.NewLine + address.CountryRegion;
        }

        private void ConfigureReceiptGrid()
        {
            dgvRcptItems.ReadOnly = true;
            dgvRcptItems.AllowUserToAddRows = false;
            dgvRcptItems.AllowUserToDeleteRows = false;
            dgvRcptItems.AllowUserToResizeRows = false;
            dgvRcptItems.AllowUserToResizeColumns = false;
            dgvRcptItems.AllowUserToOrderColumns = false;
            dgvRcptItems.RowHeadersVisible = false;
            dgvRcptItems.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRcptItems.MultiSelect = false;
            dgvRcptItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRcptItems.AutoGenerateColumns = true;
            dgvRcptItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRcptItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRcptItems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvRcptItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRcptItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRcptItems.GridColor = Color.FromArgb(230, 230, 230);
            dgvRcptItems.BackgroundColor = Color.White;
            dgvRcptItems.BorderStyle = BorderStyle.None;
            dgvRcptItems.DefaultCellStyle.Font = new Font("Segoe UI", 7.5f);
            dgvRcptItems.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgvRcptItems.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRcptItems.DefaultCellStyle.SelectionBackColor = dgvRcptItems.DefaultCellStyle.BackColor;
            dgvRcptItems.DefaultCellStyle.SelectionForeColor = dgvRcptItems.DefaultCellStyle.ForeColor;
            dgvRcptItems.EnableHeadersVisualStyles = false;
            dgvRcptItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRcptItems.ColumnHeadersHeight = 22;
            dgvRcptItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 238, 242);
            dgvRcptItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgvRcptItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 7.5f, FontStyle.Bold);
            dgvRcptItems.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRcptItems.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvRcptItems.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvRcptItems.ColumnHeadersDefaultCellStyle.BackColor;
            dgvRcptItems.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvRcptItems.ColumnHeadersDefaultCellStyle.ForeColor;
        }

        private void ConfigureReceiptColumns()
        {
            if (dgvRcptItems.Columns.Count == 0) return;
            var product = dgvRcptItems.Columns["Product"];
            var qty = dgvRcptItems.Columns["Qty"];
            var price = dgvRcptItems.Columns["UnitPrice"];
            var amount = dgvRcptItems.Columns["Amount"];

            foreach (DataGridViewColumn column in dgvRcptItems.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            product.HeaderText = "Product";
            product.FillWeight = 45;
            product.MinimumWidth = 85;
            product.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            product.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            qty.HeaderText = "Qty";
            qty.FillWeight = 10;
            qty.MinimumWidth = 30;
            qty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            price.HeaderText = "Price";
            price.FillWeight = 22;
            price.MinimumWidth = 65;
            price.DefaultCellStyle.Format = "C2";
            price.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            amount.HeaderText = "Amount";
            amount.FillWeight = 23;
            amount.MinimumWidth = 70;
            amount.DefaultCellStyle.Format = "C2";
            amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvRcptItems_SelectionChanged(object sender, EventArgs e)
        {
            dgvRcptItems.ClearSelection();
        }

        private void tsbRefreshOrders_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            txtOrderNumber.Clear();
            txtCustomer.Clear();
            cboOrderStatus.SelectedIndex = -1;

            dtpDateFrom.Checked = false;
            dtpDateTo.Checked = false;

            ClearReceipt();
        }
        private bool ValidateSearchDates()
        {
            if (dtpDateFrom.Checked != dtpDateTo.Checked)
            {
                MessageBox.Show("Please select both Date From and Date To to search by date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpDateFrom.Checked &&
                dtpDateFrom.Value.Date > dtpDateTo.Value.Date)
            {
                MessageBox.Show("The Date From cannot be later than the Date To. Please enter a valid date range.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void tsbSearchOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateSearchDates())
                return;

            SearchOrders();
        }

        private void SearchOrders()
        {
            try
            {
                string orderNumber = txtOrderNumber.Text.Trim();
                string customerName = txtCustomer.Text.Trim();

                byte? status = null;

                if (cboOrderStatus.SelectedIndex >= 0 && cboOrderStatus.SelectedValue != null)
                {
                    status = Convert.ToByte(cboOrderStatus.SelectedValue);
                }

                DateTime? dateFrom = dtpDateFrom.Checked  ? dtpDateFrom.Value.Date : (DateTime?)null;
                DateTime? dateTo = dtpDateTo.Checked      ? dtpDateTo.Value.Date   : (DateTime?)null;

                var orders = Order.SearchOrders(orderNumber, customerName, status, dateFrom, dateTo);

                BindOrders(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search orders: " + ex.Message, "Search Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindOrders(List<Order> orders)
        {
            isLoadingOrders = true;
            try
            {
                dgvOrders.DataSource = null;
                dgvOrders.DataSource = orders;
                ConfigureOrderColumns();
                dgvOrders.ClearSelection();
                dgvOrders.CurrentCell = null;
                ClearReceipt();
            }
            finally
            {
                isLoadingOrders = false;
                UpdateOrderStatusBar();
            }
        }

        private void tsbUpdateShipping_ButtonClick(object sender, EventArgs e)
        {

        }


        private void ChangeSelectedOrderStatus(byte newStatus)
        {
            int? orderId = GetSelectedOrderId();

            if (!orderId.HasValue)
                return;

            string statusName = Order.GetStatusDescription(newStatus);

            DialogResult result = MessageBox.Show($"Change the selected order status to {statusName}?", "Confirm Status Change", MessageBoxButtons.YesNo,  MessageBoxIcon.Question,   MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                Order.UpdateOrderStatus(orderId.Value, newStatus);

                LoadOrders();

                MessageBox.Show($"Order status successfully changed to {statusName}.",  "Order Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update order status: " + ex.Message,
                    "Order Management",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private int? GetSelectedOrderId()
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.", "Order Management", MessageBoxButtons.OK,  MessageBoxIcon.Warning);

                return null;
            }

            return Convert.ToInt32(
                dgvOrders.SelectedRows[0].Cells["SalesOrderID"].Value);
        }

        private void tsbDeleteOrder_Click(object sender, EventArgs e)
        {
            int? salesOrderId = GetSelectedOrderId();

            if (!salesOrderId.HasValue)
                return;

            string orderNumber = Convert.ToString(dgvOrders.SelectedRows[0].Cells["SalesOrderNumber"].Value);

            DialogResult result = MessageBox.Show($"Are you sure you want to permanently delete order {orderNumber}?\n\n" + "This action cannot be undone.",  "Confirm Delete Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                Order.DeleteOrder(salesOrderId.Value);

                LoadOrders();

                MessageBox.Show($"Order {orderNumber} was deleted successfully.",  "Order Management",   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete order: " + ex.Message, "Order Management",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbNewOrder_Click(object sender, EventArgs e)
        {
            using (var form = new frmOrderDetails())
            {
                this.Hide();

                try
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadOrders();

                        if (form.SavedOrderId.HasValue)
                            SelectOrder(form.SavedOrderId.Value);
                    }
                }
                finally
                {
                    this.Show();
                    this.Activate();
                }
            }
        }



        private void inProcessToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeSelectedOrderStatus(1);
        }

        private void approvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSelectedOrderStatus(2);
        }

        private void backorderedToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeSelectedOrderStatus(3);
        }

        private void rejectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSelectedOrderStatus(4);
        }

        private void shippedToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeSelectedOrderStatus(5);
        }

        private void cancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSelectedOrderStatus(6);
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tsbEditOrder_Click(object sender, EventArgs e)
        {
            int? orderId = GetSelectedOrderId();

            if (!orderId.HasValue)
            {
                MessageBox.Show("Please select an order to edit.", "Edit Order",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var form = new frmOrderDetails(orderId.Value))
            {
                this.Hide();

                try
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadOrders();
                        SelectOrder(form.SavedOrderId ?? orderId.Value);
                    }
                }
                finally
                {
                    this.Show();
                    this.Activate();
                }
            }
        }


        private void SelectOrder(int orderId)
        {
            dgvOrders.ClearSelection();

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells["SalesOrderID"].Value == null)
                    continue;

                int currentOrderId = Convert.ToInt32(row.Cells["SalesOrderID"].Value);

                if (currentOrderId == orderId)
                {
                    row.Selected = true;
                    dgvOrders.FirstDisplayedScrollingRowIndex = row.Index;

                    var visibleCell = row.Cells.Cast<DataGridViewCell>().FirstOrDefault(c => c.Visible);

                    if (visibleCell != null)
                        dgvOrders.CurrentCell = visibleCell;

                    return;
                }
            }
        }

    }
}