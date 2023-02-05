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
    public partial class WaterLevelForm : Form
    {
        private int waterLevelValue = 10;

        
        public WaterLevelForm()
        {
            InitializeComponent();
            waterLevelDownButton.Enabled = false;
            waterLevelUpButton.Enabled = true;
            waterLevelEmptyButton.Enabled = false;
            waterLevelValueLabel.Text = string.Format($"{(10 - waterLevelValue) * 10}%");
        }

        private void WaterLevelForm_Load(object sender, EventArgs e)
        {
            waterLevelValueLabel.Location = new Point(110, waterLevelValueLabel.Location.Y);
        }

        private void waterLevelEmptyButton_Click(object sender, EventArgs e)
        {
            hideWaterLevel.Height = 250;
            waterLevelValue = 10;
            waterLevelDownButton.Enabled = false;
            waterLevelUpButton.Enabled = true;
            waterLevelEmptyButton.Enabled = false;
            waterLevelValueLabel.Text = string.Format($"{(10 - waterLevelValue) * 10}%");
            waterLevelValueLabel.Location = new Point(110, waterLevelValueLabel.Location.Y);
        }

        private void waterLevelDownButton_Click(object sender, EventArgs e)
        {
            hideWaterLevel.Height += 25;
            waterLevelValue += 1;
            if (waterLevelValue == 10)
            {
                waterLevelDownButton.Enabled = false;
                waterLevelEmptyButton.Enabled = false;
                waterLevelValueLabel.Location = new Point(110, waterLevelValueLabel.Location.Y);
            }
            else
            {
                waterLevelUpButton.Enabled = true;
                waterLevelValueLabel.Location = new Point(100, waterLevelValueLabel.Location.Y);
            }
            waterLevelValueLabel.Text = string.Format($"{(10 - waterLevelValue) * 10}%");
        }

        private void waterLevelUpButton_Click(object sender, EventArgs e)
        {
            hideWaterLevel.Height -= 25;
            waterLevelValue -= 1;
            if (waterLevelValue == 0)
            {
                waterLevelUpButton.Enabled = false;
                waterLevelValueLabel.Location = new Point(84, waterLevelValueLabel.Location.Y);
            }
            else
            {
                waterLevelDownButton.Enabled = true;
                waterLevelEmptyButton.Enabled = true;
                waterLevelValueLabel.Location = new Point(100, waterLevelValueLabel.Location.Y);
            }
            waterLevelValueLabel.Text = string.Format($"{(10 - waterLevelValue) * 10}%");
        }

        private void waterLevelDownButton_EnabledChanged(object sender, EventArgs e)
        {
            if (!waterLevelDownButton.Enabled)
            {
                waterLevelDownButton.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                waterLevelDownButton.BackColor = Color.FromArgb(79, 134, 184);
            }
        }

        private void waterLevelUpButton_EnabledChanged(object sender, EventArgs e)
        {
            if (!waterLevelUpButton.Enabled)
            {
                waterLevelUpButton.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                waterLevelUpButton.BackColor = Color.FromArgb(79, 134, 184);
            }
        }

        private void waterLevelEmptyButton_EnabledChanged(object sender, EventArgs e)
        {
            if (!waterLevelEmptyButton.Enabled)
            {
                waterLevelEmptyButton.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                waterLevelEmptyButton.BackColor = Color.FromArgb(79, 134, 184);
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
