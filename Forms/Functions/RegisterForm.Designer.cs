﻿namespace hotel_app.Forms.Functions
{
    partial class RegisterForm
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
            this.registerButton = new hotel_app.Custom_Toolbox.ButtonCustom();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstname_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.lastname_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.id_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirth_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.checkinDateLabel = new System.Windows.Forms.Label();
            this.checkinDate_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.checkoutDateLabel = new System.Windows.Forms.Label();
            this.checkoutDate_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.room_radioButtonCustom = new hotel_app.Custom_Toolbox.RadioButtonCustom();
            this.trojan_radioButtonCustom = new hotel_app.Custom_Toolbox.RadioButtonCustom();
            this.errorLabel = new System.Windows.Forms.Label();
            this.helpButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.BackColor = System.Drawing.Color.Goldenrod;
            this.registerButton.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.registerButton.BorderColor = System.Drawing.Color.Blue;
            this.registerButton.BorderRadius = 60;
            this.registerButton.BorderSize = 0;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(450, 555);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(190, 64);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "Register";
            this.registerButton.TextColor = System.Drawing.Color.White;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.Leave += new System.EventHandler(this.registerButton_Leave);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.firstnameLabel.Location = new System.Drawing.Point(392, 35);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(111, 27);
            this.firstnameLabel.TabIndex = 8;
            this.firstnameLabel.Text = "Firstname:";
            // 
            // firstname_richTextBox
            // 
            this.firstname_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstname_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.firstname_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.firstname_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.firstname_richTextBox.BorderSize = 3;
            this.firstname_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstname_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstname_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.firstname_richTextBox.Location = new System.Drawing.Point(392, 66);
            this.firstname_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstname_richTextBox.MaxLength = 32767;
            this.firstname_richTextBox.Multiline = false;
            this.firstname_richTextBox.Name = "firstname_richTextBox";
            this.firstname_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.firstname_richTextBox.PasswordChar = false;
            this.firstname_richTextBox.Size = new System.Drawing.Size(300, 39);
            this.firstname_richTextBox.TabIndex = 7;
            this.firstname_richTextBox.Texts = "";
            this.firstname_richTextBox.UnderlinedStyle = true;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.lastnameLabel.Location = new System.Drawing.Point(392, 124);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(106, 27);
            this.lastnameLabel.TabIndex = 11;
            this.lastnameLabel.Text = "Lastname:";
            // 
            // lastname_richTextBox
            // 
            this.lastname_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastname_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.lastname_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.lastname_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.lastname_richTextBox.BorderSize = 3;
            this.lastname_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastname_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.lastname_richTextBox.Location = new System.Drawing.Point(392, 155);
            this.lastname_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastname_richTextBox.MaxLength = 32767;
            this.lastname_richTextBox.Multiline = false;
            this.lastname_richTextBox.Name = "lastname_richTextBox";
            this.lastname_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.lastname_richTextBox.PasswordChar = false;
            this.lastname_richTextBox.Size = new System.Drawing.Size(300, 39);
            this.lastname_richTextBox.TabIndex = 10;
            this.lastname_richTextBox.Texts = "";
            this.lastname_richTextBox.UnderlinedStyle = true;
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.idLabel.Location = new System.Drawing.Point(392, 345);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(44, 27);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "ID:";
            // 
            // id_richTextBox
            // 
            this.id_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.id_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.id_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.id_richTextBox.BorderSize = 3;
            this.id_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.id_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.id_richTextBox.Location = new System.Drawing.Point(392, 376);
            this.id_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_richTextBox.MaxLength = 32767;
            this.id_richTextBox.Multiline = false;
            this.id_richTextBox.Name = "id_richTextBox";
            this.id_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.id_richTextBox.PasswordChar = false;
            this.id_richTextBox.Size = new System.Drawing.Size(300, 39);
            this.id_richTextBox.TabIndex = 13;
            this.id_richTextBox.Texts = "";
            this.id_richTextBox.UnderlinedStyle = true;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(392, 208);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(147, 27);
            this.dateOfBirthLabel.TabIndex = 16;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // dateOfBirth_richTextBox
            // 
            this.dateOfBirth_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirth_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.dateOfBirth_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.dateOfBirth_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.dateOfBirth_richTextBox.BorderSize = 3;
            this.dateOfBirth_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateOfBirth_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirth_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.dateOfBirth_richTextBox.Location = new System.Drawing.Point(392, 239);
            this.dateOfBirth_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirth_richTextBox.MaxLength = 32767;
            this.dateOfBirth_richTextBox.Multiline = false;
            this.dateOfBirth_richTextBox.Name = "dateOfBirth_richTextBox";
            this.dateOfBirth_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.dateOfBirth_richTextBox.PasswordChar = false;
            this.dateOfBirth_richTextBox.Size = new System.Drawing.Size(134, 39);
            this.dateOfBirth_richTextBox.TabIndex = 15;
            this.dateOfBirth_richTextBox.Texts = "";
            this.dateOfBirth_richTextBox.UnderlinedStyle = true;
            this.dateOfBirth_richTextBox.Leave += new System.EventHandler(this.dateOfBirth_richTextBox_Leave);
            // 
            // checkinDateLabel
            // 
            this.checkinDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkinDateLabel.AutoSize = true;
            this.checkinDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkinDateLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkinDateLabel.Location = new System.Drawing.Point(392, 432);
            this.checkinDateLabel.Name = "checkinDateLabel";
            this.checkinDateLabel.Size = new System.Drawing.Size(101, 27);
            this.checkinDateLabel.TabIndex = 18;
            this.checkinDateLabel.Text = "Check-in:";
            // 
            // checkinDate_richTextBox
            // 
            this.checkinDate_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkinDate_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.checkinDate_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.checkinDate_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.checkinDate_richTextBox.BorderSize = 3;
            this.checkinDate_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkinDate_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkinDate_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkinDate_richTextBox.Location = new System.Drawing.Point(392, 469);
            this.checkinDate_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkinDate_richTextBox.MaxLength = 32767;
            this.checkinDate_richTextBox.Multiline = false;
            this.checkinDate_richTextBox.Name = "checkinDate_richTextBox";
            this.checkinDate_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.checkinDate_richTextBox.PasswordChar = false;
            this.checkinDate_richTextBox.Size = new System.Drawing.Size(134, 39);
            this.checkinDate_richTextBox.TabIndex = 17;
            this.checkinDate_richTextBox.Texts = "";
            this.checkinDate_richTextBox.UnderlinedStyle = true;
            this.checkinDate_richTextBox.Leave += new System.EventHandler(this.checkinDate_richTextBox_Leave);
            // 
            // checkoutDateLabel
            // 
            this.checkoutDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkoutDateLabel.AutoSize = true;
            this.checkoutDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutDateLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkoutDateLabel.Location = new System.Drawing.Point(558, 432);
            this.checkoutDateLabel.Name = "checkoutDateLabel";
            this.checkoutDateLabel.Size = new System.Drawing.Size(115, 27);
            this.checkoutDateLabel.TabIndex = 20;
            this.checkoutDateLabel.Text = "Check-out:";
            // 
            // checkoutDate_richTextBox
            // 
            this.checkoutDate_richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkoutDate_richTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.checkoutDate_richTextBox.BorderColor = System.Drawing.Color.Goldenrod;
            this.checkoutDate_richTextBox.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.checkoutDate_richTextBox.BorderSize = 3;
            this.checkoutDate_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutDate_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutDate_richTextBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.checkoutDate_richTextBox.Location = new System.Drawing.Point(558, 469);
            this.checkoutDate_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutDate_richTextBox.MaxLength = 32767;
            this.checkoutDate_richTextBox.Multiline = false;
            this.checkoutDate_richTextBox.Name = "checkoutDate_richTextBox";
            this.checkoutDate_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.checkoutDate_richTextBox.PasswordChar = false;
            this.checkoutDate_richTextBox.Size = new System.Drawing.Size(134, 39);
            this.checkoutDate_richTextBox.TabIndex = 19;
            this.checkoutDate_richTextBox.Texts = "";
            this.checkoutDate_richTextBox.UnderlinedStyle = true;
            this.checkoutDate_richTextBox.Leave += new System.EventHandler(this.checkoutDate_richTextBox_Leave);
            // 
            // room_radioButtonCustom
            // 
            this.room_radioButtonCustom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.room_radioButtonCustom.AutoSize = true;
            this.room_radioButtonCustom.Checked = true;
            this.room_radioButtonCustom.CheckedColor = System.Drawing.Color.Goldenrod;
            this.room_radioButtonCustom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.room_radioButtonCustom.ForeColor = System.Drawing.Color.Goldenrod;
            this.room_radioButtonCustom.Location = new System.Drawing.Point(391, 304);
            this.room_radioButtonCustom.MinimumSize = new System.Drawing.Size(0, 21);
            this.room_radioButtonCustom.Name = "room_radioButtonCustom";
            this.room_radioButtonCustom.Size = new System.Drawing.Size(89, 31);
            this.room_radioButtonCustom.TabIndex = 21;
            this.room_radioButtonCustom.TabStop = true;
            this.room_radioButtonCustom.Text = "Room";
            this.room_radioButtonCustom.UnCheckedColor = System.Drawing.Color.Gray;
            this.room_radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // trojan_radioButtonCustom
            // 
            this.trojan_radioButtonCustom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trojan_radioButtonCustom.AutoSize = true;
            this.trojan_radioButtonCustom.CheckedColor = System.Drawing.Color.Goldenrod;
            this.trojan_radioButtonCustom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trojan_radioButtonCustom.ForeColor = System.Drawing.Color.Goldenrod;
            this.trojan_radioButtonCustom.Location = new System.Drawing.Point(498, 304);
            this.trojan_radioButtonCustom.MinimumSize = new System.Drawing.Size(0, 21);
            this.trojan_radioButtonCustom.Name = "trojan_radioButtonCustom";
            this.trojan_radioButtonCustom.Size = new System.Drawing.Size(103, 31);
            this.trojan_radioButtonCustom.TabIndex = 22;
            this.trojan_radioButtonCustom.TabStop = true;
            this.trojan_radioButtonCustom.Text = "Trojan";
            this.trojan_radioButtonCustom.UnCheckedColor = System.Drawing.Color.Gray;
            this.trojan_radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.errorLabel.Location = new System.Drawing.Point(392, 522);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(109, 19);
            this.errorLabel.TabIndex = 23;
            this.errorLabel.Text = "[Error Message]";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.Color.Black;
            this.helpButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.helpButton.IconColor = System.Drawing.Color.Black;
            this.helpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.helpButton.IconSize = 40;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpButton.Location = new System.Drawing.Point(1012, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(60, 60);
            this.helpButton.TabIndex = 24;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.trojan_radioButtonCustom);
            this.Controls.Add(this.room_radioButtonCustom);
            this.Controls.Add(this.checkoutDateLabel);
            this.Controls.Add(this.checkoutDate_richTextBox);
            this.Controls.Add(this.checkinDateLabel);
            this.Controls.Add(this.checkinDate_richTextBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirth_richTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.id_richTextBox);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.lastname_richTextBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.firstname_richTextBox);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Toolbox.ButtonCustom registerButton;
        private Label firstnameLabel;
        private CustomControls.RichTextBox.RichTextBox firstname_richTextBox;
        private Label lastnameLabel;
        private CustomControls.RichTextBox.RichTextBox lastname_richTextBox;
        private Label idLabel;
        private CustomControls.RichTextBox.RichTextBox id_richTextBox;
        private Label dateOfBirthLabel;
        private CustomControls.RichTextBox.RichTextBox dateOfBirth_richTextBox;
        private Label checkinDateLabel;
        private CustomControls.RichTextBox.RichTextBox checkinDate_richTextBox;
        private Label checkoutDateLabel;
        private CustomControls.RichTextBox.RichTextBox checkoutDate_richTextBox;
        private Custom_Toolbox.RadioButtonCustom room_radioButtonCustom;
        private Custom_Toolbox.RadioButtonCustom trojan_radioButtonCustom;
        private Label errorLabel;
        private FontAwesome.Sharp.IconButton helpButton;
    }
}