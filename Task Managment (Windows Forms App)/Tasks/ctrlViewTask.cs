using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment__Windows_Forms_App_.DTOs.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;
using Task_Managment__Windows_Forms_App_.Properties;
using static Task_Managment__Windows_Forms_App_.ctrlTaskView;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class ctrlTaskView : UserControl
    {
        public enum enStatuscolor { Pendin = 1, InProgress = 2, Completed = 3, Cancelled = 4 }
        private enStatuscolor _Statuscolor = enStatuscolor.Pendin;
        public enStatuscolor Statuscolor
        {
            get
            {
                return _Statuscolor;
            }

            set
            {
                _Statuscolor = value;

                switch (_Statuscolor)
                {
                    case enStatuscolor.Pendin:
                        lblStatus.ForeColor = Color.FromArgb(254, 173, 46);
                        pbStatus.Image = Resources.circle__1_;

                        break;

                    case enStatuscolor.InProgress:
                        lblStatus.ForeColor = Color.FromArgb(53, 234, 177); ;
                        pbStatus.Image = Resources.circle;
                        break;

                    case enStatuscolor.Completed:
                        lblStatus.ForeColor = Color.FromArgb(9, 112, 254);
                        pbStatus.Image = Resources.circle__2_;
                        break;

                    case enStatuscolor.Cancelled:
                        lblStatus.ForeColor = Color.Gray;
                        pbStatus.Image = Resources.circle__3_;
                        break;
                }
            }
        }



        DTOFullTaskInfo _DTOTaskInfo;
        public ctrlTaskView(DTOFullTaskInfo task)
        {
            InitializeComponent();
            _DTOTaskInfo = task;
        }

        private async Task GetTaskByTaskID()
        {
            try
            {
                var Response = await APIClient.TasksAPI.GetAsync($"GetTaskByTaskID/{_DTOTaskInfo.TaskID}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DTOTaskInfo dtoTask = await Response.Content.ReadFromJsonAsync<DTOTaskInfo>();

                    _DTOTaskInfo.Title = dtoTask.Title;
                    _DTOTaskInfo.ProjectName = dtoTask.ProjectInfo.Title;
                    _DTOTaskInfo.Description = dtoTask.Description;
                    _DTOTaskInfo.DueDate = dtoTask.DueDate;
                    _DTOTaskInfo.StatusName = dtoTask.StatusInfo.Name;
                    _DTOTaskInfo.AssignedUserName = dtoTask.UserInfo.FirstName + " " + dtoTask.UserInfo.LastName;
                    _DTOTaskInfo.PriorityName = dtoTask.PriorityInfo.Name;

                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_DTOTaskInfo.TaskID}");

                }
                else
                {
                    MessageBox.Show($"Not Found: this User {_DTOTaskInfo.TaskID} is not have any Task");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }
        }

        private void Status()
        {
            switch (_DTOTaskInfo.StatusName)
            {
                case "Pending":
                    Statuscolor = enStatuscolor.Pendin;
                    btnNextStatus.BackgroundImage = Resources.play;
                    lblStatus.ForeColor = Color.FromArgb(254, 173, 46);
                    pbStatus.Image = Resources.circle__1_;
                    break;

                case "InProgress":
                    Statuscolor = enStatuscolor.InProgress;
                    btnNextStatus.BackgroundImage = Resources.checklist;
                    lblStatus.ForeColor = Color.FromArgb(53, 234, 177); ;
                    pbStatus.Image = Resources.circle;
                    break;

                case "Completed":
                    Statuscolor = enStatuscolor.Completed;
                    lblStatus.ForeColor = Color.FromArgb(9, 112, 254);
                    pbStatus.Image = Resources.circle__2_;
                    btnNextStatus.Visible = false;
                    btnEdit.Visible = false;
                    btnCancell.Visible = false;
                    break;

                case "Cancelled":
                    Statuscolor = enStatuscolor.Cancelled;
                    lblStatus.ForeColor = Color.Gray;
                    pbStatus.Image = Resources.circle__3_;
                    btnNextStatus.Visible = false;
                    btnEdit.Visible = false;
                    btnCancell.Visible = false;
                    break;
            }
        }

        private void LoadTask()
        {
            lblDescription.Text = _DTOTaskInfo.Description;
            lblProject.Text = _DTOTaskInfo.ProjectName;
            lblTitle.Text = _DTOTaskInfo.Title;
            lblStatus.Text = _DTOTaskInfo.StatusName;
            Status();

            lblPriority.Text = _DTOTaskInfo.PriorityName;


            lblUser.Text = _DTOTaskInfo.AssignedUserName;
            lblManager.Text = _DTOTaskInfo.ManagerName;
            lblDueDate.Text = _DTOTaskInfo.DueDate.ToString();

        }

        public void LoadControl()
        {
            if (CurrentUser.UserInfo.DTORoleInfo.Name == "Manager" || CurrentUser.UserInfo.DTORoleInfo.Name == "Admin")
            {
                btnEdit.Visible = true;
                btnCancell.Visible = true;
            }
            LoadTask();
        }

        private async Task InProgressTask()
        {
            try
            {
                var Response = await APIClient.TasksAPI.PutAsync($"TaskIsInProgress/{_DTOTaskInfo.TaskID}", null);


            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }
        }

        private async Task CompletedTask()
        {
            try
            {
                var Response = await APIClient.TasksAPI.PutAsync($"TaskIsCompleted/{_DTOTaskInfo.TaskID}", null);



            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }
        }

        private async Task CancellTask()
        {
            try
            {
                var Response = await APIClient.TasksAPI.PutAsync($"TaskIsCancelled/{_DTOTaskInfo.TaskID}", null);


            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }
        }


        private async void btnCancell_Click(object sender, EventArgs e)
        {
            await CancellTask();

            await GetTaskByTaskID();
            LoadTask();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddTask UpdateTask = new frmAddTask(_DTOTaskInfo);
            UpdateTask.ShowDialog();

            await GetTaskByTaskID();
            LoadTask();
        }

        private async void btnNextStatus_Click(object sender, EventArgs e)
        {
            switch (_DTOTaskInfo.StatusName)
            {
                case "Pending":
                    await InProgressTask();
                    break;

                case "InProgress":
                    await CompletedTask();
                    break;
            }
            await GetTaskByTaskID();
            LoadTask();
        }

        private void ctrlTaskView_Load(object sender, EventArgs e)
        {
          

        }
    }
}
