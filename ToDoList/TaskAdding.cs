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
    public partial class TaskAdding : Form
    {
        public TaskAdding()
        {
            InitializeComponent();
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            string title = txt_taskName.Text;
            string description = txt_description.Text;
            DateTime dueDate = dateTimePicker.Value;
            int index = comboBox_status.SelectedIndex;

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(description))
            {

                DBuser db = new DBuser();

                if (SessionManager.CurrentUser != null)
                {
                    string userId = SessionManager.CurrentUser.Id;
                    Task newTask = new Task(title, description, dueDate, index, userId);
                    db.AddTask(userId, newTask);

                    txt_taskName.Text = "";
                    txt_description.Text = "";
                    dateTimePicker.Value = DateTime.Now;

                    TodoPage todoPage = new TodoPage();
                    todoPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Utilisateur non connecté.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }
    }
}
