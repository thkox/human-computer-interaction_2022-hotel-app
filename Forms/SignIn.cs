using hotel_app.Forms;

namespace hotel_app
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(username_richTextBox.Texts == "Employee" && password_richTextBox.Texts == "pass1234")
            {
                //MessageBox.Show("You are an Employee");
                this.Hide();
            }
            else if(username_richTextBox.Texts == "ClientTrojan" && password_richTextBox.Texts == "pass1234")
            {
                //MessageBox.Show("You are a Client and you have closed a Trojan room");
                this.Hide();
            }
            else if (username_richTextBox.Texts == "ClientRoom" && password_richTextBox.Texts == "pass1234")
            {
                //MessageBox.Show("You are a Client and you have closed room");
                this.Hide();
                Form menuForm = new Client2Form();
                menuForm.ShowDialog();
            }
            else
            {
                errorLabel.Text = "Your credentials are incorrect, please try again.";
            }
        }
    }
}