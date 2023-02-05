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
    public partial class Client1Form : Form
    {
        private IconButton currentBtn = new();
        private readonly Panel leftBorderBtn = new(); 
        private Form currentChildForm = new(); //the second form that is loaded inside the main form

        //the name of the current form
        public string currentName = "";

        private readonly ThermostatForm thermostat = new();
        private readonly LightsForm lights = new();
        private readonly TVForm tv = new();
        private readonly RadioForm radio = new();
        private readonly GPSMenuForm gps = new();
        private readonly MainDoorForm door = new();
        private readonly RestaurantMenuForm restaurant = new();

        public Client1Form()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(10, 70) //70 is the height of the buttons
            };
            menuPanel.Controls.Add(leftBorderBtn);

            //Form
            this.Text = "Room App";
            this.DoubleBuffered = true; //to avoid flickering

            //Parameters for Room Forms
            thermostat.thermostatLabel.Text = "Living Room Thermostat";

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
                leftBorderBtn.BringToFront(); //to bring the left border button to the front (to be visible)

                //icon Current Child Form
                currentChildFormIcon.IconChar = currentBtn.IconChar; //assign the icon of the current button to the icon of the current child form
                currentChildFormIcon.IconColor = Color.FromArgb(219, 228, 238);
                childFormLabel.Text = currentBtn.Text;
                childFormLabel.ForeColor = Color.FromArgb(219, 228, 238);
            }
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

        private void OpenChildForm(Form childForm)
        {

            currentChildForm?.Hide(); //show the main form and hide the current child form, if it exists
            currentChildForm = childForm;
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None; //hide the window controls
            childForm.Dock = DockStyle.Fill; //fill the entire panel with the child form
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            //return to default settings when the user presses the logo button
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildFormIcon.IconChar = IconChar.Home;
            currentChildFormIcon.IconColor = Color.FromArgb(219, 228, 238);
            childFormLabel.Text = "Home";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm?.Hide();
            Reset();
        }
        private void Client1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
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
        private void mainDoorButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(door);
        }
        private void gpsButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(gps);
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
        private void chatRichTextBox1_Load_1(object sender, EventArgs e)
        {
            chatRichTextBox1.Text = "Welcome to our Zeus Hotel!\r\n\r\nYou can control the basic functions of your room from the left menu.\r\nIf you have any question, do not hesitate to ask us as soon as possible.\r\n\r\nHave a wonderful visit,\r\n                           the stuff";
        }

        private void chatRichTextBox3_Load_1(object sender, EventArgs e)
        {
            chatRichTextBox3.Text = "The restaurant is now open for lunch!";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}