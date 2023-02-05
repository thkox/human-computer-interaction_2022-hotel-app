namespace hotel_app.Forms.Functions
{
    partial class GPSMenuForm
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
            this.gpsLoadFormsPanel = new System.Windows.Forms.Panel();
            this.availableFacilitiesButton = new FontAwesome.Sharp.IconButton();
            this.changeParkingSlotButton = new FontAwesome.Sharp.IconButton();
            this.backPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.helpButton = new FontAwesome.Sharp.IconButton();
            this.gpsLoadFormsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gpsLoadFormsPanel
            // 
            this.gpsLoadFormsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpsLoadFormsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.gpsLoadFormsPanel.Controls.Add(this.helpButton);
            this.gpsLoadFormsPanel.Controls.Add(this.availableFacilitiesButton);
            this.gpsLoadFormsPanel.Controls.Add(this.changeParkingSlotButton);
            this.gpsLoadFormsPanel.Location = new System.Drawing.Point(4, -6);
            this.gpsLoadFormsPanel.Name = "gpsLoadFormsPanel";
            this.gpsLoadFormsPanel.Size = new System.Drawing.Size(1079, 672);
            this.gpsLoadFormsPanel.TabIndex = 0;
            // 
            // availableFacilitiesButton
            // 
            this.availableFacilitiesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.availableFacilitiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.availableFacilitiesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availableFacilitiesButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availableFacilitiesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.availableFacilitiesButton.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            this.availableFacilitiesButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.availableFacilitiesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.availableFacilitiesButton.Location = new System.Drawing.Point(585, 248);
            this.availableFacilitiesButton.Name = "availableFacilitiesButton";
            this.availableFacilitiesButton.Size = new System.Drawing.Size(150, 131);
            this.availableFacilitiesButton.TabIndex = 2;
            this.availableFacilitiesButton.Text = "Available Facilities";
            this.availableFacilitiesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.availableFacilitiesButton.UseVisualStyleBackColor = false;
            this.availableFacilitiesButton.Click += new System.EventHandler(this.availableFacilitiesButton_Click);
            // 
            // changeParkingSlotButton
            // 
            this.changeParkingSlotButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeParkingSlotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.changeParkingSlotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeParkingSlotButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeParkingSlotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.changeParkingSlotButton.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.changeParkingSlotButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.changeParkingSlotButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeParkingSlotButton.Location = new System.Drawing.Point(338, 248);
            this.changeParkingSlotButton.Name = "changeParkingSlotButton";
            this.changeParkingSlotButton.Size = new System.Drawing.Size(150, 131);
            this.changeParkingSlotButton.TabIndex = 1;
            this.changeParkingSlotButton.Text = "Change Parking Slot";
            this.changeParkingSlotButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.changeParkingSlotButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.changeParkingSlotButton.UseVisualStyleBackColor = false;
            this.changeParkingSlotButton.Click += new System.EventHandler(this.changeParkingSlotButton_Click);
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
            this.backPictureBox.Location = new System.Drawing.Point(9, 12);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(42, 42);
            this.backPictureBox.TabIndex = 4;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.Color.Black;
            this.helpButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.helpButton.IconColor = System.Drawing.Color.Black;
            this.helpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.helpButton.IconSize = 40;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpButton.Location = new System.Drawing.Point(1008, 18);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(60, 60);
            this.helpButton.TabIndex = 12;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // GPSMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.gpsLoadFormsPanel);
            this.Name = "GPSMenuForm";
            this.Text = "GPSMenuForm";
            this.Load += new System.EventHandler(this.GPSMenuForm_Load);
            this.gpsLoadFormsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel gpsLoadFormsPanel;
        private FontAwesome.Sharp.IconPictureBox backPictureBox;
        private FontAwesome.Sharp.IconButton changeParkingSlotButton;
        private FontAwesome.Sharp.IconButton availableFacilitiesButton;
        private FontAwesome.Sharp.IconButton helpButton;
    }
}