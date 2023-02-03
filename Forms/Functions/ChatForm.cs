using hotel_app.Custom_Toolbox;
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
        int tabIndex = 0; // Tab index of the chat
        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message1 = "Welcome to Zeus Hotel Palace! What you would like to do?";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(250, 50);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(200, 36);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize));
            height += 50;
            
            string message2 = "1. Order Food";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(160, 40);
            Point textBoxLoaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(130, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLoaction2, textBoxSize2));
            height += 40;

            string message3 = "2. Pay Bill";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(160, 40);
            Point textBoxLoaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(130, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLoaction3, textBoxSize3));
            height += 50;

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
            tabIndex++;
            return ancientGod;
        }

        private ChatRichTextBox SetResponseBubble(string message, Point bubbleLocation, Size bubbleSize, Point textBoxLocation, Size textBoxSize)
        {
            ChatRichTextBox rtb = new();
            rtb.Location = bubbleLocation;
            rtb.Size = bubbleSize;
            rtb.RichTextBoxLocation = textBoxLocation;
            rtb.RichTextBoxSize = textBoxSize;
            rtb.Text = message;
            rtb.BorderStyle = BorderStyle.None;
            rtb.Radius = 20;
            rtb.BackColor = Color.Black;
            //rtb.ForeColor = Color.White;
            //rtb.ShadeColor = Color.White;
            tabIndex++;
            return rtb;
        }

        private void sentMessagePictureBox_Click(object sender, EventArgs e)
        {
            Point bubbleLocation = new Point(150, height + 15);
            Size bubbleSize = new Size(200, 40);
            Point textBoxLocation = new Point(10, 10);
            Size textBoxSize = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(inputChatTextBox.Text, bubbleLocation, bubbleSize, textBoxLocation, textBoxSize));
            height += 50;
            triggerResponse();
            inputChatTextBox.Text = ""; // Clear the input text box
        }

        private void triggerResponse()
        {
            if (inputChatTextBox.Text == "Order Food")
            {
                Point location2 = new Point(10, height);
                chatPanel.Controls.Add(SetEmployeeIcon(location2));

                string message = "What would you like to order?";
                Point bubbleLocation = new Point(70, height + 10);
                Size bubbleSize = new Size(160, 40);
                Point textBoxLoaction = new Point(10, 10);
                Size textBoxSize = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize));
                height += 50;
            }
            else
            {
                Point location2 = new Point(10, height);
                chatPanel.Controls.Add(SetEmployeeIcon(location2));

                string message = "I do not understand you. What do you want";
                Point bubbleLocation = new Point(70, height + 10);
                Size bubbleSize = new Size(160, 40);
                Point textBoxLoaction = new Point(10, 10);
                Size textBoxSize = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize));
                height += 50;
            }

        }
    }
}
