namespace ToDoList
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }
        private void OnClick_btnSignup(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage();
            signupPage.Show();

            this.Hide(); 
                        
        }
        private void OnClick_btnLogin(object sender, EventArgs e)
        {
           LoginPage loginPage = new LoginPage();  
           loginPage.Show();

           this.Hide();

        }


    }

}   