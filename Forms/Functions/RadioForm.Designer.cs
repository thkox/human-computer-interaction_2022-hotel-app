﻿namespace hotel_app.Forms.Functions
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
            this.favRadioStation1 = new FontAwesome.Sharp.IconButton();
            this.favRadioStation2 = new FontAwesome.Sharp.IconButton();
            this.favRadioStation3 = new FontAwesome.Sharp.IconButton();
            this.favRadioStation4 = new FontAwesome.Sharp.IconButton();
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
            // favRadioStation1
            // 
            this.favRadioStation1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favRadioStation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.favRadioStation1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favRadioStation1.Enabled = false;
            this.favRadioStation1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favRadioStation1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation1.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.favRadioStation1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.favRadioStation1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favRadioStation1.Location = new System.Drawing.Point(116, 542);
            this.favRadioStation1.Name = "favRadioStation1";
            this.favRadioStation1.Size = new System.Drawing.Size(175, 65);
            this.favRadioStation1.TabIndex = 6;
            this.favRadioStation1.Text = "97.3 MHz";
            this.favRadioStation1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.favRadioStation1.UseVisualStyleBackColor = false;
            this.favRadioStation1.Click += new System.EventHandler(this.favRadioStation1_Click);
            // 
            // favRadioStation2
            // 
            this.favRadioStation2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favRadioStation2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.favRadioStation2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favRadioStation2.Enabled = false;
            this.favRadioStation2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favRadioStation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation2.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.favRadioStation2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.favRadioStation2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favRadioStation2.Location = new System.Drawing.Point(318, 542);
            this.favRadioStation2.Name = "favRadioStation2";
            this.favRadioStation2.Size = new System.Drawing.Size(175, 65);
            this.favRadioStation2.TabIndex = 7;
            this.favRadioStation2.Text = "99.7 MHz";
            this.favRadioStation2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.favRadioStation2.UseVisualStyleBackColor = false;
            this.favRadioStation2.Click += new System.EventHandler(this.favRadioStation2_Click);
            // 
            // favRadioStation3
            // 
            this.favRadioStation3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favRadioStation3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.favRadioStation3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favRadioStation3.Enabled = false;
            this.favRadioStation3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favRadioStation3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation3.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.favRadioStation3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.favRadioStation3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favRadioStation3.Location = new System.Drawing.Point(520, 542);
            this.favRadioStation3.Name = "favRadioStation3";
            this.favRadioStation3.Size = new System.Drawing.Size(175, 65);
            this.favRadioStation3.TabIndex = 8;
            this.favRadioStation3.Text = "100.3 MHz";
            this.favRadioStation3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.favRadioStation3.UseVisualStyleBackColor = false;
            this.favRadioStation3.Click += new System.EventHandler(this.favRadioStation3_Click);
            // 
            // favRadioStation4
            // 
            this.favRadioStation4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favRadioStation4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.favRadioStation4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favRadioStation4.Enabled = false;
            this.favRadioStation4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favRadioStation4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation4.IconChar = FontAwesome.Sharp.IconChar.TowerCell;
            this.favRadioStation4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.favRadioStation4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.favRadioStation4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favRadioStation4.Location = new System.Drawing.Point(721, 542);
            this.favRadioStation4.Name = "favRadioStation4";
            this.favRadioStation4.Size = new System.Drawing.Size(175, 65);
            this.favRadioStation4.TabIndex = 9;
            this.favRadioStation4.Text = "102.1MHz";
            this.favRadioStation4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.favRadioStation4.UseVisualStyleBackColor = false;
            this.favRadioStation4.Click += new System.EventHandler(this.favRadioStation4_Click);
            // 
            // RadioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.favRadioStation4);
            this.Controls.Add(this.favRadioStation3);
            this.Controls.Add(this.favRadioStation2);
            this.Controls.Add(this.favRadioStation1);
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
        private FontAwesome.Sharp.IconButton favRadioStation1;
        private FontAwesome.Sharp.IconButton favRadioStation2;
        private FontAwesome.Sharp.IconButton favRadioStation3;
        private FontAwesome.Sharp.IconButton favRadioStation4;
    }
}