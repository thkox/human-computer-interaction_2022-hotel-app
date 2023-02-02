using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Custom_Toolbox
{
    public partial class QuantityCustomControl : UserControl
    {
        private RichTextBox richTextBox;
        private FontAwesome.Sharp.IconButton minusButton;
        private FontAwesome.Sharp.IconButton plusButton;
        public QuantityCustomControl()
        {
            // Initialize RichTextBox
            richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Text = "0";
            richTextBox.TextChanged += RichTextBox_TextChanged;
            this.Controls.Add(richTextBox);

            // Initialize Minus Button
            minusButton = new FontAwesome.Sharp.IconButton();
            minusButton.Dock = DockStyle.Left;
            minusButton.Click += MinusButton_Click;
            this.Controls.Add(minusButton);

            minusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            minusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            minusButton.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            minusButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            minusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minusButton.Location = new System.Drawing.Point(0, 0);
            minusButton.Name = "minusButton";
            minusButton.Size = new System.Drawing.Size(20, 20);
            minusButton.TabIndex = 3;
            minusButton.TabStop = false;


            // Initialize Plus Button
            plusButton = new FontAwesome.Sharp.IconButton();
            plusButton.Dock = DockStyle.Right;
            plusButton.Click += PlusButton_Click;
            this.Controls.Add(plusButton);

            minusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(144)))), ((int)(((byte)(191)))));
            minusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            minusButton.IconChar = FontAwesome.Sharp.IconChar.SquarePlus;
            minusButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            minusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minusButton.Location = new System.Drawing.Point(100, 0);
            minusButton.Name = "plusButton";
            minusButton.Size = new System.Drawing.Size(20, 20);
            minusButton.TabIndex = 3;
            minusButton.TabStop = false;
        }
        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Ensure the RichTextBox only displays numbers
            int value;
            if (!int.TryParse(richTextBox.Text, out value))
            {
                richTextBox.Text = "0";
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(richTextBox.Text);
            richTextBox.Text = (value - 1).ToString();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(richTextBox.Text);
            richTextBox.Text = (value + 1).ToString();
        }
    }
}
