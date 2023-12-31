﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
            UpdateSignupButtonState();

        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (IsEmailValid(txt_email.Text) && ArePasswordsMatching(txt_password.Text, txt_confirmPassword.Text) && chk_terms.Checked)
            {
                string lastUserIdStr = Program.DatabaseConnection.GetLastUserId();
                int lastUserId;

                if (int.TryParse(lastUserIdStr, out lastUserId))
                {
                    int newUserId = lastUserId + 1;
                    string newUserIdStr = newUserId.ToString();


                    User newUser = new User(newUserIdStr, txt_username.Text, txt_email.Text, DateTime.Now, txt_password.Text);
                    Console.WriteLine(newUser.ToString());
                    Program.DatabaseConnection.CreateUser(newUser);

                    MessageBox.Show("Inscription Confirmed ! You can now login ! Have fun !");

                    LandingPage landingPage = new LandingPage();
                    landingPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error when converting the id.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the entries correctly.");
            }
        }


        private void btn_backHome_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Close();
        }
        private bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
        private bool ArePasswordsMatching(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
        private bool AreTermsAccepted()
        {
            return chk_terms.Checked;
        }
        private void UpdateSignupButtonState()
        {
            string email = txt_email.Text;
            string password = txt_password.Text;
            string confirmPassword = txt_confirmPassword.Text;

            bool isEmailValid = IsEmailValid(email);
            bool arePasswordsMatching = ArePasswordsMatching(password, confirmPassword);
            bool areTermsAccepted = AreTermsAccepted();

            if (arePasswordsMatching)
            {
                errorProviderConfirmPassword.SetError(txt_confirmPassword, "");
            }
            else
            {
                errorProviderConfirmPassword.SetError(txt_confirmPassword, "The 2 passwords aren't match.");
            }

            if (isEmailValid)
            {
                errorProviderEmail.SetError(txt_email, "");
            }
            else
            {
                errorProviderEmail.SetError(txt_email, "Invalid email adress.");
            }

            if (areTermsAccepted)
            {
                errorProviderTerms.SetError(chk_terms, "");
            }
            else
            {
                errorProviderTerms.SetError(chk_terms, "Please accept the ToS");
            }

            if (isEmailValid && arePasswordsMatching && areTermsAccepted)
            {
                btn_signup.Enabled = true;
            }
            else
            {
                btn_signup.Enabled = false;
            }
        }
        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            UpdateSignupButtonState();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            UpdateSignupButtonState();
        }

        private void txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateSignupButtonState();
        }

        private void chk_terms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSignupButtonState();
        }

    }
}
