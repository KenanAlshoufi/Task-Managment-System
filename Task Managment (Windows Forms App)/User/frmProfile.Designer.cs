namespace Task_Managment__Windows_Forms_App_
{
    partial class frmProfile
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
            pbImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pbVerified = new PictureBox();
            lblIsActive = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblRole = new Label();
            lblUserID = new Label();
            label6 = new Label();
            llSetPhoto = new LinkLabel();
            ofdSelectImage = new OpenFileDialog();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVerified).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.Transparent;
            pbImage.Image = Properties.Resources.user;
            pbImage.Location = new Point(6, 71);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(197, 175);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(218, 84);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 1;
            label1.Text = "Full Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(218, 132);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 2;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(219, 182);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 3;
            label3.Text = "Role : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(218, 231);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 4;
            label4.Text = "Is Active : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(9, 45);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 5;
            label5.Text = "User ID : ";
            // 
            // pbVerified
            // 
            pbVerified.BackColor = Color.Transparent;
            pbVerified.Image = Properties.Resources.check;
            pbVerified.Location = new Point(294, 82);
            pbVerified.Name = "pbVerified";
            pbVerified.Size = new Size(24, 22);
            pbVerified.SizeMode = PictureBoxSizeMode.Zoom;
            pbVerified.TabIndex = 6;
            pbVerified.TabStop = false;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsActive.Location = new Point(293, 232);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(27, 17);
            lblIsActive.TabIndex = 7;
            lblIsActive.Text = "Yes";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(322, 84);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(271, 132);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(124, 17);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "User@Examble.com";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(260, 182);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(65, 17);
            lblRole.TabIndex = 10;
            lblRole.Text = "Employee";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(73, 46);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(22, 17);
            lblUserID.TabIndex = 11;
            lblUserID.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(73, 173, 244);
            label6.Location = new Point(276, 3);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 13;
            label6.Text = "Profile";
            // 
            // llSetPhoto
            // 
            llSetPhoto.AutoSize = true;
            llSetPhoto.LinkColor = Color.FromArgb(73, 173, 244);
            llSetPhoto.Location = new Point(70, 250);
            llSetPhoto.Name = "llSetPhoto";
            llSetPhoto.Size = new Size(64, 17);
            llSetPhoto.TabIndex = 14;
            llSetPhoto.TabStop = true;
            llSetPhoto.Text = "Set Photo";
            llSetPhoto.LinkClicked += llSetPhoto_LinkClicked;
            // 
            // ofdSelectImage
            // 
            ofdSelectImage.FileName = "ofdSelectImage";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(73, 173, 244);
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(537, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 37);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(605, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 19;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(639, 284);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(llSetPhoto);
            Controls.Add(label6);
            Controls.Add(lblUserID);
            Controls.Add(lblRole);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblIsActive);
            Controls.Add(pbVerified);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbImage);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmProfile";
            Load += frmProfile_Load;
            MouseDown += frmProfile_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVerified).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pbVerified;
        private Label lblIsActive;
        private Label lblName;
        private Label lblEmail;
        private Label lblRole;
        private Label lblUserID;
        private Label label6;
        private LinkLabel llSetPhoto;
        private OpenFileDialog ofdSelectImage;
        private Button btnSave;
        private Button btnClose;
    }
}