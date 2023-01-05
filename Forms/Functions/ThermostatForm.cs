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
        int thermostatValue = 10;
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
            thermostatValueLabel.Text = "OFF";
            thermostatPanel.BackColor = Color.Red;
        }

        private void TurnONThermostat()
        {
            thermostatState = true;
            thermostatPanel.BackColor = Color.White;
            thermostatValueLabel.Text = string.Format($"{thermostatValue.ToString().PadLeft(2, '0')}");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void thermostatUpButton_Click(object sender, EventArgs e)
        {
            if (thermostatState == true)
            {
                thermostatValue += 1;
                thermostatValueLabel.Text = string.Format($"{thermostatValue.ToString().PadLeft(2, '0')}");
            }
        }

        private void thermostatDownButton_Click(object sender, EventArgs e)
        {
            if (thermostatState == true)
            {
                thermostatValue -= 1;
                thermostatValueLabel.Text = string.Format($"{thermostatValue.ToString().PadLeft(2, '0')}");
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
