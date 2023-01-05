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
    public partial class RadioForm : Form
    {
        double radioValue = 88.0;
        bool radioState = false;
        public RadioForm()
        {
            InitializeComponent();
        }

        private void TurnOFFRadio()
        {
            radioState = false;
            radioUpButton.Enabled = false;
            radioDownButton.Enabled = false;
            RadioValueLabel.Text = "OFF";
            RadioPanel.BackColor = Color.Red;
        }

        private void TurnONRadio() 
        {
            radioState = true;
            radioUpButton.Enabled = true;
            radioDownButton.Enabled = true;
            RadioPanel.BackColor = Color.White;
            RadioValueLabel.Text = string.Format($"{radioValue.ToString("0.0")}MHz");
        }

        private void RadioForm_Load(object sender, EventArgs e)
        {
            TurnOFFRadio();
            RadioValueLabel.Location = new Point(90, RadioValueLabel.Location.Y);
        }

        private void radioUpButton_Click(object sender, EventArgs e)
        {
            if (radioState == true) 
            {
                if (radioValue >= 105.7)
                    radioValue = 87.7;
                radioValue += 0.3;
                RadioValueLabel.Text = string.Format($"{radioValue.ToString("0.0")}MHz");
                if (radioValue <= 99.7) 
                    RadioValueLabel.Location = new Point(20, RadioValueLabel.Location.Y);
                else RadioValueLabel.Location = new Point(0, RadioValueLabel.Location.Y);
                
            }
        }

        private void radioDownButton_Click(object sender, EventArgs e)
        {
            if (radioValue <= 88.3)
                radioValue = 106.3;
            radioValue -= 0.3;
            RadioValueLabel.Text = string.Format($"{radioValue.ToString("0.0")}MHz");
            if (radioValue <= 100.0)
                RadioValueLabel.Location = new Point(20, RadioValueLabel.Location.Y);
            else RadioValueLabel.Location = new Point(0, RadioValueLabel.Location.Y);
        }

        private void RadioToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioState == false) 
            {
                TurnONRadio();
                if (radioValue >= 99.7)
                    RadioValueLabel.Location = new Point(0, RadioValueLabel.Location.Y);
                else RadioValueLabel.Location = new Point(20, RadioValueLabel.Location.Y);
            }
            else
            {
                TurnOFFRadio();
                RadioValueLabel.Location = new Point(90, RadioValueLabel.Location.Y);
            }
        }
    }
}
