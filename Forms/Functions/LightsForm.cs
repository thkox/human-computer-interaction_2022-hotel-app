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
            if (lightButton1.IconColor == Color.Black) 
            {
                lightButton1.IconColor = Color.Yellow;
            }
            else lightButton1.IconColor = Color.Black;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (lightButton2.IconColor == Color.Black)
            {
                lightButton2.IconColor = Color.Yellow;
            }
            else lightButton2.IconColor = Color.Black;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (lightButton3.IconColor == Color.Black)
            {
                lightButton3.IconColor = Color.Yellow;
            }
            else lightButton3.IconColor = Color.Black;
        }
    }
}
