using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class TodoPage : Form
    {
        private User user;
        List<Task> tasks = new List<Task>();

        public TodoPage()
        {
            InitializeComponent();
        }

        public TodoPage(User user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void ShowTasks()
        {
            flow_toDo.Controls.Clear();
            flow_inProgress.Controls.Clear();
            flow_done.Controls.Clear();

            foreach (var task in tasks)
            {
                Panel taskPanel = new Panel();
                taskPanel.BackColor = Color.White;
                taskPanel.Size = new Size(225, 85);
                taskPanel.Margin = new Padding(9);

                Label lblTitle = new Label();
                lblTitle.Text = task.Title;
                lblTitle.ForeColor = Color.Black;
                lblTitle.Font = new Font("Lucida Console", 18, FontStyle.Bold);
                lblTitle.Width = 200;
                lblTitle.Top = 5;

                Label lblDescription = new Label();
                lblDescription.ForeColor = Color.Black;
                lblDescription.Text = task.Description;
                lblDescription.Font = new Font("Lucida Console", 9, FontStyle.Regular);
                lblDescription.Width = 200;
                lblDescription.Top = lblTitle.Bottom + 5;

                Label lblDueDate = new Label();
                lblDueDate.Text = "Due for: " + task.DueDate.ToString("MM/dd/yyyy");
                lblDueDate.Font = new Font("Lucida Console", 9, FontStyle.Regular);
                lblDueDate.ForeColor = Color.Black;
                lblDueDate.Width = 200;
                lblDueDate.Top = lblDescription.Bottom + 5;

                Button btnDelete = new Button();
                btnDelete.Text = "X";
                btnDelete.ForeColor = (Color.Black);
                btnDelete.BackColor = Color.Red;
                btnDelete.Size = new Size(27, 27);
                btnDelete.Font = new Font("Lucida Console", 9, FontStyle.Bold);
                btnDelete.Top = 5;
                btnDelete.Left = 200;
                btnDelete.Click += (sender, e) =>
                {
                    MongoDB.Bson.ObjectId taskId = task.Id;
                    string taskIdString = taskId.ToString();

                    DBuser db = new DBuser();
                    db.RemoveTask(taskIdString);

                    LoadTasksFromDB();
                };

                taskPanel.Controls.Add(lblTitle);
                taskPanel.Controls.Add(lblDescription);
                taskPanel.Controls.Add(lblDueDate);
                taskPanel.Controls.Add(btnDelete);

                if (task.Status == 0)
                {
                    flow_toDo.Controls.Add(taskPanel);
                }
                else if (task.Status == 1)
                {
                    flow_inProgress.Controls.Add(taskPanel);
                }
                else if (task.Status == 2)
                {
                    flow_done.Controls.Add(taskPanel);
                }
            }
        }


        public void LoadTasksFromDB()
        {
            if (SessionManager.CurrentUser != null)
            {
                User currentUser = SessionManager.CurrentUser;

                DBuser db = new DBuser();
                tasks = db.GetTasksForUser(currentUser.Id);

                ShowTasks();
            }
        }
        private void TodoPage_Activated(object sender, EventArgs e)
        {
            LoadTasksFromDB();
        }
        private void TodoPage_Load(object sender, EventArgs e)
        {
            //lbl_nomUtilisateur.Text = "Welcome back " + user.Username;
            LoadTasksFromDB();
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            TaskAdding taskAdding = new TaskAdding(this);
            taskAdding.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Hide();
        }

    }
}
