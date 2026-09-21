namespace Task_Managment__Windows_Forms_App_
{
    partial class frmMyTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyTasks));
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            cbFilter = new ComboBox();
            btnClose = new Button();
            ctrlStatisticCard1 = new ctrlStatisticCard();
            ctrlStatisticCard2 = new ctrlStatisticCard();
            ctrlStatisticCard3 = new ctrlStatisticCard();
            ctrlStatisticCard4 = new ctrlStatisticCard();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.tasks;
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(100, 3);
            label5.Name = "label5";
            label5.Size = new Size(63, 32);
            label5.TabIndex = 11;
            label5.Text = "Task";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 3);
            label1.Name = "label1";
            label1.Size = new Size(50, 32);
            label1.TabIndex = 13;
            label1.Text = "My";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(38, 191);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(636, 260);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 6;
            label3.Text = "Recent Tasks";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "All", "Pending & InProgress", "Completed", "Cancelled" });
            cbFilter.Location = new Point(553, 162);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 15;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(888, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlStatisticCard1
            // 
            ctrlStatisticCard1.AccentColor = Color.White;
            ctrlStatisticCard1.BackColor = Color.White;
            ctrlStatisticCard1.CardIcon = (Image)resources.GetObject("ctrlStatisticCard1.CardIcon");
            ctrlStatisticCard1.CardTitle = "Total Tasks";
            ctrlStatisticCard1.CardValue = "0";
            ctrlStatisticCard1.Location = new Point(712, 36);
            ctrlStatisticCard1.Name = "ctrlStatisticCard1";
            ctrlStatisticCard1.Size = new Size(185, 99);
            ctrlStatisticCard1.Status = "All";
            ctrlStatisticCard1.TabIndex = 17;
            // 
            // ctrlStatisticCard2
            // 
            ctrlStatisticCard2.AccentColor = Color.FromArgb(9, 112, 254);
            ctrlStatisticCard2.BackColor = Color.White;
            ctrlStatisticCard2.CardIcon = Properties.Resources.checklist;
            ctrlStatisticCard2.CardTitle = "Completed";
            ctrlStatisticCard2.CardValue = "0";
            ctrlStatisticCard2.Location = new Point(712, 141);
            ctrlStatisticCard2.Name = "ctrlStatisticCard2";
            ctrlStatisticCard2.Size = new Size(185, 99);
            ctrlStatisticCard2.Status = "Completed";
            ctrlStatisticCard2.TabIndex = 18;
            // 
            // ctrlStatisticCard3
            // 
            ctrlStatisticCard3.AccentColor = Color.White;
            ctrlStatisticCard3.BackColor = Color.White;
            ctrlStatisticCard3.CardIcon = Properties.Resources.play;
            ctrlStatisticCard3.CardTitle = "Work";
            ctrlStatisticCard3.CardValue = "0";
            ctrlStatisticCard3.Location = new Point(712, 246);
            ctrlStatisticCard3.Name = "ctrlStatisticCard3";
            ctrlStatisticCard3.Size = new Size(185, 99);
            ctrlStatisticCard3.Status = "Pending end InProgress";
            ctrlStatisticCard3.TabIndex = 19;
            // 
            // ctrlStatisticCard4
            // 
            ctrlStatisticCard4.AccentColor = Color.Gray;
            ctrlStatisticCard4.BackColor = Color.White;
            ctrlStatisticCard4.CardIcon = Properties.Resources.bin;
            ctrlStatisticCard4.CardTitle = "Cancelled";
            ctrlStatisticCard4.CardValue = "0";
            ctrlStatisticCard4.Location = new Point(712, 351);
            ctrlStatisticCard4.Name = "ctrlStatisticCard4";
            ctrlStatisticCard4.Size = new Size(185, 99);
            ctrlStatisticCard4.Status = "Pending";
            ctrlStatisticCard4.TabIndex = 20;
            // 
            // frmMyTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(919, 460);
            Controls.Add(ctrlStatisticCard4);
            Controls.Add(ctrlStatisticCard3);
            Controls.Add(ctrlStatisticCard2);
            Controls.Add(ctrlStatisticCard1);
            Controls.Add(btnClose);
            Controls.Add(cbFilter);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMyTasks";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMyTasks";
            Load += frmMyTasks_Load;
            MouseDown += frmMyTasks_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label5;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private ComboBox cbFilter;
        private Button btnClose;
        private ctrlStatisticCard ctrlStatisticCard1;
        private ctrlStatisticCard ctrlStatisticCard2;
        private ctrlStatisticCard ctrlStatisticCard3;
        private ctrlStatisticCard ctrlStatisticCard4;
    }
}