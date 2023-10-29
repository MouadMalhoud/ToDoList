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

        private void AjouterTache(Task task, FlowLayoutPanel panel)
        {
            tasks.Add(task);

            Panel taskPanel = new Panel();
            taskPanel.BackColor = Color.White;
            taskPanel.Margin = new Padding(10);

            Label lblTitle = new Label();
            lblTitle.Text = task.Title;
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);

            Label lblDescription = new Label();
            lblDescription.Text = task.Description;


            taskPanel.Controls.Add(lblTitle);
            taskPanel.Controls.Add(lblDescription);

            panel.Controls.Add(taskPanel);
        }

        private void AfficherTaches()
        {
            flow_toDo.Controls.Clear();
            flow_inProgress.Controls.Clear();
            flow_done.Controls.Clear();

            foreach (var task in tasks)
            {
                Panel taskPanel = new Panel();
                taskPanel.BackColor = Color.White;
                taskPanel.Margin = new Padding(10);


                Label lblTitle = new Label();
                lblTitle.Text = task.Title;
                lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);

                Label lblDescription = new Label();
                lblDescription.Text = task.Description;


                taskPanel.Controls.Add(lblTitle);
                taskPanel.Controls.Add(lblDescription);

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

                AfficherTaches();
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
