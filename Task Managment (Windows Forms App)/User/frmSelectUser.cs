using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment__Windows_Forms_App_.DTOs.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class frmSelectUser : Form
    {
        List<DTOFullUserInfo> users;
        public frmSelectUser()
        {
            InitializeComponent();
        }

        public delegate void DataBacktoForm(object sender, int UserID);

        public DataBacktoForm DataBack;

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            profile.ShowDialog();
        }




        private void LoadAllUser(List<DTOFullUserInfo> Alluser)
        {
            dgvAllUsers.DataSource = Alluser;

            int RowCount = dgvAllUsers.Rows.Count;

            if (RowCount > 0)
            {
                dgvAllUsers.Columns[0].HeaderText = "User ID";
                dgvAllUsers.Columns[0].Width = 100;

                dgvAllUsers.Columns[1].HeaderText = "FullName";
                dgvAllUsers.Columns[1].Width = 200;

                dgvAllUsers.Columns[2].HeaderText = "Email";
                dgvAllUsers.Columns[2].Width = 200;

                dgvAllUsers.Columns[3].HeaderText = "Role";
                dgvAllUsers.Columns[3].Width = 100;


                dgvAllUsers.Columns[4].HeaderText = "IsActive";
                dgvAllUsers.Columns[4].Width = 100;
            }
        }

        private async Task GetAllUser()
        {
            try
            {
                var Response = await APIClient.UsersAPI.GetAsync($"GetAllUser");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    users = await Response.Content.ReadFromJsonAsync<List<DTOFullUserInfo>>();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                LoadAllUser(users);
                return;
            }

            List<DTOFullUserInfo> filteredUsers = new List<DTOFullUserInfo>();

            if (cbFilter.SelectedIndex == 0)
            {
                if (int.TryParse(txtFilter.Text.Trim(), out int searchId))
                {
                    filteredUsers = users.Where(x => x.UserID == searchId).ToList();
                }
            }
            else
            {
                filteredUsers = users.Where(x => x.FullName.StartsWith(txtFilter.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase)).ToList();
            }
            LoadAllUser(filteredUsers);
        }




        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private async void frmSelectUser_Load(object sender, EventArgs e)
        {
            await GetAllUser();

            cbFilter.SelectedIndex = 0;

            LoadAllUser(users);
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, (int)dgvAllUsers.CurrentRow.Cells[0].Value);
            this.Close();
        }

        private void selectUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, (int)dgvAllUsers.CurrentRow.Cells[0].Value);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void frmSelectUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
