using System.Resources;

namespace hotel_app.Forms
{
    partial class Client1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client1Form));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.gpsButton = new FontAwesome.Sharp.IconButton();
            this.mainDoorButton = new FontAwesome.Sharp.IconButton();
            this.radioButton = new FontAwesome.Sharp.IconButton();
            this.tvButton = new FontAwesome.Sharp.IconButton();
            this.lightsButton = new FontAwesome.Sharp.IconButton();
            this.privateThermostatButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlelabel = new System.Windows.Forms.Panel();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.childFormLabel = new System.Windows.Forms.Label();
            this.currentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlelabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).BeginInit();
            this.childFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(99)))), ((int)(((byte)(161)))));
            this.menuPanel.Controls.Add(this.gpsButton);
            this.menuPanel.Controls.Add(this.mainDoorButton);
            this.menuPanel.Controls.Add(this.radioButton);
            this.menuPanel.Controls.Add(this.tvButton);
            this.menuPanel.Controls.Add(this.lightsButton);
            this.menuPanel.Controls.Add(this.privateThermostatButton);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 800);
            this.menuPanel.TabIndex = 0;
            // 
            // gpsButton
            // 
            this.gpsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpsButton.FlatAppearance.BorderSize = 0;
            this.gpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpsButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.gpsButton.IconChar = FontAwesome.Sharp.IconChar.MapLocationDot;
            this.gpsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.gpsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gpsButton.IconSize = 50;
            this.gpsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gpsButton.Location = new System.Drawing.Point(0, 550);
            this.gpsButton.Name = "gpsButton";
            this.gpsButton.Size = new System.Drawing.Size(300, 70);
            this.gpsButton.TabIndex = 13;
            this.gpsButton.Text = "GPS";
            this.gpsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gpsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gpsButton.UseVisualStyleBackColor = true;
            this.gpsButton.Click += new System.EventHandler(this.gpsButton_Click);
            // 
            // mainDoorButton
            // 
            this.mainDoorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainDoorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainDoorButton.FlatAppearance.BorderSize = 0;
            this.mainDoorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainDoorButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainDoorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.mainDoorButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.mainDoorButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.mainDoorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mainDoorButton.IconSize = 50;
            this.mainDoorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainDoorButton.Location = new System.Drawing.Point(0, 480);
            this.mainDoorButton.Name = "mainDoorButton";
            this.mainDoorButton.Size = new System.Drawing.Size(300, 70);
            this.mainDoorButton.TabIndex = 12;
            this.mainDoorButton.Text = "Main Door";
            this.mainDoorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainDoorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainDoorButton.UseVisualStyleBackColor = true;
            this.mainDoorButton.Click += new System.EventHandler(this.mainDoorButton_Click);
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
            this.radioButton.Location = new System.Drawing.Point(0, 410);
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
            this.tvButton.Location = new System.Drawing.Point(0, 340);
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
            this.lightsButton.Location = new System.Drawing.Point(0, 270);
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
            this.privateThermostatButton.Location = new System.Drawing.Point(0, 200);
            this.privateThermostatButton.Name = "privateThermostatButton";
            this.privateThermostatButton.Size = new System.Drawing.Size(300, 70);
            this.privateThermostatButton.TabIndex = 7;
            this.privateThermostatButton.Text = "Thermostat";
            this.privateThermostatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.privateThermostatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.privateThermostatButton.UseVisualStyleBackColor = true;
            this.privateThermostatButton.Click += new System.EventHandler(this.privateThermostatButton_Click);
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
            this.pictureBox2.Image = global::hotel_app.Properties.Resources.old_man;
            this.pictureBox2.Location = new System.Drawing.Point(977, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.userNameLabel.Location = new System.Drawing.Point(885, 27);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(96, 42);
            this.userNameLabel.TabIndex = 14;
            this.userNameLabel.Text = "Odysseas\nTrojan User";
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
            this.childFormPanel.Controls.Add(this.label3);
            this.childFormPanel.Controls.Add(this.label2);
            this.childFormPanel.Controls.Add(this.label1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(300, 100);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1100, 700);
            this.childFormPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(692, 232);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Edwardian Script ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(513, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 57);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trojan Services";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(371, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 86);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zeus Palace\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Client1Form
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
            this.Name = "Client1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trojan Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client1Form_FormClosed);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlelabel.ResumeLayout(false);
            this.titlelabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton tvButton;
        private FontAwesome.Sharp.IconButton lightsButton;
        private FontAwesome.Sharp.IconButton privateThermostatButton;
        private FontAwesome.Sharp.IconButton radioButton;
        private Panel titlelabel;
        private FontAwesome.Sharp.IconPictureBox currentChildFormIcon;
        private Label childFormLabel;
        private Panel childFormPanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton mainDoorButton;
        private FontAwesome.Sharp.IconButton gpsButton;
        private PictureBox pictureBox2;
        private Label userNameLabel;
        private FontAwesome.Sharp.IconButton logoutButton;
    }
}