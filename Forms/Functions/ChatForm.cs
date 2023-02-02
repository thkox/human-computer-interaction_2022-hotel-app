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
        int height = 0; // Height of the chat
        public ChatForm()
        {


            InitializeComponent();



        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            PictureBox ancientGod = new();
            ancientGod.ForeColor = System.Drawing.Color.Crimson;
            ancientGod.Image = Properties.Resources.man;
            ancientGod.Location = new Point(0, 0);
            ancientGod.Size = new Size(50, 50);
            ancientGod.BackColor = Color.FromArgb(0, 0, 0, 0);
            ancientGod.SizeMode = PictureBoxSizeMode.Zoom;
            ancientGod.TabStop = false;
            ancientGod.Name = "ancinetGod";



            chatPanel.Controls.Add(ancientGod);
            ancientGod.TabIndex = 0;
            ancientGod.Location = new Point(0, 0);
            ancientGod.BringToFront();
            ancientGod.Show();
            ancientGod.Visible = true;
            ancientGod.Parent = chatPanel;
        }
    }
}
