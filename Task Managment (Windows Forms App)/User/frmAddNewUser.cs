using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment__Windows_Forms_App_.DTOs.Users;
using Task_Managment__Windows_Forms_App_.Global;
using Task_Managment__Windows_Forms_App_.Properties;

namespace Task_Managment__Windows_Forms_App_.User
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ' ';

        }

        private async Task<bool> IsEmailExist()
        {
            try
            {
                var response = await APIClient.UsersAPI.GetAsync($"IsEmailExist/{txtEmail.Text.Trim()}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erorr : " + ex.Message);
            }
            return true;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(temp.Text.Trim()))
            {
                errorProvider1.SetError(temp, "This Filed Is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        bool IsValidEmail=false;
        private async void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "This Filed Is required!");
                e.Cancel = true;
                IsValidEmail = false;
            }
            else if (!clsGlobal.IsValidEmail(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!.");
                e.Cancel = true;
                IsValidEmail = false;
            }
            else if ((await IsEmailExist()))
            {
                errorProvider1.SetError(txtEmail, "This email Is Exist ,Please Change it and try agein");
                e.Cancel = true;
                IsValidEmail = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
                IsValidEmail = true;
            }


        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtConfirmPassword, "This Filed Is required!");
                e.Cancel = true;
            }
            else if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtPassword, "This Filed Is required!");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtPassword, null);
            }

        }


        BitArray Valid=new BitArray(4);
        public void IsValidPassword()
        {
            if (txtPassword.Text.Trim().Length >= 8)
            {
                Valid.Set(0, true);
                pbCharactares.Image = Resources.True;
            }
            else
            {
                Valid.Set(0, false);
                pbCharactares.Image = Resources.Cross;
            }

            if (txtPassword.Text.Trim().Any(ch => char.IsLetter(ch)))
            {
                Valid.Set(1, true);
                pbLetter.Image = Resources.True;
            }
            else
            {
                Valid.Set(1, false);
                pbLetter.Image = Resources.Cross;
            }


            if (txtPassword.Text.Trim().Any(ch => char.IsDigit(ch)))
            {
                Valid.Set(2, true);
                pbNumber.Image = Resources.True;
            }
            else
            {
                Valid.Set(2, false);
                pbNumber.Image = Resources.Cross;
            }

            if (txtPassword.Text.Trim().Any(ch => char.IsPunctuation(ch)))
            {
                Valid.Set(3, true);
                pbSpecialCharacters.Image = Resources.True;
            }
            else
            {
                Valid.Set(3, false);
                pbSpecialCharacters.Image = Resources.Cross;
            }

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail)
            {
                return;
            }

            tcNewAccount.SelectedIndex = 1;

        }



        private void btnBack2_Click(object sender, EventArgs e)
        {
            tcNewAccount.SelectedIndex = 1;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            if (!Valid.HasAllSet())
            {
                return;
            }



            tcNewAccount.SelectedIndex = 2;
        }

        private async Task AddNewUser(DTONewUser user)
        {
            try
            {
                var Response = await APIClient.UsersAPI.PostAsJsonAsync("AddNewUser", user);
                if (Response.StatusCode == System.Net.HttpStatusCode.Created)
                {

                }
                else if (Response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {

                    MessageBox.Show("there is an error in the Information,Please Check and try agian", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error : {ex}");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            DTONewUser user = new DTONewUser();

            user.IsActive = false;
            if (MessageBox.Show("Do you want to active this User ? ", "Active"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user.IsActive = true;
            }

            user.FirstName = txtFirstname.Text.Trim();
            user.LastName = txtLastname.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Password = txtPassword.Text.Trim();
            user.ProfileImage = "";
            user.RoleId = (cbRole.SelectedIndex + 1);

            await AddNewUser(user);

            this.Close();
        }



        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            IsValidPassword();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tcNewAccount.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
            cbRole.SelectedIndex = 2;
        }
    }
}

