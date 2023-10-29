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
            flow_toDo.Location = new Point(83, 94);
            flow_toDo.Name = "flow_toDo";
            flow_toDo.Size = new Size(254, 528);
            flow_toDo.TabIndex = 4;
            // 
            // flow_inProgress
            // 
            flow_inProgress.Location = new Point(415, 94);
            flow_inProgress.Name = "flow_inProgress";
            flow_inProgress.Size = new Size(254, 528);
            flow_inProgress.TabIndex = 5;
            // 
            // flow_done
            // 
            flow_done.Location = new Point(750, 94);
            flow_done.Name = "flow_done";
            flow_done.Size = new Size(254, 528);
            flow_done.TabIndex = 5;
            // 
            // btn_addTask
            // 
            btn_addTask.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addTask.ForeColor = SystemColors.ActiveCaptionText;
            btn_addTask.Location = new Point(383, 29);
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
            pictureBox1.Location = new Point(350, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TodoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1107, 652);
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
    }
}