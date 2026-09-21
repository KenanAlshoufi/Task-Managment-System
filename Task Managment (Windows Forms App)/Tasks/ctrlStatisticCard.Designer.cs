namespace Task_Managment__Windows_Forms_App_
{
    partial class ctrlStatisticCard
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
            panel1 = new Panel();
            lblStatus = new Label();
            lblTitle = new Label();
            lblNumber = new Label();
            pbStatusTask = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatusTask).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 24, 50);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(pbStatusTask);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 93);
            panel1.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(23, 68);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(51, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Pending";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(38, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Total Tasks";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblNumber.ForeColor = Color.FromArgb(230, 172, 38);
            lblNumber.Location = new Point(21, 40);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(18, 19);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "0";
            // 
            // pbStatusTask
            // 
            pbStatusTask.Image = Properties.Resources.tasks;
            pbStatusTask.Location = new Point(3, 4);
            pbStatusTask.Name = "pbStatusTask";
            pbStatusTask.Size = new Size(30, 25);
            pbStatusTask.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusTask.TabIndex = 0;
            pbStatusTask.TabStop = false;
            // 
            // ctrlStatisticCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "ctrlStatisticCard";
            Size = new Size(185, 99);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatusTask).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbStatusTask;
        private Label lblNumber;
        private Label lblTitle;
        private Label lblStatus;
    }
}
