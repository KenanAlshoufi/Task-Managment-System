namespace Task_Managment__Windows_Forms_App_
{
    partial class ctrlViewProject
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
            pbEdit = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblDescription = new Label();
            lblCreatedDate = new Label();
            lblManager = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            pbAddTask = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddTask).BeginInit();
            SuspendLayout();
            // 
            // pbEdit
            // 
            pbEdit.Image = Properties.Resources.pen;
            pbEdit.Location = new Point(453, 92);
            pbEdit.Name = "pbEdit";
            pbEdit.Size = new Size(35, 35);
            pbEdit.SizeMode = PictureBoxSizeMode.Zoom;
            pbEdit.TabIndex = 30;
            pbEdit.TabStop = false;
            pbEdit.Visible = false;
            pbEdit.Click += pbEdit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(75, 104, 154);
            label3.Location = new Point(318, 137);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 25;
            label3.Text = "Assigned To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(75, 104, 154);
            label1.Location = new Point(109, 136);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 23;
            label1.Text = "CreatedData";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.folder;
            pictureBox5.Location = new Point(31, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user__1_;
            pictureBox3.Location = new Point(295, 143);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar__1_;
            pictureBox1.Location = new Point(83, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = Color.Gainsboro;
            lblDescription.Location = new Point(113, 23);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(324, 104);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedDate.ForeColor = Color.White;
            lblCreatedDate.Location = new Point(109, 152);
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
            lblManager.Location = new Point(323, 149);
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
            lblTitle.Location = new Point(92, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(40, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 22, 46);
            panel1.Controls.Add(pbAddTask);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pbEdit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblCreatedDate);
            panel1.Controls.Add(lblManager);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(18, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 213);
            panel1.TabIndex = 19;
            // 
            // pbAddTask
            // 
            pbAddTask.Image = Properties.Resources.plus;
            pbAddTask.Location = new Point(507, 92);
            pbAddTask.Name = "pbAddTask";
            pbAddTask.Size = new Size(35, 35);
            pbAddTask.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddTask.TabIndex = 32;
            pbAddTask.TabStop = false;
            pbAddTask.Visible = false;
            pbAddTask.Click += pbAddTask_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(498, 132);
            label6.Name = "label6";
            label6.Size = new Size(54, 13);
            label6.TabIndex = 31;
            label6.Text = "Add Task";
            label6.Visible = false;
            // 
            // ctrlViewProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 113, 254);
            Controls.Add(panel1);
            Name = "ctrlViewProject";
            Size = new Size(605, 213);
            Load += ctrlViewProject_Load;
            ((System.ComponentModel.ISupportInitialize)pbEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddTask).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbEdit;
        private PictureBox pictureBox7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblManager;
        private Label label1;
        private PictureBox pictureBox5;

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblDescription;
        private Label lblCreatedDate;
        private Label lblPriority;
        private Label lblTitle;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel1;
        private PictureBox pbAddTask;
        private Label label6;
    }
}
