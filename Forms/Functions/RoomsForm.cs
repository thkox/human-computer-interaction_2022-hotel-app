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
    public partial class RoomsForm : Form
    {
        private Panel roomsMenuTabs;

        private Form currentChildForm;

        private RoomFunctionsForm room = new RoomFunctionsForm();
        public RoomsForm()
        {
            InitializeComponent();
        }

        private void OpenRoomsFunctionForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            roomsLoadFormsPanel.Controls.Add(childForm);
            roomsLoadFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            roomsMenuTabs = roomsLoadFormsPanel;
            backPictureBox.Hide();
        }

        private void room1Button_Click(object sender, EventArgs e)
        {
            OpenRoomsFunctionForm(room);
            backPictureBox.Show();
        }

        private void room2Button_Click(object sender, EventArgs e)
        {
            OpenRoomsFunctionForm(room);
            backPictureBox.Show();
        }

        private void doorOpenButton_Click(object sender, EventArgs e)
        {
            OpenRoomsFunctionForm(room);
            backPictureBox.Show();
        }

        private void room4Button_Click(object sender, EventArgs e)
        {
            OpenRoomsFunctionForm(room);
            backPictureBox.Show();
        }

        private void room5Button_Click(object sender, EventArgs e)
        {
            OpenRoomsFunctionForm(room);
            backPictureBox.Show();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            roomsLoadFormsPanel = roomsMenuTabs;
            backPictureBox.Hide();
        }
    }
}
