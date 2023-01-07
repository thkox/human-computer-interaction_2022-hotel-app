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
    public partial class MainDoorForm : Form
    {
        public MainDoorForm()
        {
            InitializeComponent();
        }

        private void doorAlmostOpenButton_Click(object sender, EventArgs e)
        {
            doorClosed.Enabled = true;
            doorAlmostOpenButton.Enabled = false;
            doorOpenButton.Enabled = true;
        }

        private void doorOpenButton_Click(object sender, EventArgs e)
        {
            doorClosed.Enabled = true;
            doorAlmostOpenButton.Enabled = true;
            doorOpenButton.Enabled = false;
        }

        private void stairsUpButton_Click(object sender, EventArgs e)
        {
            stairsDownButton.Enabled = true;
            stairsUpButton.Enabled = false;
        }

        private void stairsDownButton_Click(object sender, EventArgs e)
        {
            stairsDownButton.Enabled = false;
            stairsUpButton.Enabled = true;
        }

        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!button.Enabled)
            {
                button.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                button.BackColor = Color.FromArgb(79, 134, 184);
            }
        }

        private void doorClosed_Click(object sender, EventArgs e)
        {
            doorClosed.Enabled = false;
            doorAlmostOpenButton.Enabled = true;
            doorOpenButton.Enabled = true;
        }
    }
}
