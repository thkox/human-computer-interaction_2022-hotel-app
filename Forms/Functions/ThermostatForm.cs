﻿using FontAwesome.Sharp;
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
    public partial class ThermostatForm : Form
    {
        int currentThermostatValue = 18;
        int setThermostatValue = 18;
        bool thermostatState = false;
        bool upButtonClicked = false;
        bool downButtonClicked = false;
        public ThermostatForm()
        {
            InitializeComponent();
        }

        private void ThermostatForm_Load(object sender, EventArgs e)
        {
            TurnOFFThermostat();
        }

        private void TurnOFFThermostat()
        {
            thermostatState = false;
            thermostatUpButton.Enabled = false;
            thermostatDownButton.Enabled = false;

            upButtonClicked = false;
            downButtonClicked = false;
            setValueTimer.Stop();

            leafPictureBox.Visible = false;
            
            currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
            setTempValueLabel.Text = "OFF";
            setTempValueLabel.Left = (thermostatPanel.Width - setTempValueLabel.Width) / 2;
            setTempValueLabel.ForeColor = Color.Red;
            thermostatPanel.BackColor = Color.FromArgb(129, 164, 205);
        }

        private void TurnONThermostat()
        {
            thermostatState = true;

            setValueTimer.Start();

            if (currentThermostatValue == setThermostatValue)
            {
                estimatedTimeLabel.Visible = false;
            }

            if (setThermostatValue == 10)
            {
                thermostatUpButton.Enabled = true;
                thermostatDownButton.Enabled = false;
            }
            else if (setThermostatValue == 30)
            {
                thermostatUpButton.Enabled = false;
                thermostatDownButton.Enabled = true;
            }
            else
            {
                thermostatUpButton.Enabled = true;
                thermostatDownButton.Enabled = true;
                if (setThermostatValue <= 20)
                {
                    leafPictureBox.Visible = true;
                }
            }
            thermostatPanel.BackColor = Color.FromArgb(129, 164, 205);
            currentTempValueLabel.ForeColor = Color.FromArgb(236, 241, 246);
            currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
            setTempValueLabel.ForeColor = Color.FromArgb(236, 241, 246);
            setTempValueLabel.Text = string.Format($"{setThermostatValue.ToString().PadLeft(2, '0')}°C");
            setTempValueLabel.Left = (thermostatPanel.Width - setTempValueLabel.Width) / 2;
        }

        private void thermostatUpButton_Click(object sender, EventArgs e)
        {
            upButtonClicked = true;
            downButtonClicked = false;
            setValueTimer.Start();

            if (thermostatState == true)
            {
                if (setThermostatValue >= 29)
                    thermostatUpButton.Enabled = false;
                else
                {
                    thermostatUpButton.Enabled = true;
                    thermostatDownButton.Enabled = true;
                }
                if (setThermostatValue > 19)
                {
                    leafPictureBox.Visible = false;
                }
                setThermostatValue += 1;
                currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
                setTempValueLabel.Text = string.Format($"{setThermostatValue.ToString().PadLeft(2, '0')}°C");
                setTempValueLabel.Left = (thermostatPanel.Width - setTempValueLabel.Width) / 2;

                if (currentThermostatValue > setThermostatValue)
                {
                    estimatedTimeLabel.Visible = true;
                    estimatedTimeLabel.Text = "In: " + (currentThermostatValue - setThermostatValue) * 5 + "s";
                }
                else if (currentThermostatValue < setThermostatValue)
                {
                    estimatedTimeLabel.Visible = true;
                    estimatedTimeLabel.Text = "In: " + (setThermostatValue - currentThermostatValue) * 5 + "s";
                }
                else
                {
                    estimatedTimeLabel.Visible = false;
                }
            }
        }

        private void thermostatDownButton_Click(object sender, EventArgs e)
        {
            upButtonClicked = false;
            downButtonClicked = true;
            setValueTimer.Start();

            if (thermostatState == true)
            {
                if (setThermostatValue <= 11)
                    thermostatDownButton.Enabled = false;
                else
                {
                    thermostatUpButton.Enabled = true;
                    thermostatDownButton.Enabled = true;
                }
                if (setThermostatValue <= 21)
                {
                    leafPictureBox.Visible = true;
                }
                setThermostatValue -= 1;
                currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
                setTempValueLabel.Text = string.Format($"{setThermostatValue.ToString().PadLeft(2, '0')}°C");
                setTempValueLabel.Left = (thermostatPanel.Width - setTempValueLabel.Width) / 2;

                if (currentThermostatValue > setThermostatValue)
                {
                    estimatedTimeLabel.Visible = true;
                    estimatedTimeLabel.Text = "In: " + (currentThermostatValue - setThermostatValue) * 5 + "s";
                }
                else if (currentThermostatValue < setThermostatValue)
                {
                    estimatedTimeLabel.Visible = true;
                    estimatedTimeLabel.Text = "In: " + (setThermostatValue - currentThermostatValue) * 5 + "s";
                }
                else
                {
                    estimatedTimeLabel.Visible = false;
                }
            }   
        }

        private void thermostatToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (thermostatState == false)
            {
                TurnONThermostat();
            }
            else
            {
                TurnOFFThermostat();
            }
        }

        private void thermostatButtons_EnabledChanged(object sender, EventArgs e)
        {
            IconButton button = (IconButton)sender; 
            if (!button.Enabled)
            {
                button.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                button.BackColor = Color.FromArgb(79, 134, 184);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
            if (currentThermostatValue == setThermostatValue)
            {
                setValueTimer.Stop();
                estimatedTimeLabel.Visible = false;
            }
            if (downButtonClicked == true)
            {
                currentThermostatValue -= 1;
            }
            else if (upButtonClicked == true)
            {
                currentThermostatValue += 1;
            }
        }
    }
}
