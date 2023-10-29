namespace ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoPage));
            lbl_nomUtilisateur = new Label();
            btn_logout = new Button();
            flow_toDo = new FlowLayoutPanel();
            flow_inProgress = new FlowLayoutPanel();
            flow_done = new FlowLayoutPanel();
            btn_addTask = new Button();
            pictureBox1 = new PictureBox();
            lbl_done = new Label();
            lbl_inProgress = new Label();
            label1 = new Label();
            lbl_todo = new Label();
            flow_inProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_nomUtilisateur
            // 
            lbl_nomUtilisateur.AutoSize = true;
            lbl_nomUtilisateur.Font = new Font("Lucida Console", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nomUtilisateur.ForeColor = SystemColors.ActiveCaptionText;
            lbl_nomUtilisateur.Location = new Point(26, 12);
            lbl_nomUtilisateur.Name = "lbl_nomUtilisateur";
            lbl_nomUtilisateur.Size = new Size(117, 19);
            lbl_nomUtilisateur.TabIndex = 2;
            lbl_nomUtilisateur.Text = "Welcome, ";
            // 
            // btn_logout
            // 
            btn_logout.BackgroundImage = (Image)resources.GetObject("btn_logout.BackgroundImage");
            btn_logout.BackgroundImageLayout = ImageLayout.Stretch;
            btn_logout.Location = new Point(1009, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(86, 82);
            btn_logout.TabIndex = 3;
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // flow_toDo
            // 
            flow_toDo.BackColor = Color.SteelBlue;
            flow_toDo.Location = new Point(83, 94);
            flow_toDo.Name = "flow_toDo";
            flow_toDo.Size = new Size(254, 528);
            flow_toDo.TabIndex = 4;
            // 
            // flow_inProgress
            // 
            flow_inProgress.BackColor = Color.Orange;
            flow_inProgress.Controls.Add(lbl_inProgress);
            flow_inProgress.Location = new Point(415, 94);
            flow_inProgress.Name = "flow_inProgress";
            flow_inProgress.Size = new Size(254, 528);
            flow_inProgress.TabIndex = 5;
            // 
            // flow_done
            // 
            flow_done.BackColor = Color.Chartreuse;
            flow_done.Location = new Point(750, 94);
            flow_done.Name = "flow_done";
            flow_done.Size = new Size(254, 528);
            flow_done.TabIndex = 5;
            // 
            // btn_addTask
            // 
            btn_addTask.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addTask.ForeColor = SystemColors.ActiveCaptionText;
            btn_addTask.Location = new Point(688, 5);
            btn_addTask.Name = "btn_addTask";
            btn_addTask.Size = new Size(127, 37);
            btn_addTask.TabIndex = 6;
            btn_addTask.Text = "Add new task";
            btn_addTask.UseVisualStyleBackColor = true;
            btn_addTask.Click += btn_addTask_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(655, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lbl_done
            // 
            lbl_done.AutoSize = true;
            lbl_done.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_done.ForeColor = SystemColors.ActiveCaptionText;
            lbl_done.Location = new Point(828, 62);
            lbl_done.Name = "lbl_done";
            lbl_done.Size = new Size(94, 32);
            lbl_done.TabIndex = 8;
            lbl_done.Text = "DONE";
            // 
            // lbl_inProgress
            // 
            lbl_inProgress.AutoSize = true;
            lbl_inProgress.Font = new Font("Lucida Console", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_inProgress.ForeColor = SystemColors.ActiveCaptionText;
            lbl_inProgress.Location = new Point(3, 0);
            lbl_inProgress.Name = "lbl_inProgress";
            lbl_inProgress.Size = new Size(191, 70);
            lbl_inProgress.TabIndex = 9;
            lbl_inProgress.Text = "IN PROGRESS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(426, 62);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
            label1.TabIndex = 9;
            label1.Text = "IN PROGRESS";
            // 
            // lbl_todo
            // 
            lbl_todo.AutoSize = true;
            lbl_todo.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_todo.ForeColor = SystemColors.ActiveCaptionText;
            lbl_todo.Location = new Point(142, 62);
            lbl_todo.Name = "lbl_todo";
            lbl_todo.Size = new Size(114, 32);
            lbl_todo.TabIndex = 10;
            lbl_todo.Text = "TO DO";
            // 
            // TodoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1107, 652);
            Controls.Add(lbl_todo);
            Controls.Add(lbl_done);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_addTask);
            Controls.Add(flow_done);
            Controls.Add(flow_inProgress);
            Controls.Add(flow_toDo);
            Controls.Add(btn_logout);
            Controls.Add(lbl_nomUtilisateur);
            ForeColor = SystemColors.ActiveCaption;
            Name = "TodoPage";
            Text = "TodoPage";
            Load += TodoPage_Load;
            flow_inProgress.ResumeLayout(false);
            flow_inProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_nomUtilisateur;
        private Button btn_logout;
        private FlowLayoutPanel flow_toDo;
        private FlowLayoutPanel flow_inProgress;
        private FlowLayoutPanel flow_done;
        private Button btn_addTask;
        private PictureBox pictureBox1;
        private Label lbl_inProgress;
        private Label lbl_done;
        private Label label1;
        private Label lbl_todo;
    }
}