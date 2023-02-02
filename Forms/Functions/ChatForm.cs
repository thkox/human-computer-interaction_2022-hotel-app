using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Forms.Functions
{
    public partial class ChatForm : Form
    {
        int height = 20; // Height of the chat
        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));
            Point location = new Point(70, height + 10);
            Size size = new Size(200, 40);
            chatPanel.Controls.Add(SetResponseBubble("Hello World", location, size));
            height = height + 50;
        }

        private PictureBox SetEmployeeIcon(Point location)
        {
            PictureBox ancientGod = new();
            ancientGod.ForeColor = Color.Crimson;
            ancientGod.Image = Properties.Resources.man;
            ancientGod.Location = location;
            ancientGod.Size = new Size(50, 50);
            ancientGod.BackColor = Color.FromArgb(0, 0, 0, 0);
            ancientGod.SizeMode = PictureBoxSizeMode.Zoom;
            ancientGod.TabStop = false;
            ancientGod.Name = "ancinetGod";
            ancientGod.TabIndex = 0;
            ancientGod.Parent = chatPanel;

            return ancientGod;
        }

        private RichTextBox SetResponseBubble(string message, Point location, Size size)
        {
            RichTextBox rtb = new RichTextBox();
            rtb.Location = location;
            rtb.Size = size;
            rtb.Text = message;
            rtb.BorderStyle = BorderStyle.None;
            rtb.BackColor = Color.FromArgb(255, 255, 250);
            rtb.SelectionAlignment = HorizontalAlignment.Left;
            rtb.Padding = new Padding(20, 20, 25, 20); //

            return rtb;
        }

        private void sentMessagePictureBox_Click(object sender, EventArgs e)
        {
            Point location = new Point(150, height + 10);
            Size size = new Size(200, 40);
            chatPanel.Controls.Add(SetResponseBubble("Morning", location, size));
            height = height + 50;
        }
    }
}
