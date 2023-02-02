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
    public partial class RestaurantMenuForm : Form
    {
        public RestaurantMenuForm()
        {
            InitializeComponent();
        }

        private void quantityAmericano_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Americano x" + quantityAmericano.Tag + " " + (Convert.ToInt32(quantityAmericano.Tag) * Convert.ToInt32(americanoButton.Tag)) + "€" + Environment.NewLine;
        }

        private void quantityCappuccino_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Cappuccino x" + quantityCappuccino.Tag + " " + (Convert.ToInt32(quantityCappuccino.Tag) * Convert.ToInt32(cappuccinoButton.Tag)) + "€" + Environment.NewLine;
        }

        private void quantityEspresso_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Espresso x" + quantityEspresso.Tag + " " + (Convert.ToInt32(quantityEspresso.Tag) * Convert.ToInt32(espressoButton.Tag)) + "€" + Environment.NewLine;
        }

        private void quantityLatte_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Latte x" + quantityLatte.Tag + " " + (Convert.ToInt32(quantityLatte.Tag) * Convert.ToInt32(latteButton.Tag)) + "€" + Environment.NewLine;
        }

        //private string textToWrite()
        //{

        //}
    }
}
