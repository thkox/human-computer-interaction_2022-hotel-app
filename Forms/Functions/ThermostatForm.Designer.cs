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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.thermostatUpButton = new FontAwesome.Sharp.IconButton();
            this.thermostatDownButton = new FontAwesome.Sharp.IconButton();
            this.thermostatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(286, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(249, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // thermostatUpButton
            // 
            this.thermostatUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.thermostatUpButton.IconColor = System.Drawing.Color.Black;
            this.thermostatUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thermostatUpButton.Location = new System.Drawing.Point(564, 215);
            this.thermostatUpButton.Name = "thermostatUpButton";
            this.thermostatUpButton.Size = new System.Drawing.Size(175, 65);
            this.thermostatUpButton.TabIndex = 1;
            this.thermostatUpButton.UseVisualStyleBackColor = true;
            // 
            // thermostatDownButton
            // 
            this.thermostatDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.thermostatDownButton.IconColor = System.Drawing.Color.Black;
            this.thermostatDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thermostatDownButton.Location = new System.Drawing.Point(564, 303);
            this.thermostatDownButton.Name = "thermostatDownButton";
            this.thermostatDownButton.Size = new System.Drawing.Size(175, 65);
            this.thermostatDownButton.TabIndex = 2;
            this.thermostatDownButton.UseVisualStyleBackColor = true;
            // 
            // thermostatLabel
            // 
            this.thermostatLabel.AutoSize = true;
            this.thermostatLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thermostatLabel.Location = new System.Drawing.Point(370, 144);
            this.thermostatLabel.Name = "thermostatLabel";
            this.thermostatLabel.Size = new System.Drawing.Size(303, 45);
            this.thermostatLabel.TabIndex = 4;
            this.thermostatLabel.Text = "[Thermostat Place]";
            // 
            // ThermostatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.thermostatLabel);
            this.Controls.Add(this.thermostatDownButton);
            this.Controls.Add(this.thermostatUpButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ThermostatForm";
            this.Text = "Thermostat";
            this.Load += new System.EventHandler(this.ThermostatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton thermostatUpButton;
        private FontAwesome.Sharp.IconButton thermostatDownButton;
        private Label thermostatLabel;
    }
}