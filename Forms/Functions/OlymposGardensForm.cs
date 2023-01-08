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
    public partial class OlymposGardensForm : Form
    {
        int speed = 12;
        public OlymposGardensForm()
        {
            InitializeComponent();
            parkingButton.Enabled = false;
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            //Enable Auto parking
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

            //Enable form transition
        }
        //Movement with joystick
        private void upButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Top > 92)
            {
                trojan1PictureBox.Location = new Point(trojan1PictureBox.Location.X, trojan1PictureBox.Location.Y - speed);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Top < 510)
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
            if (trojan1PictureBox.Left > 115)
            {
                trojan1PictureBox.Location = new Point(trojan1PictureBox.Location.X - speed, trojan1PictureBox.Location.Y);
                trojan1PictureBox.Image = hotel_app.Properties.Resources.trojan_horse_reversed;
            }
        }

        private void parkingButton_Click(object sender, EventArgs e)
        {
            if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot1.Bounds) == true)
            {
                trojan1PictureBox.Location = new Point(467, 86);
            }
            else if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot3.Bounds) == true)
            {
                trojan1PictureBox.Location = new Point(149, 308);
            }
            else if (trojan1PictureBox.Bounds.IntersectsWith(parkingSlot5.Bounds) == true)
            {
                trojan1PictureBox.Location = new Point(467, 505);
            }
        }
    }
}
