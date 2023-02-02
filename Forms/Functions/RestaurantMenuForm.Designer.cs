namespace hotel_app.Forms.Functions
{
    partial class RestaurantMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartButton = new FontAwesome.Sharp.IconPictureBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.coffeeTabPage = new System.Windows.Forms.TabPage();
            this.quantityAmericano = new hotel_app.Custom_Toolbox.QuantityCustomControl();
            this.latteLabel = new System.Windows.Forms.Label();
            this.espressoLabel = new System.Windows.Forms.Label();
            this.capuccinoLabel = new System.Windows.Forms.Label();
            this.americanoLabel = new System.Windows.Forms.Label();
            this.capuccinoButton = new System.Windows.Forms.Button();
            this.latteButton = new System.Windows.Forms.Button();
            this.espressoButton = new System.Windows.Forms.Button();
            this.americanoButton = new System.Windows.Forms.Button();
            this.chocolatesTabPage = new System.Windows.Forms.TabPage();
            this.specialLabel = new System.Windows.Forms.Label();
            this.ferreroLabel = new System.Windows.Forms.Label();
            this.hospitalityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zeusHeartLabel = new System.Windows.Forms.Label();
            this.chocolateButton = new System.Windows.Forms.Button();
            this.specialButton = new System.Windows.Forms.Button();
            this.ferreroButton = new System.Windows.Forms.Button();
            this.hospitalityButton = new System.Windows.Forms.Button();
            this.zeusHeartButton = new System.Windows.Forms.Button();
            this.saladsTabPage = new System.Windows.Forms.TabPage();
            this.chefLabel = new System.Windows.Forms.Label();
            this.tricoloreLabel = new System.Windows.Forms.Label();
            this.aegeanLabel = new System.Windows.Forms.Label();
            this.greekLabel = new System.Windows.Forms.Label();
            this.aegeanButton = new System.Windows.Forms.Button();
            this.chefButton = new System.Windows.Forms.Button();
            this.tricoloreButton = new System.Windows.Forms.Button();
            this.greekButton = new System.Windows.Forms.Button();
            this.pizzaTabPage = new System.Windows.Forms.TabPage();
            this.palaceLabel = new System.Windows.Forms.Label();
            this.zeusSpecialButton = new System.Windows.Forms.Button();
            this.trojanLabel = new System.Windows.Forms.Label();
            this.trojanButton = new System.Windows.Forms.Button();
            this.athinaLabel = new System.Windows.Forms.Label();
            this.palaceButton = new System.Windows.Forms.Button();
            this.zeusSpecialLabel = new System.Windows.Forms.Label();
            this.athinaButton = new System.Windows.Forms.Button();
            this.greekCuisineTabPage = new System.Windows.Forms.TabPage();
            this.fiestaLabel = new System.Windows.Forms.Label();
            this.oceanLabel = new System.Windows.Forms.Label();
            this.chickenLabel = new System.Windows.Forms.Label();
            this.fiestaButton = new System.Windows.Forms.Button();
            this.chickenButton = new System.Windows.Forms.Button();
            this.oceanButton = new System.Windows.Forms.Button();
            this.elGrecoLabel = new System.Windows.Forms.Label();
            this.pastaLabel = new System.Windows.Forms.Label();
            this.tyromezesLabel = new System.Windows.Forms.Label();
            this.souvlakiLabel = new System.Windows.Forms.Label();
            this.tyromezesButton = new System.Windows.Forms.Button();
            this.elGrecoButton = new System.Windows.Forms.Button();
            this.pastaButton = new System.Windows.Forms.Button();
            this.souvlakiButton = new System.Windows.Forms.Button();
            this.cart_richTextBox = new System.Windows.Forms.RichTextBox();
            this.checkoutButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).BeginInit();
            this.menuTabControl.SuspendLayout();
            this.coffeeTabPage.SuspendLayout();
            this.chocolatesTabPage.SuspendLayout();
            this.saladsTabPage.SuspendLayout();
            this.pizzaTabPage.SuspendLayout();
            this.greekCuisineTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartButton
            // 
            this.cartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.cartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.cartButton.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.cartButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.cartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cartButton.Location = new System.Drawing.Point(969, 108);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(32, 32);
            this.cartButton.TabIndex = 3;
            this.cartButton.TabStop = false;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.menuLabel.Location = new System.Drawing.Point(100, 30);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(140, 35);
            this.menuLabel.TabIndex = 5;
            this.menuLabel.Text = "Menu Type";
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.coffeeTabPage);
            this.menuTabControl.Controls.Add(this.chocolatesTabPage);
            this.menuTabControl.Controls.Add(this.saladsTabPage);
            this.menuTabControl.Controls.Add(this.pizzaTabPage);
            this.menuTabControl.Controls.Add(this.greekCuisineTabPage);
            this.menuTabControl.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuTabControl.Location = new System.Drawing.Point(100, 121);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(670, 452);
            this.menuTabControl.TabIndex = 6;
            // 
            // coffeeTabPage
            // 
            this.coffeeTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.coffeeTabPage.Controls.Add(this.quantityAmericano);
            this.coffeeTabPage.Controls.Add(this.latteLabel);
            this.coffeeTabPage.Controls.Add(this.espressoLabel);
            this.coffeeTabPage.Controls.Add(this.capuccinoLabel);
            this.coffeeTabPage.Controls.Add(this.americanoLabel);
            this.coffeeTabPage.Controls.Add(this.capuccinoButton);
            this.coffeeTabPage.Controls.Add(this.latteButton);
            this.coffeeTabPage.Controls.Add(this.espressoButton);
            this.coffeeTabPage.Controls.Add(this.americanoButton);
            this.coffeeTabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coffeeTabPage.Location = new System.Drawing.Point(4, 26);
            this.coffeeTabPage.Name = "coffeeTabPage";
            this.coffeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.coffeeTabPage.Size = new System.Drawing.Size(662, 422);
            this.coffeeTabPage.TabIndex = 0;
            this.coffeeTabPage.Text = "Coffee";
            // 
            // quantityAmericano
            // 
            this.quantityAmericano.Location = new System.Drawing.Point(60, 274);
            this.quantityAmericano.Name = "quantityAmericano";
            this.quantityAmericano.Size = new System.Drawing.Size(118, 28);
            this.quantityAmericano.TabIndex = 20;
            this.quantityAmericano.Tag = "0";
            this.quantityAmericano.TagChanged += new System.EventHandler(this.quantityAmericano_TagChanged);
            // 
            // latteLabel
            // 
            this.latteLabel.AutoSize = true;
            this.latteLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.latteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.latteLabel.Location = new System.Drawing.Point(488, 248);
            this.latteLabel.Name = "latteLabel";
            this.latteLabel.Size = new System.Drawing.Size(97, 23);
            this.latteLabel.TabIndex = 19;
            this.latteLabel.Text = "Latte, 12€";
            // 
            // espressoLabel
            // 
            this.espressoLabel.AutoSize = true;
            this.espressoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.espressoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.espressoLabel.Location = new System.Drawing.Point(345, 248);
            this.espressoLabel.Name = "espressoLabel";
            this.espressoLabel.Size = new System.Drawing.Size(112, 23);
            this.espressoLabel.TabIndex = 18;
            this.espressoLabel.Text = "Espresso, 9€";
            // 
            // capuccinoLabel
            // 
            this.capuccinoLabel.AutoSize = true;
            this.capuccinoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.capuccinoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.capuccinoLabel.Location = new System.Drawing.Point(196, 248);
            this.capuccinoLabel.Name = "capuccinoLabel";
            this.capuccinoLabel.Size = new System.Drawing.Size(135, 23);
            this.capuccinoLabel.TabIndex = 17;
            this.capuccinoLabel.Text = "Cappuccino, 10€";
            // 
            // americanoLabel
            // 
            this.americanoLabel.AutoSize = true;
            this.americanoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.americanoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.americanoLabel.Location = new System.Drawing.Point(58, 248);
            this.americanoLabel.Name = "americanoLabel";
            this.americanoLabel.Size = new System.Drawing.Size(122, 23);
            this.americanoLabel.TabIndex = 16;
            this.americanoLabel.Text = "Americano, 8€";
            // 
            // capuccinoButton
            // 
            this.capuccinoButton.BackgroundImage = global::hotel_app.Properties.Resources.cappuccino;
            this.capuccinoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.capuccinoButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.capuccinoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.capuccinoButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.capuccinoButton.Location = new System.Drawing.Point(196, 125);
            this.capuccinoButton.Name = "capuccinoButton";
            this.capuccinoButton.Size = new System.Drawing.Size(120, 120);
            this.capuccinoButton.TabIndex = 15;
            this.capuccinoButton.Tag = "10";
            this.capuccinoButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.capuccinoButton.UseVisualStyleBackColor = true;
            // 
            // latteButton
            // 
            this.latteButton.BackgroundImage = global::hotel_app.Properties.Resources.latte;
            this.latteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.latteButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.latteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.latteButton.Location = new System.Drawing.Point(479, 125);
            this.latteButton.Name = "latteButton";
            this.latteButton.Size = new System.Drawing.Size(120, 120);
            this.latteButton.TabIndex = 14;
            this.latteButton.Tag = "12";
            this.latteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.latteButton.UseVisualStyleBackColor = true;
            // 
            // espressoButton
            // 
            this.espressoButton.BackgroundImage = global::hotel_app.Properties.Resources.espresso;
            this.espressoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.espressoButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.espressoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.espressoButton.Location = new System.Drawing.Point(337, 125);
            this.espressoButton.Name = "espressoButton";
            this.espressoButton.Size = new System.Drawing.Size(120, 120);
            this.espressoButton.TabIndex = 13;
            this.espressoButton.Tag = "9";
            this.espressoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.espressoButton.UseVisualStyleBackColor = true;
            // 
            // americanoButton
            // 
            this.americanoButton.BackgroundImage = global::hotel_app.Properties.Resources.americano;
            this.americanoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.americanoButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.americanoButton.ForeColor = System.Drawing.Color.Black;
            this.americanoButton.Location = new System.Drawing.Point(58, 125);
            this.americanoButton.Name = "americanoButton";
            this.americanoButton.Size = new System.Drawing.Size(120, 120);
            this.americanoButton.TabIndex = 12;
            this.americanoButton.Tag = "8";
            this.americanoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.americanoButton.UseVisualStyleBackColor = true;
            // 
            // chocolatesTabPage
            // 
            this.chocolatesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.chocolatesTabPage.Controls.Add(this.specialLabel);
            this.chocolatesTabPage.Controls.Add(this.ferreroLabel);
            this.chocolatesTabPage.Controls.Add(this.hospitalityLabel);
            this.chocolatesTabPage.Controls.Add(this.label8);
            this.chocolatesTabPage.Controls.Add(this.zeusHeartLabel);
            this.chocolatesTabPage.Controls.Add(this.chocolateButton);
            this.chocolatesTabPage.Controls.Add(this.specialButton);
            this.chocolatesTabPage.Controls.Add(this.ferreroButton);
            this.chocolatesTabPage.Controls.Add(this.hospitalityButton);
            this.chocolatesTabPage.Controls.Add(this.zeusHeartButton);
            this.chocolatesTabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chocolatesTabPage.Location = new System.Drawing.Point(4, 26);
            this.chocolatesTabPage.Name = "chocolatesTabPage";
            this.chocolatesTabPage.Size = new System.Drawing.Size(662, 422);
            this.chocolatesTabPage.TabIndex = 4;
            this.chocolatesTabPage.Text = "Chocolates";
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.specialLabel.Location = new System.Drawing.Point(58, 331);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(108, 23);
            this.specialLabel.TabIndex = 32;
            this.specialLabel.Text = "Special, 18€";
            // 
            // ferreroLabel
            // 
            this.ferreroLabel.AutoSize = true;
            this.ferreroLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ferreroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.ferreroLabel.Location = new System.Drawing.Point(479, 155);
            this.ferreroLabel.Name = "ferreroLabel";
            this.ferreroLabel.Size = new System.Drawing.Size(114, 23);
            this.ferreroLabel.TabIndex = 31;
            this.ferreroLabel.Text = "Ferrero, 13€";
            // 
            // hospitalityLabel
            // 
            this.hospitalityLabel.AutoSize = true;
            this.hospitalityLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hospitalityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.hospitalityLabel.Location = new System.Drawing.Point(336, 155);
            this.hospitalityLabel.Name = "hospitalityLabel";
            this.hospitalityLabel.Size = new System.Drawing.Size(137, 23);
            this.hospitalityLabel.TabIndex = 30;
            this.hospitalityLabel.Text = "Hospitality, 15€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label8.Location = new System.Drawing.Point(196, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Chocolate, 10€";
            // 
            // zeusHeartLabel
            // 
            this.zeusHeartLabel.AutoSize = true;
            this.zeusHeartLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeusHeartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.zeusHeartLabel.Location = new System.Drawing.Point(47, 155);
            this.zeusHeartLabel.Name = "zeusHeartLabel";
            this.zeusHeartLabel.Size = new System.Drawing.Size(143, 23);
            this.zeusHeartLabel.TabIndex = 28;
            this.zeusHeartLabel.Text = "Zeus Heart, 20€";
            // 
            // chocolateButton
            // 
            this.chocolateButton.BackgroundImage = global::hotel_app.Properties.Resources.chocolate_2;
            this.chocolateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chocolateButton.Enabled = false;
            this.chocolateButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chocolateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.chocolateButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chocolateButton.Location = new System.Drawing.Point(196, 32);
            this.chocolateButton.Name = "chocolateButton";
            this.chocolateButton.Size = new System.Drawing.Size(120, 120);
            this.chocolateButton.TabIndex = 27;
            this.chocolateButton.Tag = "10";
            this.chocolateButton.UseVisualStyleBackColor = true;
            // 
            // specialButton
            // 
            this.specialButton.BackgroundImage = global::hotel_app.Properties.Resources.chocolate_5;
            this.specialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.specialButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.specialButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.specialButton.Location = new System.Drawing.Point(58, 208);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(120, 120);
            this.specialButton.TabIndex = 25;
            this.specialButton.Tag = "18";
            this.specialButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.specialButton.UseVisualStyleBackColor = true;
            // 
            // ferreroButton
            // 
            this.ferreroButton.BackgroundImage = global::hotel_app.Properties.Resources.chocolate_4;
            this.ferreroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ferreroButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ferreroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.ferreroButton.Location = new System.Drawing.Point(479, 32);
            this.ferreroButton.Name = "ferreroButton";
            this.ferreroButton.Size = new System.Drawing.Size(120, 120);
            this.ferreroButton.TabIndex = 26;
            this.ferreroButton.Tag = "13";
            this.ferreroButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ferreroButton.UseVisualStyleBackColor = true;
            // 
            // hospitalityButton
            // 
            this.hospitalityButton.BackgroundImage = global::hotel_app.Properties.Resources.chocolate_3;
            this.hospitalityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hospitalityButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hospitalityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.hospitalityButton.Location = new System.Drawing.Point(337, 32);
            this.hospitalityButton.Name = "hospitalityButton";
            this.hospitalityButton.Size = new System.Drawing.Size(120, 120);
            this.hospitalityButton.TabIndex = 24;
            this.hospitalityButton.Tag = "15";
            this.hospitalityButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hospitalityButton.UseVisualStyleBackColor = true;
            // 
            // zeusHeartButton
            // 
            this.zeusHeartButton.BackgroundImage = global::hotel_app.Properties.Resources.chocolate_1;
            this.zeusHeartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zeusHeartButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeusHeartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.zeusHeartButton.Location = new System.Drawing.Point(58, 32);
            this.zeusHeartButton.Name = "zeusHeartButton";
            this.zeusHeartButton.Size = new System.Drawing.Size(120, 120);
            this.zeusHeartButton.TabIndex = 23;
            this.zeusHeartButton.Tag = "20";
            this.zeusHeartButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.zeusHeartButton.UseVisualStyleBackColor = true;
            // 
            // saladsTabPage
            // 
            this.saladsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.saladsTabPage.Controls.Add(this.chefLabel);
            this.saladsTabPage.Controls.Add(this.tricoloreLabel);
            this.saladsTabPage.Controls.Add(this.aegeanLabel);
            this.saladsTabPage.Controls.Add(this.greekLabel);
            this.saladsTabPage.Controls.Add(this.aegeanButton);
            this.saladsTabPage.Controls.Add(this.chefButton);
            this.saladsTabPage.Controls.Add(this.tricoloreButton);
            this.saladsTabPage.Controls.Add(this.greekButton);
            this.saladsTabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saladsTabPage.Location = new System.Drawing.Point(4, 26);
            this.saladsTabPage.Name = "saladsTabPage";
            this.saladsTabPage.Size = new System.Drawing.Size(662, 422);
            this.saladsTabPage.TabIndex = 3;
            this.saladsTabPage.Text = "Salads";
            // 
            // chefLabel
            // 
            this.chefLabel.AutoSize = true;
            this.chefLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chefLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.chefLabel.Location = new System.Drawing.Point(499, 248);
            this.chefLabel.Name = "chefLabel";
            this.chefLabel.Size = new System.Drawing.Size(80, 23);
            this.chefLabel.TabIndex = 28;
            this.chefLabel.Text = "Chef, 8€";
            // 
            // tricoloreLabel
            // 
            this.tricoloreLabel.AutoSize = true;
            this.tricoloreLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tricoloreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.tricoloreLabel.Location = new System.Drawing.Point(337, 248);
            this.tricoloreLabel.Name = "tricoloreLabel";
            this.tricoloreLabel.Size = new System.Drawing.Size(122, 23);
            this.tricoloreLabel.TabIndex = 27;
            this.tricoloreLabel.Text = "Tricolore, 10€";
            // 
            // aegeanLabel
            // 
            this.aegeanLabel.AutoSize = true;
            this.aegeanLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aegeanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.aegeanLabel.Location = new System.Drawing.Point(201, 248);
            this.aegeanLabel.Name = "aegeanLabel";
            this.aegeanLabel.Size = new System.Drawing.Size(110, 23);
            this.aegeanLabel.TabIndex = 26;
            this.aegeanLabel.Text = "Aegean, 15€";
            // 
            // greekLabel
            // 
            this.greekLabel.AutoSize = true;
            this.greekLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greekLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.greekLabel.Location = new System.Drawing.Point(69, 248);
            this.greekLabel.Name = "greekLabel";
            this.greekLabel.Size = new System.Drawing.Size(100, 23);
            this.greekLabel.TabIndex = 25;
            this.greekLabel.Text = "Greek, 10€";
            // 
            // aegeanButton
            // 
            this.aegeanButton.BackgroundImage = global::hotel_app.Properties.Resources.salad_2;
            this.aegeanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aegeanButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aegeanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.aegeanButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aegeanButton.Location = new System.Drawing.Point(196, 125);
            this.aegeanButton.Name = "aegeanButton";
            this.aegeanButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aegeanButton.Size = new System.Drawing.Size(120, 120);
            this.aegeanButton.TabIndex = 24;
            this.aegeanButton.Tag = "15";
            this.aegeanButton.UseVisualStyleBackColor = true;
            // 
            // chefButton
            // 
            this.chefButton.BackgroundImage = global::hotel_app.Properties.Resources.salad_4;
            this.chefButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chefButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chefButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.chefButton.Location = new System.Drawing.Point(479, 125);
            this.chefButton.Name = "chefButton";
            this.chefButton.Size = new System.Drawing.Size(120, 120);
            this.chefButton.TabIndex = 23;
            this.chefButton.Tag = "8";
            this.chefButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chefButton.UseVisualStyleBackColor = true;
            // 
            // tricoloreButton
            // 
            this.tricoloreButton.BackgroundImage = global::hotel_app.Properties.Resources.salad_3;
            this.tricoloreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tricoloreButton.Enabled = false;
            this.tricoloreButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tricoloreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.tricoloreButton.Location = new System.Drawing.Point(337, 125);
            this.tricoloreButton.Name = "tricoloreButton";
            this.tricoloreButton.Size = new System.Drawing.Size(120, 120);
            this.tricoloreButton.TabIndex = 22;
            this.tricoloreButton.Tag = "10";
            this.tricoloreButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tricoloreButton.UseVisualStyleBackColor = true;
            // 
            // greekButton
            // 
            this.greekButton.BackgroundImage = global::hotel_app.Properties.Resources.salad_1;
            this.greekButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greekButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greekButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.greekButton.Location = new System.Drawing.Point(58, 125);
            this.greekButton.Name = "greekButton";
            this.greekButton.Size = new System.Drawing.Size(120, 120);
            this.greekButton.TabIndex = 21;
            this.greekButton.Tag = "10";
            this.greekButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.greekButton.UseVisualStyleBackColor = true;
            // 
            // pizzaTabPage
            // 
            this.pizzaTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.pizzaTabPage.Controls.Add(this.palaceLabel);
            this.pizzaTabPage.Controls.Add(this.zeusSpecialButton);
            this.pizzaTabPage.Controls.Add(this.trojanLabel);
            this.pizzaTabPage.Controls.Add(this.trojanButton);
            this.pizzaTabPage.Controls.Add(this.athinaLabel);
            this.pizzaTabPage.Controls.Add(this.palaceButton);
            this.pizzaTabPage.Controls.Add(this.zeusSpecialLabel);
            this.pizzaTabPage.Controls.Add(this.athinaButton);
            this.pizzaTabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pizzaTabPage.Location = new System.Drawing.Point(4, 26);
            this.pizzaTabPage.Name = "pizzaTabPage";
            this.pizzaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pizzaTabPage.Size = new System.Drawing.Size(662, 422);
            this.pizzaTabPage.TabIndex = 1;
            this.pizzaTabPage.Text = "Pizza";
            // 
            // palaceLabel
            // 
            this.palaceLabel.AutoSize = true;
            this.palaceLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.palaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.palaceLabel.Location = new System.Drawing.Point(488, 247);
            this.palaceLabel.Name = "palaceLabel";
            this.palaceLabel.Size = new System.Drawing.Size(102, 23);
            this.palaceLabel.TabIndex = 12;
            this.palaceLabel.Text = "Palace, 40€";
            // 
            // zeusSpecialButton
            // 
            this.zeusSpecialButton.BackgroundImage = global::hotel_app.Properties.Resources.pizza_1;
            this.zeusSpecialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zeusSpecialButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeusSpecialButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.zeusSpecialButton.Location = new System.Drawing.Point(58, 125);
            this.zeusSpecialButton.Name = "zeusSpecialButton";
            this.zeusSpecialButton.Size = new System.Drawing.Size(120, 120);
            this.zeusSpecialButton.TabIndex = 1;
            this.zeusSpecialButton.Tag = "30";
            this.zeusSpecialButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.zeusSpecialButton.UseVisualStyleBackColor = true;
            // 
            // trojanLabel
            // 
            this.trojanLabel.AutoSize = true;
            this.trojanLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trojanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.trojanLabel.Location = new System.Drawing.Point(347, 248);
            this.trojanLabel.Name = "trojanLabel";
            this.trojanLabel.Size = new System.Drawing.Size(104, 23);
            this.trojanLabel.TabIndex = 11;
            this.trojanLabel.Text = "Trojan, 10€";
            // 
            // trojanButton
            // 
            this.trojanButton.BackgroundImage = global::hotel_app.Properties.Resources.pizza_3;
            this.trojanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trojanButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trojanButton.ForeColor = System.Drawing.Color.Black;
            this.trojanButton.Location = new System.Drawing.Point(337, 125);
            this.trojanButton.Name = "trojanButton";
            this.trojanButton.Size = new System.Drawing.Size(120, 120);
            this.trojanButton.TabIndex = 3;
            this.trojanButton.Tag = "10";
            this.trojanButton.UseVisualStyleBackColor = true;
            // 
            // athinaLabel
            // 
            this.athinaLabel.AutoSize = true;
            this.athinaLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.athinaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.athinaLabel.Location = new System.Drawing.Point(203, 247);
            this.athinaLabel.Name = "athinaLabel";
            this.athinaLabel.Size = new System.Drawing.Size(104, 23);
            this.athinaLabel.TabIndex = 10;
            this.athinaLabel.Text = "Athina, 15€";
            // 
            // palaceButton
            // 
            this.palaceButton.BackgroundImage = global::hotel_app.Properties.Resources.pizza_4;
            this.palaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.palaceButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.palaceButton.ForeColor = System.Drawing.Color.Blue;
            this.palaceButton.Location = new System.Drawing.Point(479, 125);
            this.palaceButton.Name = "palaceButton";
            this.palaceButton.Size = new System.Drawing.Size(120, 120);
            this.palaceButton.TabIndex = 5;
            this.palaceButton.Tag = "40";
            this.palaceButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.palaceButton.UseVisualStyleBackColor = true;
            // 
            // zeusSpecialLabel
            // 
            this.zeusSpecialLabel.AutoSize = true;
            this.zeusSpecialLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zeusSpecialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.zeusSpecialLabel.Location = new System.Drawing.Point(42, 248);
            this.zeusSpecialLabel.Name = "zeusSpecialLabel";
            this.zeusSpecialLabel.Size = new System.Drawing.Size(151, 23);
            this.zeusSpecialLabel.TabIndex = 9;
            this.zeusSpecialLabel.Text = "Zeus Special, 30€";
            // 
            // athinaButton
            // 
            this.athinaButton.BackgroundImage = global::hotel_app.Properties.Resources.pizza_2;
            this.athinaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.athinaButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.athinaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.athinaButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.athinaButton.Location = new System.Drawing.Point(196, 125);
            this.athinaButton.Name = "athinaButton";
            this.athinaButton.Size = new System.Drawing.Size(120, 120);
            this.athinaButton.TabIndex = 7;
            this.athinaButton.Tag = "15";
            this.athinaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.athinaButton.UseVisualStyleBackColor = true;
            // 
            // greekCuisineTabPage
            // 
            this.greekCuisineTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.greekCuisineTabPage.Controls.Add(this.fiestaLabel);
            this.greekCuisineTabPage.Controls.Add(this.oceanLabel);
            this.greekCuisineTabPage.Controls.Add(this.chickenLabel);
            this.greekCuisineTabPage.Controls.Add(this.fiestaButton);
            this.greekCuisineTabPage.Controls.Add(this.chickenButton);
            this.greekCuisineTabPage.Controls.Add(this.oceanButton);
            this.greekCuisineTabPage.Controls.Add(this.elGrecoLabel);
            this.greekCuisineTabPage.Controls.Add(this.pastaLabel);
            this.greekCuisineTabPage.Controls.Add(this.tyromezesLabel);
            this.greekCuisineTabPage.Controls.Add(this.souvlakiLabel);
            this.greekCuisineTabPage.Controls.Add(this.tyromezesButton);
            this.greekCuisineTabPage.Controls.Add(this.elGrecoButton);
            this.greekCuisineTabPage.Controls.Add(this.pastaButton);
            this.greekCuisineTabPage.Controls.Add(this.souvlakiButton);
            this.greekCuisineTabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greekCuisineTabPage.Location = new System.Drawing.Point(4, 26);
            this.greekCuisineTabPage.Name = "greekCuisineTabPage";
            this.greekCuisineTabPage.Size = new System.Drawing.Size(662, 422);
            this.greekCuisineTabPage.TabIndex = 2;
            this.greekCuisineTabPage.Text = "Greek Cuisine";
            // 
            // fiestaLabel
            // 
            this.fiestaLabel.AutoSize = true;
            this.fiestaLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiestaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.fiestaLabel.Location = new System.Drawing.Point(345, 331);
            this.fiestaLabel.Name = "fiestaLabel";
            this.fiestaLabel.Size = new System.Drawing.Size(102, 23);
            this.fiestaLabel.TabIndex = 27;
            this.fiestaLabel.Text = "Fiesta, 24€";
            // 
            // oceanLabel
            // 
            this.oceanLabel.AutoSize = true;
            this.oceanLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oceanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.oceanLabel.Location = new System.Drawing.Point(205, 331);
            this.oceanLabel.Name = "oceanLabel";
            this.oceanLabel.Size = new System.Drawing.Size(101, 23);
            this.oceanLabel.TabIndex = 26;
            this.oceanLabel.Text = "Ocean, 30€";
            // 
            // chickenLabel
            // 
            this.chickenLabel.AutoSize = true;
            this.chickenLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chickenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.chickenLabel.Location = new System.Drawing.Point(68, 331);
            this.chickenLabel.Name = "chickenLabel";
            this.chickenLabel.Size = new System.Drawing.Size(101, 23);
            this.chickenLabel.TabIndex = 25;
            this.chickenLabel.Text = "Chicken, 7€";
            // 
            // fiestaButton
            // 
            this.fiestaButton.BackgroundImage = global::hotel_app.Properties.Resources.food_2;
            this.fiestaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fiestaButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiestaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.fiestaButton.Location = new System.Drawing.Point(337, 208);
            this.fiestaButton.Name = "fiestaButton";
            this.fiestaButton.Size = new System.Drawing.Size(120, 120);
            this.fiestaButton.TabIndex = 22;
            this.fiestaButton.Tag = "24";
            this.fiestaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fiestaButton.UseVisualStyleBackColor = true;
            // 
            // chickenButton
            // 
            this.chickenButton.BackgroundImage = global::hotel_app.Properties.Resources.food_4;
            this.chickenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chickenButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chickenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.chickenButton.Location = new System.Drawing.Point(58, 208);
            this.chickenButton.Name = "chickenButton";
            this.chickenButton.Size = new System.Drawing.Size(120, 120);
            this.chickenButton.TabIndex = 23;
            this.chickenButton.Tag = "7";
            this.chickenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chickenButton.UseVisualStyleBackColor = true;
            // 
            // oceanButton
            // 
            this.oceanButton.BackgroundImage = global::hotel_app.Properties.Resources.food_6;
            this.oceanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oceanButton.Enabled = false;
            this.oceanButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oceanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.oceanButton.Location = new System.Drawing.Point(196, 208);
            this.oceanButton.Name = "oceanButton";
            this.oceanButton.Size = new System.Drawing.Size(120, 120);
            this.oceanButton.TabIndex = 24;
            this.oceanButton.Tag = "30";
            this.oceanButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oceanButton.UseVisualStyleBackColor = true;
            // 
            // elGrecoLabel
            // 
            this.elGrecoLabel.AutoSize = true;
            this.elGrecoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.elGrecoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.elGrecoLabel.Location = new System.Drawing.Point(479, 155);
            this.elGrecoLabel.Name = "elGrecoLabel";
            this.elGrecoLabel.Size = new System.Drawing.Size(119, 23);
            this.elGrecoLabel.TabIndex = 21;
            this.elGrecoLabel.Text = "El Greco, 20€";
            // 
            // pastaLabel
            // 
            this.pastaLabel.AutoSize = true;
            this.pastaLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pastaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.pastaLabel.Location = new System.Drawing.Point(354, 155);
            this.pastaLabel.Name = "pastaLabel";
            this.pastaLabel.Size = new System.Drawing.Size(87, 23);
            this.pastaLabel.TabIndex = 20;
            this.pastaLabel.Text = "Pasta, 8€";
            // 
            // tyromezesLabel
            // 
            this.tyromezesLabel.AutoSize = true;
            this.tyromezesLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tyromezesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.tyromezesLabel.Location = new System.Drawing.Point(196, 155);
            this.tyromezesLabel.Name = "tyromezesLabel";
            this.tyromezesLabel.Size = new System.Drawing.Size(127, 23);
            this.tyromezesLabel.TabIndex = 19;
            this.tyromezesLabel.Text = "Tyromezes, 4€";
            // 
            // souvlakiLabel
            // 
            this.souvlakiLabel.AutoSize = true;
            this.souvlakiLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.souvlakiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.souvlakiLabel.Location = new System.Drawing.Point(64, 155);
            this.souvlakiLabel.Name = "souvlakiLabel";
            this.souvlakiLabel.Size = new System.Drawing.Size(105, 23);
            this.souvlakiLabel.TabIndex = 18;
            this.souvlakiLabel.Text = "Souvlaki, 5€";
            // 
            // tyromezesButton
            // 
            this.tyromezesButton.BackgroundImage = global::hotel_app.Properties.Resources.food_7;
            this.tyromezesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tyromezesButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tyromezesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.tyromezesButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tyromezesButton.Location = new System.Drawing.Point(196, 32);
            this.tyromezesButton.Name = "tyromezesButton";
            this.tyromezesButton.Size = new System.Drawing.Size(120, 120);
            this.tyromezesButton.TabIndex = 17;
            this.tyromezesButton.Tag = "4";
            this.tyromezesButton.UseVisualStyleBackColor = true;
            // 
            // elGrecoButton
            // 
            this.elGrecoButton.BackgroundImage = global::hotel_app.Properties.Resources.food_5;
            this.elGrecoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elGrecoButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.elGrecoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.elGrecoButton.Location = new System.Drawing.Point(479, 32);
            this.elGrecoButton.Name = "elGrecoButton";
            this.elGrecoButton.Size = new System.Drawing.Size(120, 120);
            this.elGrecoButton.TabIndex = 16;
            this.elGrecoButton.Tag = "20";
            this.elGrecoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.elGrecoButton.UseVisualStyleBackColor = true;
            // 
            // pastaButton
            // 
            this.pastaButton.BackgroundImage = global::hotel_app.Properties.Resources.food_3;
            this.pastaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pastaButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pastaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.pastaButton.Location = new System.Drawing.Point(337, 32);
            this.pastaButton.Name = "pastaButton";
            this.pastaButton.Size = new System.Drawing.Size(120, 120);
            this.pastaButton.TabIndex = 15;
            this.pastaButton.Tag = "8";
            this.pastaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pastaButton.UseVisualStyleBackColor = true;
            // 
            // souvlakiButton
            // 
            this.souvlakiButton.BackgroundImage = global::hotel_app.Properties.Resources.food_1;
            this.souvlakiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.souvlakiButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.souvlakiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.souvlakiButton.Location = new System.Drawing.Point(58, 32);
            this.souvlakiButton.Name = "souvlakiButton";
            this.souvlakiButton.Size = new System.Drawing.Size(120, 120);
            this.souvlakiButton.TabIndex = 14;
            this.souvlakiButton.Tag = "5";
            this.souvlakiButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.souvlakiButton.UseVisualStyleBackColor = true;
            // 
            // cart_richTextBox
            // 
            this.cart_richTextBox.Location = new System.Drawing.Point(776, 147);
            this.cart_richTextBox.Name = "cart_richTextBox";
            this.cart_richTextBox.Size = new System.Drawing.Size(225, 376);
            this.cart_richTextBox.TabIndex = 7;
            this.cart_richTextBox.Text = "";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutButton.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.checkoutButton.IconColor = System.Drawing.Color.Black;
            this.checkoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutButton.Location = new System.Drawing.Point(776, 529);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(225, 44);
            this.checkoutButton.TabIndex = 8;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // RestaurantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.cart_richTextBox);
            this.Controls.Add(this.menuTabControl);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.cartButton);
            this.Name = "RestaurantMenuForm";
            this.Text = "RestaurantMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).EndInit();
            this.menuTabControl.ResumeLayout(false);
            this.coffeeTabPage.ResumeLayout(false);
            this.coffeeTabPage.PerformLayout();
            this.chocolatesTabPage.ResumeLayout(false);
            this.chocolatesTabPage.PerformLayout();
            this.saladsTabPage.ResumeLayout(false);
            this.saladsTabPage.PerformLayout();
            this.pizzaTabPage.ResumeLayout(false);
            this.pizzaTabPage.PerformLayout();
            this.greekCuisineTabPage.ResumeLayout(false);
            this.greekCuisineTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox cartButton;
        private Label menuLabel;
        private TabControl menuTabControl;
        private TabPage coffeeTabPage;
        private TabPage pizzaTabPage;
        private TabPage greekCuisineTabPage;
        private TabPage saladsTabPage;
        private TabPage chocolatesTabPage;
        private Label latteLabel;
        private Label espressoLabel;
        private Label capuccinoLabel;
        private Label americanoLabel;
        private Button capuccinoButton;
        private Button latteButton;
        private Button espressoButton;
        private Button americanoButton;
        private RichTextBox cart_richTextBox;
        private Label specialLabel;
        private Label ferreroLabel;
        private Label hospitalityLabel;
        private Label label8;
        private Label zeusHeartLabel;
        private Button chocolateButton;
        private Button specialButton;
        private Button ferreroButton;
        private Button hospitalityButton;
        private Button zeusHeartButton;
        private Label palaceLabel;
        private Button zeusSpecialButton;
        private Label trojanLabel;
        private Button trojanButton;
        private Label athinaLabel;
        private Button palaceButton;
        private Label zeusSpecialLabel;
        private Button athinaButton;
        private Label chefLabel;
        private Label tricoloreLabel;
        private Label aegeanLabel;
        private Label greekLabel;
        private Button aegeanButton;
        private Button chefButton;
        private Button tricoloreButton;
        private Button greekButton;
        private Label fiestaLabel;
        private Label oceanLabel;
        private Label chickenLabel;
        private Button fiestaButton;
        private Button chickenButton;
        private Button oceanButton;
        private Label elGrecoLabel;
        private Label pastaLabel;
        private Label tyromezesLabel;
        private Label souvlakiLabel;
        private Button tyromezesButton;
        private Button elGrecoButton;
        private Button pastaButton;
        private Button souvlakiButton;
        private FontAwesome.Sharp.IconButton checkoutButton;
        private Custom_Toolbox.QuantityCustomControl quantityAmericano;
    }
}