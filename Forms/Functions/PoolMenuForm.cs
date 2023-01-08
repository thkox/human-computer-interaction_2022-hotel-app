using Microsoft.VisualBasic.Devices;
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
    public partial class PoolMenuForm : Form
    {
        private Panel poolMenuTabs;

        private Form currentChildForm;

        public ThermostatForm poolThermostat = new ThermostatForm();
        public WaterLevelForm waterLevel = new WaterLevelForm();
        private SensorForm sensor = new SensorForm();

        public PoolMenuForm()
        {
            InitializeComponent();
        }

        private void OpenPoolFunctionForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            poolLoadFormsPanel.Controls.Add(childForm);
            poolLoadFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PoolMenuForm_Load(object sender, EventArgs e)
        {
            poolMenuTabs = poolLoadFormsPanel;
            backPictureBox.Hide();
        }

        private void waterLevelButton_Click(object sender, EventArgs e)
        {
            OpenPoolFunctionForm(waterLevel);
            backPictureBox.Show();
        }

        private void thermostatButton_Click(object sender, EventArgs e)
        {
            OpenPoolFunctionForm(poolThermostat);
            backPictureBox.Show();
        }

        private void sensorButton_Click(object sender, EventArgs e)
        {
            OpenPoolFunctionForm(sensor);
            backPictureBox.Show();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            poolLoadFormsPanel = poolMenuTabs;
            backPictureBox.Hide();
        }
    }
}
