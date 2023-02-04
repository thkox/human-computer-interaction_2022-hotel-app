using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Forms.Functions
{
    public partial class RegisterForm : Form
    {
        bool allRichTextBoxesHaveText = true;
        
        public RegisterForm()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        private void dateOfBirth_richTextBox_Leave(object sender, EventArgs e)
        {
            if (dateOfBirth_richTextBox.Text.Length == 10)
            {
                DateTime date;
                if (!DateTime.TryParseExact(dateOfBirth_richTextBox.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    dateOfBirth_richTextBox.Text = "";
                    MessageBox.Show("Invalid date format. Use MM/DD/YYYY.");
                }
            }
        }

        private void checkinDate_richTextBox_Leave(object sender, EventArgs e)
        {
            if (checkinDate_richTextBox.Text.Length == 10)
            {
                DateTime date;
                if (!DateTime.TryParseExact(checkinDate_richTextBox.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    checkinDate_richTextBox.Text = "";
                    MessageBox.Show("Invalid date format. Use MM/DD/YYYY.");
                }
            }
        }

        private void checkoutDate_richTextBox_Leave(object sender, EventArgs e)
        {
            if (checkoutDate_richTextBox.Text.Length == 10)
            {
                DateTime date;
                if (!DateTime.TryParseExact(checkoutDate_richTextBox.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    checkoutDate_richTextBox.Text = "";
                    MessageBox.Show("Invalid date format. Use MM/DD/YYYY.");
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if ((firstname_richTextBox == null || string.IsNullOrWhiteSpace(firstname_richTextBox.Texts)) || (lastname_richTextBox == null || string.IsNullOrWhiteSpace(lastname_richTextBox.Texts)) || (dateOfBirth_richTextBox == null || string.IsNullOrWhiteSpace(dateOfBirth_richTextBox.Texts)) || (id_richTextBox == null || string.IsNullOrWhiteSpace(id_richTextBox.Texts)) || (checkinDate_richTextBox == null || string.IsNullOrWhiteSpace(checkinDate_richTextBox.Texts) || (checkoutDate_richTextBox == null || string.IsNullOrWhiteSpace(checkoutDate_richTextBox.Texts))))
            {
                allRichTextBoxesHaveText = false;
            }
            if (allRichTextBoxesHaveText)
            {
                //transition
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Please fill in all the fields";
                allRichTextBoxesHaveText = true;
            }
        }

        private void registerButton_Leave(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
