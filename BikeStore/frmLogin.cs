using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.Classes;

namespace BikeStore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new BikeStore.Classes.User();

                if (user.Authenticate(txtUsername.Text.Trim(), txtPassword.Text))
                {
                    frmMain mainForm = new frmMain(this);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to log in: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableSignInButton()
        {
            btnSignIn.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            EnableSignInButton();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            EnableSignInButton();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            btnSignIn.Enabled = false;
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                await InitializeDatabaseAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to initialize the database.\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task InitializeDatabaseAsync()
        {
            await Task.Run(() =>
            {
                using (var db = new BikeStoreEntities())
                {
                    db.Users.Any();
                }
            });
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && btnSignIn.Enabled)
            {
                btnSignIn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!BikeStore.Classes.User.IsLoggedIn)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}