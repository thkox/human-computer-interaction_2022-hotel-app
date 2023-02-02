using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace hotel_app.Forms.Functions
{
    public partial class RestaurantMenuForm : Form
    {
        public RestaurantMenuForm()
        {
            InitializeComponent();
            //Coffee
            quantityAmericano.TagChanged += new System.EventHandler(quantityAmericano_TagChanged);
            quantityCappuccino.TagChanged += new System.EventHandler(quantityCappuccino_TagChanged);
            quantityEspresso.TagChanged += new System.EventHandler(quantityEspresso_TagChanged);
            quantityLatte.TagChanged += new System.EventHandler(quantityLatte_TagChanged);
            //Chocolates
            quantityZeusHeart.TagChanged += new System.EventHandler(quantityZeusHeart_TagChanged);
            quantityChocolate.TagChanged += new System.EventHandler(quantityChocolate_TagChanged);
            quantityHospitality.TagChanged += new System.EventHandler(quantityHospitality_TagChanged);
            quantityFerrero.TagChanged += new System.EventHandler(quantityFerrero_TagChanged);
            quantitySpecial.TagChanged += new System.EventHandler(quantitySpecial_TagChanged);
            //Salads
            quantityGreek.TagChanged += new System.EventHandler(quantityGreek_TagChanged);
            quantityAegean.TagChanged += new System.EventHandler(quantityAegean_TagChanged);
            quantityTricolore.TagChanged += new System.EventHandler(quantityTricolore_TagChanged);
            quantityChef.TagChanged += new System.EventHandler(quantityChef_TagChanged);
            //Pizza
            quantityZeusSpecial.TagChanged += new System.EventHandler(quantityZeusSpecial_TagChanged);
            quantityAthina.TagChanged += new System.EventHandler(quantityAthina_TagChanged);
            quantityTrojan.TagChanged += new System.EventHandler(quantityTrojan_TagChanged);
            quantityPalace.TagChanged += new System.EventHandler(quantityPalace_TagChanged);
            //Greek Cuisine
            quantitySouvlaki.TagChanged += new System.EventHandler(quantitySouvlaki_TagChanged);
            quantityTyromezes.TagChanged += new System.EventHandler(quantityTyromezes_TagChanged);
            quantityPasta.TagChanged += new System.EventHandler(quantityPasta_TagChanged);
            quantityElGreco.TagChanged += new System.EventHandler(quantityElGreco_TagChanged);
            quantityChicken.TagChanged += new System.EventHandler(quantityChicken_TagChanged);
            quantityOcean.TagChanged += new System.EventHandler(quantityOcean_TagChanged);
            quantityFiesta.TagChanged += new System.EventHandler(quantityFiesta_TagChanged);
        }

        //Coffee
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

        //Chocolates
        private void quantityZeusHeart_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Zeus Heart x" + quantityZeusHeart.Tag + " " + (Convert.ToInt32(quantityZeusHeart.Tag) * Convert.ToInt32(zeusHeartButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityChocolate_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Chocolate x" + quantityChocolate.Tag + " " + (Convert.ToInt32(quantityChocolate.Tag) * Convert.ToInt32(chocolateButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityHospitality_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Hospitality x" + quantityHospitality.Tag + " " + (Convert.ToInt32(quantityHospitality.Tag) * Convert.ToInt32(hospitalityButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityFerrero_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Ferrero x" + quantityFerrero.Tag + " " + (Convert.ToInt32(quantityFerrero.Tag) * Convert.ToInt32(ferreroButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantitySpecial_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Special x" + quantitySpecial.Tag + " " + (Convert.ToInt32(quantitySpecial.Tag) * Convert.ToInt32(specialButton.Tag)) + "€" + Environment.NewLine;
        }

        //Salads
        private void quantityGreek_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Greek x" + quantityGreek.Tag + " " + (Convert.ToInt32(quantityGreek.Tag) * Convert.ToInt32(greekButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityAegean_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Aegean x" + quantityAegean.Tag + " " + (Convert.ToInt32(quantityAegean.Tag) * Convert.ToInt32(aegeanButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityTricolore_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Tricolore x" + quantityTricolore.Tag + " " + (Convert.ToInt32(quantityTricolore.Tag) * Convert.ToInt32(tricoloreButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityChef_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Chef x" + quantityChef.Tag + " " + (Convert.ToInt32(quantityChef.Tag) * Convert.ToInt32(chefButton.Tag)) + "€" + Environment.NewLine;
        }

        //Pizza
        private void quantityZeusSpecial_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Zeus Special x" + quantityZeusSpecial.Tag + " " + (Convert.ToInt32(quantityZeusSpecial.Tag) * Convert.ToInt32(zeusSpecialButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityAthina_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Athina x" + quantityAthina.Tag + " " + (Convert.ToInt32(quantityAthina.Tag) * Convert.ToInt32(athinaButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityTrojan_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Trojan x" + quantityTrojan.Tag + " " + (Convert.ToInt32(quantityTrojan.Tag) * Convert.ToInt32(trojanButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityPalace_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Palace x" + quantityPalace.Tag + " " + (Convert.ToInt32(quantityPalace.Tag) * Convert.ToInt32(palaceButton.Tag)) + "€" + Environment.NewLine;
        }

        //Greek Cuisine
        private void quantitySouvlaki_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Souvlaki x" + quantitySouvlaki.Tag + " " + (Convert.ToInt32(quantitySouvlaki.Tag) * Convert.ToInt32(souvlakiButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityTyromezes_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Tyromezes x" + quantityTyromezes.Tag + " " + (Convert.ToInt32(quantityTyromezes.Tag) * Convert.ToInt32(tyromezesButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityPasta_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Pasta x" + quantityPasta.Tag + " " + (Convert.ToInt32(quantityPasta.Tag) * Convert.ToInt32(pastaButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityElGreco_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "El Greco x" + quantityElGreco.Tag + " " + (Convert.ToInt32(quantityElGreco.Tag) * Convert.ToInt32(elGrecoButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityChicken_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Chicken x" + quantityChicken.Tag + " " + (Convert.ToInt32(quantityChicken.Tag) * Convert.ToInt32(chickenButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityOcean_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Ocean x" + quantityOcean.Tag + " " + (Convert.ToInt32(quantityOcean.Tag) * Convert.ToInt32(oceanButton.Tag)) + "€" + Environment.NewLine;
        }
        private void quantityFiesta_TagChanged(object sender, EventArgs e)
        {
            cart_richTextBox.Text = cart_richTextBox.Text + "Fiesta x" + quantityFiesta.Tag + " " + (Convert.ToInt32(quantityFiesta.Tag) * Convert.ToInt32(fiestaButton.Tag)) + "€" + Environment.NewLine;
        }
    }
}
