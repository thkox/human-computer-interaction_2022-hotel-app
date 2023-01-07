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
            this.radioLabel = new System.Windows.Forms.Label();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.radioValueLabel = new System.Windows.Forms.Label();
            this.radioUpButton = new FontAwesome.Sharp.IconButton();
            this.radioDownButton = new FontAwesome.Sharp.IconButton();
            this.RadioToggle = new hotel_app.Custom_Toolbox.ToggleButtonCustom();
            this.radioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioLabel
            // 
            this.radioLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioLabel.Location = new System.Drawing.Point(370, 144);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(200, 45);
            this.radioLabel.TabIndex = 0;
            this.radioLabel.Text = "Radio";
            this.radioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioPanel
            // 
            this.radioPanel.Controls.Add(this.radioValueLabel);
            this.radioPanel.Location = new System.Drawing.Point(300, 215);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(317, 153);
            this.radioPanel.TabIndex = 1;
            // 
            // radioValueLabel
            // 
            this.radioValueLabel.AutoSize = true;
            this.radioValueLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioValueLabel.Location = new System.Drawing.Point(0, 30);
            this.radioValueLabel.Name = "radioValueLabel";
            this.radioValueLabel.Size = new System.Drawing.Size(159, 86);
            this.radioValueLabel.TabIndex = 0;
            this.radioValueLabel.Text = "[Val]";
            // 
            // radioUpButton
            // 
            this.radioUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.radioUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioUpButton.Enabled = false;
            this.radioUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.radioUpButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioUpButton.Location = new System.Drawing.Point(623, 215);
            this.radioUpButton.Name = "radioUpButton";
            this.radioUpButton.Size = new System.Drawing.Size(175, 65);
            this.radioUpButton.TabIndex = 2;
            this.radioUpButton.UseVisualStyleBackColor = false;
            this.radioUpButton.EnabledChanged += new System.EventHandler(this.radioButtons_EnabledChanged);
            this.radioUpButton.Click += new System.EventHandler(this.radioUpButton_Click);
            // 
            // radioDownButton
            // 
            this.radioDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.radioDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDownButton.Enabled = false;
            this.radioDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.radioDownButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioDownButton.Location = new System.Drawing.Point(623, 303);
            this.radioDownButton.Name = "radioDownButton";
            this.radioDownButton.Size = new System.Drawing.Size(175, 65);
            this.radioDownButton.TabIndex = 3;
            this.radioDownButton.Text = " ";
            this.radioDownButton.UseVisualStyleBackColor = false;
            this.radioDownButton.EnabledChanged += new System.EventHandler(this.radioButtons_EnabledChanged);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.RadioToggle);
            this.Controls.Add(this.radioDownButton);
            this.Controls.Add(this.radioUpButton);
            this.Controls.Add(this.radioPanel);
            this.Controls.Add(this.radioLabel);
            this.Name = "RadioForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.RadioForm_Load);
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label radioLabel;
        private Panel radioPanel;
        private FontAwesome.Sharp.IconButton radioUpButton;
        private FontAwesome.Sharp.IconButton radioDownButton;
        private Label radioValueLabel;
        private Custom_Toolbox.ToggleButtonCustom RadioToggle;
    }
}