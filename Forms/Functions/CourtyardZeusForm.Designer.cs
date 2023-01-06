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
            this.parkingPanel = new System.Windows.Forms.Panel();
            this.parkingPictureBox = new System.Windows.Forms.PictureBox();
            this.drivingAreaPanel = new System.Windows.Forms.Panel();
            this.trojan1PictureBox = new System.Windows.Forms.PictureBox();
            this.parkingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingPictureBox)).BeginInit();
            this.drivingAreaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trojan1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingPanel
            // 
            this.parkingPanel.Controls.Add(this.drivingAreaPanel);
            this.parkingPanel.Controls.Add(this.parkingPictureBox);
            this.parkingPanel.Location = new System.Drawing.Point(1, 0);
            this.parkingPanel.Name = "parkingPanel";
            this.parkingPanel.Size = new System.Drawing.Size(1083, 662);
            this.parkingPanel.TabIndex = 0;
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
            // drivingAreaPanel
            // 
            this.drivingAreaPanel.BackColor = System.Drawing.Color.Silver;
            this.drivingAreaPanel.Controls.Add(this.trojan1PictureBox);
            this.drivingAreaPanel.Location = new System.Drawing.Point(46, 30);
            this.drivingAreaPanel.Name = "drivingAreaPanel";
            this.drivingAreaPanel.Size = new System.Drawing.Size(786, 619);
            this.drivingAreaPanel.TabIndex = 1;
            // 
            // trojan1PictureBox
            // 
            this.trojan1PictureBox.Image = global::hotel_app.Properties.Resources.trojan;
            this.trojan1PictureBox.Location = new System.Drawing.Point(289, 181);
            this.trojan1PictureBox.Name = "trojan1PictureBox";
            this.trojan1PictureBox.Size = new System.Drawing.Size(159, 89);
            this.trojan1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trojan1PictureBox.TabIndex = 0;
            this.trojan1PictureBox.TabStop = false;
            // 
            // CourtyardZeusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.parkingPanel);
            this.Name = "CourtyardZeusForm";
            this.Text = "CourtyardZeusForm";
            this.parkingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkingPictureBox)).EndInit();
            this.drivingAreaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trojan1PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel parkingPanel;
        private Panel drivingAreaPanel;
        private PictureBox trojan1PictureBox;
        private PictureBox parkingPictureBox;
    }
}