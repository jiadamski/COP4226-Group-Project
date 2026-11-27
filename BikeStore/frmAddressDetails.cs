using System;
using System.Windows.Forms;
using BikeStore.Classes;

namespace BikeStore
{
    public partial class frmAddressDetails : Form
    {
        public CustomerAddressInfo AddressInfo { get; private set; }
        public frmAddressDetails()
        {
            InitializeComponent();
        }

        public frmAddressDetails(CustomerAddressInfo address) : this()
        {
            AddressInfo = new CustomerAddressInfo
            {
                AddressId = address.AddressId,
                AddressType = address.AddressType,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                City = address.City,
                StateProvince = address.StateProvince,
                PostalCode = address.PostalCode,
                CountryRegion = address.CountryRegion
            };
        }

        private void cboAddressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAddressType.SelectedItem != null && cboAddressType.SelectedItem.ToString() == "Other")
            {
                txtOtherType.Visible = true;
                txtOtherType.Text = "";
            }
            else
            {
                txtOtherType.Visible = false;
            }
        }

        private void frmAddressDetails_Load(object sender, EventArgs e)
        {
            if (AddressInfo != null)
            {
                string type = AddressInfo.AddressType ?? "";

                if (cboAddressType.Items.Contains(type))
                {
                    cboAddressType.SelectedItem = type;
                }
                else
                {
                    cboAddressType.SelectedItem = "Other";
                    txtOtherType.Text = type;
                }

                txtAddress1.Text = AddressInfo.AddressLine1;
                txtAddress2.Text = AddressInfo.AddressLine2;
                txtCity.Text = AddressInfo.City;
                txtState.Text = AddressInfo.StateProvince;
                txtPostalCode.Text = AddressInfo.PostalCode;
                txtCountry.Text = AddressInfo.CountryRegion;
            }

            txtOtherType.Visible =
                cboAddressType.Text == "Other";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboAddressType.Text) ||
                (cboAddressType.Text == "Other" &&
                 string.IsNullOrWhiteSpace(txtOtherType.Text)) ||
                string.IsNullOrWhiteSpace(txtAddress1.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtState.Text) ||
                string.IsNullOrWhiteSpace(txtPostalCode.Text) ||
                string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Please complete all required address fields.", "Missing Address Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string addressType = cboAddressType.Text == "Other" ? txtOtherType.Text.Trim()  : cboAddressType.Text.Trim();

            AddressInfo = new CustomerAddressInfo
            {
                AddressId = AddressInfo != null  ? AddressInfo.AddressId   : 0,

                AddressType = addressType,
                AddressLine1 = txtAddress1.Text.Trim(),
                AddressLine2 = txtAddress2.Text.Trim(),
                City = txtCity.Text.Trim(),
                StateProvince = txtState.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                CountryRegion = txtCountry.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}