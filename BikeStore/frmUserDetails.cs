using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using dbUser = BikeStore.Classes.User;

namespace BikeStore
{
    public partial class frmUserDetails : Form
    {
        private readonly dbUser user;

        private bool IsNewUser => user.UserId == 0;

        public frmUserDetails(dbUser user)
        {
            InitializeComponent();

            this.user = user ?? throw new ArgumentNullException(nameof(user));
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            DisplayUserInformation();

            ConfigureForm();           
        }

        private void ConfigureForm()
        {
            Text = IsNewUser ? "Bike Store | Add User" : "Bike Store | Edit User";

            if (IsNewUser)
            {
                lblUserID.Text = "Automatic";
            }

            chkChangePassword.Visible = !IsNewUser;
            chkChangePassword.Checked = false;

            chkActive.Visible = !IsNewUser;

            if (IsNewUser)
            {
                chkActive.Checked = true;
            }

            SetPasswordFieldsVisible(IsNewUser);

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            if (!IsNewUser &&
                user.UserId == dbUser.LoggedUser.UserId)
            {
                cboRole.Enabled = false;
                chkActive.Enabled = false;
            }

            txtUsername.Focus();
        }


        private void SetPasswordFieldsVisible(bool visible)
        {
            lblPassword.Visible = visible;
            txtPassword.Visible = visible;
            lblConfirmPassword.Visible = visible;
            txtConfirmPassword.Visible = visible;

            if (!visible)
            {
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
        }


        private void DisplayUserInformation()
        {
            lblUserID.Text = IsNewUser ? "Automatic" : user.UserId.ToString();
            txtUsername.Text = user.Username;
            txtFirstName.Text = user.FirstName;
            txtMiddleName.Text = user.MiddleName;
            txtLastName.Text = user.LastName;
            txtEmailAddress.Text = user.EmailAddress;
            mtxtPhoneNumber.Text = user.Phone;
            cboRole.SelectedItem = user.Role;
            chkActive.Checked = user.IsActive;
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }


        private bool ValidateFields()
        {
            erpUserDetails.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                erpUserDetails.SetError(txtFirstName, "First name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                erpUserDetails.SetError(txtLastName, "Last name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                erpUserDetails.SetError(txtUsername, "Username is required.");
                isValid = false;
            }

            string email = txtEmailAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                erpUserDetails.SetError(txtEmailAddress, "Email address is required.");
                isValid = false;
            }
            else
            {
                try
                {
                    var address = new MailAddress(email);

                    if (address.Address != email)
                        throw new FormatException();
                }
                catch (FormatException)
                {
                    erpUserDetails.SetError(txtEmailAddress, "Enter a valid email address.");
                    isValid = false;
                }
            }

            if (!mtxtPhoneNumber.MaskCompleted)
            {
                erpUserDetails.SetError(mtxtPhoneNumber, "A complete phone number is required.");
                isValid = false;
            }

            if (cboRole.SelectedIndex == -1)
            {
                erpUserDetails.SetError(cboRole, "Please select a role.");
                isValid = false;
            }

            if (!isValid)
                return false;

            return ValidatePassword();
        }


        private void GetFormInformation()
        {
            user.Username = txtUsername.Text.Trim();
            user.FirstName = txtFirstName.Text.Trim();
            user.MiddleName = txtMiddleName.Text.Trim();
            user.LastName = txtLastName.Text.Trim();
            user.EmailAddress = txtEmailAddress.Text.Trim();
            user.Phone =  mtxtPhoneNumber.MaskedTextProvider.AssignedEditPositionCount == 0 ? null : mtxtPhoneNumber.Text.Trim();
            user.Role = cboRole.SelectedItem.ToString();
            user.IsActive = IsNewUser || chkActive.Checked;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                GetFormInformation();

                if (IsNewUser)
                {
                    user.AddUser(txtPassword.Text);
                    MessageBox.Show("User created successfully.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string newPassword = chkChangePassword.Checked ? txtPassword.Text : null;
                    user.UpdateUser(newPassword);
                    MessageBox.Show(chkChangePassword.Checked ? "User information and password updated successfully." : "User updated successfully.", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtPassword.Clear();
                txtConfirmPassword.Clear();

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( "The following error has occurred:\n" +  ex.Message, "Error Saving User",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidatePassword()
        {
            bool passwordRequired = IsNewUser || chkChangePassword.Checked;

            if (!passwordRequired)
                return true;

            bool isValid = true;

            string password = txtPassword.Text;
            string confirmation = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                erpUserDetails.SetError(txtPassword, "Password is required.");
                isValid = false;
            }
            else if (password.Length < 12 || password.Any(char.IsWhiteSpace))
            {
                erpUserDetails.SetError(txtPassword, "Password must be at least 12 characters without spaces.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(confirmation))
            {
                erpUserDetails.SetError(txtConfirmPassword, "Please confirm your password.");
                isValid = false;
            }
            else if (password != confirmation)
            {
                erpUserDetails.SetError(txtConfirmPassword, "Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            SetPasswordFieldsVisible(IsNewUser || chkChangePassword.Checked);
        }
    }
}