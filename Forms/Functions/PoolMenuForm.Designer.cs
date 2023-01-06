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
            this.poolLoadFormsPanel = new System.Windows.Forms.Panel();
            this.backPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.poolLoadFormsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // waterLevelButton
            // 
            this.waterLevelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.waterLevelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.waterLevelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waterLevelButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.waterLevelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.waterLevelButton.IconChar = FontAwesome.Sharp.IconChar.WaterLadder;
            this.waterLevelButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.waterLevelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.waterLevelButton.Location = new System.Drawing.Point(205, 206);
            this.waterLevelButton.Name = "waterLevelButton";
            this.waterLevelButton.Size = new System.Drawing.Size(150, 96);
            this.waterLevelButton.TabIndex = 0;
            this.waterLevelButton.Text = "Water Level";
            this.waterLevelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.waterLevelButton.UseVisualStyleBackColor = false;
            this.waterLevelButton.Click += new System.EventHandler(this.waterLevelButton_Click);
            // 
            // thermostatButton
            // 
            this.thermostatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thermostatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.thermostatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thermostatButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thermostatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatButton.IconChar = FontAwesome.Sharp.IconChar.Temperature1;
            this.thermostatButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.thermostatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.thermostatButton.Location = new System.Drawing.Point(459, 206);
            this.thermostatButton.Name = "thermostatButton";
            this.thermostatButton.Size = new System.Drawing.Size(150, 96);
            this.thermostatButton.TabIndex = 1;
            this.thermostatButton.Text = "Thermostat";
            this.thermostatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.thermostatButton.UseVisualStyleBackColor = false;
            this.thermostatButton.Click += new System.EventHandler(this.thermostatButton_Click);
            // 
            // sensorButton
            // 
            this.sensorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sensorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.sensorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sensorButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sensorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.sensorButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.sensorButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.sensorButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sensorButton.Location = new System.Drawing.Point(714, 206);
            this.sensorButton.Name = "sensorButton";
            this.sensorButton.Size = new System.Drawing.Size(150, 96);
            this.sensorButton.TabIndex = 2;
            this.sensorButton.Text = "Sensor";
            this.sensorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sensorButton.UseVisualStyleBackColor = false;
            this.sensorButton.Click += new System.EventHandler(this.sensorButton_Click);
            // 
            // poolLoadFormsPanel
            // 
            this.poolLoadFormsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.poolLoadFormsPanel.Controls.Add(this.waterLevelButton);
            this.poolLoadFormsPanel.Controls.Add(this.sensorButton);
            this.poolLoadFormsPanel.Controls.Add(this.thermostatButton);
            this.poolLoadFormsPanel.Location = new System.Drawing.Point(4, -6);
            this.poolLoadFormsPanel.Name = "poolLoadFormsPanel";
            this.poolLoadFormsPanel.Size = new System.Drawing.Size(1079, 672);
            this.poolLoadFormsPanel.TabIndex = 3;
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.backPictureBox.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.backPictureBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.backPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backPictureBox.IconSize = 42;
            this.backPictureBox.Location = new System.Drawing.Point(25, 12);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(42, 42);
            this.backPictureBox.TabIndex = 4;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // PoolMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.poolLoadFormsPanel);
            this.Name = "PoolMenuForm";
            this.Text = "PoolMenuForm";
            this.Load += new System.EventHandler(this.PoolMenuForm_Load);
            this.poolLoadFormsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton waterLevelButton;
        private FontAwesome.Sharp.IconButton thermostatButton;
        private FontAwesome.Sharp.IconButton sensorButton;
        private Panel poolLoadFormsPanel;
        private FontAwesome.Sharp.IconPictureBox backPictureBox;
    }
}