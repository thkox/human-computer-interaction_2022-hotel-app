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

    public partial class ZeusPalaceMenuForm : Form
    {

        private Panel ZeusPalaceMenuTabs = new Panel();
        private PoolMenuForm poolMenu = new PoolMenuForm();
        private Form currentChildForm = new Form();

        public ZeusPalaceMenuForm()
        {
            InitializeComponent();

            //Parameters for Room Forms
            poolMenu.poolThermostat.thermostatLabel.Text = "Public Pool: Thermostat";
            poolMenu.waterLevel.waterLevelLabel.Text = "Public Pool: Water Level";
        }

        private void  OpenZeusPalaceMenuFunctionForm(Form childForm) 
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            zeusPalaceLoadFormsPanel.Controls.Add(childForm);
            zeusPalaceLoadFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ZeusPalaceMenuForm_Load(object sender, EventArgs e)
        {
            ZeusPalaceMenuTabs = zeusPalaceLoadFormsPanel;
            backPictureBox.Hide();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            zeusPalaceLoadFormsPanel = ZeusPalaceMenuTabs;
            backPictureBox.Hide();
        }

        private void generalPoolButton_Click(object sender, EventArgs e)
        {
            OpenZeusPalaceMenuFunctionForm(poolMenu);
            backPictureBox.Show();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {

        }
    }
}
