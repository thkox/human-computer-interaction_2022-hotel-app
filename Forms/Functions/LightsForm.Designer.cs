namespace hotel_app.Forms.Functions
{
    partial class LightsForm
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
            this.lightButton1 = new FontAwesome.Sharp.IconButton();
            this.lightButton2 = new FontAwesome.Sharp.IconButton();
            this.lightButton3 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lightButton1
            // 
            this.lightButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lightButton1.BackColor = System.Drawing.Color.Transparent;
            this.lightButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightButton1.FlatAppearance.BorderSize = 0;
            this.lightButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightButton1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lightButton1.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.lightButton1.IconColor = System.Drawing.Color.Black;
            this.lightButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lightButton1.IconSize = 100;
            this.lightButton1.Location = new System.Drawing.Point(116, 131);
            this.lightButton1.Name = "lightButton1";
            this.lightButton1.Size = new System.Drawing.Size(163, 188);
            this.lightButton1.TabIndex = 0;
            this.lightButton1.Text = "Living Room";
            this.lightButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lightButton1.UseVisualStyleBackColor = false;
            this.lightButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lightButton2
            // 
            this.lightButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lightButton2.BackColor = System.Drawing.Color.Transparent;
            this.lightButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightButton2.FlatAppearance.BorderSize = 0;
            this.lightButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightButton2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lightButton2.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.lightButton2.IconColor = System.Drawing.Color.Black;
            this.lightButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lightButton2.IconSize = 100;
            this.lightButton2.Location = new System.Drawing.Point(312, 131);
            this.lightButton2.Name = "lightButton2";
            this.lightButton2.Size = new System.Drawing.Size(163, 188);
            this.lightButton2.TabIndex = 1;
            this.lightButton2.Text = "Bedroom";
            this.lightButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lightButton2.UseVisualStyleBackColor = false;
            this.lightButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lightButton3
            // 
            this.lightButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lightButton3.BackColor = System.Drawing.Color.Transparent;
            this.lightButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightButton3.FlatAppearance.BorderSize = 0;
            this.lightButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightButton3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lightButton3.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.lightButton3.IconColor = System.Drawing.Color.Black;
            this.lightButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lightButton3.IconSize = 100;
            this.lightButton3.Location = new System.Drawing.Point(514, 131);
            this.lightButton3.Name = "lightButton3";
            this.lightButton3.Size = new System.Drawing.Size(163, 188);
            this.lightButton3.TabIndex = 2;
            this.lightButton3.Text = "Bathroom";
            this.lightButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lightButton3.UseVisualStyleBackColor = false;
            this.lightButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // LightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lightButton3);
            this.Controls.Add(this.lightButton2);
            this.Controls.Add(this.lightButton1);
            this.Name = "LightsForm";
            this.Text = "Lights";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton lightButton1;
        private FontAwesome.Sharp.IconButton lightButton2;
        private FontAwesome.Sharp.IconButton lightButton3;
    }
}