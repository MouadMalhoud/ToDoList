﻿namespace ToDoList
{
    partial class TodoPage
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
            lbl_nomUtilisateur = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Location = new Point(57, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 525);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Location = new Point(408, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 525);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Location = new Point(761, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(274, 525);
            panel3.TabIndex = 1;
            // 
            // lbl_nomUtilisateur
            // 
            lbl_nomUtilisateur.AutoSize = true;
            lbl_nomUtilisateur.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nomUtilisateur.ForeColor = SystemColors.ActiveCaptionText;
            lbl_nomUtilisateur.Location = new Point(57, 30);
            lbl_nomUtilisateur.Name = "lbl_nomUtilisateur";
            lbl_nomUtilisateur.Size = new Size(117, 19);
            lbl_nomUtilisateur.TabIndex = 2;
            lbl_nomUtilisateur.Text = "Welcome, ";
            // 
            // TodoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1107, 652);
            Controls.Add(lbl_nomUtilisateur);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "TodoPage";
            Text = "TodoPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lbl_nomUtilisateur;
    }
}