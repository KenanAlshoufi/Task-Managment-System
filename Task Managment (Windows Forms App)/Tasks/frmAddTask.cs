using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment__Windows_Forms_App_.DTOs.Priority;
using Task_Managment__Windows_Forms_App_.DTOs.Projects;
using Task_Managment__Windows_Forms_App_.DTOs.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class frmAddTask : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        DTOFullProjectInfo _ProjectInfo;
        DTOFullTaskInfo _TaskInfo;
        int _SelectUserId = 0;
        public frmAddTask(DTOFullProjectInfo ProjectInfo)
        {
            InitializeComponent();
            _ProjectInfo = ProjectInfo;
            Mode = enMode.AddNew;
        }

        public frmAddTask(DTOFullTaskInfo TaskInfo)
        {
            InitializeComponent();
            _TaskInfo = TaskInfo;
            Mode = enMode.Update;
        }

        private async Task<int> GetPriorityID()
        {
            try
            {
                var Response = await APIClient.TasksAPI.GetAsync($"GetPriorityByName/{cbPriority.Text}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DTOPriorityInfo Priority = await Response.Content.ReadFromJsonAsync<DTOPriorityInfo>();
                    if (Priority != null)
                    {
                        return Priority.PriorityID;
                    }

                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {cbPriority.Text}");
                    return -1;
                }
                else
                {
                    MessageBox.Show($"Not Found: Priority {cbPriority.Text} is not exist");
                    return -1;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                return -1;
            }
            return -1;
        }

        private async Task AddNewTask()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("There are fileds are required.", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DTONewTask newTask = new DTONewTask();
            newTask.Title = txtTitle.Text.Trim();
            newTask.Description = txtDescription.Text.Trim();
            newTask.DueDate = dtpDueDate.Value;
            newTask.CreateBy = _ProjectInfo.ManagerID;
            newTask.PriorityID = await GetPriorityID();
            newTask.ProjectID = _ProjectInfo.ProjectID;
            newTask.UserID = _SelectUserId;
            try
            {
                var Response = await APIClient.TasksAPI.PostAsJsonAsync("AddNewTask", newTask);

                if (Response.StatusCode == System.Net.HttpStatusCode.Created)
                {

                    MessageBox.Show("Done");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred; please check and try again.", "error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.ToString());
            }
        }


        private async Task UpdateTask()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("There are fileds are required.", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DTONewTask newTask = new DTONewTask();
            newTask.Title = txtTitle.Text.Trim();
            newTask.Description = txtDescription.Text.Trim();
            newTask.PriorityID = await GetPriorityID();
            newTask.UserID = _SelectUserId;
            newTask.DueDate = dtpDueDate.Value;
            try
            {
                var Response = await APIClient.TasksAPI.PutAsJsonAsync($"UpdateTask/{_TaskInfo.TaskID}", newTask);

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    MessageBox.Show("Done");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred; please check and try again.", "error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.ToString());
            }
        }

    
        private async Task GetUserID()
        {
            try
            {
                var Response = await APIClient.UsersAPI.GetAsync($"GetUserByName/{_TaskInfo.AssignedUserName}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DTOUser _UserInfo = await Response.Content.ReadFromJsonAsync<DTOUser>();
                    _SelectUserId = _UserInfo.UserId;
                    lblUserID.Text= _UserInfo.UserId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private async void frmAddTask_Load(object sender, EventArgs e)
        {
            _SelectUserId = 0;
            cbPriority.SelectedIndex = 0;

            if (Mode == enMode.Update)
            {
                await GetUserID();
                txtDescription.Text = _TaskInfo.Description;
                txtTitle.Text = _TaskInfo.Title;
                lblNameProject.Text = _TaskInfo.ProjectName;
                lblUserManager.Text = _TaskInfo.ManagerName;
                cbPriority.SelectedIndex = cbPriority.FindString(_TaskInfo.PriorityName);
                dtpDueDate.Value = _TaskInfo.DueDate;
            }

            if (Mode == enMode.AddNew)
            {
                lblUserManager.Text = _ProjectInfo.managerName;
                lblNameProject.Text = _ProjectInfo.Title;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (txtTitle.Text == "Title")
            {
                MessageBox.Show("Please Enter Title for Task.");
                return;
            }

            if (txtDescription.Text == "Description")
            {
                MessageBox.Show("Please Enter Title for Task.");
                return;
            }

            if (_SelectUserId == 0)
            {
                MessageBox.Show("Please Select User for Task.");
                return;
            }

            if (Mode == enMode.Update)
            {
                await UpdateTask();
                return;
            }

            await AddNewTask();
        }

        private void SelectUsrID(object sender, int UserID)
        {
            _SelectUserId = UserID;
        }

        private void llSetUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSelectUser selectUser = new frmSelectUser();
            selectUser.DataBack += SelectUsrID;
            selectUser.ShowDialog();

            lblUserID.Text = _SelectUserId.ToString();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(temp.Text.Trim()))
            {
                errorProvider1.SetError(temp, "There is something required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(temp, null);
            }

        }

      
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
