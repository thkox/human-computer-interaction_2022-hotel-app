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
        private bool humansState = true;

        public SensorForm()
        {
            InitializeComponent();
        }

        private void SensorForm_Load(object sender, EventArgs e)
        {
            TurnOffSensor();
        }
        private void sernorButton_Click(object sender, EventArgs e)
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
            alarmState = false;
            alarmButton.Enabled = false;
        }

        private void TurnOnSensor()
        {
            sensorPanelRichTextBox.Text = System.Environment.NewLine + "Sensor is ON";
            if(!alarmState)
            {
                sensorPanelRichTextBox.Text += System.Environment.NewLine + "Alarm is OFF";
            }
            if (humansState)
            {
                sensorPanelRichTextBox.Text += System.Environment.NewLine + "Humans Detected";
            }
            else
            {
                sensorPanelRichTextBox.Text += System.Environment.NewLine + "DetectingHumans";
            }
                
            sensorPanelRichTextBox.SelectAll();
            sensorPanelRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            sensorPanelRichTextBox.DeselectAll();
            sensorPanelRichTextBox.BackColor = Color.Green;
            sensorPanelRichTextBox.ForeColor = Color.White;
            alarmButton.Enabled = true;
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            if (alarmState)
            {
                alarmState = false;
                TurnOffAlarm();
            }
            else
            {
                alarmState = true;
                TurnOnAlarm();
            }
        }

        private void TurnOnAlarm()
        {
            sensorPanelRichTextBox.Text = System.Environment.NewLine + "Sensor is ON";
            if (humansState)
            {
                sensorPanelRichTextBox.Text += System.Environment.NewLine + "Alarm is ON"
                    + System.Environment.NewLine + "HUMANS DETECTED!"
                    + System.Environment.NewLine + "Please CALL Security!";
            }
            else
            {
                sensorPanelRichTextBox.Text += System.Environment.NewLine + "Detecting humans"
                    + System.Environment.NewLine + "Alarm is ON";
            }
            sensorPanelRichTextBox.SelectAll();
            sensorPanelRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            sensorPanelRichTextBox.DeselectAll();
            sensorPanelRichTextBox.BackColor = Color.Orange;
        }

        private void TurnOffAlarm()
        {
            TurnOnSensor();
        }

        private void sensorButton_EnabledChanged(object sender, EventArgs e)
        {
            if (!sensorButton.Enabled)
            {
                sensorButton.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                sensorButton.BackColor = Color.FromArgb(79, 134, 184);
            }
        }

        private void alarmButton_EnabledChanged(object sender, EventArgs e)
        {
            if (!alarmButton.Enabled)
            {
                alarmButton.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                alarmButton.BackColor = Color.FromArgb(79, 134, 184);
            }
        }
    }
}
