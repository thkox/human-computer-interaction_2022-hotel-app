using hotel_app.Forms;

namespace hotel_app
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(username_richTextBox.Texts == "3" && password_richTextBox.Texts == "3")
            {
                this.Hide();
                Form menuForm = new EmployeeForm();
                menuForm.ShowDialog();
                menuForm = null;
                this.Show();

            }
            else if(username_richTextBox.Texts == "2" && password_richTextBox.Texts == "2")
            {
                this.Hide();
                Form menuForm = new Client2Form();
                menuForm.ShowDialog();
                menuForm = null;
                this.Show();
            }
            else if (username_richTextBox.Texts == "1" && password_richTextBox.Texts == "1")
            {
                //MessageBox.Show("You are a Client and you have closed room");
                this.Hide();
                Form menuForm = new Client1Form();
                menuForm.ShowDialog();
                menuForm = null;
                this.Show();
            }
            else
            {
                errorLabel.Text = "Your credentials are incorrect, please try again.";
            }
        }

        //create an event handler for the exit button
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}