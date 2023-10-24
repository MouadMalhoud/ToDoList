namespace ToDoList
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "lbl_title";
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 158);
            label1.Name = "label1";
            label1.Size = new Size(374, 32);
            label1.TabIndex = 0;
            label1.Text = "To do list Manager";
            // 
            // button1
            // 
            button1.AccessibleName = "btn_signup";
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(55, 240);
            button1.Name = "button1";
            button1.Size = new Size(156, 154);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleName = "btn_signup";
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(283, 240);
            button2.Name = "button2";
            button2.Size = new Size(149, 154);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AccessibleName = "lbl_Signup";
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 221);
            label2.Name = "label2";
            label2.Size = new Size(117, 16);
            label2.TabIndex = 3;
            label2.Text = "New here ?";
            // 
            // label3
            // 
            label3.AccessibleName = "lbl_login";
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(273, 221);
            label3.Name = "label3";
            label3.Size = new Size(172, 16);
            label3.TabIndex = 4;
            label3.Text = "Already a user?";
            // 
            // label4
            // 
            label4.AccessibleName = "lbl_btnSignup";
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(141, 381);
            label4.Name = "label4";
            label4.Size = new Size(70, 13);
            label4.TabIndex = 5;
            label4.Text = "Sign Up";
            // 
            // label5
            // 
            label5.AccessibleName = "lbl_btnLogin";
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(380, 381);
            label5.Name = "label5";
            label5.Size = new Size(52, 13);
            label5.TabIndex = 6;
            label5.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 452);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ToDoList Manager - Mouad Malhoud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}