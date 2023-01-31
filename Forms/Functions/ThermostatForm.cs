using FontAwesome.Sharp;
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
            currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
            currentTempValueLabel.ForeColor = Color.Red;
            setTempValueLabel.Text = "OFF";
            setTempValueLabel.Left = (thermostatPanel.Width - setTempValueLabel.Width) / 2;
            setTempValueLabel.ForeColor = Color.Red;
            thermostatPanel.BackColor = Color.FromArgb(129, 164, 205);
        }

        private void TurnONThermostat()
        {
            thermostatState = true;
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
            if (thermostatState == true)
            {
                if (setThermostatValue >= 29)
                    thermostatUpButton.Enabled = false;
                else
                {
                    thermostatUpButton.Enabled = true;
                    thermostatDownButton.Enabled = true;
                }
                setThermostatValue += 1;
                currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
                setTempValueLabel.Text = string.Format($"{setThermostatValue.ToString().PadLeft(2, '0')}°C");
                setTempValueLabel.Left = (thermostatPanel.Width - setTempValueLabel.Width) / 2;
            }
        }

        private void thermostatDownButton_Click(object sender, EventArgs e)
        {
            if (thermostatState == true)
            {
                if (setThermostatValue <= 11)
                    thermostatDownButton.Enabled = false;
                else
                {
                    thermostatUpButton.Enabled = true;
                    thermostatDownButton.Enabled = true;
                }
                setThermostatValue -= 1;
                currentTempValueLabel.Text = "Current Temperature: " + currentThermostatValue + "°C";
                setTempValueLabel.Text = string.Format($"{setThermostatValue.ToString().PadLeft(2, '0')}°C");
                setTempValueLabel.Left = (thermostatPanel.Width - setTempValueLabel.Width) / 2;
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
    }
}
