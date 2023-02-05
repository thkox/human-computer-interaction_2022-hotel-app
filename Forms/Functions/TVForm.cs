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
    public partial class TVForm : Form
    {
        private bool powerStatus = false;
        private bool timerStatus = false;
        public TVForm()
        {
            InitializeComponent();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            if(powerStatus)
            {
                powerStatus = false;
                ChangeTvStatus("Power Off");
            }
            else
            {
                powerStatus = true;
                ChangeTvStatus("Power On");
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Start");
        }

        private void tvStatusTimer_Tick(object sender, EventArgs e)
        {
            if(timerStatus)
            {
                tvStatusLabel.Text = "";
                checkTVPictureBox.Image = Properties.Resources.powerIdle;
                timerStatus = false;
                tvStatusTimer.Stop();
            }
            else
            {
                timerStatus = true;
            }
        }

        private void TVForm_Load(object sender, EventArgs e)
        {
            tvStatusLabel.Text = "";
        }

        private void movie1PictureBox_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Casting C# Movie");
        }

        private void movie2PictureBox_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Casting Season 3 Episode 1");
        }

        private void movie3PictureBox_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Casting Python Movie");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Back");
        }

        private void volumeUpButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Volume Up");
        }

        private void volumeDownButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Volume Down");
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("OK");
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Left");
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Right");
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Down");
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            ChangeTvStatus("Up");
        }

        private void chechTVPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ChangeTvStatus(string tvStatus)
        {
            tvStatusLabel.Text = tvStatus;
            checkTVPictureBox.Image = Properties.Resources.powerOn;
            if(timerStatus)
            {
                timerStatus = false;
                tvStatusTimer.Stop();
            }
            tvStatusTimer.Start();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
