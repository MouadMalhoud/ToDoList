namespace ToDoList
{
    partial class SignupPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPage));
            lbl_titleSignup = new Label();
            btn_backHome = new Button();
            button1 = new Button();
            chk_terms = new CheckBox();
            txt_confirmPassword = new TextBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            lbl_confirmPassword = new Label();
            lbl_password = new Label();
            lbl_Username = new Label();
            lbl_email = new Label();
            txt_email = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_titleSignup
            // 
            lbl_titleSignup.AccessibleName = "lbl_signupTitle";
            lbl_titleSignup.AutoSize = true;
            lbl_titleSignup.Font = new Font("Lucida Console", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titleSignup.Location = new Point(336, 25);
            lbl_titleSignup.Name = "lbl_titleSignup";
            lbl_titleSignup.Size = new Size(149, 29);
            lbl_titleSignup.TabIndex = 0;
            lbl_titleSignup.Text = "Sign Up ";
            // 
            // btn_backHome
            // 
            btn_backHome.BackColor = Color.Transparent;
            btn_backHome.BackgroundImage = (Image)resources.GetObject("btn_backHome.BackgroundImage");
            btn_backHome.BackgroundImageLayout = ImageLayout.Stretch;
            btn_backHome.Location = new Point(12, 12);
            btn_backHome.Name = "btn_backHome";
            btn_backHome.Size = new Size(77, 63);
            btn_backHome.TabIndex = 1;
            btn_backHome.UseVisualStyleBackColor = false;
            btn_backHome.Click += btn_backHome_Click;
            // 
            // button1
            // 
            button1.Location = new Point(242, 359);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Signup";
            button1.UseVisualStyleBackColor = true;
            // 
            // chk_terms
            // 
            chk_terms.AutoSize = true;
            chk_terms.Location = new Point(188, 322);
            chk_terms.Name = "chk_terms";
            chk_terms.Size = new Size(181, 19);
            chk_terms.TabIndex = 22;
            chk_terms.Text = "I accept the terms of services.";
            chk_terms.UseVisualStyleBackColor = true;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(188, 284);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.PasswordChar = '*';
            txt_confirmPassword.Size = new Size(193, 23);
            txt_confirmPassword.TabIndex = 21;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(188, 227);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(193, 23);
            txt_password.TabIndex = 20;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(188, 169);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(193, 23);
            txt_username.TabIndex = 19;
            // 
            // lbl_confirmPassword
            // 
            lbl_confirmPassword.AutoSize = true;
            lbl_confirmPassword.Location = new Point(188, 266);
            lbl_confirmPassword.Name = "lbl_confirmPassword";
            lbl_confirmPassword.Size = new Size(113, 15);
            lbl_confirmPassword.TabIndex = 18;
            lbl_confirmPassword.Text = "Confirm password : ";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(188, 209);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(66, 15);
            lbl_password.TabIndex = 17;
            lbl_password.Text = "Password : ";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(188, 151);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(69, 15);
            lbl_Username.TabIndex = 16;
            lbl_Username.Text = "Username : ";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(188, 97);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(81, 15);
            lbl_email.TabIndex = 15;
            lbl_email.Text = "Email adress : ";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(188, 115);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(193, 23);
            txt_email.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(481, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 244);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // SignupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(chk_terms);
            Controls.Add(txt_confirmPassword);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_confirmPassword);
            Controls.Add(lbl_password);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_email);
            Controls.Add(txt_email);
            Controls.Add(btn_backHome);
            Controls.Add(lbl_titleSignup);
            Name = "SignupPage";
            Text = "To do list manager - Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titleSignup;
        private Button btn_backHome;
        private Button button1;
        private CheckBox chk_terms;
        private TextBox txt_confirmPassword;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label lbl_confirmPassword;
        private Label lbl_password;
        private Label lbl_Username;
        private Label lbl_email;
        private TextBox txt_email;
        private PictureBox pictureBox1;
    }
}