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
        int thermostatValue = 15;
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
            thermostatValueLabel.Text = "OFF";
            thermostatValueLabel.ForeColor = Color.Red;
            thermostatPanel.BackColor = Color.FromArgb(129, 164, 205);
        }

        private void TurnONThermostat()
        {
            thermostatState = true;
            if (thermostatValue == 10)
            {
                thermostatUpButton.Enabled = true;
                thermostatDownButton.Enabled = false;
            }
            else if (thermostatValue == 30)
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
            thermostatValueLabel.ForeColor = Color.FromArgb(236, 241, 246);
            thermostatValueLabel.Text = string.Format($"{thermostatValue.ToString().PadLeft(2, '0')}°C");
        }

        private void thermostatUpButton_Click(object sender, EventArgs e)
        {
            if (thermostatState == true)
            {
                if (thermostatValue >= 29)
                    thermostatUpButton.Enabled = false;
                else
                {
                    thermostatUpButton.Enabled = true;
                    thermostatDownButton.Enabled = true;
                }
                thermostatValue += 1;
                thermostatValueLabel.Text = string.Format($"{thermostatValue.ToString().PadLeft(2, '0')}°C");
            }
        }

        private void thermostatDownButton_Click(object sender, EventArgs e)
        {
            if (thermostatState == true)
            {
                if (thermostatValue <= 11)
                    thermostatDownButton.Enabled = false;
                else
                {
                    thermostatUpButton.Enabled = true;
                    thermostatDownButton.Enabled = true;
                }
                thermostatValue -= 1;
                thermostatValueLabel.Text = string.Format($"{thermostatValue.ToString().PadLeft(2, '0')}°C");
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
