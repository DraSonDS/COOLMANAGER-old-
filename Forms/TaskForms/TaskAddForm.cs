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
    public partial class TaskAddForm : Form
    {
        public TaskAddForm()
        {
            InitializeComponent();
            
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name, surname FROM `users`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                string rowz = string.Format("{0} {1}", row.ItemArray[0], row.ItemArray[1]);
                personСomboBox.Items.Add(rowz);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void taskAddButton_Click(object sender, EventArgs e)
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
            MySqlCommand command = new MySqlCommand("INSERT INTO `tasks` (`date`, `description`, `responsible`, `orderedBy`, `priority`,`status`) VALUES (@date, @description, @responsible, @orderedBy, @priority,@status);", db.getConnection());
            command.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker1.Value;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = descriptionTextBox.Text;
            command.Parameters.Add("@responsible", MySqlDbType.VarChar).Value = personСomboBox.Text;
            command.Parameters.Add("@orderedBy", MySqlDbType.VarChar).Value = DataBank.userName;
            command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = priorityComboBox.Text;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Открыт";
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Задание добавлено");
                this.Hide();
            }
            else
                MessageBox.Show("Задание не добавлено");

            db.closeConnection();

        }

        private void personСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TaskAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
