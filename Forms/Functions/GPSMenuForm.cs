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

        private Panel GPSMenuTabs = new Panel();

        private CourtyardZeusForm courtyardZeusParking = new CourtyardZeusForm();
        private FacilitiesForm facilities = new FacilitiesForm();

        private Form currentChildForm = new Form();

        public GPSMenuForm()
        {
            InitializeComponent();
        }

        private void  OpenGPSMenuFunctionForm(Form childForm) 
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            gpsLoadFormsPanel.Controls.Add(childForm);
            gpsLoadFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void GPSMenuForm_Load(object sender, EventArgs e)
        {
            GPSMenuTabs = gpsLoadFormsPanel;
            backPictureBox.Hide();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            gpsLoadFormsPanel = GPSMenuTabs;
            backPictureBox.Hide();
        }

        private void changeParkingSlotButton_Click(object sender, EventArgs e)
        {
            OpenGPSMenuFunctionForm(courtyardZeusParking);
            backPictureBox.Show();
        }

        private void availableFacilitiesButton_Click(object sender, EventArgs e)
        {
            OpenGPSMenuFunctionForm(facilities);
            backPictureBox.Show();
        }
    }
}
