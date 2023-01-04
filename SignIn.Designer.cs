namespace hotel_app
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.hotelTitle = new System.Windows.Forms.Label();
            this.richTextBox1 = new CustomControls.RichTextBox.RichTextBox();
            this.richTextBox2 = new CustomControls.RichTextBox.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hotelTitle
            // 
            this.hotelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hotelTitle.AutoSize = true;
            this.hotelTitle.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hotelTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.hotelTitle.Location = new System.Drawing.Point(493, 88);
            this.hotelTitle.Name = "hotelTitle";
            this.hotelTitle.Size = new System.Drawing.Size(414, 113);
            this.hotelTitle.TabIndex = 0;
            this.hotelTitle.Text = "Zeus Palace";
            this.hotelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.BorderColor = System.Drawing.Color.Goldenrod;
            this.richTextBox1.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.richTextBox1.BorderSize = 3;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.richTextBox1.Location = new System.Drawing.Point(559, 305);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.richTextBox1.PasswordChar = false;
            this.richTextBox1.Size = new System.Drawing.Size(310, 39);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Texts = "";
            this.richTextBox1.UnderlinedStyle = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox2.BorderColor = System.Drawing.Color.Goldenrod;
            this.richTextBox2.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.richTextBox2.BorderSize = 3;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.richTextBox2.Location = new System.Drawing.Point(559, 406);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.richTextBox2.PasswordChar = true;
            this.richTextBox2.Size = new System.Drawing.Size(310, 39);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Texts = "";
            this.richTextBox2.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(559, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(559, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(139)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.hotelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hotelTitle;
        private CustomControls.RichTextBox.RichTextBox richTextBox1;
        private CustomControls.RichTextBox.RichTextBox richTextBox2;
        private Label label1;
        private Label label2;
    }
}