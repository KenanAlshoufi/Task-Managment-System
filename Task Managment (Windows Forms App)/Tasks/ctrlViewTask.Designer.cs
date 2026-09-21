namespace Task_Managment__Windows_Forms_App_
{
    partial class ctrlTaskView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            label5 = new Label();
            lblDescription = new Label();
            pictureBox4 = new PictureBox();
            lblProject = new Label();
            lblUser = new Label();
            lblDueDate = new Label();
            lblStatus = new Label();
            lblPriority = new Label();
            panel1 = new Panel();
            btnCancell = new Button();
            btnEdit = new Button();
            btnNextStatus = new Button();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pbStatus = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblManager = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(93, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(40, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(75, 104, 154);
            label5.Location = new Point(383, 180);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 2;
            label5.Text = "Manager";
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = Color.Gainsboro;
            lblDescription.Location = new Point(113, 23);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(283, 56);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.google_docs;
            pictureBox4.Location = new Point(43, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProject.ForeColor = Color.White;
            lblProject.ImageAlign = ContentAlignment.MiddleLeft;
            lblProject.Location = new Point(116, 149);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(51, 17);
            lblProject.TabIndex = 7;
            lblProject.Text = "Project";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.ImageAlign = ContentAlignment.MiddleLeft;
            lblUser.Location = new Point(314, 151);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(35, 17);
            lblUser.TabIndex = 17;
            lblUser.Text = "User";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDueDate.ForeColor = Color.White;
            lblDueDate.Location = new Point(111, 102);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(52, 13);
            lblDueDate.TabIndex = 8;
            lblDueDate.Text = "DueDate";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(54, 234, 178);
            lblStatus.Location = new Point(424, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.ForeColor = Color.FromArgb(254, 174, 48);
            lblPriority.Location = new Point(317, 96);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(48, 15);
            lblPriority.TabIndex = 1;
            lblPriority.Text = "Priority";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 22, 46);
            panel1.Controls.Add(btnCancell);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnNextStatus);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pbStatus);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblDueDate);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(lblPriority);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblProject);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblManager);
            panel1.Location = new Point(17, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 213);
            panel1.TabIndex = 18;
            // 
            // btnCancell
            // 
            btnCancell.BackgroundImage = Properties.Resources.bin;
            btnCancell.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancell.FlatAppearance.BorderSize = 0;
            btnCancell.FlatStyle = FlatStyle.Flat;
            btnCancell.Location = new Point(430, 103);
            btnCancell.Name = "btnCancell";
            btnCancell.Size = new Size(38, 32);
            btnCancell.TabIndex = 34;
            btnCancell.UseVisualStyleBackColor = true;
            btnCancell.Visible = false;
            btnCancell.Click += btnCancell_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImage = Properties.Resources.pen;
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(474, 102);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(38, 32);
            btnEdit.TabIndex = 33;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNextStatus
            // 
            btnNextStatus.BackgroundImage = Properties.Resources.play;
            btnNextStatus.BackgroundImageLayout = ImageLayout.Zoom;
            btnNextStatus.FlatAppearance.BorderSize = 0;
            btnNextStatus.FlatStyle = FlatStyle.Flat;
            btnNextStatus.Location = new Point(518, 102);
            btnNextStatus.Name = "btnNextStatus";
            btnNextStatus.Size = new Size(38, 32);
            btnNextStatus.TabIndex = 32;
            btnNextStatus.UseVisualStyleBackColor = true;
            btnNextStatus.Click += btnNextStatus_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.user__1_;
            pictureBox7.Location = new Point(360, 187);
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
            label4.Location = new Point(317, 81);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 26;
            label4.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(75, 104, 154);
            label3.Location = new Point(312, 137);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 25;
            label3.Text = "Assigned To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(75, 104, 154);
            label2.Location = new Point(116, 134);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 24;
            label2.Text = "Project";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(75, 104, 154);
            label1.Location = new Point(111, 86);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 23;
            label1.Text = "DueDate";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.folder;
            pictureBox5.Location = new Point(85, 140);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pbStatus
            // 
            pbStatus.Image = Properties.Resources.circle;
            pbStatus.Location = new Point(413, 11);
            pbStatus.Name = "pbStatus";
            pbStatus.Size = new Size(10, 10);
            pbStatus.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatus.TabIndex = 21;
            pbStatus.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user__1_;
            pictureBox3.Location = new Point(289, 142);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.report;
            pictureBox2.Location = new Point(289, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar__1_;
            pictureBox1.Location = new Point(85, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManager.ForeColor = Color.White;
            lblManager.ImageAlign = ContentAlignment.MiddleLeft;
            lblManager.Location = new Point(383, 193);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(35, 17);
            lblManager.TabIndex = 29;
            lblManager.Text = "User";
            // 
            // ctrlTaskView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 113, 254);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(panel1);
            Name = "ctrlTaskView";
            Size = new Size(599, 209);
            Load += ctrlTaskView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label label5;
        private Label lblDescription;
        private PictureBox pictureBox4;
        private Label lblUser;
        private Label lblDueDate;
        private Label lblProject;
        private Label lblPriority;
        private Label lblStatus;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pbStatus;
        private PictureBox pictureBox5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox7;
        private Label lblManager;
        private Button btnCancell;
        private Button btnEdit;
        private Button btnNextStatus;
    }
}
