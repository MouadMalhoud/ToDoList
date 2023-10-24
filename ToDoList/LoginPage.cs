using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB;

namespace ToDoList
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_backHome_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            User user = Program.DatabaseConnection.GetUserByUsername(username);

            if (user != null && user.Password == password)
            {
                TodoPage todoPage = new TodoPage(user);
                todoPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password !");
            }
        }
    }
}
