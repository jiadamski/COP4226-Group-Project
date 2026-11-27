using BikeStore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbCustomer = BikeStore.Classes.Customer;

namespace BikeStore
{
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadCustomers();
        }

        private void ConfigureDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.ReadOnly = true;

            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeRows = false;

            dgvCustomers.MultiSelect = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;

            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.GridColor = Color.FromArgb(220, 224, 230);
            dgvCustomers.RowTemplate.Height = 28;
            dgvCustomers.RowsDefaultCellStyle.BackColor =  Color.White;
            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 237, 243);
            dgvCustomers.DefaultCellStyle.Font =  new Font("Segoe UI", 9);
            dgvCustomers.DefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvCustomers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);

            dgvCustomers.ColumnHeadersVisible = true;
            dgvCustomers.EnableHeadersVisualStyles = false;

            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.ColumnHeadersHeight = 35;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(201, 207, 216);
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvCustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(201, 207, 216);
            dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);

            dgvCustomers.RowHeadersVisible = true;
            dgvCustomers.RowHeadersWidth = 85;
            dgvCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCustomers.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.RowHeadersDefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
            dgvCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCustomers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomers.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(201, 207, 216);
            dgvCustomers.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvCustomers.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvCustomers.RowHeadersDefaultCellStyle.Alignment =  DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvCustomers.RowHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);
        }

        private void LoadCustomers()
        {
            try
            {
                List<dbCustomer> customers = dbCustomer.GetCustomers();

                DisplayCustomers(customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load customers: " + ex.Message, "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCustomers(List<dbCustomer> customers)
        {
            dgvCustomers.DataSource = customers
                .Select(c => new
                {
                    c.CustomerId,
                    c.FirstName,
                    c.MiddleName,
                    c.LastName,
                    c.CompanyName,
                    c.EmailAddress,
                    c.Phone,
                    c.SalesPerson
                })
                .ToList();

            ConfigureColumns();

            tslblTotalCustomers.Text = "Total Customers: " + customers.Count;

            dgvCustomers.ClearSelection();
            UpdateToolStripButtons();
        }

        private void ConfigureColumns()
        {
            dgvCustomers.Columns["CustomerId"].Visible = false;
            dgvCustomers.TopLeftHeaderCell.Value = "ID";
            dgvCustomers.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomers.Columns["FirstName"].HeaderText = "First Name";
            dgvCustomers.Columns["MiddleName"].HeaderText = "Middle Name";
            dgvCustomers.Columns["LastName"].HeaderText = "Last Name";
            dgvCustomers.Columns["CompanyName"].HeaderText = "Company";
            dgvCustomers.Columns["EmailAddress"].HeaderText = "Email Address";
            dgvCustomers.Columns["Phone"].HeaderText = "Phone";
            dgvCustomers.Columns["SalesPerson"].HeaderText = "Salesperson";

            dgvCustomers.Columns["FirstName"].FillWeight = 80;
            dgvCustomers.Columns["MiddleName"].FillWeight = 70;
            dgvCustomers.Columns["LastName"].FillWeight = 100;
            dgvCustomers.Columns["CompanyName"].FillWeight = 140;
            dgvCustomers.Columns["EmailAddress"].FillWeight = 170;
            dgvCustomers.Columns["Phone"].FillWeight = 100;
            dgvCustomers.Columns["SalesPerson"].FillWeight = 110;

            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                row.HeaderCell.Value = Convert.ToString(row.Cells["CustomerId"].Value);
            }
        }

        private void SearchCustomers()
        {
            try
            {
                List<dbCustomer> customers =
                    dbCustomer.SearchCustomers(
                        txtCustomerID.Text,
                        txtCustomerFirstName.Text,
                        txtCustomerMiddleName.Text,
                        txtCustomerLastName.Text,
                        txtCustomerCompany.Text,
                        txtCustomerAddress.Text,
                        txtCustomerEmail.Text
                    );

                DisplayCustomers(customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to search customers: " + ex.Message, "Customer Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSearch()
        {
            txtCustomerID.Clear();
            txtCustomerFirstName.Clear();
            txtCustomerMiddleName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerCompany.Clear();
            txtCustomerAddress.Clear();
            txtCustomerEmail.Clear();

            LoadCustomers();

            txtCustomerID.Focus();
        }

        private dbCustomer GetSelectedCustomer()
        {
            if (dgvCustomers.SelectedRows.Count == 0)
                return null;

            int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerId"].Value);

            dbCustomer customer = new dbCustomer();

            customer.GetCustomerByID(customerId);

            return customer;
        }

        private void UpdateToolStripButtons()
        {
            bool hasSelection = dgvCustomers.SelectedRows.Count > 0;

            tsbEdit.Enabled = hasSelection;
            tsbDelete.Enabled = hasSelection;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateToolStripButtons();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            SearchCustomers();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (frmCustomerDetails form = new frmCustomerDetails())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            dbCustomer customer = GetSelectedCustomer();

            if (customer == null)
            {
                MessageBox.Show("No customer selected.", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmCustomerDetails form =
                new frmCustomerDetails(customer.CustomerId))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dbCustomer customer = GetSelectedCustomer();

                if (customer == null)
                    return;

                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete " + customer.GetFullName() + "?", "Delete Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (result != DialogResult.Yes)
                    return;

                customer.DeleteCustomer();

                LoadCustomers();

                MessageBox.Show("Customer deleted successfully.", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete customer: " + ex.Message, "Customer Management",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}