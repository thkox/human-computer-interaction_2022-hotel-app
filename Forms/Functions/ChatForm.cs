﻿using hotel_app.Custom_Toolbox;
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

        //total price of the order
        public int total = 0;

        //bubble texts
        private Point textPoint = new Point(10, 10);

        //bubbles sizes
        private Size categoriesAndFoodBubbleSize = new Size(120, 40);
        private Size mainMenuBubbleSize = new Size(200, 40);
        private Size souvlakiExampleBubbleSize = new Size(280, 60);
        private Size readyBubbleSize = new Size(260, 60);
        private Size askForPaymentBubbleSize = new Size(280, 40);
        
        public ChatForm()
        {
            InitializeComponent();
        }

        public delegate void CustomEventHandler(ChatForm sender, EventArgs e);
        public event CustomEventHandler OrderCompleted;

        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.inputChatTextBox.MessageChanged += new System.EventHandler(this.inputChatTextBox_MessageChanged);

            sentMessagePictureBox.Enabled = false;
            sentMessagePictureBox.IconColor = Color.FromArgb(96, 144, 191);

            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message1 = "Welcome to Zeus Hotel Palace!";
            Size bubbleSize = new Size(220, 40);
            chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), bubbleSize, textPoint, new Size(200, 20), Color.White));
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

            chatPanel.Controls.Add(SetResponseBubble(inputChatTextBox.Text, new Point(150, height + 15), mainMenuBubbleSize, textPoint, new Size(180, 20), Color.FromArgb(197, 212, 230)));
            height += mainMenuBubbleSize.Height + 10;
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
            else if (stateOfConversation == 12) // coffee menu order
            {
                if (inputChatTextBox.Text != "I am ready")
                    foodList.Add(inputChatTextBox.Text);
                else
                    AskForPayment();
            }
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
            Size bubbleSize = new Size(180, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), bubbleSize, textPoint, new Size(160, 20), Color.White));
            height += bubbleSize.Height + 3;
        }

        private void MainMenuMessage()
        {
            string message = "How can i help you today?";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), mainMenuBubbleSize, textPoint, new Size(180, 20), Color.White));
            height += mainMenuBubbleSize.Height + 3;

            string message2 = "1. I want to see the menu";
            chatPanel.Controls.Add(SetResponseBubble(message2, new Point(70, height + 10), mainMenuBubbleSize, textPoint, new Size(180, 20), Color.White));
            height += mainMenuBubbleSize.Height + 3;

            string message3 = "2. I have already decided";
            chatPanel.Controls.Add(SetResponseBubble(message3, new Point(70, height + 10), mainMenuBubbleSize, textPoint, new Size(180, 20), Color.White));
            height += mainMenuBubbleSize.Height + 10;
        }
        
        List<int> menusSelected = new List<int>();
        private void OrderMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Type the menu that you want to see:";
            Size bubbleSize = new Size(250, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), bubbleSize, textPoint, new Size(230, 20), Color.White));
            height += bubbleSize.Height + 3;
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            if (!menusSelected.Contains(1) && currentTime >= new TimeSpan(7, 0, 0) && currentTime <= new TimeSpan(11, 59, 59))
            {
                string message1 = "1. Coffee";
                chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
                height += categoriesAndFoodBubbleSize.Height + 3;
            }

            if (!menusSelected.Contains(2) && currentTime >= new TimeSpan(7, 0, 0) && currentTime <= new TimeSpan(18, 59, 59))
            {
                string message1 = "2. Chocolate";
                chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
                height += categoriesAndFoodBubbleSize.Height + 3;
            }

            if (!menusSelected.Contains(3) && currentTime >= new TimeSpan(12, 0, 0))
            {
                string message1 = "3. Salad";
                chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
                height += categoriesAndFoodBubbleSize.Height + 3;
            }

            if (!menusSelected.Contains(4) && currentTime >= new TimeSpan(12, 0, 0))
            {
                string message1 = "4. Pizza";
                chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
                height += categoriesAndFoodBubbleSize.Height + 3;
            }

            if (!menusSelected.Contains(5) && currentTime >= new TimeSpan(12, 0, 0))
            {
                string message1 = "5. Greek Cuisine";
                chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
                height += categoriesAndFoodBubbleSize.Height + 10;
            }
        }

        private void OrderWithoutMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), souvlakiExampleBubbleSize, textPoint, new Size(260, 40), Color.White));
            height += souvlakiExampleBubbleSize.Height + 3;

            string message5 = "When you have typed your order, please write “I am ready”.";
            chatPanel.Controls.Add(SetResponseBubble(message5, new Point(70, height + 10), readyBubbleSize, textPoint, new Size(240, 40), Color.White));
            height += readyBubbleSize.Height + 10;
        }



        private void CoffeeMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), souvlakiExampleBubbleSize, textPoint, new Size(260, 40), Color.White));
            height += souvlakiExampleBubbleSize.Height + 3;

            string message1 = "1. Americano";
            chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message2 = "2. Cappuccino";
            chatPanel.Controls.Add(SetResponseBubble(message2, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message3 = "3. Espresso";
            chatPanel.Controls.Add(SetResponseBubble(message3, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message4 = "4. Latte";
            chatPanel.Controls.Add(SetResponseBubble(message4, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message5 = "When you have typed your order, please write “I am ready”.";
            chatPanel.Controls.Add(SetResponseBubble(message5, new Point(70, height + 10), readyBubbleSize, textPoint, new Size(240, 40), Color.White));
            height += readyBubbleSize.Height + 10;
        }

        private void ChocolateMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), souvlakiExampleBubbleSize, textPoint, new Size(260, 40), Color.White));
            height += souvlakiExampleBubbleSize.Height + 3;

            string message1 = "1. Zeus Heart";
            chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message2 = "2. Chocolate";
            chatPanel.Controls.Add(SetResponseBubble(message2, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message3 = "3. Hospitality";
            chatPanel.Controls.Add(SetResponseBubble(message3, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message4 = "4. Ferrero";
            chatPanel.Controls.Add(SetResponseBubble(message4, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message5 = "5. Special";
            chatPanel.Controls.Add(SetResponseBubble(message5, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message6 = "When you have typed your order, please write “I am ready”.";
            chatPanel.Controls.Add(SetResponseBubble(message6, new Point(70, height + 10), readyBubbleSize, textPoint, new Size(240, 40), Color.White));
            height += readyBubbleSize.Height + 10;
        }

        private void SaladsMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), souvlakiExampleBubbleSize, textPoint, new Size(260, 40), Color.White));
            height += souvlakiExampleBubbleSize.Height + 3;

            string message1 = "1. Greek";
            chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message2 = "2. Aegean";
            chatPanel.Controls.Add(SetResponseBubble(message2, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message3 = "3. Tricolore";
            chatPanel.Controls.Add(SetResponseBubble(message3, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message4 = "4. Chef";
            chatPanel.Controls.Add(SetResponseBubble(message4, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message5 = "When you have typed your order, please write “I am ready”.";
            chatPanel.Controls.Add(SetResponseBubble(message5, new Point(70, height + 10), readyBubbleSize, textPoint, new Size(240, 40), Color.White));
            height += readyBubbleSize.Height + 10;
        }

        private void PizzaMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), souvlakiExampleBubbleSize, textPoint, new Size(260, 40), Color.White));
            height += souvlakiExampleBubbleSize.Height + 3;

            string message1 = "1. Zeus Special";
            chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message2 = "2. Athina";
            chatPanel.Controls.Add(SetResponseBubble(message2, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message3 = "3. Trojan";
            chatPanel.Controls.Add(SetResponseBubble(message3, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message4 = "4. Palace";
            chatPanel.Controls.Add(SetResponseBubble(message4, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message5 = "When you have typed your order, please write “I am ready”.";
            chatPanel.Controls.Add(SetResponseBubble(message5, new Point(70, height + 10), readyBubbleSize, textPoint, new Size(240, 40), Color.White));
            height += readyBubbleSize.Height + 10;
        }
        
        private void GreekCuisineMenu()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "Please type each the products that you want per message like 'Souvlaki x2'";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), souvlakiExampleBubbleSize, textPoint, new Size(260, 40), Color.White));
            height += souvlakiExampleBubbleSize.Height + 3;

            string message1 = "1. Souvlaki";
            chatPanel.Controls.Add(SetResponseBubble(message1, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message2 = "2. Tyromezes";
            chatPanel.Controls.Add(SetResponseBubble(message2, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message3 = "3. Pasta";
            chatPanel.Controls.Add(SetResponseBubble(message3, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message4 = "4. El Greco";
            chatPanel.Controls.Add(SetResponseBubble(message4, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message5 = "5. Chicken";
            chatPanel.Controls.Add(SetResponseBubble(message5, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message6 = "6. Ocean";
            chatPanel.Controls.Add(SetResponseBubble(message6, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message7 = "7. Fiesta";
            chatPanel.Controls.Add(SetResponseBubble(message7, new Point(70, height + 10), categoriesAndFoodBubbleSize, textPoint, new Size(100, 20), Color.White));
            height += categoriesAndFoodBubbleSize.Height + 3;

            string message8 = "When you have typed your order, please write “I am ready”.";
            chatPanel.Controls.Add(SetResponseBubble(message8, new Point(70, height + 10), readyBubbleSize, textPoint, new Size(240, 40), Color.White));
            height += readyBubbleSize.Height + 10;
        }
        
        private void QuestionUser()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2)); 

            string message = "Do you want to order something else?";
            Size bubbleSize = new Size(250, 40);
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), bubbleSize, textPoint, new Size(230, 20), Color.White));
            height += bubbleSize.Height + 10;
        }

        private void AskForPayment()
        {
            Point location2 = new Point(10, height);
            chatPanel.Controls.Add(SetEmployeeIcon(location2));

            string message = "This is your final order:";
            chatPanel.Controls.Add(SetResponseBubble(message, new Point(70, height + 10), mainMenuBubbleSize, textPoint, new Size(180, 20), Color.White));
            height += mainMenuBubbleSize.Height + 3;

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

            for (int i = 0; i < menu.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (menu[i] == names[j])
                    {
                        total += prices[i] * quantities[j];

                        Point bubbleLocation1 = new Point(70, height + 10);
                        Size bubbleSize1 = new Size(150, 40);
                        Point textBoxLocaction1 = textPoint;
                        Size textBoxSize1 = new Size(130, 20);
                        chatPanel.Controls.Add(SetResponseBubble(foodList[j], bubbleLocation1, bubbleSize1, textBoxLocaction1, textBoxSize1, Color.White));
                        height += bubbleSize1.Height + 3;
                    }
                }
            }

            string message2 = $"The total cost is: {total}€";
            chatPanel.Controls.Add(SetResponseBubble(message2, new Point(70, height + 10), askForPaymentBubbleSize, textPoint, new Size(260, 20), Color.White));
            height += askForPaymentBubbleSize.Height + 3;

            string message3 = "I am transfering you to the payment page";
            chatPanel.Controls.Add(SetResponseBubble(message3, new Point(70, height + 10), askForPaymentBubbleSize, textPoint, new Size(260, 20), Color.White));
            height += askForPaymentBubbleSize.Height + 3;

            string message4 = "You can now close the chat";
            chatPanel.Controls.Add(SetResponseBubble(message4, new Point(70, height + 10), askForPaymentBubbleSize, textPoint, new Size(260, 20), Color.White));
            height += askForPaymentBubbleSize.Height + 10;

            OrderCompleted?.Invoke(this, EventArgs.Empty);
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

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"..\Hotel-app-Documentation.chm", HelpNavigator.TopicId, "27");
        }
    }
}
