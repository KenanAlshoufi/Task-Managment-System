namespace Task_Managment__Windows_Forms_App_.Tasks
{
    partial class frmManagmentTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagmentTasks));
            label1 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ctrlStatisticCard4 = new ctrlStatisticCard();
            ctrlStatisticCard3 = new ctrlStatisticCard();
            ctrlStatisticCard2 = new ctrlStatisticCard();
            ctrlStatisticCard1 = new ctrlStatisticCard();
            cbFilter = new ComboBox();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblManagerName = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 3);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 16;
            label1.Text = "Managment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(200, 3);
            label5.Name = "label5";
            label5.Size = new Size(63, 32);
            label5.TabIndex = 15;
            label5.Text = "Task";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.tasks;
            pictureBox2.Location = new Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // ctrlStatisticCard4
            // 
            ctrlStatisticCard4.AccentColor = Color.Gray;
            ctrlStatisticCard4.BackColor = Color.White;
            ctrlStatisticCard4.CardIcon = Properties.Resources.bin;
            ctrlStatisticCard4.CardTitle = "Cancelled";
            ctrlStatisticCard4.CardValue = "0";
            ctrlStatisticCard4.Location = new Point(630, 122);
            ctrlStatisticCard4.Name = "ctrlStatisticCard4";
            ctrlStatisticCard4.Size = new Size(185, 99);
            ctrlStatisticCard4.Status = "Pending";
            ctrlStatisticCard4.TabIndex = 27;
            // 
            // ctrlStatisticCard3
            // 
            ctrlStatisticCard3.AccentColor = Color.White;
            ctrlStatisticCard3.BackColor = Color.White;
            ctrlStatisticCard3.CardIcon = Properties.Resources.play;
            ctrlStatisticCard3.CardTitle = "Work";
            ctrlStatisticCard3.CardValue = "0";
            ctrlStatisticCard3.Location = new Point(424, 122);
            ctrlStatisticCard3.Name = "ctrlStatisticCard3";
            ctrlStatisticCard3.Size = new Size(185, 99);
            ctrlStatisticCard3.Status = "Pending end InProgress";
            ctrlStatisticCard3.TabIndex = 26;
            // 
            // ctrlStatisticCard2
            // 
            ctrlStatisticCard2.AccentColor = Color.FromArgb(9, 112, 254);
            ctrlStatisticCard2.BackColor = Color.White;
            ctrlStatisticCard2.CardIcon = Properties.Resources.checklist;
            ctrlStatisticCard2.CardTitle = "Completed";
            ctrlStatisticCard2.CardValue = "0";
            ctrlStatisticCard2.Location = new Point(217, 122);
            ctrlStatisticCard2.Name = "ctrlStatisticCard2";
            ctrlStatisticCard2.Size = new Size(185, 99);
            ctrlStatisticCard2.Status = "Completed";
            ctrlStatisticCard2.TabIndex = 25;
            // 
            // ctrlStatisticCard1
            // 
            ctrlStatisticCard1.AccentColor = Color.White;
            ctrlStatisticCard1.BackColor = Color.White;
            ctrlStatisticCard1.CardIcon = (Image)resources.GetObject("ctrlStatisticCard1.CardIcon");
            ctrlStatisticCard1.CardTitle = "Total Tasks";
            ctrlStatisticCard1.CardValue = "0";
            ctrlStatisticCard1.Location = new Point(12, 122);
            ctrlStatisticCard1.Name = "ctrlStatisticCard1";
            ctrlStatisticCard1.Size = new Size(185, 99);
            ctrlStatisticCard1.Status = "All";
            ctrlStatisticCard1.TabIndex = 24;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "All", "Pending & InProgress", "Completed", "Cancelled" });
            cbFilter.Location = new Point(694, 240);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 23;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(68, 246);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 21;
            label3.Text = "Recent Tasks";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(111, 268);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(636, 280);
            flowLayoutPanel1.TabIndex = 22;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblManagerName
            // 
            lblManagerName.AutoSize = true;
            lblManagerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagerName.ForeColor = Color.White;
            lblManagerName.Location = new Point(589, 8);
            lblManagerName.Name = "lblManagerName";
            lblManagerName.Size = new Size(117, 20);
            lblManagerName.TabIndex = 28;
            lblManagerName.Text = "Manager Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(555, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(801, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 36;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmManagmentTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(833, 552);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(lblManagerName);
            Controls.Add(ctrlStatisticCard4);
            Controls.Add(ctrlStatisticCard3);
            Controls.Add(ctrlStatisticCard2);
            Controls.Add(ctrlStatisticCard1);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManagmentTasks";
            Text = "frmManagmentTasks";
            Load += frmManagmentTasks_Load;
            MouseDown += frmManagmentTasks_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private PictureBox pictureBox2;
        private ctrlStatisticCard ctrlStatisticCard4;
        private ctrlStatisticCard ctrlStatisticCard3;
        private ctrlStatisticCard ctrlStatisticCard2;
        private ctrlStatisticCard ctrlStatisticCard1;
        private ComboBox cbFilter;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblManagerName;
        private PictureBox pictureBox1;
        private Button btnClose;
    }
}