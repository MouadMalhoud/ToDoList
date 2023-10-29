namespace ToDoList
{
    partial class TaskAdding
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
            lbl_name = new Label();
            label1 = new Label();
            lbl_status = new Label();
            lbl_description = new Label();
            lbl_dueDate = new Label();
            dateTimePicker = new DateTimePicker();
            txt_description = new TextBox();
            comboBox_status = new ComboBox();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(113, 52);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(45, 12);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 19);
            label1.TabIndex = 1;
            label1.Text = "Add a new task";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_status.Location = new Point(109, 122);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(77, 12);
            lbl_status.TabIndex = 2;
            lbl_status.Text = "Status : ";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_description.Location = new Point(93, 179);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(117, 12);
            lbl_description.TabIndex = 3;
            lbl_description.Text = "Description : ";
            // 
            // lbl_dueDate
            // 
            lbl_dueDate.AutoSize = true;
            lbl_dueDate.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dueDate.Location = new Point(93, 307);
            lbl_dueDate.Name = "lbl_dueDate";
            lbl_dueDate.Size = new Size(93, 12);
            lbl_dueDate.TabIndex = 4;
            lbl_dueDate.Text = "Date due : ";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(44, 322);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 5;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(44, 204);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(200, 100);
            txt_description.TabIndex = 6;
            // 
            // comboBox_status
            // 
            comboBox_status.Font = new Font("Lucida Console", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "To do", "In progress", "Done" });
            comboBox_status.Location = new Point(44, 137);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(200, 21);
            comboBox_status.TabIndex = 7;
            // 
            // TaskAdding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 484);
            Controls.Add(comboBox_status);
            Controls.Add(txt_description);
            Controls.Add(dateTimePicker);
            Controls.Add(lbl_dueDate);
            Controls.Add(lbl_description);
            Controls.Add(lbl_status);
            Controls.Add(label1);
            Controls.Add(lbl_name);
            Name = "TaskAdding";
            Text = "TaskAdding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label label1;
        private Label lbl_status;
        private Label lbl_description;
        private Label lbl_dueDate;
        private DateTimePicker dateTimePicker;
        private TextBox txt_description;
        private ComboBox comboBox_status;
    }
}