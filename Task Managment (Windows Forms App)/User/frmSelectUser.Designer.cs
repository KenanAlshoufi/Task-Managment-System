namespace Task_Managment__Windows_Forms_App_
{
    partial class frmSelectUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnSelectUser = new Button();
            label1 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            dgvAllUsers = new DataGridView();
            cmsUser = new ContextMenuStrip(components);
            tsmiShowDetails = new ToolStripMenuItem();
            selectUserToolStripMenuItem = new ToolStripMenuItem();
            cbFilter = new ComboBox();
            txtFilter = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllUsers).BeginInit();
            cmsUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSelectUser
            // 
            btnSelectUser.BackgroundImage = Properties.Resources.checklist;
            btnSelectUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnSelectUser.FlatStyle = FlatStyle.Flat;
            btnSelectUser.Location = new Point(699, 158);
            btnSelectUser.Name = "btnSelectUser";
            btnSelectUser.Size = new Size(35, 32);
            btnSelectUser.TabIndex = 19;
            btnSelectUser.UseVisualStyleBackColor = true;
            btnSelectUser.Click += btnSelectUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 3);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 18;
            label1.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(115, 3);
            label5.Name = "label5";
            label5.Size = new Size(152, 32);
            label5.TabIndex = 17;
            label5.Text = "Managment";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.user__1_;
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // dgvAllUsers
            // 
            dgvAllUsers.AllowUserToAddRows = false;
            dgvAllUsers.AllowUserToDeleteRows = false;
            dgvAllUsers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllUsers.ContextMenuStrip = cmsUser;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAllUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAllUsers.Dock = DockStyle.Bottom;
            dgvAllUsers.Location = new Point(0, 208);
            dgvAllUsers.Name = "dgvAllUsers";
            dgvAllUsers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAllUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAllUsers.Size = new Size(755, 213);
            dgvAllUsers.TabIndex = 15;
            // 
            // cmsUser
            // 
            cmsUser.Items.AddRange(new ToolStripItem[] { tsmiShowDetails, selectUserToolStripMenuItem });
            cmsUser.Name = "cmsUser";
            cmsUser.Size = new Size(142, 48);
            // 
            // tsmiShowDetails
            // 
            tsmiShowDetails.Name = "tsmiShowDetails";
            tsmiShowDetails.Size = new Size(141, 22);
            tsmiShowDetails.Text = "Show Details";
            tsmiShowDetails.Click += tsmiShowDetails_Click;
            // 
            // selectUserToolStripMenuItem
            // 
            selectUserToolStripMenuItem.Name = "selectUserToolStripMenuItem";
            selectUserToolStripMenuItem.Size = new Size(141, 22);
            selectUserToolStripMenuItem.Text = "Select User";
            selectUserToolStripMenuItem.Click += selectUserToolStripMenuItem_Click;
            // 
            // cbFilter
            // 
            cbFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFilter.ForeColor = Color.CornflowerBlue;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "UserID", "Name" });
            cbFilter.Location = new Point(12, 176);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 25);
            cbFilter.TabIndex = 20;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilter.Location = new Point(159, 176);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(135, 25);
            txtFilter.TabIndex = 21;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(680, 188);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 22;
            label2.Text = "Select User";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.close;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(722, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 23;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmSelectUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(755, 421);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(btnSelectUser);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(dgvAllUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSelectUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSelectUser";
            Load += frmSelectUser_Load;
            MouseDown += frmSelectUser_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllUsers).EndInit();
            cmsUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectUser;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox2;
        private DataGridView dgvAllUsers;
        private ComboBox cbFilter;
        private TextBox txtFilter;
        private ContextMenuStrip cmsUser;
        private ToolStripMenuItem tsmiShowDetails;
        private ErrorProvider errorProvider1;
        private ToolStripMenuItem selectUserToolStripMenuItem;
        private Label label2;
        private Button btnClose;
    }
}