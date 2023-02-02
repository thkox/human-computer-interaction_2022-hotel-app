namespace hotel_app.Custom_Toolbox
{
    partial class QuantityCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.minusButton = new FontAwesome.Sharp.IconButton();
            this.plusButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.DetectUrls = false;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.MaxLength = 2;
            this.richTextBox.Multiline = false;
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox.ShortcutsEnabled = false;
            this.richTextBox.Size = new System.Drawing.Size(118, 28);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "0";
            this.richTextBox.WordWrap = false;
            this.richTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusButton.BackColor = System.Drawing.Color.Transparent;
            this.minusButton.ForeColor = System.Drawing.Color.Black;
            this.minusButton.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            this.minusButton.IconColor = System.Drawing.Color.Black;
            this.minusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minusButton.IconSize = 20;
            this.minusButton.Location = new System.Drawing.Point(-1, -1);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(30, 30);
            this.minusButton.TabIndex = 1;
            this.minusButton.TabStop = false;
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusButton.BackColor = System.Drawing.Color.Transparent;
            this.plusButton.ForeColor = System.Drawing.Color.Black;
            this.plusButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.plusButton.IconColor = System.Drawing.Color.Black;
            this.plusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.plusButton.IconSize = 30;
            this.plusButton.Location = new System.Drawing.Point(89, -1);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(30, 30);
            this.plusButton.TabIndex = 3;
            this.plusButton.TabStop = false;
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // QuantityCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.richTextBox);
            this.Name = "QuantityCustomControl";
            this.Size = new System.Drawing.Size(118, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox;
        private FontAwesome.Sharp.IconButton minusButton;
        private FontAwesome.Sharp.IconButton plusButton;
    }
}
