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
            this.starPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.radioValueLabel = new System.Windows.Forms.Label();
            this.radioUpButton = new FontAwesome.Sharp.IconButton();
            this.radioDownButton = new FontAwesome.Sharp.IconButton();
            this.radioToggle = new hotel_app.Custom_Toolbox.ToggleButtonCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.radioStation1 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.radioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // radioLabel
            // 
            this.radioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioLabel.Location = new System.Drawing.Point(397, 74);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(200, 45);
            this.radioLabel.TabIndex = 0;
            this.radioLabel.Text = "Radio";
            this.radioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioPanel
            // 
            this.radioPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioPanel.Controls.Add(this.starPictureBox);
            this.radioPanel.Controls.Add(this.radioValueLabel);
            this.radioPanel.Location = new System.Drawing.Point(327, 145);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(356, 153);
            this.radioPanel.TabIndex = 1;
            // 
            // starPictureBox
            // 
            this.starPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.starPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.starPictureBox.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.starPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.starPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.starPictureBox.Location = new System.Drawing.Point(321, 3);
            this.starPictureBox.Name = "starPictureBox";
            this.starPictureBox.Size = new System.Drawing.Size(32, 32);
            this.starPictureBox.TabIndex = 1;
            this.starPictureBox.TabStop = false;
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
            this.radioUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.radioUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioUpButton.Enabled = false;
            this.radioUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.radioUpButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioUpButton.Location = new System.Drawing.Point(327, 304);
            this.radioUpButton.Name = "radioUpButton";
            this.radioUpButton.Size = new System.Drawing.Size(175, 65);
            this.radioUpButton.TabIndex = 2;
            this.radioUpButton.UseVisualStyleBackColor = false;
            this.radioUpButton.EnabledChanged += new System.EventHandler(this.radioButtons_EnabledChanged);
            this.radioUpButton.Click += new System.EventHandler(this.radioUpButton_Click);
            // 
            // radioDownButton
            // 
            this.radioDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.radioDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioDownButton.Enabled = false;
            this.radioDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.radioDownButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioDownButton.Location = new System.Drawing.Point(508, 304);
            this.radioDownButton.Name = "radioDownButton";
            this.radioDownButton.Size = new System.Drawing.Size(175, 65);
            this.radioDownButton.TabIndex = 3;
            this.radioDownButton.Text = " ";
            this.radioDownButton.UseVisualStyleBackColor = false;
            this.radioDownButton.EnabledChanged += new System.EventHandler(this.radioButtons_EnabledChanged);
            this.radioDownButton.Click += new System.EventHandler(this.radioDownButton_Click);
            // 
            // radioToggle
            // 
            this.radioToggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioToggle.AutoSize = true;
            this.radioToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioToggle.Location = new System.Drawing.Point(484, 375);
            this.radioToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.radioToggle.Name = "radioToggle";
            this.radioToggle.OffBackColor = System.Drawing.Color.DimGray;
            this.radioToggle.OffToggleColor = System.Drawing.Color.LightGray;
            this.radioToggle.OnBackColor = System.Drawing.Color.Green;
            this.radioToggle.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioToggle.Size = new System.Drawing.Size(45, 22);
            this.radioToggle.TabIndex = 4;
            this.radioToggle.UseVisualStyleBackColor = true;
            this.radioToggle.CheckedChanged += new System.EventHandler(this.RadioToggle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(105, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Local Radio Stations:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioStation1
            // 
            this.radioStation1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioStation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.radioStation1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioStation1.Enabled = false;
            this.radioStation1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioStation1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioStation1.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.radioStation1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.radioStation1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.radioStation1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioStation1.Location = new System.Drawing.Point(116, 542);
            this.radioStation1.Name = "radioStation1";
            this.radioStation1.Size = new System.Drawing.Size(175, 65);
            this.radioStation1.TabIndex = 6;
            this.radioStation1.Text = "97.2 MHz";
            this.radioStation1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioStation1.UseVisualStyleBackColor = false;
            this.radioStation1.Click += new System.EventHandler(this.radioStation1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Enabled = false;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(318, 542);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(175, 65);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "99.8 MHz";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Enabled = false;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(520, 542);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(175, 65);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "100.3 MHz";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Enabled = false;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(721, 542);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(175, 65);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.Text = "102.1MHz";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // RadioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.radioStation1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioToggle);
            this.Controls.Add(this.radioDownButton);
            this.Controls.Add(this.radioUpButton);
            this.Controls.Add(this.radioPanel);
            this.Controls.Add(this.radioLabel);
            this.Name = "RadioForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.RadioForm_Load);
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label radioLabel;
        private Panel radioPanel;
        private FontAwesome.Sharp.IconButton radioUpButton;
        private FontAwesome.Sharp.IconButton radioDownButton;
        private Label radioValueLabel;
        private Custom_Toolbox.ToggleButtonCustom radioToggle;
        private FontAwesome.Sharp.IconPictureBox starPictureBox;
        private Label label1;
        private FontAwesome.Sharp.IconButton radioStation1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}