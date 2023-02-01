namespace hotel_app.Forms.Functions
{
    partial class ThermostatForm
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
            this.components = new System.ComponentModel.Container();
            this.thermostatUpButton = new FontAwesome.Sharp.IconButton();
            this.thermostatDownButton = new FontAwesome.Sharp.IconButton();
            this.thermostatLabel = new System.Windows.Forms.Label();
            this.thermostatToggle = new hotel_app.Custom_Toolbox.ToggleButtonCustom();
            this.currentTempValueLabel = new System.Windows.Forms.Label();
            this.thermostatPanel = new System.Windows.Forms.Panel();
            this.leafPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.setTempValueLabel = new System.Windows.Forms.Label();
            this.setValueTimer = new System.Windows.Forms.Timer(this.components);
            this.estimatedTimeLabel = new System.Windows.Forms.Label();
            this.thermostatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leafPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // thermostatUpButton
            // 
            this.thermostatUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.thermostatUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thermostatUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.thermostatUpButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thermostatUpButton.Location = new System.Drawing.Point(564, 215);
            this.thermostatUpButton.Name = "thermostatUpButton";
            this.thermostatUpButton.Size = new System.Drawing.Size(175, 65);
            this.thermostatUpButton.TabIndex = 1;
            this.thermostatUpButton.Text = "   ";
            this.thermostatUpButton.UseVisualStyleBackColor = false;
            this.thermostatUpButton.EnabledChanged += new System.EventHandler(this.thermostatButtons_EnabledChanged);
            this.thermostatUpButton.Click += new System.EventHandler(this.thermostatUpButton_Click);
            // 
            // thermostatDownButton
            // 
            this.thermostatDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.thermostatDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thermostatDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.thermostatDownButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thermostatDownButton.Location = new System.Drawing.Point(564, 303);
            this.thermostatDownButton.Name = "thermostatDownButton";
            this.thermostatDownButton.Size = new System.Drawing.Size(175, 65);
            this.thermostatDownButton.TabIndex = 2;
            this.thermostatDownButton.UseVisualStyleBackColor = false;
            this.thermostatDownButton.EnabledChanged += new System.EventHandler(this.thermostatButtons_EnabledChanged);
            this.thermostatDownButton.Click += new System.EventHandler(this.thermostatDownButton_Click);
            // 
            // thermostatLabel
            // 
            this.thermostatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatLabel.AutoSize = true;
            this.thermostatLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thermostatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatLabel.Location = new System.Drawing.Point(350, 147);
            this.thermostatLabel.Name = "thermostatLabel";
            this.thermostatLabel.Size = new System.Drawing.Size(303, 45);
            this.thermostatLabel.TabIndex = 4;
            this.thermostatLabel.Text = "[Thermostat Place]";
            // 
            // thermostatToggle
            // 
            this.thermostatToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatToggle.AutoSize = true;
            this.thermostatToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thermostatToggle.Location = new System.Drawing.Point(438, 397);
            this.thermostatToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.thermostatToggle.Name = "thermostatToggle";
            this.thermostatToggle.OffBackColor = System.Drawing.Color.DimGray;
            this.thermostatToggle.OffToggleColor = System.Drawing.Color.LightGray;
            this.thermostatToggle.OnBackColor = System.Drawing.Color.Green;
            this.thermostatToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatToggle.Size = new System.Drawing.Size(45, 22);
            this.thermostatToggle.TabIndex = 5;
            this.thermostatToggle.UseVisualStyleBackColor = true;
            this.thermostatToggle.CheckedChanged += new System.EventHandler(this.thermostatToggle_CheckedChanged);
            // 
            // currentTempValueLabel
            // 
            this.currentTempValueLabel.AutoSize = true;
            this.currentTempValueLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTempValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.currentTempValueLabel.Location = new System.Drawing.Point(3, 110);
            this.currentTempValueLabel.Name = "currentTempValueLabel";
            this.currentTempValueLabel.Size = new System.Drawing.Size(76, 38);
            this.currentTempValueLabel.TabIndex = 7;
            this.currentTempValueLabel.Text = "[Val]";
            // 
            // thermostatPanel
            // 
            this.thermostatPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            this.thermostatPanel.Controls.Add(this.estimatedTimeLabel);
            this.thermostatPanel.Controls.Add(this.leafPictureBox);
            this.thermostatPanel.Controls.Add(this.setTempValueLabel);
            this.thermostatPanel.Controls.Add(this.currentTempValueLabel);
            this.thermostatPanel.Location = new System.Drawing.Point(186, 215);
            this.thermostatPanel.Name = "thermostatPanel";
            this.thermostatPanel.Size = new System.Drawing.Size(372, 153);
            this.thermostatPanel.TabIndex = 8;
            // 
            // leafPictureBox
            // 
            this.leafPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            this.leafPictureBox.ForeColor = System.Drawing.Color.Green;
            this.leafPictureBox.IconChar = FontAwesome.Sharp.IconChar.Leaf;
            this.leafPictureBox.IconColor = System.Drawing.Color.Green;
            this.leafPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.leafPictureBox.IconSize = 42;
            this.leafPictureBox.Location = new System.Drawing.Point(16, 22);
            this.leafPictureBox.Name = "leafPictureBox";
            this.leafPictureBox.Size = new System.Drawing.Size(42, 43);
            this.leafPictureBox.TabIndex = 9;
            this.leafPictureBox.TabStop = false;
            this.leafPictureBox.Visible = false;
            // 
            // setTempValueLabel
            // 
            this.setTempValueLabel.AutoSize = true;
            this.setTempValueLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setTempValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.setTempValueLabel.Location = new System.Drawing.Point(108, 10);
            this.setTempValueLabel.Name = "setTempValueLabel";
            this.setTempValueLabel.Size = new System.Drawing.Size(134, 67);
            this.setTempValueLabel.TabIndex = 8;
            this.setTempValueLabel.Text = "[Val]";
            // 
            // setValueTimer
            // 
            this.setValueTimer.Interval = 5000;
            this.setValueTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // estimatedTimeLabel
            // 
            this.estimatedTimeLabel.AutoSize = true;
            this.estimatedTimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estimatedTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.estimatedTimeLabel.Location = new System.Drawing.Point(136, 77);
            this.estimatedTimeLabel.Name = "estimatedTimeLabel";
            this.estimatedTimeLabel.Size = new System.Drawing.Size(60, 29);
            this.estimatedTimeLabel.TabIndex = 10;
            this.estimatedTimeLabel.Text = "[Val]";
            this.estimatedTimeLabel.Visible = false;
            // 
            // ThermostatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.thermostatPanel);
            this.Controls.Add(this.thermostatToggle);
            this.Controls.Add(this.thermostatLabel);
            this.Controls.Add(this.thermostatDownButton);
            this.Controls.Add(this.thermostatUpButton);
            this.Name = "ThermostatForm";
            this.Text = "Thermostat";
            this.Load += new System.EventHandler(this.ThermostatForm_Load);
            this.thermostatPanel.ResumeLayout(false);
            this.thermostatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leafPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton thermostatUpButton;
        private FontAwesome.Sharp.IconButton thermostatDownButton;
        public Label thermostatLabel;
        private Custom_Toolbox.ToggleButtonCustom thermostatToggle;
        private Label currentTempValueLabel;
        private Panel thermostatPanel;
        private Label setTempValueLabel;
        private FontAwesome.Sharp.IconPictureBox leafPictureBox;
        private System.Windows.Forms.Timer setValueTimer;
        private Label estimatedTimeLabel;
    }
}