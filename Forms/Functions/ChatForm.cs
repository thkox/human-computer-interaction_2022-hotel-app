using hotel_app.Custom_Toolbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            sentMessagePictureBox.Enabled = false;
            sentMessagePictureBox.IconColor = Color.FromArgb(96, 144, 191);

            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message1 = "Welcome to Zeus Hotel Palace!";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(250, 40);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(200, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            MainMenuMessage();
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

        private ChatRichTextBox SetResponseBubble(string message, Point bubbleLocation, Size bubbleSize, Point textBoxLocation, Size textBoxSize, Color color)
        {
            ChatRichTextBox rtb = new();
            rtb.Location = bubbleLocation;
            rtb.Size = bubbleSize;
            rtb.RichTextBoxLocation = textBoxLocation;
            rtb.RichTextBoxSize = textBoxSize;
            rtb.Text = message;
            rtb.BorderStyle = BorderStyle.None;
            rtb.Radius = 20;
            rtb.TabIndex = tabIndex;
            //rtb.BackColor = Color.Black;
            //rtb.ForeColor = Color.White;
            rtb.ShadeColor = color;
            tabIndex++;
            return rtb;
        }

        private void sentMessagePictureBox_Click(object sender, EventArgs e)
        {
            chatPanel.AutoScrollPosition = new Point(0, 0);
            Point bubbleLocation = new Point(150, height + 15);
            Size bubbleSize = new Size(200, 40);
            Point textBoxLocation = new Point(10, 10);
            Size textBoxSize = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(inputChatTextBox.Text, bubbleLocation, bubbleSize, textBoxLocation, textBoxSize, Color.FromArgb(197, 212, 230)));
            height += bubbleSize.Height + 20;
            TriggerResponse();
            inputChatTextBox.Text = ""; // Clear the input text box
        }

        private void TriggerResponse()
        {
            chatPanel.AutoScrollPosition = new Point(0, 0);
            if (inputChatTextBox.Text == "Order Food")
            {
                Point location2 = new Point(10, height);
                chatPanel.Controls.Add(SetEmployeeIcon(location2));

                string message = "What would you like to order?";
                Point bubbleLocation = new Point(70, height + 10);
                Size bubbleSize = new Size(160, 40);
                Point textBoxLoaction = new Point(10, 10);
                Size textBoxSize = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
                height += bubbleSize.Height + 3;
            }
            else
            {
                Point location2 = new Point(10, height);
                chatPanel.Controls.Add(SetEmployeeIcon(location2));

                string message = "I do not understand you.";
                Point bubbleLocation = new Point(70, height + 10);
                Size bubbleSize = new Size(180, 40);
                Point textBoxLoaction = new Point(10, 10);
                Size textBoxSize = new Size(160, 20);
                chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
                height += bubbleSize.Height + 3;
                MainMenuMessage();
            }
            chatPanel.AutoScrollPosition = new Point(0, 0);

        }

        private void MainMenuMessage()
        {
            chatPanel.AutoScrollPosition = new Point(0, 0);
            
            string message = "What you would like to do?";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(190, 40);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(170, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message2 = "1. Order Food";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(160, 40);
            Point textBoxLoaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(130, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLoaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "2. Pay Bill";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(160, 40);
            Point textBoxLoaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(130, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLoaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 10;
            
            chatPanel.AutoScrollPosition = new Point(0, height);
        }

        private void inputChatTextBox_MessageChanged(object sender, EventArgs e)
        {
            if (inputChatTextBox.Text == "")
            {
                sentMessagePictureBox.Enabled = false;
                sentMessagePictureBox.IconColor = Color.FromArgb(96, 144, 191);
            }
            else
            {
                sentMessagePictureBox.Enabled = true;
                sentMessagePictureBox.IconColor = Color.FromArgb(232, 238, 244);
            }
        }
    }
}
