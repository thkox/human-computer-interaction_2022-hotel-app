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
            radioValueLabel.Left = (radioPanel.Width - radioValueLabel.Width) / 2;
            radioState = false;
            radioUpButton.Enabled = false;
            radioDownButton.Enabled = false;
            radioValueLabel.Text = "OFF";
            radioValueLabel.ForeColor = Color.Red;
            radioPanel.BackColor = Color.FromArgb(129, 164, 205);
        }

        private void TurnONRadio() 
        {
            radioState = true;
            radioUpButton.Enabled = true;
            radioDownButton.Enabled = true;
            radioPanel.BackColor = Color.FromArgb(129, 164, 205);
            radioValueLabel.ForeColor = Color.FromArgb(236, 241, 246);
            radioValueLabel.Text = string.Format($"{radioValue.ToString("0.0")}MHz");
        }

        private void RadioForm_Load(object sender, EventArgs e)
        {
            TurnOFFRadio();
            radioLabel.Left = (this.ClientSize.Width - radioLabel.Width) / 2;
            radioPanel.Left = (this.ClientSize.Width - radioPanel.Width) / 2;
            radioDownButton.Left = radioPanel.Left;
            radioUpButton.Left = radioDownButton.Left + 181;
            radioToggle.Left = (this.ClientSize.Width - radioToggle.Width) / 2;
        }

        private void radioUpButton_Click(object sender, EventArgs e)
        {
            if (radioState == true) 
            {
                if (radioValue >= 105.7)
                    radioValue = 87.7;
                radioValue += 0.3;
                radioValueLabel.Text = string.Format($"{radioValue.ToString("0.0")}MHz");
                radioValueLabel.Left = (radioPanel.Width - radioValueLabel.Width) / 2;
            }
        }

        private void radioDownButton_Click(object sender, EventArgs e)
        {
            if (radioValue <= 88.3)
                radioValue = 106.3;
            radioValue -= 0.3;
            radioValueLabel.Text = string.Format($"{radioValue.ToString("0.0")}MHz");
            radioValueLabel.Left = (radioPanel.Width - radioValueLabel.Width) / 2;
        }

        private void RadioToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioState == false) 
            {
                TurnONRadio();
                radioValueLabel.Left = (radioPanel.Width - radioValueLabel.Width) / 2;
            }
            else
            {
                TurnOFFRadio();
                radioValueLabel.Left = (radioPanel.Width - radioValueLabel.Width) / 2;
            }
        }

        private void radioButtons_EnabledChanged(object sender, EventArgs e)
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
