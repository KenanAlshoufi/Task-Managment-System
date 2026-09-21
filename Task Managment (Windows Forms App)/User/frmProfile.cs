using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class frmProfile : Form
    {
        private int _UserID;
        DTOUser UserInfo;
        public frmProfile(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private async Task<Image> LoadImage()
        {
            try
            {
                byte[] imageBytes = await APIClient.UsersAPI
                    .GetByteArrayAsync($"GetImage/{UserInfo.ProfileImage}");

                using MemoryStream memory = new MemoryStream(imageBytes);

                return Image.FromStream(memory);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private async Task UpdateImage(string ProfileImage)
        {
            try
            {
                var response = await APIClient.UsersAPI.PutAsJsonAsync($"UpdateImage/{_UserID}", ProfileImage);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Successful Upload your Image.");
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();

                    MessageBox.Show(
                        $"Upload failed: {response.StatusCode}\n{error}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }

        }

        private async Task UploadImage()
        {
            using MultipartFormDataContent content = new MultipartFormDataContent();
            using FileStream fileStream = File.OpenRead(pbImage.ImageLocation);
            using StreamContent FileContaent = new StreamContent(fileStream);

            FileContaent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

            content.Add(FileContaent, "ImageFile", Path.GetFileName(pbImage.ImageLocation));
            try
            {
                var response = await APIClient.UsersAPI.PostAsync("UploadImage", content);

                if (response.IsSuccessStatusCode)
                {
                    var ImagePath = await response.Content.ReadFromJsonAsync<DTOUploadImageResponse>();

                    await UpdateImage(ImagePath.FileName);


                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();

                    MessageBox.Show(
                        $"Upload failed: {response.StatusCode}\n{error}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }

        }



        private async Task LoadFullInfo()
        {
            try
            {
                var Response = await APIClient.UsersAPI.GetAsync($"GetUserByID/{_UserID}");

                if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    UserInfo = await Response.Content.ReadFromJsonAsync<DTOUser>();
                    if (UserInfo != null)
                    {
                        lblUserID.Text = UserInfo.UserId.ToString();
                        lblName.Text = (UserInfo.FirstName + " " + UserInfo.LastName);
                        lblEmail.Text = UserInfo.Email;
                        lblRole.Text = UserInfo.DTORoleInfo.Name;
                        lblIsActive.Text = (UserInfo.IsActive ? "yes" : "No");
                        if (UserInfo.ProfileImage != "")
                        {
                            var Image = await LoadImage();
                            if (Image != null)
                            {
                                pbImage.Image = Image;
                            }

                        }
                    }

                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_UserID}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Not Found: User {_UserID} is not exist");
                    this.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
                this.Close();
            }
        }

        private async void frmProfile_Load(object sender, EventArgs e)
        {
            await LoadFullInfo();
        }

        private void llSetPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdSelectImage.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            ofdSelectImage.FilterIndex = 1;
            ofdSelectImage.RestoreDirectory = true;

            if (ofdSelectImage.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file 
                string selectedFilePath = ofdSelectImage.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath); 

                pbImage.ImageLocation = selectedFilePath;

                btnSave.Visible = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation != null)
            {
                await UploadImage();
            }

            btnSave.Visible = false;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProfile_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
