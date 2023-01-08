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
    public partial class CourtyardZeusForm : Form
    {
        bool moveRight, moveLeft, moveUp, moveDown;//if we delete the timer then we can delete these bools
        int speed = 12;

        private OlymposGardensForm olymposGardensForm = new OlymposGardensForm();
        public CourtyardZeusForm()
        {
            InitializeComponent();
            parkingButton.Enabled = false;
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            //Movement Bounds
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

            
            //Enable form transition
            if (trojan1PictureBox.Bounds.IntersectsWith(LeftTransitionPictureBox.Bounds) == true)
            {
                //this.Hide();
                
            }
            

        }

        private void ChangePark(Form childForm) 
        {
            this.AddOwnedForm(olymposGardensForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //gpsLoadFormsPanel.Controls.Add(childForm);
            //gpsLoadFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) 
            {
                moveLeft = true;
                trojan1PictureBox.Image = hotel_app.Properties.Resources.trojan_horse_reversed;
            }
            if (e.KeyCode == Keys.Right) 
            {
                moveRight = true;
                trojan1PictureBox.Image = hotel_app.Properties.Resources.trojan;
            }
            if (e.KeyCode == Keys.Down) 
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }
        }
    }
}
