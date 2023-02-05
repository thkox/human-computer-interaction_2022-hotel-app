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
        private readonly Panel roomsMenuTabs;

        private Form currentChildForm;

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

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
