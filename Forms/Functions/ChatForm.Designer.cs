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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.charBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.downBar = new System.Windows.Forms.Panel();
            this.inputChatTextBox = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.sentMessagePictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.helpButton = new FontAwesome.Sharp.IconButton();
            this.charBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.downBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sentMessagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // charBarPanel
            // 
            this.charBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(82)))), ((int)(((byte)(133)))));
            this.charBarPanel.Controls.Add(this.helpButton);
            this.charBarPanel.Controls.Add(this.label1);
            this.charBarPanel.Controls.Add(this.iconPictureBox1);
            this.charBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.charBarPanel.Location = new System.Drawing.Point(0, 0);
            this.charBarPanel.Name = "charBarPanel";
            this.charBarPanel.Size = new System.Drawing.Size(400, 60);
            this.charBarPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat with an agent";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(82)))), ((int)(((byte)(133)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Commenting;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(263, 18);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
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
            this.inputChatTextBox.TextMultiline = false;
            this.inputChatTextBox.TextReadonly = false;
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
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(124)))), ((int)(((byte)(177)))));
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.helpButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.helpButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.helpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.helpButton.IconSize = 40;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpButton.Location = new System.Drawing.Point(344, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(53, 54);
            this.helpButton.TabIndex = 12;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.downBar);
            this.Controls.Add(this.charBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Support";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.charBarPanel.ResumeLayout(false);
            this.charBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.downBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sentMessagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel charBarPanel;
        private Panel downBar;
        private FontAwesome.Sharp.IconPictureBox sentMessagePictureBox;
        private Panel chatPanel;
        private Custom_Toolbox.ChatRichTextBox inputChatTextBox;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton helpButton;
    }
}