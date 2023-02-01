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
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void mastercardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            visaCheckBox.Checked = false;
        }

        private void visaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mastercardCheckBox.Checked = false;
        }
    }
}
