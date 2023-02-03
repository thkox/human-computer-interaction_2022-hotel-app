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
            this.statusPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.statusRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sensorButton
            // 
            this.sensorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sensorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.sensorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sensorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.alarmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.alarmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // statusPictureBox
            // 
            this.statusPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.statusPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusPictureBox.IconChar = FontAwesome.Sharp.IconChar.ShieldBlank;
            this.statusPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.statusPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusPictureBox.IconSize = 146;
            this.statusPictureBox.Location = new System.Drawing.Point(399, 196);
            this.statusPictureBox.Name = "statusPictureBox";
            this.statusPictureBox.Size = new System.Drawing.Size(149, 146);
            this.statusPictureBox.TabIndex = 2;
            this.statusPictureBox.TabStop = false;
            // 
            // statusRichTextBox
            // 
            this.statusRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.statusRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.statusRichTextBox.Location = new System.Drawing.Point(554, 163);
            this.statusRichTextBox.Name = "statusRichTextBox";
            this.statusRichTextBox.Size = new System.Drawing.Size(374, 179);
            this.statusRichTextBox.TabIndex = 3;
            this.statusRichTextBox.Text = "";
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.statusRichTextBox);
            this.Controls.Add(this.statusPictureBox);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.sensorButton);
            this.Name = "SensorForm";
            this.Text = "SensorForm";
            this.Load += new System.EventHandler(this.SensorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton sensorButton;
        private FontAwesome.Sharp.IconButton alarmButton;
        private FontAwesome.Sharp.IconPictureBox statusPictureBox;
        private RichTextBox statusRichTextBox;
    }
}