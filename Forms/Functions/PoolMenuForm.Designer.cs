namespace hotel_app.Forms.Functions
{
    partial class PoolMenuForm
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
            this.waterLevelButton = new FontAwesome.Sharp.IconButton();
            this.thermostatButton = new FontAwesome.Sharp.IconButton();
            this.sensorButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // waterLevelButton
            // 
            this.waterLevelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waterLevelButton.IconChar = FontAwesome.Sharp.IconChar.WaterLadder;
            this.waterLevelButton.IconColor = System.Drawing.Color.Black;
            this.waterLevelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.waterLevelButton.Location = new System.Drawing.Point(214, 273);
            this.waterLevelButton.Name = "waterLevelButton";
            this.waterLevelButton.Size = new System.Drawing.Size(150, 96);
            this.waterLevelButton.TabIndex = 0;
            this.waterLevelButton.Text = "Water Level";
            this.waterLevelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.waterLevelButton.UseVisualStyleBackColor = true;
            // 
            // thermostatButton
            // 
            this.thermostatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thermostatButton.IconChar = FontAwesome.Sharp.IconChar.Temperature1;
            this.thermostatButton.IconColor = System.Drawing.Color.Black;
            this.thermostatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thermostatButton.Location = new System.Drawing.Point(468, 273);
            this.thermostatButton.Name = "thermostatButton";
            this.thermostatButton.Size = new System.Drawing.Size(150, 96);
            this.thermostatButton.TabIndex = 1;
            this.thermostatButton.Text = "Thermostat";
            this.thermostatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.thermostatButton.UseVisualStyleBackColor = true;
            // 
            // sensorButton
            // 
            this.sensorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sensorButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sensorButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.sensorButton.IconColor = System.Drawing.Color.Black;
            this.sensorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sensorButton.Location = new System.Drawing.Point(723, 273);
            this.sensorButton.Name = "sensorButton";
            this.sensorButton.Size = new System.Drawing.Size(150, 96);
            this.sensorButton.TabIndex = 2;
            this.sensorButton.Text = "Sensor";
            this.sensorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sensorButton.UseVisualStyleBackColor = true;
            // 
            // PoolMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.sensorButton);
            this.Controls.Add(this.thermostatButton);
            this.Controls.Add(this.waterLevelButton);
            this.Name = "PoolMenuForm";
            this.Text = "PoolMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton waterLevelButton;
        private FontAwesome.Sharp.IconButton thermostatButton;
        private FontAwesome.Sharp.IconButton sensorButton;
    }
}