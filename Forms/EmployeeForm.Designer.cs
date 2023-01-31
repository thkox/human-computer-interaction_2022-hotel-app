using System.Resources;

namespace hotel_app.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.olymposGardensButton = new FontAwesome.Sharp.IconButton();
            this.courtyardZeusButton = new FontAwesome.Sharp.IconButton();
            this.zeusPalaceButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlelabel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.childFormLabel = new System.Windows.Forms.Label();
            this.currentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlelabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).BeginInit();
            this.childFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(68)))), ((int)(((byte)(110)))));
            this.menuPanel.Controls.Add(this.olymposGardensButton);
            this.menuPanel.Controls.Add(this.courtyardZeusButton);
            this.menuPanel.Controls.Add(this.zeusPalaceButton);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 861);
            this.menuPanel.TabIndex = 0;
            // 
            // olymposGardensButton
            // 
            this.olymposGardensButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.olymposGardensButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.olymposGardensButton.FlatAppearance.BorderSize = 0;
            this.olymposGardensButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.olymposGardensButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.olymposGardensButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.olymposGardensButton.IconChar = FontAwesome.Sharp.IconChar.Tree;
            this.olymposGardensButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.olymposGardensButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.olymposGardensButton.IconSize = 50;
            this.olymposGardensButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.olymposGardensButton.Location = new System.Drawing.Point(0, 340);
            this.olymposGardensButton.Name = "olymposGardensButton";
            this.olymposGardensButton.Size = new System.Drawing.Size(300, 70);
            this.olymposGardensButton.TabIndex = 9;
            this.olymposGardensButton.Text = "Olympos Gardens";
            this.olymposGardensButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.olymposGardensButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.olymposGardensButton.UseVisualStyleBackColor = true;
            this.olymposGardensButton.Click += new System.EventHandler(this.olymposGardensButton_Click);
            // 
            // courtyardZeusButton
            // 
            this.courtyardZeusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courtyardZeusButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.courtyardZeusButton.FlatAppearance.BorderSize = 0;
            this.courtyardZeusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courtyardZeusButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courtyardZeusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.courtyardZeusButton.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.courtyardZeusButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.courtyardZeusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.courtyardZeusButton.IconSize = 50;
            this.courtyardZeusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courtyardZeusButton.Location = new System.Drawing.Point(0, 270);
            this.courtyardZeusButton.Name = "courtyardZeusButton";
            this.courtyardZeusButton.Size = new System.Drawing.Size(300, 70);
            this.courtyardZeusButton.TabIndex = 8;
            this.courtyardZeusButton.Text = "Courtyard Zeus";
            this.courtyardZeusButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courtyardZeusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.courtyardZeusButton.UseVisualStyleBackColor = true;
            this.courtyardZeusButton.Click += new System.EventHandler(this.courtyardZeusButton_Click);
            // 
            // zeusPalaceButton
            // 
            this.zeusPalaceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zeusPalaceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.zeusPalaceButton.FlatAppearance.BorderSize = 0;
            this.zeusPalaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeusPalaceButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeusPalaceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.zeusPalaceButton.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.zeusPalaceButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.zeusPalaceButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.zeusPalaceButton.IconSize = 50;
            this.zeusPalaceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zeusPalaceButton.Location = new System.Drawing.Point(0, 200);
            this.zeusPalaceButton.Name = "zeusPalaceButton";
            this.zeusPalaceButton.Size = new System.Drawing.Size(300, 70);
            this.zeusPalaceButton.TabIndex = 7;
            this.zeusPalaceButton.Text = "Zeus Palace";
            this.zeusPalaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zeusPalaceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.zeusPalaceButton.UseVisualStyleBackColor = true;
            this.zeusPalaceButton.Click += new System.EventHandler(this.zeusPalaceButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::hotel_app.Properties.Resources.logoMenuFinal;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(82)))), ((int)(((byte)(133)))));
            this.titlelabel.Controls.Add(this.pictureBox3);
            this.titlelabel.Controls.Add(this.label4);
            this.titlelabel.Controls.Add(this.childFormLabel);
            this.titlelabel.Controls.Add(this.currentChildFormIcon);
            this.titlelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlelabel.Location = new System.Drawing.Point(300, 0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(1384, 100);
            this.titlelabel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::hotel_app.Properties.Resources.man;
            this.pictureBox3.Location = new System.Drawing.Point(1226, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(1116, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 42);
            this.label4.TabIndex = 20;
            this.label4.Text = "Marios\r\nEmployee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // childFormLabel
            // 
            this.childFormLabel.AutoSize = true;
            this.childFormLabel.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.childFormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.childFormLabel.Location = new System.Drawing.Point(55, 50);
            this.childFormLabel.Name = "childFormLabel";
            this.childFormLabel.Size = new System.Drawing.Size(64, 21);
            this.childFormLabel.TabIndex = 1;
            this.childFormLabel.Text = "Home";
            // 
            // currentChildFormIcon
            // 
            this.currentChildFormIcon.BackColor = System.Drawing.Color.Transparent;
            this.currentChildFormIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.currentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentChildFormIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.currentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildFormIcon.Location = new System.Drawing.Point(17, 39);
            this.currentChildFormIcon.Name = "currentChildFormIcon";
            this.currentChildFormIcon.Size = new System.Drawing.Size(32, 32);
            this.currentChildFormIcon.TabIndex = 0;
            this.currentChildFormIcon.TabStop = false;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.childFormPanel.Controls.Add(this.label3);
            this.childFormPanel.Controls.Add(this.label2);
            this.childFormPanel.Controls.Add(this.label1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(300, 100);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(1384, 761);
            this.childFormPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(825, 203);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Edwardian Script ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(805, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 57);
            this.label2.TabIndex = 7;
            this.label2.Text = "Staff Services";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(663, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 86);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zeus Palace\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(139)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1684, 861);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeForm_FormClosed);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlelabel.ResumeLayout(false);
            this.titlelabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentChildFormIcon)).EndInit();
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton olymposGardensButton;
        private FontAwesome.Sharp.IconButton courtyardZeusButton;
        private FontAwesome.Sharp.IconButton zeusPalaceButton;
        private Panel titlelabel;
        private FontAwesome.Sharp.IconPictureBox currentChildFormIcon;
        private Label childFormLabel;
        private Panel childFormPanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label4;
    }
}