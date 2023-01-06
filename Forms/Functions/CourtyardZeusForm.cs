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
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 12;
        public CourtyardZeusForm()
        {
            InitializeComponent();
            parkingButton.Enabled = false;
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            //Movement Bounds
            if (moveLeft == true && trojan1PictureBox.Left > 53) 
            {
                trojan1PictureBox.Left -= speed;
            }
            if (moveRight == true && trojan1PictureBox.Left < 750)
            {
                trojan1PictureBox.Left += speed;
            }
            if (moveUp == true && trojan1PictureBox.Top > 32)
            {
                trojan1PictureBox.Top -= speed;
            }
            if (moveDown == true && trojan1PictureBox.Top < 560)
            {
                trojan1PictureBox.Top += speed;
            }

            //Enable Auto Parking
            
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) 
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right) 
            {
                moveRight = true;
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
