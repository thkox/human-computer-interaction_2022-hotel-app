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
        public RoomsForm rooms = new RoomsForm();

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
            backPictureBox2.Hide();

            poolMenu.waterLevelButton.Click += new EventHandler(poolMenuButton_Click);
            poolMenu.thermostatButton.Click += new EventHandler(poolMenuButton_Click);
            poolMenu.sensorButton.Click += new EventHandler(poolMenuButton_Click);
            
            poolMenu.backPictureBox.Click += new EventHandler(backButton_Click);
            
            
            //same actions for rooms button

            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backPictureBox2.Show();
        }
        
        private void poolMenuButton_Click(object sender, EventArgs e)
        {
            backPictureBox2.Hide();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            zeusPalaceLoadFormsPanel = ZeusPalaceMenuTabs;
            backPictureBox2.Hide();
        }

        private void publicPoolButton_Click(object sender, EventArgs e)
        {
            OpenZeusPalaceMenuFunctionForm(poolMenu);
            backPictureBox2.Show();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            OpenZeusPalaceMenuFunctionForm(rooms);
            backPictureBox2.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        //create an Event Listener to Hide the ZeusPalaceMenuForm.backPictureBox when the publicPoolButton_Click is triggered.
    }
}
