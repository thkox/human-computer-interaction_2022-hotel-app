namespace hotel_app.Forms.Functions
{
    partial class RoomsForm
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
            this.roomsLoadFormsPanel = new System.Windows.Forms.Panel();
            this.room1Button = new FontAwesome.Sharp.IconButton();
            this.roomsLoadFormsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomsLoadFormsPanel
            // 
            this.roomsLoadFormsPanel.Controls.Add(this.room1Button);
            this.roomsLoadFormsPanel.Location = new System.Drawing.Point(0, 0);
            this.roomsLoadFormsPanel.Name = "roomsLoadFormsPanel";
            this.roomsLoadFormsPanel.Size = new System.Drawing.Size(1086, 662);
            this.roomsLoadFormsPanel.TabIndex = 10;
            // 
            // room1Button
            // 
            this.room1Button.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.room1Button.IconColor = System.Drawing.Color.Black;
            this.room1Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.room1Button.Location = new System.Drawing.Point(212, 177);
            this.room1Button.Name = "room1Button";
            this.room1Button.Size = new System.Drawing.Size(75, 78);
            this.room1Button.TabIndex = 0;
            this.room1Button.Text = "Room 1";
            this.room1Button.UseVisualStyleBackColor = true;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.roomsLoadFormsPanel);
            this.Name = "RoomsForm";
            this.Text = "RoomsForm";
            this.roomsLoadFormsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel roomsLoadFormsPanel;
        private FontAwesome.Sharp.IconButton room1Button;
    }
}