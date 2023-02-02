using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Custom_Toolbox
{
    public partial class QuantityCustomControl : UserControl
    {
        public QuantityCustomControl()
        {
            InitializeComponent();
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Ensure the RichTextBox only displays numbers
            int value;
            if (!int.TryParse(richTextBox.Text, out value))
            {
                richTextBox.Text = "0";
            }
            richTextBox.SelectAll();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(richTextBox.Text);
            richTextBox.Text = (value - 1).ToString();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(richTextBox.Text);
            richTextBox.Text = (value + 1).ToString();
        }
    }
}
