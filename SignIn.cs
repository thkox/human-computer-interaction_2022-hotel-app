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
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(username_richTextBox.Texts == "Employee" && password_richTextBox.Texts == "pass1234")
            {
                MessageBox.Show("You are an Employee");
            }
            else if(username_richTextBox.Texts == "Client" && password_richTextBox.Texts == "pass1234")
            {
                MessageBox.Show("You are a Client");
            }
        }
    }
}