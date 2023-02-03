using hotel_app.Custom_Toolbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            Size bubbleSize = new Size(220, 40);
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
            Size textBoxSize = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(inputChatTextBox.Text, bubbleLocation, bubbleSize, textBoxLocation, textBoxSize, Color.FromArgb(197, 212, 230)));
            height += bubbleSize.Height + 20;
            TriggerResponse();
            inputChatTextBox.Text = ""; // Clear the input text box
        }

        List<string> foodList = new List<string>();
        
        private void TriggerResponse()
        {
            chatPanel.AutoScrollPosition = new Point(0, 0);
            if (stateOfConversation == 1 && (inputChatTextBox.Text == "1" || inputChatTextBox.Text == "I want to see the menu"))
            {
                OrderMenu();
                stateOfConversation = 11;
            }
            else if (stateOfConversation == 1 && (inputChatTextBox.Text == "2" || inputChatTextBox.Text == "I have already decided"))
            {
                OrderWithoutMenu();
                stateOfConversation = 12;
            }
            else if (stateOfConversation == 11 && (inputChatTextBox.Text == "1" || inputChatTextBox.Text == "Coffee"))
            {
                CoffeeMenu();
                menusSelected.Add(1);
                stateOfConversation = 111; //the user order coffee
            }
            else if (stateOfConversation == 11 && (inputChatTextBox.Text == "2" || inputChatTextBox.Text == "Chocolate"))
            {
                ChocolateMenu();
                menusSelected.Add(2);
                stateOfConversation = 112; //the user order chocolate
            }
            else if (stateOfConversation == 11 && (inputChatTextBox.Text == "3" || inputChatTextBox.Text == "Salad"))
            {
                SaladsMenu();
                menusSelected.Add(3);
                stateOfConversation = 113; //the user order chocolate
            }
            else if (stateOfConversation == 11)
            {
                OrderMenu();
            }
            else if (stateOfConversation == 12) // coffee menu order
            {
                if (inputChatTextBox.Text != "I am ready")
                    foodList.Add(inputChatTextBox.Text);
                else
                    AskForPayment();
            }
            else if (stateOfConversation == 111) // coffee menu order
            {
                if (inputChatTextBox.Text != "I am ready")
                    foodList.Add(inputChatTextBox.Text);
                else
                {
                    if (menusSelected.Count != 3)
                    {
                        QuestionUser();
                        stateOfConversation = 3;
                    }
                    else
                        AskForPayment();
                }
            }
            else if (stateOfConversation == 112) // coffee menu order
            {
                if (inputChatTextBox.Text != "I am ready")
                    foodList.Add(inputChatTextBox.Text);
                else
                {
                    if (menusSelected.Count != 3)
                    {
                        QuestionUser();
                        stateOfConversation = 3;
                    }
                    else
                        AskForPayment();
                }
            }
            else if (stateOfConversation == 113) // coffee menu order
            {
                if (inputChatTextBox.Text != "I am ready")
                    foodList.Add(inputChatTextBox.Text);
                else
                {
                    if (menusSelected.Count != 3)
                    {
                        QuestionUser();
                        stateOfConversation = 3;
                    }
                    else
                        AskForPayment();

                }
            }
            else if (stateOfConversation == 3 && inputChatTextBox.Text == "Yes") // coffee menu order
            {
                OrderMenu();
                stateOfConversation = 11;
            }
            else if ((stateOfConversation == 3 && inputChatTextBox.Text == "No") || stateOfConversation == 5) // coffee menu order
            {
                AskForPayment();
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
            string message = "How can i help you today?";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(200, 40);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(180, 20);
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
                string message1 = "1. Coffee";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
            }

            if (!menusSelected.Contains(2))
            {
                string message1 = "2. Chocolate";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
            }

            if (!menusSelected.Contains(3))
            {
                string message1 = "3. Salad";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 10;
            }
        }

        private void OrderWithoutMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message5 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(260, 60);
            Point textBoxLoaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLoaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 10;
        }


        private void CoffeeMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Americano";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLoaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Cappuccino";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLoaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLoaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Espresso";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLoaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLoaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. Latte";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLoaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLoaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(260, 60);
            Point textBoxLoaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLoaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 10;
        }

        private void ChocolateMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Zeus Heart";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLoaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Chocolate";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLoaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLoaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Hospitality";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLoaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLoaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. Ferrero";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLoaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLoaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "5. Special";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(120, 40);
            Point textBoxLoaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLoaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 3;

            string message6 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation6 = new Point(70, height + 10);
            Size bubbleSize6 = new Size(260, 60);
            Point textBoxLoaction6 = new Point(10, 10);
            Size textBoxSize6 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message6, bubbleLocation6, bubbleSize6, textBoxLoaction6, textBoxSize6, Color.White));
            height += bubbleSize6.Height + 10;
        }

        private void SaladsMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Greek";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLoaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Aegean";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLoaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLoaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Tricolore";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLoaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLoaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. Chef";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLoaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLoaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(260, 60);
            Point textBoxLoaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLoaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 10;
        }

        private void QuestionUser()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2)); 

            string message = "Do you want to order something else?";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(250, 40);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(230, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 10;
        }

        private void AskForPayment()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "This is your final order:";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(200, 40);
            Point textBoxLoaction = new Point(10, 10);
            Size textBoxSize = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLoaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            foreach (string productWithValue in foodList)
            {
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(150, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(productWithValue, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
            }

            foreach (string productWithValue in foodList)
            {
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(150, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(productWithValue, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
            }

            foreach (string productWithValue in foodList)
            {
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(150, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(productWithValue, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
            }

            foreach (string productWithValue in foodList)
            {
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(150, 40);
                Point textBoxLoaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(productWithValue, bubbleLocation1, bubbleSize1, textBoxLoaction1, textBoxSize1, Color.White));
                height += bubbleSize.Height + 3;
            }

            string message2 = "I am transfering you to the payment page";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(280, 40);
            Point textBoxLoaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(260, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLoaction2, textBoxSize2, Color.White));
            height += bubbleSize.Height + 10;

            List<string[]> splitList = new List<string[]>();
            for (int i = 0; i < foodList.Count; i++)
            {
                splitList.Add(foodList[i].Split('x'));
            }
            List<string> names = new List<string>();
            List<int> quantities = new List<int>();
            foreach (string[] split in splitList)
            {
                int length = split[0].Length-1;
                string name = split[0].Substring(0, length);
                names.Add(name);
                quantities.Add(int.Parse(split[1]));
            }

            //this where we are going to trandfer the user to another page
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
