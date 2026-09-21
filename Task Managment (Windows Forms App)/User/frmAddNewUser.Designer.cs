namespace Task_Managment__Windows_Forms_App_.User
{
    partial class frmAddNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            tcNewAccount = new TabControl();
            tpEmail = new TabPage();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            btnNext1 = new Button();
            txtEmail = new TextBox();
            tpPassword = new TabPage();
            button1 = new Button();
            pbSpecialCharacters = new PictureBox();
            pbNumber = new PictureBox();
            pbLetter = new PictureBox();
            pbCharactares = new PictureBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            btnNext2 = new Button();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            label8 = new Label();
            txtPassword = new TextBox();
            tpUserInfo = new TabPage();
            pictureBox4 = new PictureBox();
            btnSave = new Button();
            btnBack2 = new Button();
            txtLastname = new TextBox();
            label6 = new Label();
            txtFirstname = new TextBox();
            cbRole = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            btnClose = new Button();
            label1 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            tcNewAccount.SuspendLayout();
            tpEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLetter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCharactares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 20, 44);
            panel1.Controls.Add(tcNewAccount);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(19, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 402);
            panel1.TabIndex = 0;
            // 
            // tcNewAccount
            // 
            tcNewAccount.Appearance = TabAppearance.FlatButtons;
            tcNewAccount.Controls.Add(tpEmail);
            tcNewAccount.Controls.Add(tpPassword);
            tcNewAccount.Controls.Add(tpUserInfo);
            tcNewAccount.ItemSize = new Size(0, 1);
            tcNewAccount.Location = new Point(34, 75);
            tcNewAccount.Name = "tcNewAccount";
            tcNewAccount.SelectedIndex = 0;
            tcNewAccount.Size = new Size(639, 251);
            tcNewAccount.SizeMode = TabSizeMode.Fixed;
            tcNewAccount.TabIndex = 23;
            // 
            // tpEmail
            // 
            tpEmail.BackColor = Color.FromArgb(7, 20, 44);
            tpEmail.Controls.Add(pictureBox7);
            tpEmail.Controls.Add(label7);
            tpEmail.Controls.Add(pictureBox1);
            tpEmail.Controls.Add(btnNext1);
            tpEmail.Controls.Add(txtEmail);
            tpEmail.Location = new Point(4, 5);
            tpEmail.Name = "tpEmail";
            tpEmail.Padding = new Padding(3);
            tpEmail.Size = new Size(631, 242);
            tpEmail.TabIndex = 0;
            tpEmail.Text = "tpEmail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(169, 63);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 16;
            label7.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.card;
            pictureBox1.Location = new Point(521, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnNext1
            // 
            btnNext1.FlatStyle = FlatStyle.Flat;
            btnNext1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext1.ForeColor = Color.CornflowerBlue;
            btnNext1.Location = new Point(186, 184);
            btnNext1.Name = "btnNext1";
            btnNext1.Size = new Size(229, 36);
            btnNext1.TabIndex = 17;
            btnNext1.Text = "Next";
            btnNext1.UseVisualStyleBackColor = true;
            btnNext1.Click += btnNext1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(186, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 14;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // tpPassword
            // 
            tpPassword.BackColor = Color.FromArgb(7, 20, 44);
            tpPassword.Controls.Add(pictureBox6);
            tpPassword.Controls.Add(pictureBox5);
            tpPassword.Controls.Add(button1);
            tpPassword.Controls.Add(pbSpecialCharacters);
            tpPassword.Controls.Add(pbNumber);
            tpPassword.Controls.Add(pbLetter);
            tpPassword.Controls.Add(pbCharactares);
            tpPassword.Controls.Add(label12);
            tpPassword.Controls.Add(label11);
            tpPassword.Controls.Add(label10);
            tpPassword.Controls.Add(label9);
            tpPassword.Controls.Add(pictureBox3);
            tpPassword.Controls.Add(btnNext2);
            tpPassword.Controls.Add(label2);
            tpPassword.Controls.Add(txtConfirmPassword);
            tpPassword.Controls.Add(label8);
            tpPassword.Controls.Add(txtPassword);
            tpPassword.Location = new Point(4, 5);
            tpPassword.Name = "tpPassword";
            tpPassword.Padding = new Padding(3);
            tpPassword.Size = new Size(631, 242);
            tpPassword.TabIndex = 1;
            tpPassword.Text = "tpPassword";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.left_arrow;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(1, 1);
            button1.Name = "button1";
            button1.Size = new Size(36, 29);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pbSpecialCharacters
            // 
            pbSpecialCharacters.Image = Properties.Resources.circle__3_;
            pbSpecialCharacters.Location = new Point(444, 82);
            pbSpecialCharacters.Name = "pbSpecialCharacters";
            pbSpecialCharacters.Size = new Size(11, 16);
            pbSpecialCharacters.SizeMode = PictureBoxSizeMode.Zoom;
            pbSpecialCharacters.TabIndex = 32;
            pbSpecialCharacters.TabStop = false;
            // 
            // pbNumber
            // 
            pbNumber.Image = Properties.Resources.circle__3_;
            pbNumber.Location = new Point(444, 68);
            pbNumber.Name = "pbNumber";
            pbNumber.Size = new Size(11, 16);
            pbNumber.SizeMode = PictureBoxSizeMode.Zoom;
            pbNumber.TabIndex = 31;
            pbNumber.TabStop = false;
            // 
            // pbLetter
            // 
            pbLetter.Image = Properties.Resources.circle__3_;
            pbLetter.Location = new Point(444, 53);
            pbLetter.Name = "pbLetter";
            pbLetter.Size = new Size(11, 16);
            pbLetter.SizeMode = PictureBoxSizeMode.Zoom;
            pbLetter.TabIndex = 30;
            pbLetter.TabStop = false;
            // 
            // pbCharactares
            // 
            pbCharactares.Image = Properties.Resources.circle__3_;
            pbCharactares.Location = new Point(444, 38);
            pbCharactares.Name = "pbCharactares";
            pbCharactares.Size = new Size(11, 16);
            pbCharactares.SizeMode = PictureBoxSizeMode.Zoom;
            pbCharactares.TabIndex = 29;
            pbCharactares.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Franklin Gothic Medium Cond", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Silver;
            label12.Location = new Point(456, 82);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 28;
            label12.Text = "special characters";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium Cond", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(456, 68);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 27;
            label11.Text = "Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium Cond", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(456, 53);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 26;
            label10.Text = "Letter";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium Cond", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(456, 38);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 25;
            label9.Text = "8-Characters";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.card;
            pictureBox3.Location = new Point(521, -13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(137, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // btnNext2
            // 
            btnNext2.FlatStyle = FlatStyle.Flat;
            btnNext2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnNext2.ForeColor = Color.CornflowerBlue;
            btnNext2.Location = new Point(186, 184);
            btnNext2.Name = "btnNext2";
            btnNext2.Size = new Size(229, 36);
            btnNext2.TabIndex = 22;
            btnNext2.Text = "Next";
            btnNext2.UseVisualStyleBackColor = true;
            btnNext2.Click += btnNext2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(155, 99);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 19;
            label2.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(186, 122);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(229, 27);
            txtConfirmPassword.TabIndex = 18;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(155, 30);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 17;
            label8.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(186, 53);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(229, 27);
            txtPassword.TabIndex = 15;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // tpUserInfo
            // 
            tpUserInfo.BackColor = Color.FromArgb(7, 20, 44);
            tpUserInfo.Controls.Add(pictureBox4);
            tpUserInfo.Controls.Add(btnSave);
            tpUserInfo.Controls.Add(btnBack2);
            tpUserInfo.Controls.Add(txtLastname);
            tpUserInfo.Controls.Add(label6);
            tpUserInfo.Controls.Add(txtFirstname);
            tpUserInfo.Controls.Add(cbRole);
            tpUserInfo.Controls.Add(label4);
            tpUserInfo.Controls.Add(label3);
            tpUserInfo.Location = new Point(4, 5);
            tpUserInfo.Name = "tpUserInfo";
            tpUserInfo.Padding = new Padding(3);
            tpUserInfo.Size = new Size(631, 242);
            tpUserInfo.TabIndex = 2;
            tpUserInfo.Text = "tpUserInfo";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.card;
            pictureBox4.Location = new Point(521, -13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(137, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(230, 172, 38);
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(191, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(231, 38);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack2
            // 
            btnBack2.BackgroundImage = Properties.Resources.left_arrow;
            btnBack2.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack2.FlatAppearance.BorderSize = 0;
            btnBack2.FlatStyle = FlatStyle.Flat;
            btnBack2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBack2.ForeColor = Color.CornflowerBlue;
            btnBack2.Location = new Point(3, 3);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(36, 29);
            btnBack2.TabIndex = 25;
            btnBack2.UseVisualStyleBackColor = true;
            btnBack2.Click += btnBack2_Click;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(393, 60);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(129, 23);
            txtLastname.TabIndex = 19;
            txtLastname.Validating += textBox1_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(42, 133);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 18;
            label6.Text = "Role";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(87, 60);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(129, 23);
            txtFirstname.TabIndex = 16;
            txtFirstname.Validating += textBox1_Validating;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Manager", "Employee" });
            cbRole.Location = new Point(87, 130);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(121, 23);
            cbRole.TabIndex = 4;
            cbRole.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(318, 62);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 1;
            label4.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 66);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 0;
            label3.Text = "FirstName";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(676, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 20;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 8);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 19;
            label1.Text = "Add";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(344, 7);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 18;
            label5.Text = "User";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.user__1_;
            pictureBox2.Location = new Point(236, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.padlock;
            pictureBox5.Location = new Point(126, 30);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.padlock;
            pictureBox6.Location = new Point(126, 99);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(23, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.mail;
            pictureBox7.Location = new Point(144, 63);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(23, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 35;
            pictureBox7.TabStop = false;
            // 
            // frmAddNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(11, 113, 254);
            ClientSize = new Size(732, 405);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddNewUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddNewUser";
            Load += frmAddNewUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcNewAccount.ResumeLayout(false);
            tpEmail.ResumeLayout(false);
            tpEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpPassword.ResumeLayout(false);
            tpPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpecialCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLetter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCharactares).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tpUserInfo.ResumeLayout(false);
            tpUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label7;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private CheckBox checkBox1;
        private Button btnNext1;
        private TabControl tcNewAccount;
        private TabPage tpEmail;
        private TabPage tpPassword;
        private Label label2;
        private TextBox txtConfirmPassword;
        private TabPage tpUserInfo;
        private TextBox txtFirstname;
        private ComboBox cbRole;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox txtLastname;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
        private Button btnNext2;
        private Button btnBack2;
        private Button btnSave;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label12;
        private PictureBox pbSpecialCharacters;
        private PictureBox pbNumber;
        private PictureBox pbLetter;
        private PictureBox pbCharactares;
        private Button button1;
        private Button btnClose;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}