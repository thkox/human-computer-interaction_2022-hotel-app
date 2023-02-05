using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using FontAwesome.Sharp;
using hotel_app.Forms.Functions;

namespace hotel_app.Forms
{
    public partial class EmployeeForm : Form
    {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        private Panel currentMenuPanel;

        private static readonly Client1Form trojan1Form = new();
        private static readonly Client1Form trojan2Form = new();

        private static readonly Client2Form room1Form = new();
        private static readonly Client2Form room3Form = new();
        private static readonly Client2Form suite1Form = new();


        private readonly Client1Form[] trojanForms = new Client1Form[] { trojan1Form, trojan2Form};
        private readonly Client2Form[] roomForms = new Client2Form[] { room1Form, room3Form, suite1Form};


        //forms that we can open now
        readonly ZeusPalaceMenuForm zeusPalaceMenu = new();
        readonly ParkingForm parking = new(); //Courtyard Zeus and Olympos Gardens different panels

        public EmployeeForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(10, 70) //70 is the height of the buttons
            };
            menuPanel.Controls.Add(leftBorderBtn);

            //Form
            this.Text = "Staff App";
            this.DoubleBuffered = true; //to avoid flickering

            //disable some properties for the parking form
            parking.trojan1PictureBox.Visible = false;
            parking.trojan4PictureBox.Visible = false;
            parking.upOButton.Visible = false;
            parking.upZButton.Visible = false;
            parking.downOButton.Visible = false;
            parking.downZButton.Visible = false;
            parking.leftOButton.Visible = false;
            parking.leftZButton.Visible = false;
            parking.rightOButton.Visible = false;
            parking.rightZButton.Visible = false;
            parking.parkingButton.Visible = false;
            parking.parkingButton2.Visible = false;


            //hide the logos for the clients menu
            foreach (Client1Form trojanForm in trojanForms)
            {
                trojanForm.panel1.Visible = false;
                trojanForm.gpsButton.Visible = false;
                trojanForm.foodButton.Visible = false;
            }
            foreach (Client2Form roomForm in roomForms)
            {
                roomForm.panel1.Visible = false;
                roomForm.foodButton.Visible=false;
            }

            currentNameLabel.Visible = false;

            //add the click event for the pictureboxes in the parking form
            parking.trojan3PictureBox.Click += new EventHandler(Trojan3PictureBox_Click);
            parking.trojan6PictureBox.Click += new EventHandler(Trojan6PictureBox_Click);

            //add the mouse enter event for the pictureboxes in the parking form
            parking.trojan3PictureBox.MouseEnter += new EventHandler(Trojan3PictureBox_MouseEnter);
            parking.trojan6PictureBox.MouseEnter += new EventHandler(Trojan6PictureBox_MouseEnter);

            //add the mouse leave event for the pictureboxes in the parking form
            parking.trojan3PictureBox.MouseLeave += new EventHandler(Trojan3PictureBox_MouseLeave);
            parking.trojan6PictureBox.MouseLeave += new EventHandler(Trojan6PictureBox_MouseLeave);

            //add the click event for the iconButtons in the roomsForm
            zeusPalaceMenu.rooms.room1Button.Click += new EventHandler(Room1PictureBox_Click);
            zeusPalaceMenu.rooms.room3Button.Click += new EventHandler(Room3PictureBox_Click);
            zeusPalaceMenu.rooms.suite1Button.Click += new EventHandler(Suite1PictureBox_Click);

            //load the names of the trojans
            trojanForms[0].currentName = "Trojan B2";
            trojanForms[1].currentName = "Trojan A2";

            //change trojan cursor
            parking.trojan3PictureBox.Cursor = Cursors.Hand;
            parking.trojan6PictureBox.Cursor = Cursors.Hand;

            //load the names of the rooms
            roomForms[0].currentName = "Room 1";
            roomForms[1].currentName = "Room 3";
            roomForms[2].currentName = "Suite 1";
        }
        
        //activate a trojan
        private void Trojan3PictureBox_Click(object sender, EventArgs e)
        {
            loadTrojanFunctions(trojan2Form);
        }

        private void Trojan6PictureBox_Click(object sender, EventArgs e)
        {
            loadTrojanFunctions(trojan1Form);
        }

        //Mouse Enter events for the trojans
        private void Trojan2PictureBox_MouseEnter(object? sender, EventArgs e)
        {
            parking.trojan2PictureBox.BackColor = Color.White;
        }
        private void Trojan3PictureBox_MouseEnter(object? sender, EventArgs e)
        {
            parking.trojan3PictureBox.BackColor = Color.White;
        }
        private void Trojan5PictureBox_MouseEnter(object? sender, EventArgs e)
        {
            parking.trojan5PictureBox.BackColor = Color.White;
        }
        private void Trojan6PictureBox_MouseEnter(object? sender, EventArgs e)
        {
            parking.trojan6PictureBox.BackColor = Color.White;
        }

        //Mouse Leave events for the trojans
        private void Trojan2PictureBox_MouseLeave(object? sender, EventArgs e)
        {
            parking.trojan2PictureBox.BackColor = Color.Silver;
        }
        private void Trojan3PictureBox_MouseLeave(object? sender, EventArgs e)
        {
            parking.trojan3PictureBox.BackColor = Color.Silver;
        }
        private void Trojan5PictureBox_MouseLeave(object? sender, EventArgs e)
        {
            parking.trojan5PictureBox.BackColor = Color.Silver;
        }
        private void Trojan6PictureBox_MouseLeave(object? sender, EventArgs e)
        {
            parking.trojan6PictureBox.BackColor = Color.Silver;
        }

        //activate a room
        private void Room1PictureBox_Click(object sender, EventArgs e)
        {
            loadRoomFunctions(room1Form);
        }

        private void Room3PictureBox_Click(object sender, EventArgs e)
        {
            loadRoomFunctions(room3Form);

        }

        private void Suite1PictureBox_Click(object sender, EventArgs e)
        {
            loadRoomFunctions(suite1Form);

        }

        private void loadTrojanFunctions(Client1Form trojanForm)
        {
            OpenChildMenu(trojanForm.menuPanel);
            leftBorderBtn.Visible = false;
            backButton.Visible = true;

            label1.Hide();
            label2.Hide();
            helpButton.Hide();

            currentNameLabel.Text = trojanForm.currentName;
            //center align the label
            currentNameLabel.Left = (currentNameLabel.Parent.ClientSize.Width - currentNameLabel.Width) / 2;
            currentNameLabel.Top = (currentNameLabel.Parent.ClientSize.Height - currentNameLabel.Height) / 2;

            currentNameLabel.Visible = true;

            currentChildForm.Hide();
            childFormPanel.Controls.Add(trojanForm.childFormPanel);
        }

        private void loadRoomFunctions(Client2Form roomForm)
        {
            OpenChildMenu(roomForm.menuPanel);
            leftBorderBtn.Visible = false;
            backButton.Visible = true;

            label1.Hide();
            label2.Hide();
            helpButton.Hide();


            currentNameLabel.Text = roomForm.currentName;
            //center align the label
            currentNameLabel.Left = (currentNameLabel.Parent.ClientSize.Width - currentNameLabel.Width) / 2;
            currentNameLabel.Top = (currentNameLabel.Parent.ClientSize.Height - currentNameLabel.Height) / 2;

            currentNameLabel.Visible = true;

            currentChildForm.Hide();
            childFormPanel.Controls.Add(roomForm.childFormPanel);
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
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
                leftBorderBtn.BringToFront();

                //icon Current Child Form
                currentChildFormIcon.IconChar = currentBtn.IconChar;
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

        private void OpenChildMenu(Panel clientMenuForm)
        {
            currentMenuPanel?.Hide();
            currentMenuPanel = clientMenuForm;
            clientMenuForm.Dock = DockStyle.Fill;

            zeusPalaceButton.Hide();
            olymposGardensButton.Hide();
            courtyardZeusButton.Hide();
            registerButton.Hide();

            menuPanel.Controls.Add(clientMenuForm);
            menuPanel.Tag = clientMenuForm;

            clientMenuForm.BringToFront();
            clientMenuForm.Show();
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Hide();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseFunctionsForm()
        {
            currentChildForm?.Hide();
            currentMenuPanel?.Hide();
            currentNameLabel?.Hide();
            backButton?.Hide();
            leftBorderBtn.Visible = true;
        }
        private void courtyardZeusButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(parking);
            parking.olymbosGardensPanel.Hide();
            parking.trojan4PictureBox.Location = new Point(807, 251);

            parking.trojan1PictureBox.Location = new Point(173, 263);
            parking.trojan1PictureBox.Image = Properties.Resources.trojan;
            parking.zeusCourtyardPanel.Show();
        }

        private void olymposGardensButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(parking);
            parking.zeusCourtyardPanel.Hide();
            parking.trojan1PictureBox.Location = new Point(173, 263);

            parking.trojan4PictureBox.Location = new Point(807, 251);
            parking.trojan4PictureBox.Image = Properties.Resources.trojan_horse_reversed;
            parking.olymbosGardensPanel.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildFormIcon.IconChar = IconChar.Home;
            currentChildFormIcon.IconColor = Color.FromArgb(219, 228, 238);
            childFormLabel.Text = "Home";
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            CloseFunctionsForm();

            zeusPalaceButton.Show();
            olymposGardensButton.Show();
            courtyardZeusButton.Show();
            registerButton.Show();
            backButton.Hide();

            label1.Show();
            label2.Show();
            helpButton.Show();

            //for every possible panel loaded inside the childFormPanel
            foreach (Client1Form trojanForm in trojanForms)
            {
                if (childFormPanel.Controls.Contains(trojanForm.childFormPanel))
                {
                    childFormPanel.Controls.Remove(trojanForm.childFormPanel);
                }
            }
            foreach (Client2Form roomForm in roomForms)
            {
                if (childFormPanel.Controls.Contains(roomForm.childFormPanel))
                {
                    childFormPanel.Controls.Remove(roomForm.childFormPanel);
                }
            }

            Reset();
        }

        private void zeusPalaceButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(zeusPalaceMenu);
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            RegisterForm registerForm = new RegisterForm();
            registerForm.RegisterCompleted += new RegisterForm.RegisterEventHandler(this.registerForm_RegisterCompleted);
            OpenChildForm(registerForm);
        }

        private void registerForm_RegisterCompleted(object sender, EventArgs e)
        {
            registrationLabel.Visible = true;
            Reset();
            hideMessageTimer.Start();
        }

        private void hideMessageTimer_Tick(object sender, EventArgs e)
        {

            registrationLabel.Visible = false;
            hideMessageTimer.Stop();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CloseFunctionsForm();

            zeusPalaceButton.Show();
            olymposGardensButton.Show();
            courtyardZeusButton.Show();
            registerButton.Show();
            backButton.Hide();

            label1.Show();
            label2.Show();
            helpButton.Show();

            //for every possible panel loaded inside the childFormPanel
            foreach (Client1Form trojanForm in trojanForms)
            {
                if (childFormPanel.Controls.Contains(trojanForm.childFormPanel))
                {
                    childFormPanel.Controls.Remove(trojanForm.childFormPanel);
                    OpenChildForm(parking);
                }
            }
            foreach (Client2Form roomForm in roomForms)
            {
                if (childFormPanel.Controls.Contains(roomForm.childFormPanel))
                {
                    childFormPanel.Controls.Remove(roomForm.childFormPanel);
                    OpenChildForm(zeusPalaceMenu);
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
