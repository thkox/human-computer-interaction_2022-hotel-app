using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using hotel_app.Forms.Functions;

namespace hotel_app.Forms
{
    public partial class Client2Form : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm; //the second form that is loaded inside the main form

        public string currentName = "";

        //forms that we can open now
        PoolMenuForm pool = new PoolMenuForm();
        ThermostatForm thermostat = new ThermostatForm();
        LightsForm lights = new LightsForm();
        TVForm tv = new TVForm();
        RadioForm radio = new RadioForm();  
        RestaurantMenuForm restaurant = new RestaurantMenuForm();

        public Client2Form()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 70); //70 is the height of the buttons
            menuPanel.Controls.Add(leftBorderBtn);

            //Form
            this.Text = "Room App";
            this.DoubleBuffered= true;

            //Parameters for Trojan Forms
            thermostat.thermostatLabel.Text = "Living Room Thermostat";
            pool.poolThermostat.thermostatLabel.Text = "Private Pool: Thermostat";
            pool.waterLevel.waterLevelLabel.Text = "Private Pool: Water Level";

            //show only the room lights
            lights.roomLightsPanel.Left = (lights.roomLightsPanel.Parent.ClientSize.Width - lights.roomLightsPanel.Width) / 2;
            lights.roomLightsPanel.Top = (lights.roomLightsPanel.Parent.ClientSize.Height - lights.roomLightsPanel.Height) / 2;
            lights.outdoorLightsPanel.Visible = false;
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton(); //disable the previous button
                currentBtn = (IconButton)senderBtn; //assign the current button to the sender button
                currentBtn.BackColor = Color.FromArgb(129, 164, 205);
                currentBtn.ForeColor = Color.FromArgb(34, 99, 161);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(34, 99, 161);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //leftBorder button
                leftBorderBtn.BackColor = Color.FromArgb(219, 228, 238);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront(); //to bring the left border button to the front

                //icon Current Child Form
                currentChildFormIcon.IconChar = currentBtn.IconChar; //assign the icon of the current button to the icon of the current child form
                currentChildFormIcon.IconColor = Color.FromArgb(219, 228, 238);
                childFormLabel.Text = currentBtn.Text;
                childFormLabel.ForeColor = Color.FromArgb(219, 228, 238);

            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; //to remove the border of the form
            childForm.Dock = DockStyle.Fill; //fill the entire panel
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(34, 99, 161);
                currentBtn.ForeColor = Color.FromArgb(219, 228, 238);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(219, 228, 238);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildFormIcon.IconChar = IconChar.Home;
            currentChildFormIcon.IconColor = Color.FromArgb(219, 228, 238);
            childFormLabel.Text = "Home";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            Reset();
        }
        private void Client2Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
        private void poolButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(pool);
        }
        private void privateThermostatButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(thermostat);
        }
        private void lightsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(lights);
        }
        private void tvButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(tv);
        }
        private void radioButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(radio);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void foodButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(restaurant);
        }

        private void chatRichTextBox1_Load(object sender, EventArgs e)
        {
            chatRichTextBox1.Text = "Welcome to our Zeus Hotel!\r\n\r\nYou can control the basic functions of your room from the left menu.\r\nIf you have any question, do not hesitate to ask us as soon as possible.\r\n\r\nHave a wonderful visit,\r\n                           the stuff";
        }

        private void chatRichTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void chatRichTextBox3_Load(object sender, EventArgs e)
        {
            chatRichTextBox3.Text = "The restaurant is now open for lunch!";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}