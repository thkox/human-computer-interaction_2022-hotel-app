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
        private int stateOfConversation = 0;
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

            stateOfConversation++;
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
            if (stateOfConversation == 1 && (inputChatTextBox.Text == "1" || inputChatTextBox.Text == "I want to see the menu"))
            {
                OrderMenu();
            }
            else
            {
                ErrorChatMessage();
                MainMenuMessage();
            }
            chatPanel.AutoScrollPosition = new Point(0, height);
        }

        private void ErrorChatMessage()
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
        }

        private void MainMenuMessage()
        {
            string message = "How can I assist you today?";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(220, 40);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(200, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message2 = "1. I want to see the menu";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(200, 40);
            Point textBoxLoaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLoaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "2. I have already decided";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(200, 40);
            Point textBoxLoaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLoaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 10;
        }

        List<int> menusSelected = new List<int>();
        private void OrderMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Type the menu that you want to see:";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(250, 40);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(230, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            if(!menusSelected.Contains(1))
            {
                string message1 = "1. Coffee:";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
                menusSelected.Add(1);
            }

            if (!menusSelected.Contains(2))
            {
                string message1 = "2. Chocolates:";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
                menusSelected.Add(1);
            }

            if (!menusSelected.Contains(3))
            {
                string message1 = "3. Salads:";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
                menusSelected.Add(1);
            }
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
