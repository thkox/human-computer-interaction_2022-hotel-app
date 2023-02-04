using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace hotel_app.Forms.Functions
{
    public partial class ParkingForm : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;//if we delete the timer then we can delete these bools
        int speed = 12;

        public delegate void TrojanParkingEventHandler(object sender, EventArgs e);
        public event TrojanParkingEventHandler Parking;

        public ParkingForm()
        {
            InitializeComponent();
            parkingButton.Enabled = false;
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            //Movement Bounds Zeus
            if (moveLeft == true && trojan1PictureBox.Left > 60) 
            {
                trojan1PictureBox.Left -= speed;
            }
            if (moveRight == true && trojan1PictureBox.Left < 919)
            {
                trojan1PictureBox.Left += speed;
            }
            if (moveUp == true && trojan1PictureBox.Top > 32)
            {
                trojan1PictureBox.Top -= speed;
            }
            if (moveDown == true && trojan1PictureBox.Top < 560)//maybe < 550
            {
                trojan1PictureBox.Top += speed;
            }            

            //Enable Auto Parking
            if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot1.Bounds) == true)
            {
                parkingButton.Enabled = true;
            }
            else if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot3.Bounds) == true)
            {
                parkingButton.Enabled = true;
            }
            else if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot5.Bounds) == true)
            {
                parkingButton.Enabled = true;
            }
            else parkingButton.Enabled = false;

            //Enable Auto parking
            if (trojan4PictureBox.Bounds.IntersectsWith(parkingSlot6.Bounds) == true)
            {
                parkingButton2.Enabled = true;
            }
            else if (trojan4PictureBox.Bounds.IntersectsWith(parkingSlot7.Bounds) == true)
            {
                parkingButton2.Enabled = true;
            }
            else if (trojan4PictureBox.Bounds.IntersectsWith(parkingSlot8.Bounds) == true)
            {
                parkingButton2.Enabled = true;
            }
            else parkingButton2.Enabled = false;


            //Enable form transition
            if (trojan1PictureBox.Bounds.IntersectsWith(leftTransitionPictureBox.Bounds) == true)
            {
                zeusCourtyardPanel.Hide();
                trojan1PictureBox.Location = new Point(173, 263);
                 
                trojan4PictureBox.Location = new Point(807, 251);
                trojan4PictureBox.Image = Properties.Resources.trojan_horse_reversed;
                olymbosGardensPanel.Show();
            }

            if (trojan4PictureBox.Bounds.IntersectsWith(rightTransitionPictureBox.Bounds) == true)
            {
                olymbosGardensPanel.Hide();
                trojan4PictureBox.Location = new Point(807, 251);

                trojan1PictureBox.Location = new Point(173, 263);
                trojan1PictureBox.Image = Properties.Resources.trojan;
                zeusCourtyardPanel.Show();               
            }
        }

        //Movement with joystick
        private void upButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Top > 32)
            {
                trojan1PictureBox.Location = new Point(trojan1PictureBox.Location.X, trojan1PictureBox.Location.Y - speed);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Top < 550)
            {
                trojan1PictureBox.Location = new Point(trojan1PictureBox.Location.X, trojan1PictureBox.Location.Y + speed);
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Left < 919)
            {
                trojan1PictureBox.Location = new Point(trojan1PictureBox.Location.X + speed, trojan1PictureBox.Location.Y);
                trojan1PictureBox.Image = hotel_app.Properties.Resources.trojan;
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Left > 60)
            {
                trojan1PictureBox.Location = new Point(trojan1PictureBox.Location.X - speed, trojan1PictureBox.Location.Y);
                trojan1PictureBox.Image = hotel_app.Properties.Resources.trojan_horse_reversed;
            }
        }

        private void ParkingForm_Load(object sender, EventArgs e)
        {
            //center the parking panel 
            int width = this.Width / 2 - zeusCourtyardPanel.Width / 2;
            int height = this.Height / 2 - zeusCourtyardPanel.Height / 2;
            zeusCourtyardPanel.Location = new Point(width, height);
            zeusCourtyardPanel.Anchor = AnchorStyles.None;
            zeusCourtyardPanel.Show();

            olymbosGardensPanel.Location = new Point(width, height);
            olymbosGardensPanel.Anchor = AnchorStyles.None;
            olymbosGardensPanel.Hide();
        }

        private void downOButton_Click(object sender, EventArgs e)
        {
            if (trojan4PictureBox.Top < 550)
            {
                trojan4PictureBox.Location = new Point(trojan4PictureBox.Location.X, trojan4PictureBox.Location.Y + speed);
            }
        }

        private void rightOButton_Click(object sender, EventArgs e)
        {
            if (trojan4PictureBox.Left < 919)
            {
                trojan4PictureBox.Location = new Point(trojan4PictureBox.Location.X + speed, trojan4PictureBox.Location.Y);
                trojan4PictureBox.Image = hotel_app.Properties.Resources.trojan;
            }
        }

        private void upOButton_Click(object sender, EventArgs e)
        {
            if (trojan4PictureBox.Top > 32)
            {
                trojan4PictureBox.Location = new Point(trojan4PictureBox.Location.X, trojan4PictureBox.Location.Y - speed);
            }
        }

        private void leftOButton_Click(object sender, EventArgs e)
        {
            if (trojan4PictureBox.Left > 60)
            {
                trojan4PictureBox.Location = new Point(trojan4PictureBox.Location.X - speed, trojan4PictureBox.Location.Y);
                trojan4PictureBox.Image = hotel_app.Properties.Resources.trojan_horse_reversed;
            }
        }

        private void parkingButton2_Click(object sender, EventArgs e)
        {
            if (trojan4PictureBox.Bounds.IntersectsWith(parkingSlot6.Bounds) == true)
            {
                trojan4PictureBox.Location = new Point(467, 86);
            }
            else if (trojan4PictureBox.Bounds.IntersectsWith(parkingSlot7.Bounds) == true)
            {
                trojan4PictureBox.Location = new Point(149, 308);
            }
            else if (trojan4PictureBox.Bounds.IntersectsWith(parkingSlot8.Bounds) == true)
            {
                trojan4PictureBox.Location = new Point(467, 505);
            }
            Parking?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void parkingButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot1.Bounds) == true)
            {
                trojan1PictureBox.Location = new Point(882, 45);
            }
            else if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot3.Bounds) == true)
            {
                trojan1PictureBox.Location = new Point(882, 294);
            }
            else if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot5.Bounds) == true)
            {
                trojan1PictureBox.Location = new Point(882, 542);
            }
            Parking?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

    }
}
