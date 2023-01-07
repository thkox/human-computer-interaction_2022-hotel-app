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
            this.doorOpenButton = new System.Windows.Forms.Button();
            this.doorAlmostOpenButton = new System.Windows.Forms.Button();
            this.DoorClosed = new System.Windows.Forms.Button();
            this.stairsUpButton = new System.Windows.Forms.Button();
            this.stairsDownButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doorOpenButton
            // 
            this.doorOpenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorOpenButton.Image = global::hotel_app.Properties.Resources.DoorOpen;
            this.doorOpenButton.Location = new System.Drawing.Point(700, 164);
            this.doorOpenButton.Name = "doorOpenButton";
            this.doorOpenButton.Size = new System.Drawing.Size(140, 140);
            this.doorOpenButton.TabIndex = 0;
            this.doorOpenButton.UseVisualStyleBackColor = true;
            // 
            // doorAlmostOpenButton
            // 
            this.doorAlmostOpenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorAlmostOpenButton.Image = global::hotel_app.Properties.Resources.DoorAlmostOpen;
            this.doorAlmostOpenButton.Location = new System.Drawing.Point(453, 164);
            this.doorAlmostOpenButton.Name = "doorAlmostOpenButton";
            this.doorAlmostOpenButton.Size = new System.Drawing.Size(140, 140);
            this.doorAlmostOpenButton.TabIndex = 1;
            this.doorAlmostOpenButton.UseVisualStyleBackColor = true;
            // 
            // DoorClosed
            // 
            this.DoorClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoorClosed.Image = global::hotel_app.Properties.Resources.DoorClosed;
            this.DoorClosed.Location = new System.Drawing.Point(199, 164);
            this.DoorClosed.Name = "DoorClosed";
            this.DoorClosed.Size = new System.Drawing.Size(140, 140);
            this.DoorClosed.TabIndex = 2;
            this.DoorClosed.UseVisualStyleBackColor = true;
            // 
            // stairsUpButton
            // 
            this.stairsUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stairsUpButton.Image = global::hotel_app.Properties.Resources.StairsUp;
            this.stairsUpButton.Location = new System.Drawing.Point(322, 391);
            this.stairsUpButton.Name = "stairsUpButton";
            this.stairsUpButton.Size = new System.Drawing.Size(140, 140);
            this.stairsUpButton.TabIndex = 3;
            this.stairsUpButton.UseVisualStyleBackColor = true;
            // 
            // stairsDownButton
            // 
            this.stairsDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stairsDownButton.Image = global::hotel_app.Properties.Resources.StairsDown;
            this.stairsDownButton.Location = new System.Drawing.Point(579, 391);
            this.stairsDownButton.Name = "stairsDownButton";
            this.stairsDownButton.Size = new System.Drawing.Size(140, 140);
            this.stairsDownButton.TabIndex = 4;
            this.stairsDownButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // MainDoorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stairsDownButton);
            this.Controls.Add(this.stairsUpButton);
            this.Controls.Add(this.DoorClosed);
            this.Controls.Add(this.doorAlmostOpenButton);
            this.Controls.Add(this.doorOpenButton);
            this.Name = "MainDoorForm";
            this.Text = "MainDoorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button doorOpenButton;
        private Button doorAlmostOpenButton;
        private Button DoorClosed;
        private Button stairsUpButton;
        private Button stairsDownButton;
        private Label label1;
        private Label label2;
    }
}