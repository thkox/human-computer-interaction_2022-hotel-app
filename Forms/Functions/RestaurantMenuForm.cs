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
            cart_richTextBox.Text = "Americano" + " " + quantityAmericano.Tag + " " + "x" + " " + "$" + " " + (quantityAmericano.Tag) + Environment.NewLine;
        }
    }
}
