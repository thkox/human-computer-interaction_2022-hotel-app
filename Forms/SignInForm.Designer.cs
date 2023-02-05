using System.Windows.Forms.VisualStyles;

namespace hotel_app
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.username_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.password_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new hotel_app.Custom_Toolbox.ButtonCustom();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.username_richTextBox.Location = new System.Drawing.Point(553, 390);
            this.username_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.username_richTextBox.MaxLength = 32767;
            this.username_richTextBox.Multiline = false;
            this.username_richTextBox.Name = "username_richTextBox";
            this.username_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.username_richTextBox.PasswordChar = false;
            this.username_richTextBox.Size = new System.Drawing.Size(300, 39);
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
            this.password_richTextBox.Location = new System.Drawing.Point(553, 491);
            this.password_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.password_richTextBox.MaxLength = 32767;
            this.password_richTextBox.Multiline = false;
            this.password_richTextBox.Name = "password_richTextBox";
            this.password_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.password_richTextBox.PasswordChar = true;
            this.password_richTextBox.Size = new System.Drawing.Size(300, 39);
            this.password_richTextBox.TabIndex = 2;
            this.password_richTextBox.Texts = "";
            this.password_richTextBox.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(553, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(553, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.BackColor = System.Drawing.Color.Goldenrod;
            this.login_button.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.login_button.BorderColor = System.Drawing.Color.Blue;
            this.login_button.BorderRadius = 60;
            this.login_button.BorderSize = 0;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(608, 591);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(190, 64);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Sign in";
            this.login_button.TextColor = System.Drawing.Color.White;
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.errorLabel.Location = new System.Drawing.Point(472, 548);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(161, 27);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "[Error Message]";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::hotel_app.Properties.Resources.MainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(454, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.helpButton.Location = new System.Drawing.Point(1311, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(60, 60);
            this.helpButton.TabIndex = 23;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // SignInForm
            // 
            this.AcceptButton = this.login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_richTextBox);
            this.Controls.Add(this.username_richTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RichTextBox.RichTextBox username_richTextBox;
        private CustomControls.RichTextBox.RichTextBox password_richTextBox;
        private Label label1;
        private Label label2;
        private Custom_Toolbox.ButtonCustom login_button;
        private Label errorLabel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton helpButton;
    }
}