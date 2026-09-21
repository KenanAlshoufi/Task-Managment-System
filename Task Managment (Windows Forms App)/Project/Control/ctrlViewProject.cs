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
using Task_Managment__Windows_Forms_App_.DTOs.Projects;
using Task_Managment__Windows_Forms_App_.DTOs.Tasks;
using Task_Managment__Windows_Forms_App_.Global;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class ctrlViewProject : UserControl
    {
        int _ProjectID;
        DTOFullProjectInfo _ProjectInfo;
        public ctrlViewProject(DTOFullProjectInfo ProjectInfo)
        {
            InitializeComponent();
            _ProjectInfo = ProjectInfo;
        }

        private async Task GetProjectForUserID()
        {
            try
            {
                var Response = await APIClient.ProjectAPI.GetAsync($"GetProjectByID/{_ProjectInfo.ProjectID}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DTOProjectInfo dtoProject = await Response.Content.ReadFromJsonAsync<DTOProjectInfo>();

                    _ProjectInfo.Title = dtoProject.Title;
                    _ProjectInfo.Description = dtoProject.Description;
                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_ProjectInfo.ProjectID}");

                }
                else
                {
                    MessageBox.Show($"Not Found: this User {_ProjectInfo.ProjectID} is not have any Task");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }
        }

        private void LoadProjectInfo()
        {
            lblTitle.Text = _ProjectInfo.Title;
            lblManager.Text = _ProjectInfo.managerName;
            lblDescription.Text = _ProjectInfo.Description;
            lblCreatedDate.Text = _ProjectInfo.CreatedData.ToString();

            if (_ProjectInfo.managerName == CurrentUser.UserInfo.FirstName+" " + CurrentUser.UserInfo.LastName)
            {
                pbAddTask.Visible = true;
                pbEdit.Visible = true;
                label6.Visible = true;
            }
        }

        private  void ctrlViewProject_Load(object sender, EventArgs e)
        {
            LoadProjectInfo();
        }

        private async void  pbEdit_Click(object sender, EventArgs e)
        {
            frmAddEditProject editProject = new frmAddEditProject(_ProjectInfo);
            editProject.ShowDialog();

           await GetProjectForUserID();
            LoadProjectInfo();
        }

        private void pbAddTask_Click(object sender, EventArgs e)
        {
            frmAddTask frmAddTask = new frmAddTask(_ProjectInfo);
            frmAddTask.ShowDialog();
        }
    }
}
