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
            this.radioButton = new FontAwesome.Sharp.IconButton();
            this.tvButton = new FontAwesome.Sharp.IconButton();
            this.lightsButton = new FontAwesome.Sharp.IconButton();
            this.privateThermostatButton = new FontAwesome.Sharp.IconButton();
            this.poolButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hotelTitle = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Panel();
            this.childFormLabel = new System.Windows.Forms.Label();
            this.currentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titlelabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
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
            this.menuPanel.Size = new System.Drawing.Size(300, 761);
            this.menuPanel.TabIndex = 0;
            // 
            // radioButton
            // 
            this.radioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton.FlatAppearance.BorderSize = 0;
            this.radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton.IconChar = FontAwesome.Sharp.IconChar.Radio;
            this.radioButton.IconColor = System.Drawing.Color.OrangeRed;
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
            this.tvButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvButton.FlatAppearance.BorderSize = 0;
            this.tvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tvButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tvButton.IconChar = FontAwesome.Sharp.IconChar.Television;
            this.tvButton.IconColor = System.Drawing.Color.OrangeRed;
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
            this.lightsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.lightsButton.FlatAppearance.BorderSize = 0;
            this.lightsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lightsButton.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.lightsButton.IconColor = System.Drawing.Color.OrangeRed;
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
            this.privateThermostatButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.privateThermostatButton.FlatAppearance.BorderSize = 0;
            this.privateThermostatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privateThermostatButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.privateThermostatButton.IconChar = FontAwesome.Sharp.IconChar.Thermometer3;
            this.privateThermostatButton.IconColor = System.Drawing.Color.OrangeRed;
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
            this.poolButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.poolButton.FlatAppearance.BorderSize = 0;
            this.poolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poolButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.poolButton.IconChar = FontAwesome.Sharp.IconChar.WaterLadder;
            this.poolButton.IconColor = System.Drawing.Color.OrangeRed;
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
            this.panel1.Controls.Add(this.hotelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 5;
            // 
            // hotelTitle
            // 
            this.hotelTitle.AutoSize = true;
            this.hotelTitle.Font = new System.Drawing.Font("Edwardian Script ITC", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hotelTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.hotelTitle.Location = new System.Drawing.Point(51, 20);
            this.hotelTitle.Name = "hotelTitle";
            this.hotelTitle.Size = new System.Drawing.Size(197, 172);
            this.hotelTitle.TabIndex = 5;
            this.hotelTitle.Text = "Zeus\r\nPalace";
            this.hotelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotelTitle.Click += new System.EventHandler(this.hotelTitle_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.titlelabel.Controls.Add(this.childFormLabel);
            this.titlelabel.Controls.Add(this.currentChildFormIcon);
            this.titlelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlelabel.Location = new System.Drawing.Point(300, 0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(1084, 100);
            this.titlelabel.TabIndex = 1;
            // 
            // childFormLabel
            // 
            this.childFormLabel.AutoSize = true;
            this.childFormLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.childFormLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.childFormLabel.Location = new System.Drawing.Point(55, 39);
            this.childFormLabel.Name = "childFormLabel";
            this.childFormLabel.Size = new System.Drawing.Size(79, 32);
            this.childFormLabel.TabIndex = 1;
            this.childFormLabel.Text = "Home";
            // 
            // currentChildFormIcon
            // 
            this.currentChildFormIcon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.currentChildFormIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.currentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentChildFormIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.currentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildFormIcon.Location = new System.Drawing.Point(17, 39);
            this.currentChildFormIcon.Name = "currentChildFormIcon";
            this.currentChildFormIcon.Size = new System.Drawing.Size(32, 32);
            this.currentChildFormIcon.TabIndex = 0;
            this.currentChildFormIcon.TabStop = false;
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(300, 100);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1084, 661);
            this.childFormPanel.TabIndex = 2;
            // 
            // Client2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(139)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Client2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.titlelabel.ResumeLayout(false);
            this.titlelabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private FontAwesome.Sharp.IconButton poolButton;
        private Panel panel1;
        private Label hotelTitle;
        private FontAwesome.Sharp.IconButton tvButton;
        private FontAwesome.Sharp.IconButton lightsButton;
        private FontAwesome.Sharp.IconButton privateThermostatButton;
        private FontAwesome.Sharp.IconButton radioButton;
        private Panel titlelabel;
        private FontAwesome.Sharp.IconPictureBox currentChildFormIcon;
        private Label childFormLabel;
        private Panel childFormPanel;
    }
}