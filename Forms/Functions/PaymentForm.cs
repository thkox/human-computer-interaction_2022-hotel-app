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
    public partial class PaymentForm : Form
    {
        private Panel paymentMenuTabs;

        private Form currentChildForm;

        private OrderStatusForm orderStatus = new OrderStatusForm();

        bool allRichTextBoxesHaveText = true;

        public PaymentForm()
        {
            InitializeComponent();
            errorLabel.Visible = false;

            orderStatus.EventCompletedEnd += new OrderStatusForm.EventCompleted(this.CloseThisForm);

        }

        private void CloseThisForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cardNumber_richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void month_richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void year_richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cardholderName_richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cvv_richTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void month_richTextBox_Enter(object sender, EventArgs e)
        {
            if (month_richTextBox.Texts == "MM")
            {
                month_richTextBox.Texts = "";
                month_richTextBox.ForeColor = Color.Black;
            }
        }

        private void month_richTextBox_Leave(object sender, EventArgs e)
        {
            if (month_richTextBox.Texts == "")
            {
                month_richTextBox.Texts = "MM";
                month_richTextBox.ForeColor = Color.Gray;
            }
        }

        private void year_richTextBox_Enter(object sender, EventArgs e)
        {
            if (year_richTextBox.Texts == "YYYY")
            {
                year_richTextBox.Texts = "";
                year_richTextBox.ForeColor = Color.Black;
            }
        }

        private void year_richTextBox_Leave(object sender, EventArgs e)
        {
            if (year_richTextBox.Texts == "")
            {
                year_richTextBox.Texts = "YYYY";
                year_richTextBox.ForeColor = Color.Gray;
            }
        }

        private void cvv_richTextBox_Enter(object sender, EventArgs e)
        {
            if (cvv_richTextBox.Texts == "CVV")
            {
                cvv_richTextBox.Texts = "";
                cvv_richTextBox.ForeColor = Color.Black;
            }
        }

        private void cvv_richTextBox_Leave(object sender, EventArgs e)
        {
            if (cvv_richTextBox.Texts == "")
            {
                cvv_richTextBox.Texts = "CVV";
                cvv_richTextBox.ForeColor = Color.Gray;
            }
        }

        private void cardholderName_richTextBox_Enter(object sender, EventArgs e)
        {
            if (cardholderName_richTextBox.Texts == "Enter Cardholder name")
            {
                cardholderName_richTextBox.Texts = "";
                cardholderName_richTextBox.ForeColor = Color.Black;
            }
        }

        private void cardholderName_richTextBox_Leave(object sender, EventArgs e)
        {
            if (cardholderName_richTextBox.Texts == "")
            {
                cardholderName_richTextBox.Texts = "Enter Cardholder name";
                cardholderName_richTextBox.ForeColor = Color.Gray;
            }
        }

        private void cardNumber_richTextBox_Enter(object sender, EventArgs e)
        {
            if (cardNumber_richTextBox.Texts == "Enter Card Number")
            {
                cardNumber_richTextBox.Texts = "";
                cardNumber_richTextBox.ForeColor = Color.Black;
            }
        }

        private void cardNumber_richTextBox_Leave(object sender, EventArgs e)
        {
            if (cardNumber_richTextBox.Texts == "")
            {
                cardNumber_richTextBox.Texts = "Enter Card Number";
                cardNumber_richTextBox.ForeColor = Color.Gray;
            }
        }

        private void OpenOrderStatusForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paymentLoadFormsPanel.Controls.Add(childForm);
            paymentLoadFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            paymentMenuTabs = paymentLoadFormsPanel;
        }

        private void confirmationButton_Click(object sender, EventArgs e)
        {
            if (cardholderName_richTextBox.Texts == "Enter Cardholder name" || cardNumber_richTextBox.Texts == "Enter Card Number" || cvv_richTextBox.Texts == "CVV" || month_richTextBox.Texts == "MM" || year_richTextBox.Texts == "YYYY" || year_richTextBox.Texts == "YYYY")
            {
                allRichTextBoxesHaveText = false;
            }

            if (allRichTextBoxesHaveText)
            {
                OpenOrderStatusForm(orderStatus);
                
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Please fill in all the fields";
                allRichTextBoxesHaveText = true;
            }

        }

        private void confirmationButton_Leave(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
