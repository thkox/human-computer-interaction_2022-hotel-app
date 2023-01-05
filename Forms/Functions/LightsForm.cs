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
            if (iconButton1.IconColor == System.Drawing.Color.Black) 
            {
                iconButton1.IconColor = System.Drawing.Color.Yellow;
            }
        }
    }
}
