namespace hotel_app.Forms.Functions
{
    partial class ZeusPalaceMenuForm
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
            this.zeusPalaceLoadFormsPanel = new System.Windows.Forms.Panel();
            this.roomButton = new FontAwesome.Sharp.IconButton();
            this.publicPoolButton = new FontAwesome.Sharp.IconButton();
            this.backPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.zeusPalaceLoadFormsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // zeusPalaceLoadFormsPanel
            // 
            this.zeusPalaceLoadFormsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.zeusPalaceLoadFormsPanel.Controls.Add(this.roomButton);
            this.zeusPalaceLoadFormsPanel.Controls.Add(this.publicPoolButton);
            this.zeusPalaceLoadFormsPanel.Location = new System.Drawing.Point(4, -6);
            this.zeusPalaceLoadFormsPanel.Name = "zeusPalaceLoadFormsPanel";
            this.zeusPalaceLoadFormsPanel.Size = new System.Drawing.Size(1079, 672);
            this.zeusPalaceLoadFormsPanel.TabIndex = 0;
            // 
            // roomButton
            // 
            this.roomButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.roomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.roomButton.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.roomButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.roomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomButton.Location = new System.Drawing.Point(585, 248);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(150, 131);
            this.roomButton.TabIndex = 2;
            this.roomButton.Text = "Room";
            this.roomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roomButton.UseVisualStyleBackColor = false;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // publicPoolButton
            // 
            this.publicPoolButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publicPoolButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.publicPoolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publicPoolButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publicPoolButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.publicPoolButton.IconChar = FontAwesome.Sharp.IconChar.WaterLadder;
            this.publicPoolButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.publicPoolButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.publicPoolButton.Location = new System.Drawing.Point(331, 248);
            this.publicPoolButton.Name = "publicPoolButton";
            this.publicPoolButton.Size = new System.Drawing.Size(150, 131);
            this.publicPoolButton.TabIndex = 1;
            this.publicPoolButton.Text = "Public\r\nPool";
            this.publicPoolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.publicPoolButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.publicPoolButton.UseVisualStyleBackColor = false;
            this.publicPoolButton.Click += new System.EventHandler(this.publicPoolButton_Click);
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.backPictureBox.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.backPictureBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.backPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backPictureBox.IconSize = 42;
            this.backPictureBox.Location = new System.Drawing.Point(9, 12);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(42, 42);
            this.backPictureBox.TabIndex = 4;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // ZeusPalaceMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.zeusPalaceLoadFormsPanel);
            this.Name = "ZeusPalaceMenuForm";
            this.Text = "GPSMenuForm";
            this.Load += new System.EventHandler(this.ZeusPalaceMenuForm_Load);
            this.zeusPalaceLoadFormsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel zeusPalaceLoadFormsPanel;
        private FontAwesome.Sharp.IconPictureBox backPictureBox;
        private FontAwesome.Sharp.IconButton publicPoolButton;
        private FontAwesome.Sharp.IconButton roomButton;
    }
}