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
            this.username_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.password_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCustom1 = new hotel_app.Custom_Toolbox.ButtonCustom();
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
            // username_richTextBox
            // 
            this.username_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.username_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.username_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.username_richTextBox.BorderSize = 3;
            this.username_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.username_richTextBox.Location = new System.Drawing.Point(559, 305);
            this.username_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.username_richTextBox.Multiline = false;
            this.username_richTextBox.Name = "username_richTextBox";
            this.username_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.username_richTextBox.PasswordChar = false;
            this.username_richTextBox.Size = new System.Drawing.Size(310, 39);
            this.username_richTextBox.TabIndex = 1;
            this.username_richTextBox.Texts = "";
            this.username_richTextBox.UnderlinedStyle = true;
            // 
            // password_richTextBox
            // 
            this.password_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.password_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.password_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.password_richTextBox.BorderSize = 3;
            this.password_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.password_richTextBox.Location = new System.Drawing.Point(559, 406);
            this.password_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.password_richTextBox.Multiline = false;
            this.password_richTextBox.Name = "password_richTextBox";
            this.password_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.password_richTextBox.PasswordChar = true;
            this.password_richTextBox.Size = new System.Drawing.Size(310, 39);
            this.password_richTextBox.TabIndex = 2;
            this.password_richTextBox.Texts = "";
            this.password_richTextBox.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(559, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(559, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom1.BorderColor = System.Drawing.Color.Blue;
            this.buttonCustom1.BorderRadius = 40;
            this.buttonCustom1.BorderSize = 0;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.ForeColor = System.Drawing.Color.White;
            this.buttonCustom1.Location = new System.Drawing.Point(1043, 401);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(150, 40);
            this.buttonCustom1.TabIndex = 6;
            this.buttonCustom1.Text = "buttonCustom1";
            this.buttonCustom1.TextColor = System.Drawing.Color.White;
            this.buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(139)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_richTextBox);
            this.Controls.Add(this.username_richTextBox);
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
        private CustomControls.RichTextBox.RichTextBox username_richTextBox;
        private CustomControls.RichTextBox.RichTextBox password_richTextBox;
        private Label label1;
        private Label label2;
        private Custom_Toolbox.ButtonCustom buttonCustom1;
    }
}