using ExampleSQLApp.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            //show info about user
            usernameLabel.Text = DataBank.loginShow;
            nameLabel.Text = DataBank.userName;
            postLabel.Text = DataBank.userPost;
            searchData();

            taskDataGridView.Columns[1].HeaderText = "Дата выполнения";
            taskDataGridView.Columns[2].HeaderText = "Описание";
            taskDataGridView.Columns[3].HeaderText = "Ответственный";
            taskDataGridView.Columns[4].HeaderText = "Поручил";
            taskDataGridView.Columns[5].HeaderText = "Статус";
          
            this.taskDataGridView.Columns[0].Visible = false;

            //button add
            DataGridViewButtonColumn delButton = new DataGridViewButtonColumn();
            delButton.HeaderText = "Button";
            delButton.Name = "delBtn";
            delButton.Text = "Удалить";
            delButton.UseColumnTextForButtonValue = true;
            taskDataGridView.Columns.Add(delButton);

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "editBtn";
            editButton.Text = "Редактировать";
            editButton.UseColumnTextForButtonValue = true;
            taskDataGridView.Columns.Add(editButton);

            DataGridViewButtonColumn compliteButton = new DataGridViewButtonColumn();
            compliteButton.Name = "compliteBtn";
            compliteButton.Text = "Сменить статус";
            compliteButton.UseColumnTextForButtonValue = true;
            taskDataGridView.Columns.Add(compliteButton);

        }
        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            searchData();
        }
        private void taskDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //Delete task button
            if (taskDataGridView.Columns[e.ColumnIndex].Name == "delBtn")
            {
                DataBank.taskId = this.taskDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (MessageBox.Show("Вы действительно хотите удалить это задание?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("DELETE FROM `tasks` WHERE `tasks`.`id` =" + DataBank.taskId + "", db.getConnection());
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Задание удалено");
                    }
                    else
                        MessageBox.Show("Задание не изменено");
                        db.closeConnection();
                }
            }
            //Edit task button
            else if (taskDataGridView.Columns[e.ColumnIndex].Name == "editBtn")
            {
              MessageBox.Show("Редактирование");
              DataBank.taskId = this.taskDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
              DataBank.priority = this.taskDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
              DataBank.date = (DateTime)this.taskDataGridView.Rows[e.RowIndex].Cells[4].Value;
              DataBank.description = this.taskDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
              DataBank.responsible = this.taskDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
              Forms.TaskForms.TaskEditForm taskEditForm = new Forms.TaskForms.TaskEditForm();
              taskEditForm.ShowDialog();
            }
            //Complete task button
            else if (taskDataGridView.Columns[e.ColumnIndex].Name == "compliteBtn")
            {
                DataBank.taskId = this.taskDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                DataBank.status = this.taskDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                MessageBox.Show("Сменить статус задачи");
                Forms.TaskForms.StatusForm statusForm = new Forms.TaskForms.StatusForm();
                statusForm.ShowDialog();
            }
        }
        private void taskAddButton_Click(object sender, EventArgs e)
        {
            Forms.TaskForms.TaskAddForm taskAddForm = new Forms.TaskForms.TaskAddForm();
            taskAddForm.Show();
        }
        public void searchData()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tasks` WHERE responsible ='"+DataBank.userName+"'", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            taskDataGridView.DataSource = table;

        }

    }
 }
    
