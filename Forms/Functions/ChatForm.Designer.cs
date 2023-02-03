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
            this.downBar = new System.Windows.Forms.Panel();
            this.sentMessagePictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.chatRichTextBox1 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.charBarPanel.SuspendLayout();
            this.downBar.SuspendLayout();
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
            // downBar
            // 
            this.downBar.BackColor = System.Drawing.Color.OliveDrab;
            this.downBar.Controls.Add(this.chatRichTextBox1);
            this.downBar.Controls.Add(this.sentMessagePictureBox);
            this.downBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBar.Location = new System.Drawing.Point(0, 507);
            this.downBar.Name = "downBar";
            this.downBar.Size = new System.Drawing.Size(384, 54);
            this.downBar.TabIndex = 1;
            // 
            // sentMessagePictureBox
            // 
            this.sentMessagePictureBox.BackColor = System.Drawing.Color.OliveDrab;
            this.sentMessagePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sentMessagePictureBox.ForeColor = System.Drawing.Color.Crimson;
            this.sentMessagePictureBox.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.sentMessagePictureBox.IconColor = System.Drawing.Color.Crimson;
            this.sentMessagePictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sentMessagePictureBox.IconSize = 31;
            this.sentMessagePictureBox.Location = new System.Drawing.Point(330, 11);
            this.sentMessagePictureBox.Name = "sentMessagePictureBox";
            this.sentMessagePictureBox.Size = new System.Drawing.Size(32, 31);
            this.sentMessagePictureBox.TabIndex = 1;
            this.sentMessagePictureBox.TabStop = false;
            this.sentMessagePictureBox.Click += new System.EventHandler(this.sentMessagePictureBox_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(0, 66);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(384, 441);
            this.chatPanel.TabIndex = 2;
            // 
            // chatRichTextBox1
            // 
            this.chatRichTextBox1.BackColor = System.Drawing.Color.White;
            this.chatRichTextBox1.Location = new System.Drawing.Point(12, 6);
            this.chatRichTextBox1.Name = "chatRichTextBox1";
            this.chatRichTextBox1.Radius = 20;
            this.chatRichTextBox1.RichTextBoxLocation = new System.Drawing.Point(20, 3);
            this.chatRichTextBox1.RichTextBoxSize = new System.Drawing.Size(200, 30);
            this.chatRichTextBox1.ShadeColor = System.Drawing.Color.Silver;
            this.chatRichTextBox1.Size = new System.Drawing.Size(300, 40);
            this.chatRichTextBox1.TabIndex = 0;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.downBar);
            this.Controls.Add(this.charBarPanel);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.charBarPanel.ResumeLayout(false);
            this.downBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sentMessagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel charBarPanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel downBar;
        private FontAwesome.Sharp.IconPictureBox sentMessagePictureBox;
        private Panel chatPanel;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox1;
    }
}