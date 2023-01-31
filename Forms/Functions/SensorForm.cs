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
        private void sensorButton_Click(object sender, EventArgs e)
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
            statusRichTextBox.Text = System.Environment.NewLine + "Sensor is OFF";
            statusPictureBox.IconColor = Color.Red;
            alarmState = false;
            alarmButton.Enabled = false;
        }

        private void TurnOnSensor()
        {
            statusRichTextBox.Text = System.Environment.NewLine + "Sensor is ON";
            if(!alarmState)
            {
                statusRichTextBox.Text += System.Environment.NewLine + "Alarm is OFF";
            }
            if (humansState)
            {
                statusRichTextBox.Text += System.Environment.NewLine + "Humans Detected";
            }
            else
            {
                statusRichTextBox.Text += System.Environment.NewLine + "DetectingHumans";
            }
            statusPictureBox.IconColor = Color.Green;
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
            statusRichTextBox.Text = System.Environment.NewLine + "Sensor is ON";
            if (humansState)
            {
                statusRichTextBox.Text += System.Environment.NewLine + "Alarm is Armed"
                    + System.Environment.NewLine + "HUMANS DETECTED!"
                    + System.Environment.NewLine + "Please CALL Security!";
            }
            else
            {
                statusRichTextBox.Text += System.Environment.NewLine + "Detecting humans"
                    + System.Environment.NewLine + "Alarm is Armed";
            }
            statusPictureBox.IconColor = Color.Orange;
        }

        private void TurnOffAlarm()
        {
            TurnOnSensor();
        }

        private void sensorButton_EnabledChanged(object sender, EventArgs e)
        {

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
