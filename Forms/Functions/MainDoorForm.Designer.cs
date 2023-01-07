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
            this.doorStateLabel = new System.Windows.Forms.Label();
            this.stairsState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doorOpenButton
            // 
            this.doorOpenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.doorOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doorOpenButton.Image = global::hotel_app.Properties.Resources.DoorOpen;
            this.doorOpenButton.Location = new System.Drawing.Point(682, 172);
            this.doorOpenButton.Name = "doorOpenButton";
            this.doorOpenButton.Size = new System.Drawing.Size(140, 140);
            this.doorOpenButton.TabIndex = 0;
            this.doorOpenButton.UseVisualStyleBackColor = false;
            // 
            // doorAlmostOpenButton
            // 
            this.doorAlmostOpenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doorAlmostOpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.doorAlmostOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doorAlmostOpenButton.Image = global::hotel_app.Properties.Resources.DoorAlmostOpen;
            this.doorAlmostOpenButton.Location = new System.Drawing.Point(477, 172);
            this.doorAlmostOpenButton.Name = "doorAlmostOpenButton";
            this.doorAlmostOpenButton.Size = new System.Drawing.Size(140, 140);
            this.doorAlmostOpenButton.TabIndex = 1;
            this.doorAlmostOpenButton.UseVisualStyleBackColor = false;
            // 
            // DoorClosed
            // 
            this.DoorClosed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoorClosed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(184)))));
            this.DoorClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoorClosed.Image = global::hotel_app.Properties.Resources.DoorClosed;
            this.DoorClosed.Location = new System.Drawing.Point(280, 172);
            this.DoorClosed.Name = "DoorClosed";
            this.DoorClosed.Size = new System.Drawing.Size(140, 140);
            this.DoorClosed.TabIndex = 2;
            this.DoorClosed.UseVisualStyleBackColor = false;
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
            // 
            // doorStateLabel
            // 
            this.doorStateLabel.AutoSize = true;
            this.doorStateLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.doorStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.doorStateLabel.Location = new System.Drawing.Point(199, 113);
            this.doorStateLabel.Name = "doorStateLabel";
            this.doorStateLabel.Size = new System.Drawing.Size(154, 30);
            this.doorStateLabel.TabIndex = 5;
            this.doorStateLabel.Text = "Door Options:";
            // 
            // stairsState
            // 
            this.stairsState.AutoSize = true;
            this.stairsState.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.stairsState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.stairsState.Location = new System.Drawing.Point(199, 347);
            this.stairsState.Name = "stairsState";
            this.stairsState.Size = new System.Drawing.Size(170, 30);
            this.stairsState.TabIndex = 6;
            this.stairsState.Text = "Stairs Options:";
            // 
            // MainDoorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.stairsState);
            this.Controls.Add(this.doorStateLabel);
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
        private Label doorStateLabel;
        private Label stairsState;
    }
}