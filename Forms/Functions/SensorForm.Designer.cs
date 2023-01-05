namespace hotel_app.Forms.Functions
{
    partial class SensorForm
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
            this.sernsorButton = new FontAwesome.Sharp.IconButton();
            this.alarmButton = new FontAwesome.Sharp.IconButton();
            this.sensorPanelRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sernsorButton
            // 
            this.sernsorButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sernsorButton.IconChar = FontAwesome.Sharp.IconChar.LandMineOn;
            this.sernsorButton.IconColor = System.Drawing.Color.Black;
            this.sernsorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sernsorButton.Location = new System.Drawing.Point(334, 437);
            this.sernsorButton.Name = "sernsorButton";
            this.sernsorButton.Size = new System.Drawing.Size(150, 116);
            this.sernsorButton.TabIndex = 0;
            this.sernsorButton.Text = "Sensor";
            this.sernsorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sernsorButton.UseVisualStyleBackColor = true;
            this.sernsorButton.Click += new System.EventHandler(this.sernsorButton_Click);
            // 
            // alarmButton
            // 
            this.alarmButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmButton.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            this.alarmButton.IconColor = System.Drawing.Color.Black;
            this.alarmButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.alarmButton.Location = new System.Drawing.Point(600, 435);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(150, 116);
            this.alarmButton.TabIndex = 1;
            this.alarmButton.Text = "Alarm";
            this.alarmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // sensorPanelRichTextBox
            // 
            this.sensorPanelRichTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sensorPanelRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sensorPanelRichTextBox.Location = new System.Drawing.Point(334, 181);
            this.sensorPanelRichTextBox.Name = "sensorPanelRichTextBox";
            this.sensorPanelRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sensorPanelRichTextBox.Size = new System.Drawing.Size(416, 183);
            this.sensorPanelRichTextBox.TabIndex = 2;
            this.sensorPanelRichTextBox.Text = "";
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.sensorPanelRichTextBox);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.sernsorButton);
            this.Name = "SensorForm";
            this.Text = "SensorForm";
            this.Load += new System.EventHandler(this.SensorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton sernsorButton;
        private FontAwesome.Sharp.IconButton alarmButton;
        private RichTextBox sensorPanelRichTextBox;
    }
}