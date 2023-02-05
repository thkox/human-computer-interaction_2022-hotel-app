using System.Resources;

namespace hotel_app.Forms
{
    partial class Client2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client2Form));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.foodButton = new FontAwesome.Sharp.IconButton();
            this.radioButton = new FontAwesome.Sharp.IconButton();
            this.tvButton = new FontAwesome.Sharp.IconButton();
            this.lightsButton = new FontAwesome.Sharp.IconButton();
            this.privateThermostatButton = new FontAwesome.Sharp.IconButton();
            this.poolButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlelabel = new System.Windows.Forms.Panel();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.childFormLabel = new System.Windows.Forms.Label();
            this.currentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.helpButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.chatRichTextBox4 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.chatRichTextBox3 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chatRichTextBox2 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.chatRichTextBox1 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chatRichTextBox5 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlelabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).BeginInit();
            this.childFormPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(99)))), ((int)(((byte)(161)))));
            this.menuPanel.Controls.Add(this.foodButton);
            this.menuPanel.Controls.Add(this.radioButton);
            this.menuPanel.Controls.Add(this.tvButton);
            this.menuPanel.Controls.Add(this.lightsButton);
            this.menuPanel.Controls.Add(this.privateThermostatButton);
            this.menuPanel.Controls.Add(this.poolButton);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 800);
            this.menuPanel.TabIndex = 0;
            // 
            // foodButton
            // 
            this.foodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodButton.FlatAppearance.BorderSize = 0;
            this.foodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.foodButton.IconChar = FontAwesome.Sharp.IconChar.Cutlery;
            this.foodButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.foodButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.foodButton.IconSize = 50;
            this.foodButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodButton.Location = new System.Drawing.Point(0, 550);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(300, 70);
            this.foodButton.TabIndex = 15;
            this.foodButton.Text = "Restaurant";
            this.foodButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.foodButton.UseVisualStyleBackColor = true;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // radioButton
            // 
            this.radioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton.FlatAppearance.BorderSize = 0;
            this.radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.radioButton.IconChar = FontAwesome.Sharp.IconChar.Radio;
            this.radioButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.radioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioButton.IconSize = 50;
            this.radioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton.Location = new System.Drawing.Point(0, 480);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(300, 70);
            this.radioButton.TabIndex = 10;
            this.radioButton.Text = "Radio";
            this.radioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton.UseVisualStyleBackColor = true;
            this.radioButton.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // tvButton
            // 
            this.tvButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvButton.FlatAppearance.BorderSize = 0;
            this.tvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tvButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.tvButton.IconChar = FontAwesome.Sharp.IconChar.Television;
            this.tvButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.tvButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tvButton.IconSize = 50;
            this.tvButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tvButton.Location = new System.Drawing.Point(0, 410);
            this.tvButton.Name = "tvButton";
            this.tvButton.Size = new System.Drawing.Size(300, 70);
            this.tvButton.TabIndex = 9;
            this.tvButton.Text = "TV";
            this.tvButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tvButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tvButton.UseVisualStyleBackColor = true;
            this.tvButton.Click += new System.EventHandler(this.tvButton_Click);
            // 
            // lightsButton
            // 
            this.lightsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lightsButton.FlatAppearance.BorderSize = 0;
            this.lightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightsButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lightsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.lightsButton.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.lightsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.lightsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lightsButton.IconSize = 50;
            this.lightsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lightsButton.Location = new System.Drawing.Point(0, 340);
            this.lightsButton.Name = "lightsButton";
            this.lightsButton.Size = new System.Drawing.Size(300, 70);
            this.lightsButton.TabIndex = 8;
            this.lightsButton.Text = "Lights";
            this.lightsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lightsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lightsButton.UseVisualStyleBackColor = true;
            this.lightsButton.Click += new System.EventHandler(this.lightsButton_Click);
            // 
            // privateThermostatButton
            // 
            this.privateThermostatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.privateThermostatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.privateThermostatButton.FlatAppearance.BorderSize = 0;
            this.privateThermostatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privateThermostatButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.privateThermostatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.privateThermostatButton.IconChar = FontAwesome.Sharp.IconChar.Thermometer3;
            this.privateThermostatButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.privateThermostatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.privateThermostatButton.IconSize = 50;
            this.privateThermostatButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.privateThermostatButton.Location = new System.Drawing.Point(0, 270);
            this.privateThermostatButton.Name = "privateThermostatButton";
            this.privateThermostatButton.Size = new System.Drawing.Size(300, 70);
            this.privateThermostatButton.TabIndex = 7;
            this.privateThermostatButton.Text = "Thermostat";
            this.privateThermostatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.privateThermostatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.privateThermostatButton.UseVisualStyleBackColor = true;
            this.privateThermostatButton.Click += new System.EventHandler(this.privateThermostatButton_Click);
            // 
            // poolButton
            // 
            this.poolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.poolButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.poolButton.FlatAppearance.BorderSize = 0;
            this.poolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poolButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.poolButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.poolButton.IconChar = FontAwesome.Sharp.IconChar.WaterLadder;
            this.poolButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.poolButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.poolButton.IconSize = 50;
            this.poolButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.poolButton.Location = new System.Drawing.Point(0, 200);
            this.poolButton.Name = "poolButton";
            this.poolButton.Size = new System.Drawing.Size(300, 70);
            this.poolButton.TabIndex = 6;
            this.poolButton.Text = "Pool";
            this.poolButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.poolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.poolButton.UseVisualStyleBackColor = true;
            this.poolButton.Click += new System.EventHandler(this.poolButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::hotel_app.Properties.Resources.logoMenuFinal;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(177)))));
            this.titlelabel.Controls.Add(this.logoutButton);
            this.titlelabel.Controls.Add(this.pictureBox2);
            this.titlelabel.Controls.Add(this.userNameLabel);
            this.titlelabel.Controls.Add(this.childFormLabel);
            this.titlelabel.Controls.Add(this.currentChildFormIcon);
            this.titlelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlelabel.Location = new System.Drawing.Point(300, 0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(1100, 100);
            this.titlelabel.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutButton.Location = new System.Drawing.Point(1041, 27);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(47, 44);
            this.logoutButton.TabIndex = 23;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::hotel_app.Properties.Resources.woman;
            this.pictureBox2.Location = new System.Drawing.Point(977, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.userNameLabel.Location = new System.Drawing.Point(885, 27);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(93, 42);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "Helen\r\nRoom User";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // childFormLabel
            // 
            this.childFormLabel.AutoSize = true;
            this.childFormLabel.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.childFormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.childFormLabel.Location = new System.Drawing.Point(55, 50);
            this.childFormLabel.Name = "childFormLabel";
            this.childFormLabel.Size = new System.Drawing.Size(64, 21);
            this.childFormLabel.TabIndex = 1;
            this.childFormLabel.Text = "Home";
            // 
            // currentChildFormIcon
            // 
            this.currentChildFormIcon.BackColor = System.Drawing.Color.Transparent;
            this.currentChildFormIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.currentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentChildFormIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.currentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildFormIcon.Location = new System.Drawing.Point(17, 39);
            this.currentChildFormIcon.Name = "currentChildFormIcon";
            this.currentChildFormIcon.Size = new System.Drawing.Size(32, 32);
            this.currentChildFormIcon.TabIndex = 0;
            this.currentChildFormIcon.TabStop = false;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.childFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.childFormPanel.Controls.Add(this.helpButton);
            this.childFormPanel.Controls.Add(this.panel2);
            this.childFormPanel.Controls.Add(this.label2);
            this.childFormPanel.Controls.Add(this.label1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(300, 100);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1100, 700);
            this.childFormPanel.TabIndex = 2;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.Color.Black;
            this.helpButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.helpButton.IconColor = System.Drawing.Color.Black;
            this.helpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.helpButton.IconSize = 40;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpButton.Location = new System.Drawing.Point(1027, 22);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(60, 60);
            this.helpButton.TabIndex = 23;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.iconPictureBox5);
            this.panel2.Controls.Add(this.iconPictureBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.iconPictureBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.chatRichTextBox4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.iconPictureBox6);
            this.panel2.Controls.Add(this.chatRichTextBox3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chatRichTextBox2);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.chatRichTextBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chatRichTextBox5);
            this.panel2.Location = new System.Drawing.Point(16, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 534);
            this.panel2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(662, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "Inside Temperature: 21°C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(773, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Radio is off";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Thermometer3;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 50;
            this.iconPictureBox5.Location = new System.Drawing.Point(920, 184);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox5.TabIndex = 7;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Radio;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 50;
            this.iconPictureBox4.Location = new System.Drawing.Point(920, 106);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox4.TabIndex = 6;
            this.iconPictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(174, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "TV is on";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Television;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 50;
            this.iconPictureBox3.Location = new System.Drawing.Point(103, 191);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox3.TabIndex = 20;
            this.iconPictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(159, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pool Sensor is on, alarm is off";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Orange;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Orange;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 50;
            this.iconPictureBox2.Location = new System.Drawing.Point(103, 101);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox2.TabIndex = 18;
            this.iconPictureBox2.TabStop = false;
            // 
            // chatRichTextBox4
            // 
            this.chatRichTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.chatRichTextBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chatRichTextBox4.Location = new System.Drawing.Point(27, 72);
            this.chatRichTextBox4.MaxLegthSize = 30;
            this.chatRichTextBox4.Name = "chatRichTextBox4";
            this.chatRichTextBox4.Radius = 40;
            this.chatRichTextBox4.RichTextBoxLocation = new System.Drawing.Point(30, 30);
            this.chatRichTextBox4.RichTextBoxSize = new System.Drawing.Size(450, 160);
            this.chatRichTextBox4.ShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.chatRichTextBox4.Size = new System.Drawing.Size(1011, 200);
            this.chatRichTextBox4.TabIndex = 17;
            this.chatRichTextBox4.TextMultiline = true;
            this.chatRichTextBox4.TextReadonly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(689, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 54);
            this.label10.TabIndex = 16;
            this.label10.Text = "You can order now order\r\nyour food throught the chat!";
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.iconPictureBox6.ForeColor = System.Drawing.Color.Yellow;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPictureBox6.IconColor = System.Drawing.Color.Yellow;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 50;
            this.iconPictureBox6.Location = new System.Drawing.Point(614, 410);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox6.TabIndex = 15;
            this.iconPictureBox6.TabStop = false;
            // 
            // chatRichTextBox3
            // 
            this.chatRichTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.chatRichTextBox3.ForeColor = System.Drawing.Color.White;
            this.chatRichTextBox3.Location = new System.Drawing.Point(614, 327);
            this.chatRichTextBox3.MaxLegthSize = 30;
            this.chatRichTextBox3.Name = "chatRichTextBox3";
            this.chatRichTextBox3.Radius = 20;
            this.chatRichTextBox3.RichTextBoxLocation = new System.Drawing.Point(30, 10);
            this.chatRichTextBox3.RichTextBoxSize = new System.Drawing.Size(300, 15);
            this.chatRichTextBox3.ShadeColor = System.Drawing.Color.White;
            this.chatRichTextBox3.Size = new System.Drawing.Size(343, 40);
            this.chatRichTextBox3.TabIndex = 14;
            this.chatRichTextBox3.TextMultiline = true;
            this.chatRichTextBox3.TextReadonly = true;
            this.chatRichTextBox3.Load += new System.EventHandler(this.chatRichTextBox3_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(569, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Restaurant status:";
            // 
            // chatRichTextBox2
            // 
            this.chatRichTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.chatRichTextBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chatRichTextBox2.Location = new System.Drawing.Point(538, 302);
            this.chatRichTextBox2.MaxLegthSize = 30;
            this.chatRichTextBox2.Name = "chatRichTextBox2";
            this.chatRichTextBox2.Radius = 40;
            this.chatRichTextBox2.RichTextBoxLocation = new System.Drawing.Point(30, 30);
            this.chatRichTextBox2.RichTextBoxSize = new System.Drawing.Size(450, 160);
            this.chatRichTextBox2.ShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.chatRichTextBox2.Size = new System.Drawing.Size(500, 200);
            this.chatRichTextBox2.TabIndex = 12;
            this.chatRichTextBox2.TextMultiline = true;
            this.chatRichTextBox2.TextReadonly = true;
            this.chatRichTextBox2.Load += new System.EventHandler(this.chatRichTextBox2_Load);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(448, 31);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // chatRichTextBox1
            // 
            this.chatRichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.chatRichTextBox1.ForeColor = System.Drawing.Color.White;
            this.chatRichTextBox1.Location = new System.Drawing.Point(32, 302);
            this.chatRichTextBox1.MaxLegthSize = 30;
            this.chatRichTextBox1.Name = "chatRichTextBox1";
            this.chatRichTextBox1.Radius = 40;
            this.chatRichTextBox1.RichTextBoxLocation = new System.Drawing.Point(30, 30);
            this.chatRichTextBox1.RichTextBoxSize = new System.Drawing.Size(450, 160);
            this.chatRichTextBox1.ShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.chatRichTextBox1.Size = new System.Drawing.Size(500, 200);
            this.chatRichTextBox1.TabIndex = 2;
            this.chatRichTextBox1.TextMultiline = true;
            this.chatRichTextBox1.TextReadonly = true;
            this.chatRichTextBox1.Load += new System.EventHandler(this.chatRichTextBox1_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Messages from the stuff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(486, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Status";
            // 
            // chatRichTextBox5
            // 
            this.chatRichTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.chatRichTextBox5.ForeColor = System.Drawing.Color.White;
            this.chatRichTextBox5.Location = new System.Drawing.Point(8, 16);
            this.chatRichTextBox5.MaxLegthSize = 30;
            this.chatRichTextBox5.Name = "chatRichTextBox5";
            this.chatRichTextBox5.Radius = 60;
            this.chatRichTextBox5.RichTextBoxLocation = new System.Drawing.Point(30, 30);
            this.chatRichTextBox5.RichTextBoxSize = new System.Drawing.Size(1, 1);
            this.chatRichTextBox5.ShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.chatRichTextBox5.Size = new System.Drawing.Size(1060, 498);
            this.chatRichTextBox5.TabIndex = 22;
            this.chatRichTextBox5.TextMultiline = true;
            this.chatRichTextBox5.TextReadonly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Edwardian Script ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(503, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 57);
            this.label2.TabIndex = 7;
            this.label2.Text = "Room Services";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(361, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 86);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zeus Palace\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Client2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(139)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Client2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client2Form_FormClosed);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlelabel.ResumeLayout(false);
            this.titlelabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton poolButton;
        private FontAwesome.Sharp.IconButton tvButton;
        private FontAwesome.Sharp.IconButton lightsButton;
        private FontAwesome.Sharp.IconButton privateThermostatButton;
        private FontAwesome.Sharp.IconButton radioButton;
        private Panel titlelabel;
        private FontAwesome.Sharp.IconPictureBox currentChildFormIcon;
        private Label childFormLabel;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label userNameLabel;
        private FontAwesome.Sharp.IconButton logoutButton;
        public Panel menuPanel;
        public Panel panel1;
        public Panel childFormPanel;
        public FontAwesome.Sharp.IconButton foodButton;
        private Panel panel2;
        private Label label3;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox1;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label9;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox2;
        private Label label8;
        private Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox3;
        private Label label10;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox4;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox5;
        private FontAwesome.Sharp.IconButton helpButton;
    }
}