namespace ToDoList
{
    partial class Todo
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lbl_nameUser = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(68, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 504);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Location = new Point(423, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 504);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LimeGreen;
            panel3.Location = new Point(783, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 504);
            panel3.TabIndex = 1;
            // 
            // lbl_nameUser
            // 
            lbl_nameUser.AutoSize = true;
            lbl_nameUser.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nameUser.Location = new Point(21, 30);
            lbl_nameUser.Name = "lbl_nameUser";
            lbl_nameUser.Size = new Size(136, 21);
            lbl_nameUser.TabIndex = 2;
            lbl_nameUser.Text = "Welcome, ";
            // 
            // Todo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 626);
            Controls.Add(lbl_nameUser);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Todo";
            Text = "Todo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lbl_nameUser;
    }
}