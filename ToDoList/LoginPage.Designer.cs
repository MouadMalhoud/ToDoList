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
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_titleLogin);
            Controls.Add(btn_backHome);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_backHome;
        private Label lbl_titleLogin;
    }
}