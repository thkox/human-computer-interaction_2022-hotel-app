namespace hotel_app.Forms.Functions
{
    partial class CourtyardZeusForm
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
            this.components = new System.ComponentModel.Container();
            this.parkingPanel = new System.Windows.Forms.Panel();
            this.parkingButton = new FontAwesome.Sharp.IconButton();
            this.trojan1PictureBox = new System.Windows.Forms.PictureBox();
            this.parkingPictureBox = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.parkingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trojan1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingPanel
            // 
            this.parkingPanel.Controls.Add(this.parkingButton);
            this.parkingPanel.Controls.Add(this.trojan1PictureBox);
            this.parkingPanel.Controls.Add(this.parkingPictureBox);
            this.parkingPanel.Location = new System.Drawing.Point(1, 0);
            this.parkingPanel.Name = "parkingPanel";
            this.parkingPanel.Size = new System.Drawing.Size(1083, 662);
            this.parkingPanel.TabIndex = 0;
            // 
            // parkingButton
            // 
            this.parkingButton.BackColor = System.Drawing.Color.Silver;
            this.parkingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkingButton.FlatAppearance.BorderSize = 0;
            this.parkingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingButton.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.parkingButton.IconColor = System.Drawing.Color.Black;
            this.parkingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.parkingButton.IconSize = 68;
            this.parkingButton.Location = new System.Drawing.Point(53, 587);
            this.parkingButton.Name = "parkingButton";
            this.parkingButton.Size = new System.Drawing.Size(64, 62);
            this.parkingButton.TabIndex = 1;
            this.parkingButton.UseVisualStyleBackColor = false;
            // 
            // trojan1PictureBox
            // 
            this.trojan1PictureBox.Image = global::hotel_app.Properties.Resources.trojan;
            this.trojan1PictureBox.Location = new System.Drawing.Point(295, 252);
            this.trojan1PictureBox.Name = "trojan1PictureBox";
            this.trojan1PictureBox.Size = new System.Drawing.Size(88, 89);
            this.trojan1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trojan1PictureBox.TabIndex = 0;
            this.trojan1PictureBox.TabStop = false;
            // 
            // parkingPictureBox
            // 
            this.parkingPictureBox.Image = global::hotel_app.Properties.Resources.parking;
            this.parkingPictureBox.Location = new System.Drawing.Point(46, 30);
            this.parkingPictureBox.Name = "parkingPictureBox";
            this.parkingPictureBox.Size = new System.Drawing.Size(987, 619);
            this.parkingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.parkingPictureBox.TabIndex = 0;
            this.parkingPictureBox.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // CourtyardZeusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.parkingPanel);
            this.Name = "CourtyardZeusForm";
            this.Text = "CourtyardZeusForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.parkingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trojan1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel parkingPanel;
        private PictureBox parkingPictureBox;
        private System.Windows.Forms.Timer moveTimer;
        private FontAwesome.Sharp.IconButton parkingButton;
        private PictureBox trojan1PictureBox;
    }
}