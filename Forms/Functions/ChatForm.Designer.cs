namespace hotel_app.Forms.Functions
{
    partial class ChatForm
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
            this.charBarPanel = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sentMessagePictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.inputRichTextBox = new CustomControls.RichTextBox.RichTextBox();
            this.chatHistoryPanel = new System.Windows.Forms.Panel();
            this.charBarPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentMessagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // charBarPanel
            // 
            this.charBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.charBarPanel.Controls.Add(this.iconButton1);
            this.charBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.charBarPanel.Location = new System.Drawing.Point(0, 0);
            this.charBarPanel.Name = "charBarPanel";
            this.charBarPanel.Size = new System.Drawing.Size(384, 66);
            this.charBarPanel.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Headset;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(161, 41);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Chat with an Agent";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sentMessagePictureBox);
            this.panel2.Controls.Add(this.inputRichTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 41);
            this.panel2.TabIndex = 1;
            // 
            // sentMessagePictureBox
            // 
            this.sentMessagePictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.sentMessagePictureBox.ForeColor = System.Drawing.Color.Chocolate;
            this.sentMessagePictureBox.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.sentMessagePictureBox.IconColor = System.Drawing.Color.Chocolate;
            this.sentMessagePictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sentMessagePictureBox.IconSize = 31;
            this.sentMessagePictureBox.Location = new System.Drawing.Point(327, 6);
            this.sentMessagePictureBox.Name = "sentMessagePictureBox";
            this.sentMessagePictureBox.Size = new System.Drawing.Size(32, 31);
            this.sentMessagePictureBox.TabIndex = 1;
            this.sentMessagePictureBox.TabStop = false;
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputRichTextBox.BorderColor = System.Drawing.Color.MidnightBlue;
            this.inputRichTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.inputRichTextBox.BorderSize = 2;
            this.inputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputRichTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.inputRichTextBox.Location = new System.Drawing.Point(4, 6);
            this.inputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputRichTextBox.Multiline = false;
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.inputRichTextBox.PasswordChar = false;
            this.inputRichTextBox.Size = new System.Drawing.Size(305, 31);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Texts = "";
            this.inputRichTextBox.UnderlinedStyle = false;
            // 
            // chatHistoryPanel
            // 
            this.chatHistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatHistoryPanel.Location = new System.Drawing.Point(0, 66);
            this.chatHistoryPanel.Name = "chatHistoryPanel";
            this.chatHistoryPanel.Size = new System.Drawing.Size(384, 454);
            this.chatHistoryPanel.TabIndex = 2;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.chatHistoryPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.charBarPanel);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.charBarPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sentMessagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel charBarPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private CustomControls.RichTextBox.RichTextBox inputRichTextBox;
        private FontAwesome.Sharp.IconPictureBox sentMessagePictureBox;
        private Panel chatHistoryPanel;
    }
}