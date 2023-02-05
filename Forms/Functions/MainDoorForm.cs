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
    public partial class MainDoorForm : Form
    {
        public MainDoorForm()
        {
            InitializeComponent();
        }

        //for the door commands
        private bool doorInterval = false;
        private List<String> doorStateList = new List<String>();
        private int doorStateListIndex = 0;

        //for the stairs commands
        private bool stairsInterval = false;
        private List<String> stairsStateList = new List<String>();
        private int stairsStateListIndex = 0;

        private void doorAlmostOpenButton_Click(object sender, EventArgs e)
        {
            doorClosed.Enabled = true;
            doorAlmostOpenButton.Enabled = false;
            doorOpenButton.Enabled = true;

            doorInterval = false;
            doorTimer.Start();
            doorStateLabel.Text = "Door will be half opened";
            doorStateListIndex = 1;
            doorStateLabel.Left = (panel1.Width - doorStateLabel.Width) / 2;

        }

        private void doorOpenButton_Click(object sender, EventArgs e)
        {
            doorClosed.Enabled = true;
            doorAlmostOpenButton.Enabled = true;
            doorOpenButton.Enabled = false;

            doorInterval = false;
            doorTimer.Start();
            doorStateLabel.Text = "Door will be opened";
            doorStateListIndex = 2;
            doorStateLabel.Left = (panel1.Width - doorStateLabel.Width) / 2;

        }

        private void stairsUpButton_Click(object sender, EventArgs e)
        {
            stairsDownButton.Enabled = true;
            stairsUpButton.Enabled = false;

            stairsInterval = false;
            stairsTimer.Start();
            stairsStateLabel.Text = "Stairs will be closed";
            stairsStateListIndex = 1;
            stairsStateLabel.Left = (panel2.Width - stairsStateLabel.Width) / 2;

        }

        private void stairsDownButton_Click(object sender, EventArgs e)
        {
            stairsDownButton.Enabled = false;
            stairsUpButton.Enabled = true;

            stairsInterval = false;
            stairsTimer.Start();
            stairsStateLabel.Text = "Stairs will be opened";
            stairsStateListIndex = 0;
            stairsStateLabel.Left = (panel2.Width - stairsStateLabel.Width) / 2;

        }

        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!button.Enabled)
            {
                button.BackColor = Color.FromArgb(236, 241, 246);
            }
            else
            {
                button.BackColor = Color.FromArgb(79, 134, 184);
            }
        }

        private void doorClosed_Click(object sender, EventArgs e)
        {
            doorClosed.Enabled = false;
            doorAlmostOpenButton.Enabled = true;
            doorOpenButton.Enabled = true;

            doorInterval = false;
            doorTimer.Start();
            doorStateLabel.Text = "Door will be closed";
            doorStateListIndex = 0;
            doorStateLabel.Left = (panel1.Width - doorStateLabel.Width) / 2;

        }


        private void doorTimer_Tick(object sender, EventArgs e)
        {
            if (!doorInterval)
            {
                doorInterval= true;
                doorStateLabel.Text = doorStateList[doorStateListIndex];
                doorTimer.Stop();
            }
            doorStateLabel.Left = (panel1.Width - doorStateLabel.Width) / 2;

        }

        private void stairsTimer_Tick(object sender, EventArgs e)
        {
            if (!stairsInterval)
            {
                stairsInterval = true;
                stairsStateLabel.Text = stairsStateList[stairsStateListIndex];
                stairsTimer.Stop();
            }
            stairsStateLabel.Left = (panel2.Width - stairsStateLabel.Width) / 2;

        }

        private void MainDoorForm_Load(object sender, EventArgs e)
        {
            doorStateList.Add("Door is Close");
            doorStateList.Add("Door is half Open");
            doorStateList.Add("Door is Open");

            doorStateLabel.Text = doorStateList[doorStateListIndex];

            stairsStateList.Add("Stairs are Open");
            stairsStateList.Add("Stairs are Close");

            stairsStateLabel.Text = stairsStateList[stairsStateListIndex];

            doorClosed_Click(doorClosed, EventArgs.Empty);
            stairsDownButton_Click(stairsDownButton, EventArgs.Empty);  
        }

        private void chatRichTextBox1_Load(object sender, EventArgs e)
        {
            doorStateLabel.Left = (panel1.Width - doorStateLabel.Width) / 2;
        }

        private void stairsStateLabel_Click(object sender, EventArgs e)
        {
            stairsStateLabel.Left = (panel2.Width - stairsStateLabel.Width) / 2;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
