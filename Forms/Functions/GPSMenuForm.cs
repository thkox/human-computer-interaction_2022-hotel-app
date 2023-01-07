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
    //private Panel GPSMenuTabs;

    //private Form currentChildForm;

    public partial class GPSMenuForm : Form
    {

        private Panel GPSMenuTabs;

        private Form currentChildForm;
        public GPSMenuForm()
        {
            InitializeComponent();
        }

        private void GPSMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            gpsLoadFormsPanel = GPSMenuTabs;
            backPictureBox.Hide();
        }
    }
}
