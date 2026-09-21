namespace Task_Managment__Windows_Forms_App_
{
    partial class frmAddTask
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
            pictureBox7 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            btnClose = new Button();
            lblNameProject = new Label();
            lblUserID = new Label();
            btnSave = new Button();
            llSetUser = new LinkLabel();
            cbPriority = new ComboBox();
            dtpDueDate = new DateTimePicker();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            lblUserManager = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.user__1_;
            pictureBox7.Location = new Point(390, 10);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(22, 20);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 28;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(75, 104, 154);
            label4.Location = new Point(323, 82);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 26;
            label4.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(75, 104, 154);
            label3.Location = new Point(321, 131);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 25;
            label3.Text = "Assigned To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(75, 104, 154);
            label2.Location = new Point(97, 134);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 24;
            label2.Text = "Project";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(75, 104, 154);
            label1.Location = new Point(92, 84);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 23;
            label1.Text = "DueDate";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.folder;
            pictureBox5.Location = new Point(67, 138);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user__1_;
            pictureBox3.Location = new Point(295, 136);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.report;
            pictureBox2.Location = new Point(296, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar__1_;
            pictureBox1.Location = new Point(67, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(75, 104, 154);
            label12.Location = new Point(413, 3);
            label12.Name = "label12";
            label12.Size = new Size(61, 17);
            label12.TabIndex = 2;
            label12.Text = "Manager";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.google_docs;
            pictureBox4.Location = new Point(49, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 22, 46);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblNameProject);
            panel1.Controls.Add(lblUserID);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(llSetUser);
            panel1.Controls.Add(cbPriority);
            panel1.Controls.Add(dtpDueDate);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblUserManager);
            panel1.Location = new Point(18, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 213);
            panel1.TabIndex = 19;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(11, 113, 254);
            btnClose.Location = new Point(345, 173);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 33);
            btnClose.TabIndex = 40;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // lblNameProject
            // 
            lblNameProject.AutoSize = true;
            lblNameProject.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameProject.ForeColor = Color.White;
            lblNameProject.ImageAlign = ContentAlignment.MiddleLeft;
            lblNameProject.Location = new Point(97, 146);
            lblNameProject.Name = "lblNameProject";
            lblNameProject.Size = new Size(51, 17);
            lblNameProject.TabIndex = 39;
            lblNameProject.Text = "Project";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.White;
            lblUserID.ImageAlign = ContentAlignment.MiddleLeft;
            lblUserID.Location = new Point(378, 144);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(35, 17);
            lblUserID.TabIndex = 38;
            lblUserID.Text = "User";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(11, 113, 254);
            btnSave.Location = new Point(444, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 33);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // llSetUser
            // 
            llSetUser.AutoSize = true;
            llSetUser.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llSetUser.LinkColor = Color.White;
            llSetUser.Location = new Point(323, 146);
            llSetUser.Name = "llSetUser";
            llSetUser.Size = new Size(49, 13);
            llSetUser.TabIndex = 36;
            llSetUser.TabStop = true;
            llSetUser.Text = "Set User";
            llSetUser.LinkClicked += llSetUser_LinkClicked;
            // 
            // cbPriority
            // 
            cbPriority.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPriority.ForeColor = Color.FromArgb(254, 174, 48);
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "Low", "Medum", "High" });
            cbPriority.Location = new Point(326, 99);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(86, 21);
            cbPriority.TabIndex = 35;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(95, 100);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(101, 23);
            dtpDueDate.TabIndex = 34;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(7, 22, 46);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 9F);
            txtDescription.ForeColor = Color.Gainsboro;
            txtDescription.Location = new Point(112, 22);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(270, 58);
            txtDescription.TabIndex = 32;
            txtDescription.Text = "Description";
            txtDescription.Validating += txtDescription_Validating;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(7, 22, 46);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(102, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(221, 20);
            txtTitle.TabIndex = 20;
            txtTitle.Text = "Title";
            txtTitle.Validating += txtDescription_Validating;
            // 
            // lblUserManager
            // 
            lblUserManager.AutoSize = true;
            lblUserManager.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserManager.ForeColor = Color.White;
            lblUserManager.ImageAlign = ContentAlignment.MiddleLeft;
            lblUserManager.Location = new Point(413, 16);
            lblUserManager.Name = "lblUserManager";
            lblUserManager.Size = new Size(35, 17);
            lblUserManager.TabIndex = 29;
            lblUserManager.Text = "User";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddTask
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(11, 113, 254);
            CancelButton = btnClose;
            ClientSize = new Size(566, 213);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddTask";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddTask";
            Load += frmAddTask_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbNextStatus;
        private PictureBox pictureBox7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblDueDate;
        private Label label12;
        private Label lblUser;
        private Label lblUserManager;
        private PictureBox pictureBox4;
        private Label lblProject;
        private Panel panel1;
        private Label label5;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private DateTimePicker dtpDueDate;
        private ComboBox cbPriority;
        private LinkLabel llSetUser;
        private Button btnSave;
        private Label lblUserID;
        private ErrorProvider errorProvider1;
        private Label lblNameProject;
        private Button btnClose;
    }
}