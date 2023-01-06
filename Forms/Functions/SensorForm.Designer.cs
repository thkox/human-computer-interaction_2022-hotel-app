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
            this.sensorButton = new FontAwesome.Sharp.IconButton();
            this.alarmButton = new FontAwesome.Sharp.IconButton();
            this.sensorPanelRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sensorButton
            // 
            this.sensorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.sensorButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sensorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.sensorButton.IconChar = FontAwesome.Sharp.IconChar.LandMineOn;
            this.sensorButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.sensorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sensorButton.Location = new System.Drawing.Point(334, 437);
            this.sensorButton.Name = "sensorButton";
            this.sensorButton.Size = new System.Drawing.Size(150, 116);
            this.sensorButton.TabIndex = 0;
            this.sensorButton.Text = "Sensor";
            this.sensorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sensorButton.UseVisualStyleBackColor = false;
            this.sensorButton.EnabledChanged += new System.EventHandler(this.sensorButton_EnabledChanged);
            this.sensorButton.Click += new System.EventHandler(this.sensorButton_Click);
            // 
            // alarmButton
            // 
            this.alarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.alarmButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.alarmButton.IconChar = FontAwesome.Sharp.IconChar.ShieldHalved;
            this.alarmButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.alarmButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.alarmButton.Location = new System.Drawing.Point(600, 435);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(150, 116);
            this.alarmButton.TabIndex = 1;
            this.alarmButton.Text = "Alarm";
            this.alarmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.alarmButton.UseVisualStyleBackColor = false;
            this.alarmButton.EnabledChanged += new System.EventHandler(this.alarmButton_EnabledChanged);
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // sensorPanelRichTextBox
            // 
            this.sensorPanelRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            this.sensorPanelRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sensorPanelRichTextBox.Location = new System.Drawing.Point(259, 103);
            this.sensorPanelRichTextBox.Name = "sensorPanelRichTextBox";
            this.sensorPanelRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sensorPanelRichTextBox.Size = new System.Drawing.Size(551, 258);
            this.sensorPanelRichTextBox.TabIndex = 2;
            this.sensorPanelRichTextBox.Text = "";
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.sensorPanelRichTextBox);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.sensorButton);
            this.Name = "SensorForm";
            this.Text = "SensorForm";
            this.Load += new System.EventHandler(this.SensorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton sensorButton;
        private FontAwesome.Sharp.IconButton alarmButton;
        private RichTextBox sensorPanelRichTextBox;
    }
}