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
            this.inputChatTextBox = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.sentMessagePictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.charBarPanel.SuspendLayout();
            this.downBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentMessagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // charBarPanel
            // 
            this.charBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(82)))), ((int)(((byte)(133)))));
            this.charBarPanel.Controls.Add(this.iconButton1);
            this.charBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.charBarPanel.Location = new System.Drawing.Point(0, 0);
            this.charBarPanel.Name = "charBarPanel";
            this.charBarPanel.Size = new System.Drawing.Size(400, 60);
            this.charBarPanel.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(82)))), ((int)(((byte)(133)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Headset;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(63, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(260, 41);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Chat with an Employee";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // downBar
            // 
            this.downBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(177)))));
            this.downBar.Controls.Add(this.inputChatTextBox);
            this.downBar.Controls.Add(this.sentMessagePictureBox);
            this.downBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downBar.Location = new System.Drawing.Point(0, 550);
            this.downBar.Name = "downBar";
            this.downBar.Size = new System.Drawing.Size(400, 50);
            this.downBar.TabIndex = 1;
            // 
            // inputChatTextBox
            // 
            this.inputChatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(177)))));
            this.inputChatTextBox.ForeColor = System.Drawing.Color.White;
            this.inputChatTextBox.Location = new System.Drawing.Point(12, 4);
            this.inputChatTextBox.MaxLegthSize = 30;
            this.inputChatTextBox.Name = "inputChatTextBox";
            this.inputChatTextBox.Radius = 20;
            this.inputChatTextBox.RichTextBoxLocation = new System.Drawing.Point(20, 6);
            this.inputChatTextBox.RichTextBoxSize = new System.Drawing.Size(200, 30);
            this.inputChatTextBox.ShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.inputChatTextBox.Size = new System.Drawing.Size(300, 40);
            this.inputChatTextBox.TabIndex = 0;
            this.inputChatTextBox.TextReadonly = false;
            this.inputChatTextBox.MessageChanged += new System.EventHandler(this.inputChatTextBox_MessageChanged);
            // 
            // sentMessagePictureBox
            // 
            this.sentMessagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(177)))));
            this.sentMessagePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sentMessagePictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.sentMessagePictureBox.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.sentMessagePictureBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.sentMessagePictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sentMessagePictureBox.IconSize = 31;
            this.sentMessagePictureBox.Location = new System.Drawing.Point(335, 8);
            this.sentMessagePictureBox.Name = "sentMessagePictureBox";
            this.sentMessagePictureBox.Size = new System.Drawing.Size(32, 31);
            this.sentMessagePictureBox.TabIndex = 1;
            this.sentMessagePictureBox.TabStop = false;
            this.sentMessagePictureBox.Click += new System.EventHandler(this.sentMessagePictureBox_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(205)))));
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(0, 60);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(400, 490);
            this.chatPanel.TabIndex = 2;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
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
        private Custom_Toolbox.ChatRichTextBox inputChatTextBox;
    }
}