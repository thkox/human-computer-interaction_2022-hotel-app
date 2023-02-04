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
        private Panel restaurantMenuTabs;

        private Form currentChildForm;

        private ChatForm chatSupport = new ChatForm();

        int total;
        private List<string> menu = new List<string> {"Americano", "Cappuccino", "Espresso", "Latte",  //coffee
        "Zeus Heart", "Chocolate", "Hospitality", "Ferrero", "Special", //chocolates
        "Greek", "Aegean", "Tricolore", "Chef", //salads
        "Zeus Special", "Athina", "Trojan", "Palace", //pizza
        "Souvlaki", "Tyromezes", "Pasta", "El Greco", "Chicken", "Ocean", "Fiesta"}; //greek cuisine
        public RestaurantMenuForm()
        {
            InitializeComponent();
            cartTotal();
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

            //if the user completes the order using the chat
            chatSupport.OrderedCompleted += new ChatForm.CustomEventHandler(chatSupport_OrderedCompleted);
        }

        private void chatSupport_OrderedCompleted(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            payment.total_richTextBox.Text = $"{chatSupport.total}€";
            OpenPaymentForm(payment);
        }

        //Coffee
        private void quantityAmericano_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        private void quantityCappuccino_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        private void quantityEspresso_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        private void quantityLatte_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        //Chocolates
        private void quantityZeusHeart_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityChocolate_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityHospitality_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityFerrero_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantitySpecial_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        //Salads
        private void quantityGreek_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityAegean_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityTricolore_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityChef_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        //Pizza
        private void quantityZeusSpecial_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityAthina_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityTrojan_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityPalace_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        //Greek Cuisine
        private void quantitySouvlaki_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityTyromezes_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityPasta_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityElGreco_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityChicken_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityOcean_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }
        private void quantityFiesta_TagChanged(object sender, EventArgs e)
        {
            cartTotal();
            cart_richTextBox.Text = "";
            writeCartList();
        }

        private void cartTotal()
        {
            total = (Convert.ToInt32(quantityAmericano.Tag) * Convert.ToInt32(americanoButton.Tag)) + (Convert.ToInt32(quantityCappuccino.Tag) * Convert.ToInt32(cappuccinoButton.Tag)) + (Convert.ToInt32(quantityEspresso.Tag) * Convert.ToInt32(espressoButton.Tag)) + (Convert.ToInt32(quantityLatte.Tag) * Convert.ToInt32(latteButton.Tag)) //coffee
                + (Convert.ToInt32(quantityZeusHeart.Tag) * Convert.ToInt32(zeusHeartButton.Tag)) + (Convert.ToInt32(quantityChocolate.Tag) * Convert.ToInt32(chocolateButton.Tag)) + (Convert.ToInt32(quantityHospitality.Tag) * Convert.ToInt32(hospitalityButton.Tag)) + (Convert.ToInt32(quantityFerrero.Tag) * Convert.ToInt32(ferreroButton.Tag)) + (Convert.ToInt32(quantitySpecial.Tag) * Convert.ToInt32(specialButton.Tag)) //chocolates
                + (Convert.ToInt32(quantityGreek.Tag) * Convert.ToInt32(greekButton.Tag)) + (Convert.ToInt32(quantityAegean.Tag) * Convert.ToInt32(aegeanButton.Tag)) + (Convert.ToInt32(quantityTricolore.Tag) * Convert.ToInt32(tricoloreButton.Tag)) + (Convert.ToInt32(quantityChef.Tag) * Convert.ToInt32(chefButton.Tag)) //salads
                + (Convert.ToInt32(quantityZeusSpecial.Tag) * Convert.ToInt32(zeusSpecialButton.Tag)) + (Convert.ToInt32(quantityAthina.Tag) * Convert.ToInt32(athinaButton.Tag)) + (Convert.ToInt32(quantityTrojan.Tag) * Convert.ToInt32(trojanButton.Tag)) + (Convert.ToInt32(quantityPalace.Tag) * Convert.ToInt32(palaceButton.Tag)) //pizza
                + (Convert.ToInt32(quantitySouvlaki.Tag) * Convert.ToInt32(souvlakiButton.Tag)) + (Convert.ToInt32(quantityTyromezes.Tag) * Convert.ToInt32(tyromezesButton.Tag)) + (Convert.ToInt32(quantityPasta.Tag) * Convert.ToInt32(pastaButton.Tag)) + (Convert.ToInt32(quantityElGreco.Tag) * Convert.ToInt32(elGrecoButton.Tag)) + (Convert.ToInt32(quantityChicken.Tag) * Convert.ToInt32(chickenButton.Tag)) + (Convert.ToInt32(quantityOcean.Tag) * Convert.ToInt32(oceanButton.Tag)) + (Convert.ToInt32(quantityFiesta.Tag) * Convert.ToInt32(fiestaButton.Tag)); //greek cuisine
            total_richTextBox.Text = total.ToString() + "€";
            if (total == 0)
            {
                checkoutButton.Enabled = false;
            }
            else
            {
                checkoutButton.Enabled = true;
            }
        }
        
        private void writeCartList()
        {
            List<int> menu_quantity_tags = new List<int> {
            Convert.ToInt32(quantityAmericano.Tag), Convert.ToInt32(quantityCappuccino.Tag), Convert.ToInt32(quantityEspresso.Tag), Convert.ToInt32(quantityLatte.Tag), //coffee
            Convert.ToInt32(quantityZeusHeart.Tag), Convert.ToInt32(quantityChocolate.Tag), Convert.ToInt32(quantityHospitality.Tag), Convert.ToInt32(quantityFerrero.Tag), Convert.ToInt32(quantitySpecial.Tag), //chocolates
            Convert.ToInt32(quantityGreek.Tag), Convert.ToInt32(quantityAegean.Tag), Convert.ToInt32(quantityTricolore.Tag), Convert.ToInt32(quantityChef.Tag), //salads
            Convert.ToInt32(quantityZeusSpecial.Tag), Convert.ToInt32(quantityAthina.Tag), Convert.ToInt32(quantityTrojan.Tag), Convert.ToInt32(quantityPalace.Tag), //pizza
            Convert.ToInt32(quantitySouvlaki.Tag), Convert.ToInt32(quantityTyromezes.Tag), Convert.ToInt32(quantityPasta.Tag), Convert.ToInt32(quantityElGreco.Tag), Convert.ToInt32(quantityChicken.Tag), Convert.ToInt32(quantityOcean.Tag), Convert.ToInt32(quantityFiesta.Tag)}; //greek cuisine
            
            for (int i = 0; i < menu_quantity_tags.Count; i++)
            {
                if (menu_quantity_tags[i] > 0)
                {
                    if (menu[i] == "Tricolore")
                    {
                        cart_richTextBox.Text = cart_richTextBox.Text + menu[i] + "\t\tx" + menu_quantity_tags[i] + "" + Environment.NewLine;
                    }
                    else if (menu[i].Length > 8)
                    {
                        cart_richTextBox.Text = cart_richTextBox.Text + menu[i] + "\tx" + menu_quantity_tags[i] + "" + Environment.NewLine;
                    }
                    else
                    {
                        cart_richTextBox.Text = cart_richTextBox.Text + menu[i] + "\t\tx" + menu_quantity_tags[i] + "" + Environment.NewLine;
                    }
                }
            }
        }

        private void OpenPaymentForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            menuLoadFormsPanel.Controls.Add(childForm);
            menuLoadFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void RestaurantMenuForm_Load(object sender, EventArgs e)
        {
            restaurantMenuTabs = menuLoadFormsPanel;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm();
            payment.total_richTextBox.Text = total_richTextBox.Text;
            OpenPaymentForm(payment);
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            menuLoadFormsPanel = restaurantMenuTabs;
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            chatSupport.Show();
        }

        private void menuLoadFormsPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
