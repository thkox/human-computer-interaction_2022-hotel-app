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
    public partial class EmployeeForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //forms that we can open now
        ZeusPalaceMenuForm zeusPalaceMenu = new ZeusPalaceMenuForm();
        ParkingForm parking = new ParkingForm(); //Courtyard Zeus and Olympos Gardens different panels

        public EmployeeForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 70); //70 is the height of the buttons
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

            parking.label2.Visible = true;
            parking.label3.Visible = true;
            parking.label4.Visible = true;
            parking.label5.Visible = true;

            //add the click property for the pictureaboxes in the parking form
            parking.leftTransitionPictureBox.Click += new EventHandler(leftTransitionPictureBox_Click);
           
            parking.rightTransitionPictureBox.Click += new EventHandler(rightTransitionPictureBox_Click);

            parking.leftTransitionPictureBox.MouseHover += new System.EventHandler(LeftTransitionPictureBox_MouseHover);
            parking.rightTransitionPictureBox.MouseHover += new System.EventHandler(RightTransitionPictureBox_MouseHover);

            parking.trojan2PictureBox.Click += new EventHandler(Trojan2PictureBox_Click);
            parking.trojan3PictureBox.Click += new EventHandler(Trojan3PictureBox_Click);
            parking.trojan5PictureBox.Click += new EventHandler(Trojan5PictureBox_Click);
            parking.trojan6PictureBox.Click += new EventHandler(Trojan6PictureBox_Click);
        }

        private void Trojan2PictureBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Client2Form());
        }

        private void Trojan3PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Trojan5PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Trojan6PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void LeftTransitionPictureBox_MouseHover(object sender, EventArgs e)
        {
            parking.leftTransitionPictureBox.Cursor = Cursors.Hand;
        }

        private void RightTransitionPictureBox_MouseHover(object sender, EventArgs e)
        {
            parking.rightTransitionPictureBox.Cursor = Cursors.Hand;
        }

        private void leftTransitionPictureBox_Click(object sender, EventArgs e)
        {
            parking.zeusCourtyardPanel.Hide();
            parking.olymbosGardensPanel.Show();
        }

        private void rightTransitionPictureBox_Click(object sender, EventArgs e)
        {
            parking.zeusCourtyardPanel.Show();
            parking.olymbosGardensPanel.Hide();
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

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
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
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signinForm = new SignInForm();
            signinForm.Show();
        }
    }
}
