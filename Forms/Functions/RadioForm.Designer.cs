namespace hotel_app.Forms.Functions
{
    partial class RadioForm
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
            this.Radiolabel = new System.Windows.Forms.Label();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.RadioValueLabel = new System.Windows.Forms.Label();
            this.radioUpButton = new FontAwesome.Sharp.IconButton();
            this.radioDownButton = new FontAwesome.Sharp.IconButton();
            this.RadioToggle = new hotel_app.Custom_Toolbox.ToggleButtonCustom();
            this.RadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Radiolabel
            // 
            this.Radiolabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Radiolabel.Location = new System.Drawing.Point(370, 144);
            this.Radiolabel.Name = "Radiolabel";
            this.Radiolabel.Size = new System.Drawing.Size(200, 45);
            this.Radiolabel.TabIndex = 0;
            this.Radiolabel.Text = "Radio";
            this.Radiolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.RadioValueLabel);
            this.RadioPanel.Location = new System.Drawing.Point(300, 215);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(317, 153);
            this.RadioPanel.TabIndex = 1;
            // 
            // RadioValueLabel
            // 
            this.RadioValueLabel.AutoSize = true;
            this.RadioValueLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RadioValueLabel.Location = new System.Drawing.Point(0, 30);
            this.RadioValueLabel.Name = "RadioValueLabel";
            this.RadioValueLabel.Size = new System.Drawing.Size(159, 86);
            this.RadioValueLabel.TabIndex = 0;
            this.RadioValueLabel.Text = "[Val]";
            // 
            // radioUpButton
            // 
            this.radioUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioUpButton.Enabled = false;
            this.radioUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.radioUpButton.IconColor = System.Drawing.Color.Black;
            this.radioUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioUpButton.Location = new System.Drawing.Point(623, 215);
            this.radioUpButton.Name = "radioUpButton";
            this.radioUpButton.Size = new System.Drawing.Size(175, 65);
            this.radioUpButton.TabIndex = 2;
            this.radioUpButton.UseVisualStyleBackColor = true;
            this.radioUpButton.Click += new System.EventHandler(this.radioUpButton_Click);
            // 
            // radioDownButton
            // 
            this.radioDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDownButton.Enabled = false;
            this.radioDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.radioDownButton.IconColor = System.Drawing.Color.Black;
            this.radioDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioDownButton.Location = new System.Drawing.Point(623, 303);
            this.radioDownButton.Name = "radioDownButton";
            this.radioDownButton.Size = new System.Drawing.Size(175, 65);
            this.radioDownButton.TabIndex = 3;
            this.radioDownButton.Text = " ";
            this.radioDownButton.UseVisualStyleBackColor = true;
            this.radioDownButton.Click += new System.EventHandler(this.radioDownButton_Click);
            // 
            // RadioToggle
            // 
            this.RadioToggle.AutoSize = true;
            this.RadioToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioToggle.Location = new System.Drawing.Point(438, 388);
            this.RadioToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.RadioToggle.Name = "RadioToggle";
            this.RadioToggle.OffBackColor = System.Drawing.Color.DimGray;
            this.RadioToggle.OffToggleColor = System.Drawing.Color.LightGray;
            this.RadioToggle.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioToggle.OnToggleColor = System.Drawing.Color.Black;
            this.RadioToggle.Size = new System.Drawing.Size(45, 22);
            this.RadioToggle.TabIndex = 4;
            this.RadioToggle.UseVisualStyleBackColor = true;
            this.RadioToggle.CheckedChanged += new System.EventHandler(this.RadioToggle_CheckedChanged);
            // 
            // RadioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.RadioToggle);
            this.Controls.Add(this.radioDownButton);
            this.Controls.Add(this.radioUpButton);
            this.Controls.Add(this.RadioPanel);
            this.Controls.Add(this.Radiolabel);
            this.Name = "RadioForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.RadioForm_Load);
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Radiolabel;
        private Panel RadioPanel;
        private FontAwesome.Sharp.IconButton radioUpButton;
        private FontAwesome.Sharp.IconButton radioDownButton;
        private Label RadioValueLabel;
        private Custom_Toolbox.ToggleButtonCustom RadioToggle;
    }
}