using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment__Windows_Forms_App_.DTOs.Tasks;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;
using Task_Managment__Windows_Forms_App_.Tasks;
using Task_Managment__Windows_Forms_App_.User;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class Main : Form
    {
        DTOUser _UserInfo;
        List<DTOFullTaskInfo> DTOTask;
        public Main(DTOUser UserInfo)
        {
            InitializeComponent();
            _UserInfo = UserInfo;
        }

        private async Task NumberOfTasks()
        {
            int NumberOfTask = 0;
            try
            {
                var Response = await APIClient.TasksAPI.GetAsync($"NumberOfTasks/{_UserInfo.UserId}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    NumberOfTask = await Response.Content.ReadFromJsonAsync<int>();


                    lblNumberOfTasks.Text = NumberOfTask.ToString();


                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_UserInfo.UserId}");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }

        private async Task NumberOfProjects()
        {
            int NumberOfProject = 0;
            try
            {
                var Response = await APIClient.ProjectAPI.GetAsync($"NumberOfProjects/{_UserInfo.UserId}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    NumberOfProject = await Response.Content.ReadFromJsonAsync<int>();


                    lblProject.Text = NumberOfProject.ToString();


                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_UserInfo.UserId}");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }

        private async Task GetAllTaskForUserID()
        {

            try
            {
                var Response = await APIClient.TasksAPI.GetAsync($"GetAllTaskForUserID/{_UserInfo.UserId}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DTOTask = await Response.Content.ReadFromJsonAsync<List<DTOFullTaskInfo>>();

                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_UserInfo.UserId}");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }

        private async Task LoadAllTaskForUser()
        {
            DTOTask = null;
           
            await GetAllTaskForUserID();

            flowLayoutPanel1.Controls.Clear();

            if (DTOTask != null)
            {
                foreach (var item in DTOTask)
                {
                    ctrlTaskView taskView = new ctrlTaskView(item);
                    taskView.LoadControl();
                    taskView.Margin = new Padding(10);
                    flowLayoutPanel1.Controls.Add(taskView);
                }
            }

        }



        private void LoadUserInfo()
        {
            lblUser.Text = _UserInfo.FirstName;
            tslNameUser.Text = _UserInfo.FirstName;
            tslRole.Text = _UserInfo.DTORoleInfo.Name;

            if (_UserInfo.DTORoleInfo.Name == "Admin" || _UserInfo.DTORoleInfo.Name == "Manager")
            {
                tslManagmentTask.Visible = true;
                toolStripStatusLabel6.Visible = true;
                toolStripStatusLabel9.Visible = true;
                tslAddNewUser.Visible = true;
            }

            if (DTOTask == null)
            {
                lblAllTasks.Visible = false;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadAllTaskForUser();
            await NumberOfTasks();
            await NumberOfProjects();

            LoadUserInfo();
        }

        private void tslProfile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile(_UserInfo.UserId);
            profile.ShowDialog();


        }

        private void tslProject_Click(object sender, EventArgs e)
        {
            frmProjects projects = new frmProjects(_UserInfo);
            projects.ShowDialog();

            Form1_Load(null, null);
        }

        private void tslMyTasks_Click(object sender, EventArgs e)
        {
            frmMyTasks myTasks = new frmMyTasks(_UserInfo);
            myTasks.ShowDialog();

            Form1_Load(null, null);
        }

        private void tslLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tslManagmentTask_Click(object sender, EventArgs e)
        {
            frmManagmentTasks managmentTasks = new frmManagmentTasks();
            managmentTasks.ShowDialog();

            Form1_Load(null, null);
        }

        private void tslAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser newUser = new frmAddNewUser();
            newUser.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
