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
            thermostatPanel.BackColor = Color.Red;
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
            thermostatPanel.BackColor = Color.White;
            thermostatValueLabel.Text = string.Format($"{thermostatValue.ToString().PadLeft(2, '0')}°C");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
