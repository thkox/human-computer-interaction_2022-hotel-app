using FontAwesome.Sharp;
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
    public partial class LightsForm : Form
    {
        public LightsForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void changeStateOfLight(IconButton light)
        {
            if (light.IconColor == Color.FromArgb(236, 241, 246))
            {
                light.IconColor = Color.Yellow;
            }
            else light.IconColor = Color.FromArgb(236, 241, 246);
        }

        private void lightButton1_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);
        }

        private void lightButton2_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);
        }

        private void lightButton3_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);
        }

        private void changeBackcolorOnMouseHover(IconButton light)
        {
            light.BackColor = Color.FromArgb(96, 144, 191);
        }
    }
}
