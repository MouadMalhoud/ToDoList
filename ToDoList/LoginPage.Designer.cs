namespace ToDoList
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            btn_backHome = new Button();
            lbl_titleLogin = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            lbl_password = new Label();
            lbl_Username = new Label();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_backHome
            // 
            btn_backHome.BackColor = Color.Transparent;
            btn_backHome.BackgroundImage = (Image)resources.GetObject("btn_backHome.BackgroundImage");
            btn_backHome.BackgroundImageLayout = ImageLayout.Stretch;
            btn_backHome.Location = new Point(12, 12);
            btn_backHome.Name = "btn_backHome";
            btn_backHome.Size = new Size(77, 63);
            btn_backHome.TabIndex = 2;
            btn_backHome.UseVisualStyleBackColor = false;
            btn_backHome.Click += btn_backHome_Click;
            // 
            // lbl_titleLogin
            // 
            lbl_titleLogin.AccessibleName = "lbl_signupTitle";
            lbl_titleLogin.AutoSize = true;
            lbl_titleLogin.Font = new Font("Lucida Console", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titleLogin.Location = new Point(336, 25);
            lbl_titleLogin.Name = "lbl_titleLogin";
            lbl_titleLogin.Size = new Size(132, 29);
            lbl_titleLogin.TabIndex = 3;
            lbl_titleLogin.Text = "Log in ";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(478, 224);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(193, 23);
            txt_password.TabIndex = 24;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(478, 166);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(193, 23);
            txt_username.TabIndex = 23;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.Location = new Point(478, 206);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(117, 16);
            lbl_password.TabIndex = 22;
            lbl_password.Text = "Password : ";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Username.Location = new Point(478, 148);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(117, 16);
            lbl_Username.TabIndex = 21;
            lbl_Username.Text = "Username : ";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(494, 273);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(152, 23);
            btn_login.TabIndex = 25;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(67, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 249);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_titleLogin);
            Controls.Add(btn_backHome);
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_backHome;
        private Label lbl_titleLogin;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label lbl_password;
        private Label lbl_Username;
        private Button btn_login;
        private PictureBox pictureBox1;
    }
}