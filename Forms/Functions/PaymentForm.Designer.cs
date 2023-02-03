namespace hotel_app.Forms.Functions
{
    partial class PaymentForm
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.buttonCustom1 = new hotel_app.Custom_Toolbox.ButtonCustom();
            this.cvv_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNumber_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.year_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.month_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.cardholderName_richTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.cardHolderNameLabel = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.visaCheckBox = new System.Windows.Forms.CheckBox();
            this.mastercardButton = new FontAwesome.Sharp.IconButton();
            this.mastercardCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.paymentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.totalLabel.Location = new System.Drawing.Point(652, 85);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(118, 45);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "[Total]";
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            this.paymentPanel.Controls.Add(this.buttonCustom1);
            this.paymentPanel.Controls.Add(this.cvv_richTextBox);
            this.paymentPanel.Controls.Add(this.label1);
            this.paymentPanel.Controls.Add(this.cardNumber_richTextBox);
            this.paymentPanel.Controls.Add(this.cardNumberLabel);
            this.paymentPanel.Controls.Add(this.year_richTextBox);
            this.paymentPanel.Controls.Add(this.month_richTextBox);
            this.paymentPanel.Controls.Add(this.expirationDateLabel);
            this.paymentPanel.Controls.Add(this.cardholderName_richTextBox);
            this.paymentPanel.Controls.Add(this.cardHolderNameLabel);
            this.paymentPanel.Controls.Add(this.iconButton1);
            this.paymentPanel.Controls.Add(this.visaCheckBox);
            this.paymentPanel.Controls.Add(this.mastercardButton);
            this.paymentPanel.Controls.Add(this.mastercardCheckBox);
            this.paymentPanel.Controls.Add(this.paymentMethodLabel);
            this.paymentPanel.Location = new System.Drawing.Point(307, 133);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(466, 355);
            this.paymentPanel.TabIndex = 1;
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.Color.Teal;
            this.buttonCustom1.BackgroundColor = System.Drawing.Color.Teal;
            this.buttonCustom1.BorderColor = System.Drawing.Color.Blue;
            this.buttonCustom1.BorderRadius = 40;
            this.buttonCustom1.BorderSize = 0;
            this.buttonCustom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom1.ForeColor = System.Drawing.Color.White;
            this.buttonCustom1.Location = new System.Drawing.Point(303, 294);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(150, 40);
            this.buttonCustom1.TabIndex = 15;
            this.buttonCustom1.Text = "Confirmation";
            this.buttonCustom1.TextColor = System.Drawing.Color.White;
            this.buttonCustom1.UseVisualStyleBackColor = false;
            this.buttonCustom1.Click += new System.EventHandler(this.buttonCustom1_Click);
            // 
            // cvv_richTextBox
            // 
            this.cvv_richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cvv_richTextBox.BorderColor = System.Drawing.Color.LightSlateGray;
            this.cvv_richTextBox.BorderFocusColor = System.Drawing.Color.SlateGray;
            this.cvv_richTextBox.BorderSize = 2;
            this.cvv_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cvv_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cvv_richTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.cvv_richTextBox.Location = new System.Drawing.Point(284, 241);
            this.cvv_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cvv_richTextBox.Multiline = false;
            this.cvv_richTextBox.Name = "cvv_richTextBox";
            this.cvv_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.cvv_richTextBox.PasswordChar = false;
            this.cvv_richTextBox.Size = new System.Drawing.Size(44, 31);
            this.cvv_richTextBox.TabIndex = 14;
            this.cvv_richTextBox.Texts = "CVV";
            this.cvv_richTextBox.UnderlinedStyle = false;
            this.cvv_richTextBox.Enter += new System.EventHandler(this.cvv_richTextBox_Enter);
            this.cvv_richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cvv_richTextBox_KeyPress);
            this.cvv_richTextBox.Leave += new System.EventHandler(this.cvv_richTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(284, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "CVV code";
            // 
            // cardNumber_richTextBox
            // 
            this.cardNumber_richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cardNumber_richTextBox.BorderColor = System.Drawing.Color.LightSlateGray;
            this.cardNumber_richTextBox.BorderFocusColor = System.Drawing.Color.SlateGray;
            this.cardNumber_richTextBox.BorderSize = 2;
            this.cardNumber_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardNumber_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardNumber_richTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.cardNumber_richTextBox.Location = new System.Drawing.Point(15, 241);
            this.cardNumber_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cardNumber_richTextBox.Multiline = false;
            this.cardNumber_richTextBox.Name = "cardNumber_richTextBox";
            this.cardNumber_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.cardNumber_richTextBox.PasswordChar = false;
            this.cardNumber_richTextBox.Size = new System.Drawing.Size(250, 31);
            this.cardNumber_richTextBox.TabIndex = 12;
            this.cardNumber_richTextBox.Texts = "Enter Card Number";
            this.cardNumber_richTextBox.UnderlinedStyle = false;
            this.cardNumber_richTextBox.Enter += new System.EventHandler(this.cardNumber_richTextBox_Enter);
            this.cardNumber_richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardNumber_richTextBox_KeyPress);
            this.cardNumber_richTextBox.Leave += new System.EventHandler(this.cardNumber_richTextBox_Leave);
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.cardNumberLabel.Location = new System.Drawing.Point(15, 207);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(147, 30);
            this.cardNumberLabel.TabIndex = 11;
            this.cardNumberLabel.Text = "Card Number";
            // 
            // year_richTextBox
            // 
            this.year_richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.year_richTextBox.BorderColor = System.Drawing.Color.LightSlateGray;
            this.year_richTextBox.BorderFocusColor = System.Drawing.Color.SlateGray;
            this.year_richTextBox.BorderSize = 2;
            this.year_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.year_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.year_richTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.year_richTextBox.Location = new System.Drawing.Point(335, 150);
            this.year_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.year_richTextBox.Multiline = false;
            this.year_richTextBox.Name = "year_richTextBox";
            this.year_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.year_richTextBox.PasswordChar = false;
            this.year_richTextBox.Size = new System.Drawing.Size(87, 31);
            this.year_richTextBox.TabIndex = 10;
            this.year_richTextBox.Texts = "YYYY";
            this.year_richTextBox.UnderlinedStyle = false;
            this.year_richTextBox.Enter += new System.EventHandler(this.year_richTextBox_Enter);
            this.year_richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.year_richTextBox_KeyPress);
            this.year_richTextBox.Leave += new System.EventHandler(this.year_richTextBox_Leave);
            // 
            // month_richTextBox
            // 
            this.month_richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.month_richTextBox.BorderColor = System.Drawing.Color.LightSlateGray;
            this.month_richTextBox.BorderFocusColor = System.Drawing.Color.SlateGray;
            this.month_richTextBox.BorderSize = 2;
            this.month_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.month_richTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.month_richTextBox.Location = new System.Drawing.Point(283, 150);
            this.month_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.month_richTextBox.Multiline = false;
            this.month_richTextBox.Name = "month_richTextBox";
            this.month_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.month_richTextBox.PasswordChar = false;
            this.month_richTextBox.Size = new System.Drawing.Size(44, 31);
            this.month_richTextBox.TabIndex = 9;
            this.month_richTextBox.Texts = "MM";
            this.month_richTextBox.UnderlinedStyle = false;
            this.month_richTextBox.Enter += new System.EventHandler(this.month_richTextBox_Enter);
            this.month_richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.month_richTextBox_KeyPress);
            this.month_richTextBox.Leave += new System.EventHandler(this.month_richTextBox_Leave);
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.expirationDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expirationDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.expirationDateLabel.Location = new System.Drawing.Point(283, 116);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(170, 30);
            this.expirationDateLabel.TabIndex = 7;
            this.expirationDateLabel.Text = "Expiration date";
            // 
            // cardholderName_richTextBox
            // 
            this.cardholderName_richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.cardholderName_richTextBox.BorderColor = System.Drawing.Color.LightSlateGray;
            this.cardholderName_richTextBox.BorderFocusColor = System.Drawing.Color.SlateGray;
            this.cardholderName_richTextBox.BorderSize = 2;
            this.cardholderName_richTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardholderName_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardholderName_richTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.cardholderName_richTextBox.Location = new System.Drawing.Point(14, 150);
            this.cardholderName_richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cardholderName_richTextBox.Multiline = false;
            this.cardholderName_richTextBox.Name = "cardholderName_richTextBox";
            this.cardholderName_richTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.cardholderName_richTextBox.PasswordChar = false;
            this.cardholderName_richTextBox.Size = new System.Drawing.Size(250, 31);
            this.cardholderName_richTextBox.TabIndex = 6;
            this.cardholderName_richTextBox.Texts = "Enter Cardholder name";
            this.cardholderName_richTextBox.UnderlinedStyle = false;
            this.cardholderName_richTextBox.Enter += new System.EventHandler(this.cardholderName_richTextBox_Enter);
            this.cardholderName_richTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardholderName_richTextBox_KeyPress);
            this.cardholderName_richTextBox.Leave += new System.EventHandler(this.cardholderName_richTextBox_Leave);
            // 
            // cardHolderNameLabel
            // 
            this.cardHolderNameLabel.AutoSize = true;
            this.cardHolderNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardHolderNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardHolderNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.cardHolderNameLabel.Location = new System.Drawing.Point(14, 116);
            this.cardHolderNameLabel.Name = "cardHolderNameLabel";
            this.cardHolderNameLabel.Size = new System.Drawing.Size(183, 30);
            this.cardHolderNameLabel.TabIndex = 5;
            this.cardHolderNameLabel.Text = "Cardholder name";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CcVisa;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 80;
            this.iconButton1.Location = new System.Drawing.Point(160, 42);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(80, 54);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // visaCheckBox
            // 
            this.visaCheckBox.AutoSize = true;
            this.visaCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visaCheckBox.Location = new System.Drawing.Point(139, 42);
            this.visaCheckBox.Name = "visaCheckBox";
            this.visaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.visaCheckBox.TabIndex = 3;
            this.visaCheckBox.UseVisualStyleBackColor = true;
            this.visaCheckBox.CheckedChanged += new System.EventHandler(this.visaCheckBox_CheckedChanged);
            // 
            // mastercardButton
            // 
            this.mastercardButton.FlatAppearance.BorderSize = 0;
            this.mastercardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mastercardButton.IconChar = FontAwesome.Sharp.IconChar.CcMastercard;
            this.mastercardButton.IconColor = System.Drawing.Color.Black;
            this.mastercardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mastercardButton.IconSize = 80;
            this.mastercardButton.Location = new System.Drawing.Point(53, 42);
            this.mastercardButton.Name = "mastercardButton";
            this.mastercardButton.Size = new System.Drawing.Size(80, 54);
            this.mastercardButton.TabIndex = 2;
            this.mastercardButton.UseVisualStyleBackColor = true;
            // 
            // mastercardCheckBox
            // 
            this.mastercardCheckBox.AutoSize = true;
            this.mastercardCheckBox.Checked = true;
            this.mastercardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mastercardCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mastercardCheckBox.Location = new System.Drawing.Point(32, 42);
            this.mastercardCheckBox.Name = "mastercardCheckBox";
            this.mastercardCheckBox.Size = new System.Drawing.Size(15, 14);
            this.mastercardCheckBox.TabIndex = 1;
            this.mastercardCheckBox.UseVisualStyleBackColor = true;
            this.mastercardCheckBox.CheckedChanged += new System.EventHandler(this.mastercardCheckBox_CheckedChanged);
            // 
            // paymentMethodLabel
            // 
            this.paymentMethodLabel.AutoSize = true;
            this.paymentMethodLabel.BackColor = System.Drawing.Color.Transparent;
            this.paymentMethodLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentMethodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.paymentMethodLabel.Location = new System.Drawing.Point(15, 0);
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            this.paymentMethodLabel.Size = new System.Drawing.Size(182, 30);
            this.paymentMethodLabel.TabIndex = 0;
            this.paymentMethodLabel.Text = "Payment Method";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.paymentPanel);
            this.Controls.Add(this.totalLabel);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel paymentPanel;
        private Label paymentMethodLabel;
        private FontAwesome.Sharp.IconButton mastercardButton;
        private CheckBox mastercardCheckBox;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CheckBox visaCheckBox;
        private Label cardHolderNameLabel;
        private CustomControls.RichTextBox.RichTextBox cardholderName_richTextBox;
        private CustomControls.RichTextBox.RichTextBox month_richTextBox;
        private Label expirationDateLabel;
        private CustomControls.RichTextBox.RichTextBox year_richTextBox;
        private Custom_Toolbox.ButtonCustom buttonCustom1;
        private CustomControls.RichTextBox.RichTextBox cvv_richTextBox;
        private Label label1;
        private CustomControls.RichTextBox.RichTextBox cardNumber_richTextBox;
        private Label cardNumberLabel;
        public Label totalLabel;
    }
}