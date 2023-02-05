using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Forms.Functions
{
    public partial class OrderStatusForm : Form
    {
        int steps = 1;

        public delegate void EventCompleted(object sender, EventArgs e);
        public event EventCompleted EventCompletedEnd;

        public OrderStatusForm()
        {
            InitializeComponent();
        }

        private void OrderStatusForm_Load(object sender, EventArgs e)
        {
            progressTimer.Start();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            steps += 1;
            if (steps == 2)
            {
                step2PictureBox.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                step2PictureBox.IconColor = Color.White;
                step2Label.ForeColor = Color.White;
                progressPictureBox.Size = new Size(130, 28);
            }
            else if (steps == 3)
            {
                step3PictureBox.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                step3Label.ForeColor = Color.White;
                step3PictureBox.IconColor = Color.White;
                progressPictureBox.Size = new Size(260, 28);
            }
            else if (steps == 4)
            {
                step4PictureBox.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                step4Label.ForeColor = Color.White;
                step4PictureBox.IconColor = Color.White;
                progressPictureBox.Size = new Size(390, 28);
            }
            else if (steps == 5)
            {
                step5PictureBox.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                step5Label.ForeColor = Color.White;
                step5PictureBox.IconColor = Color.White;
                progressPictureBox.Size = new Size(520, 28);
            }
            else if (steps == 6)
            {
                step6PictureBox.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                step6Label.ForeColor = Color.White;
                step6PictureBox.IconColor = Color.White;
                progressPictureBox.Size = new Size(650, 28);
            }
            else
            {
                progressTimer.Stop();
                EventCompletedEnd?.Invoke(this, EventArgs.Empty);
                this.Hide();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
