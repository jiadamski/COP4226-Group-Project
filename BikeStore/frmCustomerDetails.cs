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
    public partial class frmCustomerDetails : Form
    {
        private dbCustomer currentCustomer;
        private bool isEditMode;
        public frmCustomerDetails()
        {
            InitializeComponent();

            currentCustomer = new dbCustomer();
            isEditMode = false;
        }

        public frmCustomerDetails(int customerId) : this()
        {
            isEditMode = true;
            currentCustomer.GetCustomerByID(customerId);
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            ConfigureAddressDataGridView();

            if (isEditMode)
            {
                LoadCustomerInfo();
                LoadCustomerAddresses();
            }
            else
            {
                txtCustomerID.Text = "New";
                RefreshAddressGrid();
            }

            UpdateAddressButtons();
        }

        private void LoadCustomerInfo()
        {
            txtCustomerID.Text = currentCustomer.CustomerId.ToString();
            cboCustomerTitle.Text = currentCustomer.Title ?? "";
            txtCustomerFirstName.Text = currentCustomer.FirstName ?? "";
            txtCustomerMiddleName.Text = currentCustomer.MiddleName ?? "";
            txtCustomerLastName.Text = currentCustomer.LastName ?? "";
            txtCustomerSuffix.Text = currentCustomer.Suffix ?? "";
            txtCustomerCompany.Text = currentCustomer.CompanyName ?? "";
            txtCustomerSalesperson.Text = currentCustomer.SalesPerson ?? "";
            txtCustomerEmail.Text = currentCustomer.EmailAddress ?? "";
            mtxtCustomerPhone.Text = currentCustomer.Phone ?? "";
        }

        private void LoadCustomerAddresses()
        {
            if (currentCustomer.CustomerId == 0)
                return;

            currentCustomer.LoadAddresses();

            RefreshAddressGrid();
        }


        private void SaveCustomerInfo()
        {
            try
            {
                currentCustomer.Title = cboCustomerTitle.Text.Trim();
                currentCustomer.FirstName = txtCustomerFirstName.Text.Trim();
                currentCustomer.MiddleName = txtCustomerMiddleName.Text.Trim();
                currentCustomer.LastName = txtCustomerLastName.Text.Trim();
                currentCustomer.Suffix = txtCustomerSuffix.Text.Trim();
                currentCustomer.CompanyName = txtCustomerCompany.Text.Trim();
                currentCustomer.SalesPerson = txtCustomerSalesperson.Text.Trim();
                currentCustomer.EmailAddress = txtCustomerEmail.Text.Trim();

                currentCustomer.Phone = mtxtCustomerPhone.MaskCompleted  ? mtxtCustomerPhone.Text  : null;

                if (isEditMode)
                {
                    currentCustomer.UpdateCustomer();
                }
                else
                {
                    currentCustomer.AddCustomer();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred while saving customer information:\n\n" + ex.Message, "Customer Information",  MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomerForm())
            {
                return;
            }

            SaveCustomerInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tsbRefreshAddresses_Click(object sender, EventArgs e)
        {
            RefreshAddressGrid();
        }

        private bool ValidateCustomerForm()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerLastName.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerCompany.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerSalesperson.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerEmail.Text) ||
                !mtxtCustomerPhone.MaskCompleted)
            {
                MessageBox.Show("Please complete all required customer information.", "Missing Customer Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (currentCustomer.Addresses == null ||  currentCustomer.Addresses.Count == 0)
            {
                tcCustomerInfo.SelectedTab = tabCustomerAddresses;
                MessageBox.Show("Please add at least one address before saving the customer.", "Missing Address Information",  MessageBoxButtons.OK,  MessageBoxIcon.Warning);

                return false;
            }

            foreach (var address in currentCustomer.Addresses)
            {
                if (string.IsNullOrWhiteSpace(address.AddressType) ||
                    string.IsNullOrWhiteSpace(address.AddressLine1) ||
                    string.IsNullOrWhiteSpace(address.City) ||
                    string.IsNullOrWhiteSpace(address.StateProvince) ||
                    string.IsNullOrWhiteSpace(address.CountryRegion) ||
                    string.IsNullOrWhiteSpace(address.PostalCode))
                {
                    MessageBox.Show("Please complete all required fields for every address.", "Incomplete Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void dgvAddresses_SelectionChanged(object sender, EventArgs e)
        {
            UpdateAddressButtons();
        }

        private void UpdateAddressButtons()
        {
            bool hasSelection = dgvAddresses.SelectedRows.Count > 0;

            tsbAddAddress.Enabled = true;
            tsbRefreshAddresses.Enabled = true;

            tsbEditAddress.Enabled = hasSelection;
            tsbDeleteAddress.Enabled = hasSelection;
        }

        private void tsbAddAddress_Click(object sender, EventArgs e)
        {
            using (frmAddressDetails form = new frmAddressDetails())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    currentCustomer.Addresses.Add(form.AddressInfo);
                    RefreshAddressGrid();
                }
            }
        }

        private void RefreshAddressGrid()
        {
            dgvAddresses.DataSource = null;

            dgvAddresses.DataSource = currentCustomer.Addresses
                .Select(a => new
                {
                    a.AddressId,
                    a.AddressType,
                    a.AddressLine1,
                    a.AddressLine2,
                    a.City,
                    a.StateProvince,
                    a.PostalCode,
                    a.CountryRegion
                })
                .ToList();

            dgvAddresses.Columns["AddressId"].Visible = false;
            dgvAddresses.Columns["AddressType"].HeaderText = "Type";
            dgvAddresses.Columns["AddressType"].Width = 90;

            dgvAddresses.Columns["AddressLine1"].HeaderText = "Address 1";
            dgvAddresses.Columns["AddressLine1"].Width = 180;

            dgvAddresses.Columns["AddressLine2"].HeaderText = "Address 2";
            dgvAddresses.Columns["AddressLine2"].Width = 150;

            dgvAddresses.Columns["City"].HeaderText = "City";
            dgvAddresses.Columns["City"].Width = 120;

            dgvAddresses.Columns["StateProvince"].HeaderText = "State";
            dgvAddresses.Columns["StateProvince"].Width = 100;

            dgvAddresses.Columns["PostalCode"].HeaderText = "ZIP Code";
            dgvAddresses.Columns["PostalCode"].Width = 90;

            dgvAddresses.Columns["CountryRegion"].HeaderText = "Country";
            dgvAddresses.Columns["CountryRegion"].Width = 130;

            dgvAddresses.ClearSelection();
            UpdateAddressButtons();
        }

        private void ConfigureAddressDataGridView()
        {
            dgvAddresses.AutoGenerateColumns = true;
            dgvAddresses.ReadOnly = true;
            dgvAddresses.AllowUserToAddRows = false;
            dgvAddresses.AllowUserToDeleteRows = false;
            dgvAddresses.AllowUserToResizeRows = false;

            dgvAddresses.MultiSelect = false;
            dgvAddresses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAddresses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvAddresses.ScrollBars = ScrollBars.Both;

            dgvAddresses.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            //dgvAddresses.BackgroundColor = Color.White;
            dgvAddresses.BorderStyle = BorderStyle.None;

            dgvAddresses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAddresses.GridColor = Color.FromArgb(220, 224, 230);

            dgvAddresses.RowTemplate.Height = 25;
            dgvAddresses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 237, 243);

            dgvAddresses.DefaultCellStyle.Font =  new Font("Segoe UI", 9);

            dgvAddresses.DefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);

            dgvAddresses.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAddresses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);

            dgvAddresses.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);

            dgvAddresses.ColumnHeadersVisible = true;
            dgvAddresses.EnableHeadersVisualStyles = false;

            dgvAddresses.ColumnHeadersHeightSizeMode =  DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAddresses.ColumnHeadersHeight = 25;
            dgvAddresses.ColumnHeadersBorderStyle =  DataGridViewHeaderBorderStyle.None;
            dgvAddresses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(201, 207, 216);
            dgvAddresses.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvAddresses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvAddresses.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAddresses.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(201, 207, 216);
            dgvAddresses.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);
            dgvAddresses.RowHeadersVisible = false;
        }

        private int GetSelectedAddressIndex()
        {
            if (dgvAddresses.SelectedRows.Count == 0)
                return -1;

            return dgvAddresses.SelectedRows[0].Index;
        }

        private void tsbEditAddress_Click(object sender, EventArgs e)
        {
            int index = GetSelectedAddressIndex();

            if (index < 0)
                return;

            CustomerAddressInfo address =
                currentCustomer.Addresses[index];

            using (frmAddressDetails form = new frmAddressDetails(address))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    currentCustomer.Addresses[index] = form.AddressInfo;

                    RefreshAddressGrid();
                }
            }
        }

        private void tsbDeleteAddress_Click(object sender, EventArgs e)
        {
            int index = GetSelectedAddressIndex();

            if (index < 0)
                return;

            DialogResult result = MessageBox.Show("Are you sure you want to remove the selected address?", "Remove Address",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            currentCustomer.Addresses.RemoveAt(index);

            RefreshAddressGrid();
        }
    }
}