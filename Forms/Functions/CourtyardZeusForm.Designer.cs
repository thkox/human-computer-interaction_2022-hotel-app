namespace hotel_app.Forms.Functions
{
    partial class CourtyardZeusForm
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
            this.parkingPanel = new System.Windows.Forms.Panel();
            this.upButton = new FontAwesome.Sharp.IconButton();
            this.leftButton = new FontAwesome.Sharp.IconButton();
            this.rightButton = new FontAwesome.Sharp.IconButton();
            this.downButton = new FontAwesome.Sharp.IconButton();
            this.trojan1PictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CourtyardZeusLabel = new System.Windows.Forms.Label();
            this.LeftTransitionPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.parkingSlot5 = new System.Windows.Forms.PictureBox();
            this.parkingSlot4 = new System.Windows.Forms.PictureBox();
            this.parkingSlot3 = new System.Windows.Forms.PictureBox();
            this.parkingSlot2 = new System.Windows.Forms.PictureBox();
            this.parkingSlot1 = new System.Windows.Forms.PictureBox();
            this.parkingButton = new FontAwesome.Sharp.IconButton();
            this.parkingPictureBox = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.parkingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trojan1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTransitionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingPanel
            // 
            this.parkingPanel.Controls.Add(this.upButton);
            this.parkingPanel.Controls.Add(this.leftButton);
            this.parkingPanel.Controls.Add(this.rightButton);
            this.parkingPanel.Controls.Add(this.downButton);
            this.parkingPanel.Controls.Add(this.trojan1PictureBox);
            this.parkingPanel.Controls.Add(this.label1);
            this.parkingPanel.Controls.Add(this.CourtyardZeusLabel);
            this.parkingPanel.Controls.Add(this.LeftTransitionPictureBox);
            this.parkingPanel.Controls.Add(this.parkingSlot5);
            this.parkingPanel.Controls.Add(this.parkingSlot4);
            this.parkingPanel.Controls.Add(this.parkingSlot3);
            this.parkingPanel.Controls.Add(this.parkingSlot2);
            this.parkingPanel.Controls.Add(this.parkingSlot1);
            this.parkingPanel.Controls.Add(this.parkingButton);
            this.parkingPanel.Controls.Add(this.parkingPictureBox);
            this.parkingPanel.Location = new System.Drawing.Point(1, 0);
            this.parkingPanel.Name = "parkingPanel";
            this.parkingPanel.Size = new System.Drawing.Size(1083, 662);
            this.parkingPanel.TabIndex = 0;
            // 
            // upButton
            // 
            this.upButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upButton.BackColor = System.Drawing.Color.Silver;
            this.upButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.upButton.FlatAppearance.BorderSize = 0;
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upButton.IconChar = FontAwesome.Sharp.IconChar.CircleUp;
            this.upButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.upButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.upButton.Location = new System.Drawing.Point(107, 484);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(48, 48);
            this.upButton.TabIndex = 16;
            this.upButton.UseVisualStyleBackColor = false;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftButton.BackColor = System.Drawing.Color.Silver;
            this.leftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.leftButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.leftButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.leftButton.Location = new System.Drawing.Point(53, 538);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(48, 62);
            this.leftButton.TabIndex = 15;
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightButton.BackColor = System.Drawing.Color.Silver;
            this.rightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.rightButton.FlatAppearance.BorderSize = 0;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.rightButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.rightButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rightButton.Location = new System.Drawing.Point(161, 538);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(48, 62);
            this.rightButton.TabIndex = 14;
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downButton.BackColor = System.Drawing.Color.Silver;
            this.downButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.downButton.FlatAppearance.BorderSize = 0;
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.downButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.downButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.downButton.Location = new System.Drawing.Point(107, 601);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(48, 48);
            this.downButton.TabIndex = 10;
            this.downButton.UseVisualStyleBackColor = false;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // trojan1PictureBox
            // 
            this.trojan1PictureBox.BackColor = System.Drawing.Color.Silver;
            this.trojan1PictureBox.Image = global::hotel_app.Properties.Resources.trojan;
            this.trojan1PictureBox.Location = new System.Drawing.Point(414, 46);
            this.trojan1PictureBox.Name = "trojan1PictureBox";
            this.trojan1PictureBox.Size = new System.Drawing.Size(88, 89);
            this.trojan1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trojan1PictureBox.TabIndex = 0;
            this.trojan1PictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Olympos\r\nGardens";
            // 
            // CourtyardZeusLabel
            // 
            this.CourtyardZeusLabel.AutoSize = true;
            this.CourtyardZeusLabel.BackColor = System.Drawing.Color.Transparent;
            this.CourtyardZeusLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CourtyardZeusLabel.Location = new System.Drawing.Point(456, 0);
            this.CourtyardZeusLabel.Name = "CourtyardZeusLabel";
            this.CourtyardZeusLabel.Size = new System.Drawing.Size(171, 30);
            this.CourtyardZeusLabel.TabIndex = 8;
            this.CourtyardZeusLabel.Text = "Zeus Courtyard";
            // 
            // LeftTransitionPictureBox
            // 
            this.LeftTransitionPictureBox.BackColor = System.Drawing.Color.Silver;
            this.LeftTransitionPictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LeftTransitionPictureBox.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft;
            this.LeftTransitionPictureBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.LeftTransitionPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LeftTransitionPictureBox.IconSize = 87;
            this.LeftTransitionPictureBox.Location = new System.Drawing.Point(53, 263);
            this.LeftTransitionPictureBox.Name = "LeftTransitionPictureBox";
            this.LeftTransitionPictureBox.Size = new System.Drawing.Size(87, 89);
            this.LeftTransitionPictureBox.TabIndex = 7;
            this.LeftTransitionPictureBox.TabStop = false;
            // 
            // parkingSlot5
            // 
            this.parkingSlot5.BackColor = System.Drawing.Color.Silver;
            this.parkingSlot5.Location = new System.Drawing.Point(848, 573);
            this.parkingSlot5.Name = "parkingSlot5";
            this.parkingSlot5.Size = new System.Drawing.Size(159, 13);
            this.parkingSlot5.TabIndex = 6;
            this.parkingSlot5.TabStop = false;
            // 
            // parkingSlot4
            // 
            this.parkingSlot4.BackColor = System.Drawing.Color.Silver;
            this.parkingSlot4.Location = new System.Drawing.Point(848, 454);
            this.parkingSlot4.Name = "parkingSlot4";
            this.parkingSlot4.Size = new System.Drawing.Size(159, 13);
            this.parkingSlot4.TabIndex = 5;
            this.parkingSlot4.TabStop = false;
            // 
            // parkingSlot3
            // 
            this.parkingSlot3.BackColor = System.Drawing.Color.Silver;
            this.parkingSlot3.Location = new System.Drawing.Point(848, 327);
            this.parkingSlot3.Name = "parkingSlot3";
            this.parkingSlot3.Size = new System.Drawing.Size(159, 13);
            this.parkingSlot3.TabIndex = 4;
            this.parkingSlot3.TabStop = false;
            // 
            // parkingSlot2
            // 
            this.parkingSlot2.BackColor = System.Drawing.Color.Silver;
            this.parkingSlot2.Location = new System.Drawing.Point(848, 204);
            this.parkingSlot2.Name = "parkingSlot2";
            this.parkingSlot2.Size = new System.Drawing.Size(159, 13);
            this.parkingSlot2.TabIndex = 3;
            this.parkingSlot2.TabStop = false;
            // 
            // parkingSlot1
            // 
            this.parkingSlot1.BackColor = System.Drawing.Color.Silver;
            this.parkingSlot1.Location = new System.Drawing.Point(848, 79);
            this.parkingSlot1.Name = "parkingSlot1";
            this.parkingSlot1.Size = new System.Drawing.Size(159, 13);
            this.parkingSlot1.TabIndex = 2;
            this.parkingSlot1.TabStop = false;
            // 
            // parkingButton
            // 
            this.parkingButton.BackColor = System.Drawing.Color.Silver;
            this.parkingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkingButton.FlatAppearance.BorderSize = 0;
            this.parkingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingButton.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.parkingButton.IconColor = System.Drawing.Color.Black;
            this.parkingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.parkingButton.IconSize = 68;
            this.parkingButton.Location = new System.Drawing.Point(107, 538);
            this.parkingButton.Name = "parkingButton";
            this.parkingButton.Size = new System.Drawing.Size(48, 62);
            this.parkingButton.TabIndex = 1;
            this.parkingButton.UseVisualStyleBackColor = false;
            this.parkingButton.Click += new System.EventHandler(this.parkingButton_Click);
            // 
            // parkingPictureBox
            // 
            this.parkingPictureBox.Image = global::hotel_app.Properties.Resources.parking;
            this.parkingPictureBox.Location = new System.Drawing.Point(45, 30);
            this.parkingPictureBox.Name = "parkingPictureBox";
            this.parkingPictureBox.Size = new System.Drawing.Size(987, 619);
            this.parkingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.parkingPictureBox.TabIndex = 0;
            this.parkingPictureBox.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // CourtyardZeusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.parkingPanel);
            this.Name = "CourtyardZeusForm";
            this.Text = "CourtyardZeusForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.parkingPanel.ResumeLayout(false);
            this.parkingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trojan1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTransitionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel parkingPanel;
        private PictureBox parkingPictureBox;
        private System.Windows.Forms.Timer moveTimer;
        private FontAwesome.Sharp.IconButton parkingButton;
        private PictureBox trojan1PictureBox;
        private PictureBox parkingSlot1;
        private PictureBox parkingSlot5;
        private PictureBox parkingSlot4;
        private PictureBox parkingSlot3;
        private PictureBox parkingSlot2;
        private FontAwesome.Sharp.IconPictureBox LeftTransitionPictureBox;
        private Label CourtyardZeusLabel;
        private Label label1;
        private FontAwesome.Sharp.IconButton downButton;
        private FontAwesome.Sharp.IconButton upButton;
        private FontAwesome.Sharp.IconButton leftButton;
        private FontAwesome.Sharp.IconButton rightButton;
    }
}