namespace hotel_app.Forms.Functions
{
    partial class RestaurantMenuForm
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
            this.pagePanel = new System.Windows.Forms.Panel();
            this.cartButton = new FontAwesome.Sharp.IconPictureBox();
            this.menuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pagePanel
            // 
            this.pagePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagePanel.Location = new System.Drawing.Point(123, 167);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(763, 395);
            this.pagePanel.TabIndex = 0;
            // 
            // cartButton
            // 
            this.cartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.cartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.cartButton.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.cartButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.cartButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cartButton.Location = new System.Drawing.Point(854, 129);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(32, 32);
            this.cartButton.TabIndex = 3;
            this.cartButton.TabStop = false;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.menuLabel.Location = new System.Drawing.Point(100, 30);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(140, 35);
            this.menuLabel.TabIndex = 5;
            this.menuLabel.Text = "Menu Type";
            // 
            // RestaurantMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.pagePanel);
            this.Name = "RestaurantMenuForm";
            this.Text = "RestaurantMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pagePanel;
        private FontAwesome.Sharp.IconPictureBox cartButton;
        private Label menuLabel;
    }
}