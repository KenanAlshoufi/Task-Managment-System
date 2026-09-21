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
using Task_Managment__Windows_Forms_App_.DTOs.Projects;
using Task_Managment__Windows_Forms_App_.Global;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class frmAddEditProject : Form
    {
        DTOFullProjectInfo _projectInfo;

        enum enMode { AddNew=1,Update=2}

        enMode mode = enMode.AddNew;
        public frmAddEditProject(DTOFullProjectInfo projectInfo)
        {
            InitializeComponent();
            _projectInfo = projectInfo;
             mode = enMode.Update;
        }

        public frmAddEditProject()
        {
            InitializeComponent();
             mode = enMode.AddNew;
        }

        private async Task AddNewProject()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("There are fileds are required.", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DTONewProject newProject = new DTONewProject();
            newProject.MangerID = CurrentUser.UserInfo.UserId;
            newProject.Title = txtTitle.Text.Trim();
            newProject.Description = txtDescription.Text.Trim();
            try
            {
                var Response = await APIClient.ProjectAPI.PostAsJsonAsync("AddNewProject", newProject);

                if (Response.StatusCode == System.Net.HttpStatusCode.Created)
                {

                    MessageBox.Show("Done","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private async Task UpdateProject()
        {
            DTOUpdateProject updateProject = new DTOUpdateProject();
            updateProject.Title = txtTitle.Text.Trim();
            updateProject.Description = txtDescription.Text.Trim();

            try
            {
                var Response = await APIClient.ProjectAPI.PutAsJsonAsync($"UpdateProject/{_projectInfo.ProjectID}",
                    updateProject);

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
                MessageBox.Show("Error : " + ex.Message, "error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
            }
        }

        private void LoadProjectInfo()
        {
            lblCreatedDate.Text = _projectInfo.CreatedData.ToString();
            lblManager.Text = _projectInfo.managerName;
            txtTitle.Text = _projectInfo.Title;
            txtDescription.Text = _projectInfo.Description;
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == enMode.AddNew)
            {
                await AddNewProject();
            }
            else if (mode == enMode.Update)
            {
                if (MessageBox.Show("Are you sure you need to edit this Project ?", "question", MessageBoxButtons.OKCancel) ==
                    DialogResult.OK)
                {
                    await UpdateProject();
                }
            }
        }

        private void frmEditProject_Load(object sender, EventArgs e)
        {

            if (mode == enMode.AddNew)
            {
                lblCreatedDate.Text =DateTime.Now.ToString();
                lblManager.Text = CurrentUser.UserInfo.FirstName+" "+ CurrentUser.UserInfo.LastName;
            }
            else
            {
                 LoadProjectInfo();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
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
    }
}
