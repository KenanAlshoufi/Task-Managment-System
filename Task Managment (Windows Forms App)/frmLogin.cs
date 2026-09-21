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
using Task_Managment__Windows_Forms_App_.DTOs.Login;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class frmLogin : Form
    {
        DTOUser _UserInfo;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async Task Login()
        {

            try
            {
                DTOLoginRequest loginRequest=new DTOLoginRequest();
                loginRequest.Email = txtEmail.Text.Trim();
                loginRequest.Password = txtPassword.Text.Trim();

                var Response = await APIClient.UsersAPI.PostAsJsonAsync($"LoginToAccount", loginRequest);

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    _UserInfo = await Response.Content.ReadFromJsonAsync<DTOUser>();

                    CurrentUser.UserInfo = _UserInfo;

                    Main main = new Main(_UserInfo);
                    this.Hide();
                    main.ShowDialog();
                    this.Show();


                }
                else
                {
                    MessageBox.Show("The email or password is incorrect.", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
