using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp.Forms.TaskForms
{
    public partial class TaskEditForm : Form
    {

        public TaskEditForm()
        {
            InitializeComponent();
        }
        private void TaskEditForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name, surname FROM `users`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string rowz = string.Format("{0} {1}", row.ItemArray[0], row.ItemArray[1]);
                personСomboBox.Items.Add(rowz);
            }
            dateTimePicker1.Value = DataBank.date;
            priorityComboBox.SelectedItem = DataBank.priority;
            personСomboBox.SelectedItem = DataBank.responsible;
            descriptionTextBox.Text = DataBank.description;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void taskEditButton_Click(object sender, EventArgs e)
        {
            
            //Проверка заполнены ли все поля регистрации
            warningchecklabel.Visible = false;
            if (priorityComboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (personСomboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }

            DB db = new DB();
            // MySqlCommand command = new MySqlCommand("UPDATE `tasks`SET (`date`, `description`, `responsible`, `orderedBy`, `priority`) VALUES (@date, @description, @responsible, @orderedBy, @priority);", db.getConnection());
            MySqlCommand command = new MySqlCommand("UPDATE `tasks`SET `date` = @date, description = @description, responsible = @responsible, priority = @priority WHERE `tasks`.`id` = " + DataBank.taskId + ";", db.getConnection());
            command.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker1.Value;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = descriptionTextBox.Text;
            command.Parameters.Add("@responsible", MySqlDbType.VarChar).Value = personСomboBox.Text;
            command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = priorityComboBox.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Задание изменено");
                this.Hide();
            }
            db.closeConnection();

        }

    }
}
