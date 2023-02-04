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
            this.inputChatTextBox.MessageChanged += new System.EventHandler(this.inputChatTextBox_MessageChanged);

            sentMessagePictureBox.Enabled = false;
            sentMessagePictureBox.IconColor = Color.FromArgb(96, 144, 191);

            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message1 = "Welcome to Zeus Hotel Palace!";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(220, 40);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(200, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
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
            height += bubbleSize.Height + 10;
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
                stateOfConversation = 113; //the user order salad
            }
            else if (stateOfConversation == 11 && (inputChatTextBox.Text == "4" || inputChatTextBox.Text == "Pizza"))
            {
                PizzaMenu();
                menusSelected.Add(4);
                stateOfConversation = 114; //the user order pizza
            }
            else if (stateOfConversation == 11 && (inputChatTextBox.Text == "5" || inputChatTextBox.Text == "Greek Cuisine"))
            {
                GreekCuisineMenu();
                menusSelected.Add(5);
                stateOfConversation = 115; //the user order greek cuisine
            }
            else if (stateOfConversation == 11)
            {
                OrderMenu();
            }
            else if (stateOfConversation == 111)
            {
                CoffeeMenu();
            }
            else if (stateOfConversation == 112)
            {
                ChocolateMenu();
            }
            else if (stateOfConversation == 113)
            {
                SaladsMenu();
            }
            else if (stateOfConversation == 114)
            {
                PizzaMenu();
            }
            else if (stateOfConversation == 115)
            {
                GreekCuisineMenu();
            }
            else if (stateOfConversation == 12) // coffee menu order
            {
                if (inputChatTextBox.Text != "I am ready")
                    foodList.Add(inputChatTextBox.Text);
                else
                    AskForPayment();
            }
            GreekCuisineMenu
            else if (stateOfConversation == 111 || stateOfConversation == 113 || stateOfConversation == 114 || stateOfConversation == 115) // coffee menu order
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
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(160, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;
        }

        private void MainMenuMessage()
        {
            string message = "How can i help you today?";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(200, 40);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message2 = "1. I want to see the menu";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(200, 40);
            Point textBoxLocaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLocaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "2. I have already decided";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(200, 40);
            Point textBoxLocaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLocaction3, textBoxSize3, Color.White));
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
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(230, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            if(!menusSelected.Contains(1))
            {
                string message1 = "1. Coffee";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLocaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
                height += bubbleSize1.Height + 3;
            }

            if (!menusSelected.Contains(2))
            {
                string message1 = "2. Chocolate";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLocaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
                height += bubbleSize1.Height + 3;
            }

            if (!menusSelected.Contains(3))
            {
                string message1 = "3. Salad";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLocaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
                height += bubbleSize1.Height + 3;
            }

            if (!menusSelected.Contains(4))
            {
                string message1 = "4. Pizza";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLocaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
                height += bubbleSize1.Height + 3;
            }

            if (!menusSelected.Contains(5))
            {
                string message1 = "5. Greek Cuisine";
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(120, 40);
                Point textBoxLocaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(100, 20);
                chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
                height += bubbleSize1.Height + 10;
            }
        }

        private void OrderWithoutMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message5 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(260, 60);
            Point textBoxLocaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLocaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 10;
        }



        private void CoffeeMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Americano";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLocaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Cappuccino";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLocaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLocaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Espresso";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLocaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLocaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. Latte";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLocaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLocaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(260, 60);
            Point textBoxLocaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLocaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 10;
        }

        private void ChocolateMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Zeus Heart";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLocaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Chocolate";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLocaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLocaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Hospitality";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLocaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLocaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. Ferrero";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLocaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLocaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "5. Special";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(120, 40);
            Point textBoxLocaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLocaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 3;

            string message6 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation6 = new Point(70, height + 10);
            Size bubbleSize6 = new Size(260, 60);
            Point textBoxLocaction6 = new Point(10, 10);
            Size textBoxSize6 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message6, bubbleLocation6, bubbleSize6, textBoxLocaction6, textBoxSize6, Color.White));
            height += bubbleSize6.Height + 10;
        }

        private void SaladsMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Greek";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLocaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Aegean";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLocaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLocaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Tricolore";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLocaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLocaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. Chef";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLocaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLocaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(260, 60);
            Point textBoxLocaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLocaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 10;
        }

        private void PizzaMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Zeus Special";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLocaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Athina";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLocaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLocaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Trojan";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLocaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLocaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. Palace";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLocaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLocaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(260, 60);
            Point textBoxLocaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLocaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 10;
        }
        
        private void GreekCuisineMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(280, 60);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(260, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            string message1 = "1. Souvlaki";
            Point bubbleLocation1 = new Point(70, height + 10);
            Size bubbleSize1 = new Size(120, 40);
            Point textBoxLocaction1 = new Point(10, 10);
            Size textBoxSize1 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message1, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
            height += bubbleSize1.Height + 3;

            string message2 = "2. Tyromezes";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(120, 40);
            Point textBoxLocaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLocaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 3;

            string message3 = "3. Pasta";
            Point bubbleLocation3 = new Point(70, height + 10);
            Size bubbleSize3 = new Size(120, 40);
            Point textBoxLocaction3 = new Point(10, 10);
            Size textBoxSize3 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message3, bubbleLocation3, bubbleSize3, textBoxLocaction3, textBoxSize3, Color.White));
            height += bubbleSize3.Height + 3;

            string message4 = "4. El Greco";
            Point bubbleLocation4 = new Point(70, height + 10);
            Size bubbleSize4 = new Size(120, 40);
            Point textBoxLocaction4 = new Point(10, 10);
            Size textBoxSize4 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message4, bubbleLocation4, bubbleSize4, textBoxLocaction4, textBoxSize4, Color.White));
            height += bubbleSize4.Height + 3;

            string message5 = "5. Chicken";
            Point bubbleLocation5 = new Point(70, height + 10);
            Size bubbleSize5 = new Size(120, 40);
            Point textBoxLocaction5 = new Point(10, 10);
            Size textBoxSize5 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message5, bubbleLocation5, bubbleSize5, textBoxLocaction5, textBoxSize5, Color.White));
            height += bubbleSize5.Height + 3;

            string message6 = "6. Ocean";
            Point bubbleLocation6 = new Point(70, height + 10);
            Size bubbleSize6 = new Size(120, 40);
            Point textBoxLocaction6 = new Point(10, 10);
            Size textBoxSize6 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message6, bubbleLocation6, bubbleSize6, textBoxLocaction6, textBoxSize6, Color.White));
            height += bubbleSize6.Height + 3;

            string message7 = "7. Fiesta";
            Point bubbleLocation7 = new Point(70, height + 10);
            Size bubbleSize7 = new Size(120, 40);
            Point textBoxLocaction7 = new Point(10, 10);
            Size textBoxSize7 = new Size(100, 20);
            chatPanel.Controls.Add(SetResponseBubble(message7, bubbleLocation7, bubbleSize7, textBoxLocaction7, textBoxSize7, Color.White));
            height += bubbleSize7.Height + 3;

            string message8 = "When you have typed your ordered, please write “I am ready”.";
            Point bubbleLocation8 = new Point(70, height + 10);
            Size bubbleSize8 = new Size(260, 60);
            Point textBoxLocaction8 = new Point(10, 10);
            Size textBoxSize8 = new Size(240, 40);
            chatPanel.Controls.Add(SetResponseBubble(message8, bubbleLocation8, bubbleSize8, textBoxLocaction8, textBoxSize8, Color.White));
            height += bubbleSize8.Height + 10;
        }
        
        private void QuestionUser()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2)); 

            string message = "Do you want to order something else?";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(250, 40);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(230, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 10;
        }

        private void AskForPayment()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "This is your final order:";
            Point bubbleLocation = new Point(70, height + 10);
            Size bubbleSize = new Size(200, 40);
            Point textBoxLocaction = new Point(10, 10);
            Size textBoxSize = new Size(180, 20);
            chatPanel.Controls.Add(SetResponseBubble(message, bubbleLocation, bubbleSize, textBoxLocaction, textBoxSize, Color.White));
            height += bubbleSize.Height + 3;

            foreach (string productWithValue in foodList)
            {
                Point bubbleLocation1 = new Point(70, height + 10);
                Size bubbleSize1 = new Size(150, 40);
                Point textBoxLocaction1 = new Point(10, 10);
                Size textBoxSize1 = new Size(130, 20);
                chatPanel.Controls.Add(SetResponseBubble(productWithValue, bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
                height += bubbleSize1.Height + 3;
            }

            string message2 = "I am transfering you to the payment page";
            Point bubbleLocation2 = new Point(70, height + 10);
            Size bubbleSize2 = new Size(280, 40);
            Point textBoxLocaction2 = new Point(10, 10);
            Size textBoxSize2 = new Size(260, 20);
            chatPanel.Controls.Add(SetResponseBubble(message2, bubbleLocation2, bubbleSize2, textBoxLocaction2, textBoxSize2, Color.White));
            height += bubbleSize2.Height + 10;

            List<int> prices = new List<int> { 8, 10, 9, 12, //coffee prices
            20, 10, 15, 13, 18, //chocolates prices
            10, 15, 10, 8, //salads prices
            30, 15, 10, 40, //pizza prices
            5, 4, 8, 20, 7, 30, 24}; //greek cuisine prices

            List<string> menu = new List<string> {"Americano", "Cappuccino", "Espresso", "Latte",  //coffee
            "Zeus Heart", "Chocolate", "Hospitality", "Ferrero", "Special", //chocolates
            "Greek", "Aegean", "Tricolore", "Chef", //salads
            "Zeus Special", "Athina", "Trojan", "Palace", //pizza
            "Souvlaki", "Tyromezes", "Pasta", "El Greco", "Chicken", "Ocean", "Fiesta"}; //greek cuisine
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

            int total = 0;

            for (int i = 0; i < menu.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (menu[i] == names[j])
                    {
                        total += prices[i] * quantities[j];
                    }
                }
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
