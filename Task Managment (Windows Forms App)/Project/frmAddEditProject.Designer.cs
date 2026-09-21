namespace Task_Managment__Windows_Forms_App_
{
    partial class frmAddEditProject
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
            label3 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblCreatedDate = new Label();
            lblManager = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            btnSave = new Button();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(75, 104, 154);
            label3.Location = new Point(434, 88);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 25;
            label3.Text = "Assigned To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(75, 104, 154);
            label1.Location = new Point(434, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 23;
            label1.Text = "CreatedData";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.folder;
            pictureBox5.Location = new Point(17, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user__1_;
            pictureBox3.Location = new Point(409, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar__1_;
            pictureBox1.Location = new Point(408, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedDate.ForeColor = Color.White;
            lblCreatedDate.Location = new Point(434, 44);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(71, 13);
            lblCreatedDate.TabIndex = 8;
            lblCreatedDate.Text = "CreatedData";
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManager.ForeColor = Color.White;
            lblManager.ImageAlign = ContentAlignment.MiddleLeft;
            lblManager.Location = new Point(436, 101);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(35, 17);
            lblManager.TabIndex = 17;
            lblManager.Text = "User";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(21, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(40, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 22, 46);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblCreatedDate);
            panel1.Controls.Add(lblManager);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(18, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 210);
            panel1.TabIndex = 20;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(11, 113, 254);
            btnClose.Location = new Point(364, 165);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.No;
            btnClose.Size = new Size(89, 33);
            btnClose.TabIndex = 4;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(11, 113, 254);
            btnSave.Location = new Point(464, 165);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 33);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(94, 48);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(233, 23);
            txtTitle.TabIndex = 1;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(94, 85);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(259, 65);
            txtDescription.TabIndex = 2;
            txtDescription.Validating += txtTitle_Validating;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.Gainsboro;
            lblDescription.Location = new Point(20, 87);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(11, 113, 254);
            ClientSize = new Size(607, 209);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddEditProject";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmEditProject";
            Load += frmEditProject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label lblCreatedDate;
        private Label lblManager;
        private Label lblTitle;
        private Panel panel1;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Button btnSave;
        private Label lblDescription;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}