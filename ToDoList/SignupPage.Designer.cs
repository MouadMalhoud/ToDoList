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
            // SignupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_backHome);
            Controls.Add(lbl_titleSignup);
            Name = "SignupPage";
            Text = "To do list manager - Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titleSignup;
        private Button btn_backHome;
    }
}