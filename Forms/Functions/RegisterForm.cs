using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Forms.Functions
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void dateOfBirth_richTextBox_Leave(object sender, EventArgs e)
        {
            Regex datePattern = new Regex(@"^(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])/\d{4}$");

            if (!datePattern.IsMatch(dateOfBirth_richTextBox.Text))
            {
                MessageBox.Show("Invalid date format. Use MM/dd/yyyy.");
                dateOfBirth_richTextBox.Focus();
            }
        }

        private void checkinDate_richTextBox_Leave(object sender, EventArgs e)
        {
            Regex datePattern = new Regex(@"^(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])/\d{4}$");

            if (!datePattern.IsMatch(checkinDate_richTextBox.Text))
            {
                MessageBox.Show("Invalid date format. Use MM/dd/yyyy.");
                checkinDate_richTextBox.Focus();
            }
        }

        private void checkoutDate_richTextBox_Leave(object sender, EventArgs e)
        {
            Regex datePattern = new Regex(@"^(0[1-9]|1[0-2])/(0[1-9]|[1-2][0-9]|3[0-1])/\d{4}$");

            if (!datePattern.IsMatch(checkoutDate_richTextBox.Text))
            {
                MessageBox.Show("Invalid date format. Use MM/dd/yyyy.");
                checkoutDate_richTextBox.Focus();
            }
        }
    }
}
