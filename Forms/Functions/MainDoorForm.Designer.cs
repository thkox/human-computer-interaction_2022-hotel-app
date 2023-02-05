namespace hotel_app.Forms.Functions
{
    partial class MainDoorForm
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
            this.components = new System.ComponentModel.Container();
            this.doorOpenButton = new System.Windows.Forms.Button();
            this.doorAlmostOpenButton = new System.Windows.Forms.Button();
            this.doorClosed = new System.Windows.Forms.Button();
            this.stairsUpButton = new System.Windows.Forms.Button();
            this.stairsDownButton = new System.Windows.Forms.Button();
            this.doorState = new System.Windows.Forms.Label();
            this.stairsState = new System.Windows.Forms.Label();
            this.doorTimer = new System.Windows.Forms.Timer(this.components);
            this.doorStateLabel = new System.Windows.Forms.Label();
            this.stairsStateLabel = new System.Windows.Forms.Label();
            this.stairsTimer = new System.Windows.Forms.Timer(this.components);
            this.chatRichTextBox1 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.chatRichTextBox2 = new hotel_app.Custom_Toolbox.ChatRichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // doorOpenButton
            // 
            this.doorOpenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.doorOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doorOpenButton.Image = global::hotel_app.Properties.Resources.DoorOpen;
            this.doorOpenButton.Location = new System.Drawing.Point(684, 116);
            this.doorOpenButton.Name = "doorOpenButton";
            this.doorOpenButton.Size = new System.Drawing.Size(140, 140);
            this.doorOpenButton.TabIndex = 0;
            this.doorOpenButton.UseVisualStyleBackColor = false;
            this.doorOpenButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.doorOpenButton.Click += new System.EventHandler(this.doorOpenButton_Click);
            // 
            // doorAlmostOpenButton
            // 
            this.doorAlmostOpenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorAlmostOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.doorAlmostOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doorAlmostOpenButton.Image = global::hotel_app.Properties.Resources.DoorAlmostOpen;
            this.doorAlmostOpenButton.Location = new System.Drawing.Point(479, 116);
            this.doorAlmostOpenButton.Name = "doorAlmostOpenButton";
            this.doorAlmostOpenButton.Size = new System.Drawing.Size(140, 140);
            this.doorAlmostOpenButton.TabIndex = 1;
            this.doorAlmostOpenButton.UseVisualStyleBackColor = false;
            this.doorAlmostOpenButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.doorAlmostOpenButton.Click += new System.EventHandler(this.doorAlmostOpenButton_Click);
            // 
            // doorClosed
            // 
            this.doorClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorClosed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.doorClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doorClosed.Image = global::hotel_app.Properties.Resources.DoorClosed;
            this.doorClosed.Location = new System.Drawing.Point(282, 116);
            this.doorClosed.Name = "doorClosed";
            this.doorClosed.Size = new System.Drawing.Size(140, 140);
            this.doorClosed.TabIndex = 2;
            this.doorClosed.UseVisualStyleBackColor = false;
            this.doorClosed.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.doorClosed.Click += new System.EventHandler(this.doorClosed_Click);
            // 
            // stairsUpButton
            // 
            this.stairsUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stairsUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.stairsUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stairsUpButton.Image = global::hotel_app.Properties.Resources.StairsUp;
            this.stairsUpButton.Location = new System.Drawing.Point(373, 399);
            this.stairsUpButton.Name = "stairsUpButton";
            this.stairsUpButton.Size = new System.Drawing.Size(140, 140);
            this.stairsUpButton.TabIndex = 3;
            this.stairsUpButton.UseVisualStyleBackColor = false;
            this.stairsUpButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.stairsUpButton.Click += new System.EventHandler(this.stairsUpButton_Click);
            // 
            // stairsDownButton
            // 
            this.stairsDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stairsDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.stairsDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stairsDownButton.Image = global::hotel_app.Properties.Resources.StairsDown;
            this.stairsDownButton.Location = new System.Drawing.Point(566, 399);
            this.stairsDownButton.Name = "stairsDownButton";
            this.stairsDownButton.Size = new System.Drawing.Size(140, 140);
            this.stairsDownButton.TabIndex = 4;
            this.stairsDownButton.UseVisualStyleBackColor = false;
            this.stairsDownButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.stairsDownButton.Click += new System.EventHandler(this.stairsDownButton_Click);
            // 
            // doorState
            // 
            this.doorState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorState.AutoSize = true;
            this.doorState.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.doorState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.doorState.Location = new System.Drawing.Point(201, 57);
            this.doorState.Name = "doorState";
            this.doorState.Size = new System.Drawing.Size(154, 30);
            this.doorState.TabIndex = 5;
            this.doorState.Text = "Door Options:";
            // 
            // stairsState
            // 
            this.stairsState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stairsState.AutoSize = true;
            this.stairsState.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.stairsState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.stairsState.Location = new System.Drawing.Point(199, 347);
            this.stairsState.Name = "stairsState";
            this.stairsState.Size = new System.Drawing.Size(170, 30);
            this.stairsState.TabIndex = 6;
            this.stairsState.Text = "Stairs Options:";
            // 
            // doorTimer
            // 
            this.doorTimer.Interval = 2000;
            this.doorTimer.Tick += new System.EventHandler(this.doorTimer_Tick);
            // 
            // doorStateLabel
            // 
            this.doorStateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorStateLabel.AutoSize = true;
            this.doorStateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.doorStateLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.doorStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.doorStateLabel.Location = new System.Drawing.Point(84, 16);
            this.doorStateLabel.Name = "doorStateLabel";
            this.doorStateLabel.Size = new System.Drawing.Size(141, 23);
            this.doorStateLabel.TabIndex = 16;
            this.doorStateLabel.Text = "[Door Status]";
            this.doorStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stairsStateLabel
            // 
            this.stairsStateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stairsStateLabel.AutoSize = true;
            this.stairsStateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.stairsStateLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.stairsStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.stairsStateLabel.Location = new System.Drawing.Point(84, 21);
            this.stairsStateLabel.Name = "stairsStateLabel";
            this.stairsStateLabel.Size = new System.Drawing.Size(150, 23);
            this.stairsStateLabel.TabIndex = 17;
            this.stairsStateLabel.Text = "[Stairs Status]";
            this.stairsStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stairsStateLabel.Click += new System.EventHandler(this.stairsStateLabel_Click);
            // 
            // stairsTimer
            // 
            this.stairsTimer.Interval = 2000;
            this.stairsTimer.Tick += new System.EventHandler(this.stairsTimer_Tick);
            // 
            // chatRichTextBox1
            // 
            this.chatRichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chatRichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.chatRichTextBox1.ForeColor = System.Drawing.Color.White;
            this.chatRichTextBox1.Location = new System.Drawing.Point(22, 3);
            this.chatRichTextBox1.MaxLegthSize = 30;
            this.chatRichTextBox1.Name = "chatRichTextBox1";
            this.chatRichTextBox1.Radius = 20;
            this.chatRichTextBox1.RichTextBoxLocation = new System.Drawing.Point(20, 20);
            this.chatRichTextBox1.RichTextBoxSize = new System.Drawing.Size(1, 1);
            this.chatRichTextBox1.ShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.chatRichTextBox1.Size = new System.Drawing.Size(279, 52);
            this.chatRichTextBox1.TabIndex = 18;
            this.chatRichTextBox1.TextMultiline = true;
            this.chatRichTextBox1.TextReadonly = true;
            this.chatRichTextBox1.Load += new System.EventHandler(this.chatRichTextBox1_Load);
            // 
            // chatRichTextBox2
            // 
            this.chatRichTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chatRichTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.chatRichTextBox2.ForeColor = System.Drawing.Color.White;
            this.chatRichTextBox2.Location = new System.Drawing.Point(22, 3);
            this.chatRichTextBox2.MaxLegthSize = 30;
            this.chatRichTextBox2.Name = "chatRichTextBox2";
            this.chatRichTextBox2.Radius = 20;
            this.chatRichTextBox2.RichTextBoxLocation = new System.Drawing.Point(20, 20);
            this.chatRichTextBox2.RichTextBoxSize = new System.Drawing.Size(1, 1);
            this.chatRichTextBox2.ShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(159)))), ((int)(((byte)(202)))));
            this.chatRichTextBox2.Size = new System.Drawing.Size(279, 60);
            this.chatRichTextBox2.TabIndex = 19;
            this.chatRichTextBox2.TextMultiline = true;
            this.chatRichTextBox2.TextReadonly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.doorStateLabel);
            this.panel1.Controls.Add(this.chatRichTextBox1);
            this.panel1.Location = new System.Drawing.Point(393, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 58);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.stairsStateLabel);
            this.panel2.Controls.Add(this.chatRichTextBox2);
            this.panel2.Location = new System.Drawing.Point(382, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 73);
            this.panel2.TabIndex = 21;
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
            this.helpButton.TabIndex = 22;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // MainDoorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stairsState);
            this.Controls.Add(this.doorState);
            this.Controls.Add(this.stairsDownButton);
            this.Controls.Add(this.stairsUpButton);
            this.Controls.Add(this.doorClosed);
            this.Controls.Add(this.doorAlmostOpenButton);
            this.Controls.Add(this.doorOpenButton);
            this.Name = "MainDoorForm";
            this.Text = "MainDoorForm";
            this.Load += new System.EventHandler(this.MainDoorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button doorOpenButton;
        private Button doorAlmostOpenButton;
        private Button doorClosed;
        private Button stairsUpButton;
        private Button stairsDownButton;
        private Label doorState;
        private Label stairsState;
        private System.Windows.Forms.Timer doorTimer;
        private Label doorStateLabel;
        private Label stairsStateLabel;
        private System.Windows.Forms.Timer stairsTimer;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox1;
        private Custom_Toolbox.ChatRichTextBox chatRichTextBox2;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton helpButton;
    }
}