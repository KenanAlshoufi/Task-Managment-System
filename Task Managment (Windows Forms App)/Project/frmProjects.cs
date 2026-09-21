using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment__Windows_Forms_App_.DTOs.Projects;
using Task_Managment__Windows_Forms_App_.DTOs.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;


namespace Task_Managment__Windows_Forms_App_
{
    public partial class frmProjects : Form
    {
        DTOUser _UserInfo;

        List<DTOFullProjectInfo> MyProject;
        public frmProjects(DTOUser UserInfo)
        {
            InitializeComponent();
            _UserInfo = UserInfo;
        }


        private async Task LoadMyProject()
        {
            try
            {
                var Response = await APIClient.ProjectAPI.GetAsync($"GetAllProject/{_UserInfo.UserId}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MyProject = await Response.Content.ReadFromJsonAsync<List<DTOFullProjectInfo>>();

                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_UserInfo.UserId}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Not Found: this User {_UserInfo.UserId} is not have any Project");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }



        private void ShowAllProject()
        {

            flowLayoutPanel1.Controls.Clear();
            foreach (var item in MyProject)
            {
                ctrlViewProject viewProject = new ctrlViewProject(item);
                viewProject.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(viewProject);
            }


        }

        private async void frmProjects_Load(object sender, EventArgs e)
        {
            await LoadMyProject();

            if (_UserInfo.DTORoleInfo.Name == "Admin" || _UserInfo.DTORoleInfo.Name == "Manager")
            {
                btnAddProject.Visible = true;
                label6.Visible = true;

            }


            if (MyProject != null)
            {
                ShowAllProject();
            }

        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmAddEditProject newProject = new frmAddEditProject();
            newProject.ShowDialog();

            frmProjects_Load(null, null);
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

        private void frmProjects_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
