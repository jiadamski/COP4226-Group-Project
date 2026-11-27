using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using dbUser = BikeStore.Classes.User;

namespace BikeStore
{
    public partial class frmUserManagement : Form
    {
        private BindingSource userBindingSource = new BindingSource();
        private List<dbUser> deletedUsers = new List<dbUser>();

        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            if (!dbUser.IsLoggedIn || dbUser.LoggedUser.Role != "Admin")
            {
                MessageBox.Show("Administrator access is required.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Close();

                return;
            }

            ConfigureDataGridView();

            LoadUsers();
        }


        private void ConfigureDataGridView()
        {
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.ReadOnly = true;

            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;

            dgvUsers.MultiSelect = false;
            dgvUsers.RowHeadersVisible = false;

            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.BringToFront();

            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.GridColor = Color.FromArgb(220, 224, 230);
            dgvUsers.RowsDefaultCellStyle.BackColor = Color.White;
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(233, 237, 243);
            dgvUsers.DefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvUsers.RowTemplate.Height = 28;

            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(190, 200, 214);
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);

            dgvUsers.ColumnHeadersVisible = true;
            dgvUsers.EnableHeadersVisualStyles = false;

            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.ColumnHeadersHeight = 35;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(201, 207, 216);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 36, 42);
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(201, 207, 216);
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 36, 42);
        }


        private void LoadUsers()
        {
            try
            {
                var users = dbUser.GetUsers();

                dgvUsers.DataSource = users
                    .Select(u => new
                    {
                        u.UserId,
                        u.Username,
                        FirstName = string.IsNullOrWhiteSpace(u.MiddleName) ? u.FirstName : $"{u.FirstName} {u.MiddleName}",
                        u.LastName,
                        u.EmailAddress,
                        u.Phone,
                        u.Role,
                        u.IsActive,
                        u.LastLoginDate
                    })
                    .ToList();

                ConfigureColumns();

                tslblTotalUsers.Text = "Total Users: " + users.Count;

                dgvUsers.ClearSelection();

                UpdateToolStripButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following has occurred:\n" + ex.Message, "Error Loading Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureColumns()
        {
            dgvUsers.Columns["UserId"].HeaderText = "ID";
            dgvUsers.Columns["Username"].HeaderText = "Username";
            dgvUsers.Columns["FirstName"].HeaderText = "First Name";
            dgvUsers.Columns["LastName"].HeaderText = "Last Name";
            dgvUsers.Columns["EmailAddress"].HeaderText = "Email Address";
            dgvUsers.Columns["Phone"].HeaderText = "Phone";
            dgvUsers.Columns["Role"].HeaderText = "Role";
            dgvUsers.Columns["IsActive"].HeaderText = "Status";
            dgvUsers.Columns["LastLoginDate"].HeaderText = "Last Login";
            dgvUsers.Columns["LastLoginDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

            dgvUsers.Columns["UserId"].FillWeight = 25;
            dgvUsers.Columns["Username"].FillWeight = 60;
            dgvUsers.Columns["IsActive"].FillWeight = 40;
            dgvUsers.Columns["Role"].FillWeight = 60;
            dgvUsers.Columns["EmailAddress"].FillWeight = 130;
            dgvUsers.Columns["LastLoginDate"].FillWeight = 120;
            dgvUsers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private dbUser GetSelectedUser()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                return null;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);

            dbUser selectedProfile = new dbUser();

            if (!selectedProfile.GetUserInformation(userId))
            {
                return null;
            }

            return selectedProfile;
        }

        private void UpdateToolStripButtons()
        {
            bool hasSelection = dgvUsers.SelectedRows.Count > 0;

            tsbAdd.Enabled = true;
            tsbEdit.Enabled = hasSelection;
            tsbDelete.Enabled = false;
            tsbDisable.Enabled = false;
            tsbRefresh.Enabled = true;

            if (hasSelection && dbUser.IsLoggedIn)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
                bool isLoggedUser = userId == dbUser.LoggedUser.UserId;

                tsbDelete.Enabled = !isLoggedUser;
                tsbDisable.Enabled = !isLoggedUser;

                bool isActive = Convert.ToBoolean(dgvUsers.SelectedRows[0].Cells["IsActive"].Value);

                tsbDisable.ToolTipText = isActive ? "Disable User" : "Enable User";
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            UpdateToolStripButtons();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            dbUser user = new dbUser();

            using (frmUserDetails detailsForm = new frmUserDetails(user))
            {
                if (detailsForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dbUser user = GetSelectedUser();

                if (user == null)
                {
                    MessageBox.Show("Please select a user.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                using (frmUserDetails detailsForm = new frmUserDetails(user))
                {
                    if (detailsForm.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error has occured:\n" + ex.Message, "Error Editing User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvUsers.Rows[e.RowIndex].Selected = true;

                tsbEdit_Click(sender, EventArgs.Empty);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dbUser user = GetSelectedUser();

                if (user == null)
                {
                    MessageBox.Show("Please select a user.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (user.UserId == dbUser.LoggedUser.UserId)
                {
                    MessageBox.Show("You cannot delete your own account.", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to permanently delete " + user.Username + "?\n\n" + "This action cannot be undone.", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                user.DeleteUser();

                MessageBox.Show("User "+ user.Username + " was deleted successfully.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error has occured:\n" + ex.Message, "Error Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbDisable_Click(object sender, EventArgs e)
        {
            try
            {
                dbUser user = GetSelectedUser();

                if (user == null)
                {
                    MessageBox.Show("Please select a user.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (user.UserId == dbUser.LoggedUser.UserId)
                {
                    MessageBox.Show("You cannot disable your own account.", "Invalid Request", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string action = user.IsActive ? "disable"  : "enable";

                DialogResult result = MessageBox.Show($"Are you sure you want to {action} " + $"{user.Username}?", "Change User Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                user.ToggleUserStatus();

                string status = user.IsActive ? "enabled" : "disabled";

                MessageBox.Show("User " + status + " successfully.", "Change Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error has occured:\n" + ex.Message, "Error Changing User Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}