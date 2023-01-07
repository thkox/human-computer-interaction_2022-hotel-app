namespace hotel_app.Forms.Functions
{
    partial class WaterLevelForm
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
            this.waterLevel = new System.Windows.Forms.PictureBox();
            this.hideWaterLevel = new System.Windows.Forms.PictureBox();
            this.waterLevelUpButton = new FontAwesome.Sharp.IconButton();
            this.waterLevelDownButton = new FontAwesome.Sharp.IconButton();
            this.waterLevelPanel = new System.Windows.Forms.Panel();
            this.waterLevelValueLabel = new System.Windows.Forms.Label();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.waterLevelEmptyButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.waterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideWaterLevel)).BeginInit();
            this.waterLevelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // waterLevel
            // 
            this.waterLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevel.BackColor = System.Drawing.Color.RoyalBlue;
            this.waterLevel.Location = new System.Drawing.Point(309, 166);
            this.waterLevel.Name = "waterLevel";
            this.waterLevel.Size = new System.Drawing.Size(80, 250);
            this.waterLevel.TabIndex = 0;
            this.waterLevel.TabStop = false;
            // 
            // hideWaterLevel
            // 
            this.hideWaterLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hideWaterLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.hideWaterLevel.Location = new System.Drawing.Point(309, 166);
            this.hideWaterLevel.Name = "hideWaterLevel";
            this.hideWaterLevel.Size = new System.Drawing.Size(80, 250);
            this.hideWaterLevel.TabIndex = 1;
            this.hideWaterLevel.TabStop = false;
            // 
            // waterLevelUpButton
            // 
            this.waterLevelUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.waterLevelUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waterLevelUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.waterLevelUpButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.waterLevelUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.waterLevelUpButton.Location = new System.Drawing.Point(576, 422);
            this.waterLevelUpButton.Name = "waterLevelUpButton";
            this.waterLevelUpButton.Size = new System.Drawing.Size(175, 65);
            this.waterLevelUpButton.TabIndex = 2;
            this.waterLevelUpButton.UseVisualStyleBackColor = false;
            this.waterLevelUpButton.EnabledChanged += new System.EventHandler(this.waterLevelUpButton_EnabledChanged);
            this.waterLevelUpButton.Click += new System.EventHandler(this.waterLevelUpButton_Click);
            // 
            // waterLevelDownButton
            // 
            this.waterLevelDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.waterLevelDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waterLevelDownButton.ForeColor = System.Drawing.Color.Transparent;
            this.waterLevelDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.waterLevelDownButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.waterLevelDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.waterLevelDownButton.Location = new System.Drawing.Point(395, 422);
            this.waterLevelDownButton.Name = "waterLevelDownButton";
            this.waterLevelDownButton.Size = new System.Drawing.Size(175, 65);
            this.waterLevelDownButton.TabIndex = 3;
            this.waterLevelDownButton.UseVisualStyleBackColor = false;
            this.waterLevelDownButton.EnabledChanged += new System.EventHandler(this.waterLevelDownButton_EnabledChanged);
            this.waterLevelDownButton.Click += new System.EventHandler(this.waterLevelDownButton_Click);
            // 
            // waterLevelPanel
            // 
            this.waterLevelPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            this.waterLevelPanel.Controls.Add(this.waterLevelValueLabel);
            this.waterLevelPanel.Location = new System.Drawing.Point(395, 166);
            this.waterLevelPanel.Name = "waterLevelPanel";
            this.waterLevelPanel.Size = new System.Drawing.Size(356, 250);
            this.waterLevelPanel.TabIndex = 4;
            // 
            // waterLevelValueLabel
            // 
            this.waterLevelValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelValueLabel.AutoSize = true;
            this.waterLevelValueLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waterLevelValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.waterLevelValueLabel.Location = new System.Drawing.Point(84, 77);
            this.waterLevelValueLabel.Name = "waterLevelValueLabel";
            this.waterLevelValueLabel.Size = new System.Drawing.Size(159, 86);
            this.waterLevelValueLabel.TabIndex = 0;
            this.waterLevelValueLabel.Text = "[Val]";
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waterLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.waterLevelLabel.Location = new System.Drawing.Point(351, 102);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(199, 45);
            this.waterLevelLabel.TabIndex = 1;
            this.waterLevelLabel.Text = "[Pool Place]";
            // 
            // waterLevelEmptyButton
            // 
            this.waterLevelEmptyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelEmptyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.waterLevelEmptyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waterLevelEmptyButton.IconChar = FontAwesome.Sharp.IconChar.TintSlash;
            this.waterLevelEmptyButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.waterLevelEmptyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.waterLevelEmptyButton.Location = new System.Drawing.Point(309, 422);
            this.waterLevelEmptyButton.Name = "waterLevelEmptyButton";
            this.waterLevelEmptyButton.Size = new System.Drawing.Size(80, 65);
            this.waterLevelEmptyButton.TabIndex = 5;
            this.waterLevelEmptyButton.UseVisualStyleBackColor = false;
            this.waterLevelEmptyButton.EnabledChanged += new System.EventHandler(this.waterLevelEmptyButton_EnabledChanged);
            this.waterLevelEmptyButton.Click += new System.EventHandler(this.waterLevelEmptyButton_Click);
            // 
            // WaterLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.waterLevelLabel);
            this.Controls.Add(this.waterLevelEmptyButton);
            this.Controls.Add(this.waterLevelPanel);
            this.Controls.Add(this.waterLevelDownButton);
            this.Controls.Add(this.waterLevelUpButton);
            this.Controls.Add(this.hideWaterLevel);
            this.Controls.Add(this.waterLevel);
            this.Name = "WaterLevelForm";
            this.Text = "WaterLevelForm";
            this.Load += new System.EventHandler(this.WaterLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideWaterLevel)).EndInit();
            this.waterLevelPanel.ResumeLayout(false);
            this.waterLevelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox waterLevel;
        private PictureBox hideWaterLevel;
        private FontAwesome.Sharp.IconButton waterLevelUpButton;
        private FontAwesome.Sharp.IconButton waterLevelDownButton;
        private Panel waterLevelPanel;
        private Label waterLevelValueLabel;
        private FontAwesome.Sharp.IconButton waterLevelEmptyButton;
        public Label waterLevelLabel;
    }
}