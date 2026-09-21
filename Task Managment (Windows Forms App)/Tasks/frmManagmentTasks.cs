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

namespace Task_Managment__Windows_Forms_App_.Tasks
{
    public partial class frmManagmentTasks : Form
    {
        public frmManagmentTasks()
        {
            InitializeComponent();
        }

        List<DTOFullTaskInfo> MyTask;

        private async Task LoadMyTask()
        {
            try
            {
                var Response = await APIClient.TasksAPI.GetAsync($"GetAllTaskForManagerID/{CurrentUser.UserInfo.UserId}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MyTask = await Response.Content.ReadFromJsonAsync<List<DTOFullTaskInfo>>();

                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {CurrentUser.UserInfo.UserId}");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }

        private async Task LoadAllCompletedTask()
        {
            try
            {
                var Response = await APIClient.TasksAPI.GetAsync($"GetAllTaskForManagerIDCompleted/{CurrentUser.UserInfo.UserId}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (MyTask != null)
                    {
                        MyTask.AddRange(await Response.Content.ReadFromJsonAsync<List<DTOFullTaskInfo>>());
                    }
                    else
                        MyTask = await Response.Content.ReadFromJsonAsync<List<DTOFullTaskInfo>>();


                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {CurrentUser.UserInfo.UserId}");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }

        private async Task LoadAllCancelledTask()
        {
            try
            {
                var Response = await APIClient.TasksAPI.GetAsync($"GetAllTaskForManagerIDCancelled/{CurrentUser.UserInfo.UserId}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (MyTask != null)
                    {
                        MyTask.AddRange(await Response.Content.ReadFromJsonAsync<List<DTOFullTaskInfo>>());
                    }
                    else
                        MyTask = await Response.Content.ReadFromJsonAsync<List<DTOFullTaskInfo>>();


                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {CurrentUser.UserInfo.UserId}");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }


        private void LoadData(List<DTOFullTaskInfo> Tasks)
        {
            if (Tasks != null)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in Tasks)
                {
                    ctrlTaskView taskView = new ctrlTaskView(item);
                    taskView.LoadControl();
                    taskView.Margin = new Padding(10);
                    flowLayoutPanel1.Controls.Add(taskView);
                }
            }
        }

        private async void frmManagmentTasks_Load(object sender, EventArgs e)
        {
            await LoadMyTask();

            await LoadAllCompletedTask();

            await LoadAllCancelledTask();

            if (MyTask != null)
            {
                ctrlStatisticCard1.CardValue = MyTask.Count().ToString();
                ctrlStatisticCard2.CardValue = MyTask.Where(x => (x.StatusName == "Completed")).Count().ToString();
                ctrlStatisticCard3.CardValue = MyTask.Where(x => (x.StatusName == "Pending") || (x.StatusName == "InProgress")).Count().ToString();
                ctrlStatisticCard4.CardValue = MyTask.Where(x => (x.StatusName == "Cancelled")).Count().ToString();
            }

            lblManagerName.Text = CurrentUser.UserInfo.FirstName + " " + CurrentUser.UserInfo.LastName;

            cbFilter.SelectedIndex = 0;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);



        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTOFullTaskInfo> FilterTask = new List<DTOFullTaskInfo>();

            if (MyTask == null)
                return;

            if (cbFilter.SelectedIndex == 0)
            {
                LoadData(MyTask);
                return;
            }
            else if (cbFilter.SelectedIndex == 1)
            {
                FilterTask = MyTask.Where(x => (x.StatusName == "Pending") || (x.StatusName == "InProgress")).ToList();
            }
            else if (cbFilter.SelectedIndex == 2)
            {
                FilterTask = MyTask.Where(x => (x.StatusName == "Completed")).ToList();
            }
            else
            {
                FilterTask = MyTask.Where(x => x.StatusName == "Cancelled").ToList();
            }
            LoadData(FilterTask);
        }

        private void frmManagmentTasks_MouseDown(object sender, MouseEventArgs e)
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
