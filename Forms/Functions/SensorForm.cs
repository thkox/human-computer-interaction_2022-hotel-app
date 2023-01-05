using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using HorizontalAlignment = System.Windows.Forms.HorizontalAlignment;

namespace hotel_app.Forms.Functions
{
    public partial class SensorForm : Form
    {
        private bool sensorState = false;
        private bool alarmState = false;
        private int humans = 0;

        public SensorForm()
        {
            InitializeComponent();
        }

        private void SensorForm_Load(object sender, EventArgs e)
        {
            TurnOffAlarm();
        }
        private void sernsorButton_Click(object sender, EventArgs e)
        {
            if(sensorState)
            {
                sensorState = false;
                TurnOffSensor();
            }
            else
            {
                sensorState = true;
                TurnOnSensor();
            }
        }

        private void TurnOffSensor()
        {
            sensorPanelRichTextBox.Text = System.Environment.NewLine + "Sensor is OFF";
            sensorPanelRichTextBox.SelectAll();
            sensorPanelRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            sensorPanelRichTextBox.DeselectAll();
            sensorPanelRichTextBox.BackColor = Color.Red;
            sensorPanelRichTextBox.ForeColor = Color.White;
            alarmButton.Enabled = false;
        }

        private void TurnOnSensor()
        {
            sensorPanelRichTextBox.Text = System.Environment.NewLine + "Sensor is On" +
                System.Environment.NewLine + $"Detecting: {humans} humans";
            sensorPanelRichTextBox.SelectAll();
            sensorPanelRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            sensorPanelRichTextBox.DeselectAll();
            sensorPanelRichTextBox.BackColor = Color.Green;
            sensorPanelRichTextBox.ForeColor = Color.White;
            alarmButton.Enabled = true;
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            if (sensorState)
            {
                sensorState = false;
                TurnOffAlarm();
            }
            else
            {
                sensorState = true;
                TurnOnAlarm();
            }
        }

        private void TurnOnAlarm()
        {
            sensorPanelRichTextBox.Text += System.Environment.NewLine + "Alarm is on";
            sensorPanelRichTextBox.SelectAll();
            sensorPanelRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            sensorPanelRichTextBox.DeselectAll();
        }

        private void TurnOffAlarm()
        {
            TurnOnSensor();
        }

    }
}
