using System;
using System.Windows.Forms;
using dbUser = BikeStore.Classes.User;

namespace BikeStore
{
    public partial class frmMain : Form
    {
        private frmLogin loginForm;
        private bool isLoggingOut = false;

        public frmMain(frmLogin login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut)
            {
                return;
            }

            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                isLoggingOut = true;
                this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLoggingOut)
            {
                loginForm.Show();
            }
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLoggedUser.Text = "Logged in as: " + (dbUser.LoggedUser?.GetFullName() ?? "Unknown") + " (" + (dbUser.LoggedUser?.Role ?? "Unknown") + ")";

            if (dbUser.LoggedUser?.Role == "Admin")
            {
                userManagementToolStripMenuItem.Visible = true;
            }
            else
            {
                userManagementToolStripMenuItem.Visible = false;
            }
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dbUser.IsLoggedIn || dbUser.LoggedUser.Role != "Admin")
            {
                MessageBox.Show("Administrator access is required.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            using (frmUserManagement userMgmtForm = new frmUserManagement())
            {
                userMgmtForm.ShowDialog(this);
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCustomerManagement customerMgnt = new frmCustomerManagement())
            {
                customerMgnt.ShowDialog(this);
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmOrderManagement orderMgnt = new frmOrderManagement())
            {
                orderMgnt.ShowDialog(this);
            }
        }
    }
}