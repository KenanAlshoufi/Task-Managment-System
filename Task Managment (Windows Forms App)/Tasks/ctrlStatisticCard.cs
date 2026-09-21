using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Managment__Windows_Forms_App_
{
    public partial class ctrlStatisticCard : UserControl
    {
        public ctrlStatisticCard()
        {
            InitializeComponent();
        }



        public string CardTitle
        { 
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value;
            }

        }
        public string CardValue
        {
            get { return lblNumber.Text; }
            set
            {
                lblNumber.Text = value;
            }

        }
        public Image CardIcon
        {
            get { return pbStatusTask.Image; }
            set
            {
                pbStatusTask.Image = value;
            }

        }
        public Color AccentColor
        {
            get { return lblStatus.ForeColor; }
            set
            {
                lblStatus.ForeColor = value;
            }
        }

        public string Status
        {
            get { return lblStatus.Text; }
            set
            {
                lblStatus.Text = value;
            }

        }


    }
}
