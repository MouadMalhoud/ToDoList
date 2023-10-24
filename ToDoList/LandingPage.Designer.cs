namespace ToDoList
{
    partial class LandingPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            lbl_title = new Label();
            btn_signup = new Button();
            btn_login = new Button();
            lbl_signup = new Label();
            lbl_login = new Label();
            lbl_btnSignup = new Label();
            lbl_btnLogin = new Label();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AccessibleName = "lbl_title";
            lbl_title.AutoSize = true;
            lbl_title.BackColor = Color.Transparent;
            lbl_title.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(85, 158);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(374, 32);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "To do list Manager";
            // 
            // btn_signup
            // 
            btn_signup.AccessibleName = "btn_signup";
            btn_signup.BackgroundImage = (Image)resources.GetObject("btn_signup.BackgroundImage");
            btn_signup.BackgroundImageLayout = ImageLayout.Stretch;
            btn_signup.Location = new Point(55, 240);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(156, 154);
            btn_signup.TabIndex = 1;
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += new System.EventHandler(this.OnClick_btnSignup);
            // 
            // btn_login
            // 
            btn_login.AccessibleName = "btn_login";
            btn_login.BackgroundImage = (Image)resources.GetObject("btn_login.BackgroundImage");
            btn_login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_login.Location = new Point(283, 240);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(149, 154);
            btn_login.TabIndex = 2;
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += new System.EventHandler(this.OnClick_btnLogin);

            // 
            // lbl_signup
            // 
            lbl_signup.AccessibleName = "lbl_Signup";
            lbl_signup.AutoSize = true;
            lbl_signup.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_signup.Location = new Point(73, 221);
            lbl_signup.Name = "lbl_signup";
            lbl_signup.Size = new Size(117, 16);
            lbl_signup.TabIndex = 3;
            lbl_signup.Text = "New here ?";
            // 
            // lbl_login
            // 
            lbl_login.AccessibleName = "lbl_login";
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_login.Location = new Point(273, 221);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(172, 16);
            lbl_login.TabIndex = 4;
            lbl_login.Text = "Already a user?";
            // 
            // lbl_btnSignup
            // 
            lbl_btnSignup.AccessibleName = "lbl_btnSignup";
            lbl_btnSignup.AutoSize = true;
            lbl_btnSignup.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_btnSignup.Location = new Point(141, 381);
            lbl_btnSignup.Name = "lbl_btnSignup";
            lbl_btnSignup.Size = new Size(70, 13);
            lbl_btnSignup.TabIndex = 5;
            lbl_btnSignup.Text = "Sign Up";
            // 
            // lbl_btnLogin
            // 
            lbl_btnLogin.AccessibleName = "lbl_btnLogin";
            lbl_btnLogin.AutoSize = true;
            lbl_btnLogin.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_btnLogin.Location = new Point(380, 381);
            lbl_btnLogin.Name = "lbl_btnLogin";
            lbl_btnLogin.Size = new Size(52, 13);
            lbl_btnLogin.TabIndex = 6;
            lbl_btnLogin.Text = "Login";
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 452);
            Controls.Add(lbl_btnLogin);
            Controls.Add(lbl_btnSignup);
            Controls.Add(lbl_login);
            Controls.Add(lbl_signup);
            Controls.Add(btn_login);
            Controls.Add(btn_signup);
            Controls.Add(lbl_title);
            Name = "LandingPage";
            Text = "ToDoList Manager - Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Button btn_signup;
        private Button btn_login;
        private Label lbl_signup;
        private Label lbl_login;
        private Label lbl_btnSignup;
        private Label lbl_btnLogin;
    }
}