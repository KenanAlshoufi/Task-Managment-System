namespace Task_Managment__Windows_Forms_App_
{
    partial class frmProjects
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
            label1 = new Label();
            pictureBox5 = new PictureBox();
            btnAddProject = new Button();
            label6 = new Label();
            btnClose = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 4);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 15;
            label1.Text = "Projects";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.folder;
            pictureBox5.Location = new Point(3, -2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // btnAddProject
            // 
            btnAddProject.BackgroundImage = Properties.Resources.plus;
            btnAddProject.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddProject.FlatAppearance.BorderSize = 0;
            btnAddProject.FlatStyle = FlatStyle.Flat;
            btnAddProject.ForeColor = Color.White;
            btnAddProject.Location = new Point(589, 50);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(32, 28);
            btnAddProject.TabIndex = 33;
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Visible = false;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(570, 81);
            label6.Name = "label6";
            label6.Size = new Size(68, 13);
            label6.TabIndex = 34;
            label6.Text = "Add Project";
            label6.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(607, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 35;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            flowLayoutPanel1.Location = new Point(3, 106);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(635, 423);
            flowLayoutPanel1.TabIndex = 36;
            // 
            // frmProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 20, 44);
            ClientSize = new Size(644, 538);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(btnAddProject);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProjects";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmProjects";
            Load += frmProjects_Load;
            MouseDown += frmProjects_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox5;
        private Button btnAddProject;
        private Label label6;
        private Button btnClose;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}