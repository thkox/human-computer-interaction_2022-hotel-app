﻿namespace hotel_app.Forms.Functions
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
            this.thermostatUpButton = new FontAwesome.Sharp.IconButton();
            this.thermostatDownButton = new FontAwesome.Sharp.IconButton();
            this.thermostatLabel = new System.Windows.Forms.Label();
            this.thermostatToggle = new hotel_app.Custom_Toolbox.ToggleButtonCustom();
            this.thermostatValueLabel = new System.Windows.Forms.Label();
            this.thermostatPanel = new System.Windows.Forms.Panel();
            this.thermostatPanel.SuspendLayout();
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
            this.thermostatUpButton.EnabledChanged += new System.EventHandler(this.thermostatUpButton_EnabledChanged);
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
            this.thermostatDownButton.EnabledChanged += new System.EventHandler(this.thermostatDownButton_EnabledChanged);
            this.thermostatDownButton.Click += new System.EventHandler(this.thermostatDownButton_Click);
            // 
            // thermostatLabel
            // 
            this.thermostatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatLabel.AutoSize = true;
            this.thermostatLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thermostatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatLabel.Location = new System.Drawing.Point(370, 144);
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
            this.thermostatToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.thermostatToggle.OnToggleColor = System.Drawing.Color.Black;
            this.thermostatToggle.Size = new System.Drawing.Size(45, 22);
            this.thermostatToggle.TabIndex = 5;
            this.thermostatToggle.UseVisualStyleBackColor = true;
            this.thermostatToggle.CheckedChanged += new System.EventHandler(this.thermostatToggle_CheckedChanged);
            // 
            // thermostatValueLabel
            // 
            this.thermostatValueLabel.AutoSize = true;
            this.thermostatValueLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thermostatValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatValueLabel.Location = new System.Drawing.Point(36, 30);
            this.thermostatValueLabel.Name = "thermostatValueLabel";
            this.thermostatValueLabel.Size = new System.Drawing.Size(159, 86);
            this.thermostatValueLabel.TabIndex = 7;
            this.thermostatValueLabel.Text = "[Val]";
            // 
            // thermostatPanel
            // 
            this.thermostatPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            this.thermostatPanel.Controls.Add(this.thermostatValueLabel);
            this.thermostatPanel.Location = new System.Drawing.Point(350, 215);
            this.thermostatPanel.Name = "thermostatPanel";
            this.thermostatPanel.Size = new System.Drawing.Size(208, 153);
            this.thermostatPanel.TabIndex = 8;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton thermostatUpButton;
        private FontAwesome.Sharp.IconButton thermostatDownButton;
        public Label thermostatLabel;
        private Custom_Toolbox.ToggleButtonCustom thermostatToggle;
        private Label thermostatValueLabel;
        private Panel thermostatPanel;
    }
}