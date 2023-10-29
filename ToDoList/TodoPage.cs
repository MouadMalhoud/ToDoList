using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


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
        }
        private void AjouterTache(Task task, FlowLayoutPanel panel)
        {
            tasks.Add(task);

            Panel taskPanel = new Panel();
            // Personnalisez le panneau pour afficher les informations de la tâche

            // Ajoutez le panneau au FlowLayoutPanel
            panel.Controls.Add(taskPanel);
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            TaskAdding taskAdding = new TaskAdding();
            taskAdding.Show();

            this.Hide();
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
