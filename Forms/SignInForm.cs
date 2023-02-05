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
            if(username_richTextBox.Texts == "employeeuser" && password_richTextBox.Texts == "employeeuser")
            {
                username_richTextBox.Texts = "";
                password_richTextBox.Texts = "";
                errorLabel.Text = "";
                this.Hide();
                Form menuForm = new EmployeeForm();
                menuForm.ShowDialog();
                this.Show();

            }
            else if(username_richTextBox.Texts == "roomuser" && password_richTextBox.Texts == "roomuser")
            {
                username_richTextBox.Texts = "";
                password_richTextBox.Texts = "";
                errorLabel.Text = "";
                this.Hide();
                Form menuForm = new Client2Form();
                menuForm.ShowDialog();
                this.Show();
            }
            else if (username_richTextBox.Texts == "trojanuser" && password_richTextBox.Texts == "trojanuser")
            {
                //MessageBox.Show("You are a Client and you have closed room");
                username_richTextBox.Texts = "";
                password_richTextBox.Texts = "";
                errorLabel.Text = "";
                this.Hide();
                Form menuForm = new Client1Form();
                menuForm.ShowDialog();
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

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}