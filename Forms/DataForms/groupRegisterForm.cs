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

namespace ExampleSQLApp.Forms.DataForms
{
    public partial class groupRegisterForm : Form
    {
        int teacher_id;
        string teacher_name;
        string teacher_surname;
        public groupRegisterForm()
        {
            InitializeComponent();
        }
        private void groupRegisterForm_Load(object sender, EventArgs e)
        {
            comboboxsubject();
            comboboxteacher();
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboboxteacher()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name, surname FROM `users`WHERE post = 'Учитель'", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string rowz = string.Format("{0} {1}", row.ItemArray[0], row.ItemArray[1]);
                teacherComboBox.Items.Add(rowz);
            }
            
        }
        private void comboboxsubject()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name_subject FROM `subjects`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string rowz = string.Format("{0}", row.ItemArray[0]);
                subjectComboBox.Items.Add(rowz);
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
        private void buttonGroupReg_Click(object sender, EventArgs e)
        {
            //Проверка заполнены ли все поля регистрации
            warningchecklabel.Visible = false;
            if (nameField.Text == "Название группы")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (subjectComboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (statusComboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (typeComboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (teacherComboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (capacityTextBox.Text == "Вместимость")
            {
                warningchecklabel.Visible = true;
                return;
            }
            //take teachers name and surname

            string[] words = teacherComboBox.Text.Split(' ');
            teacher_name = words[0];
            teacher_surname = words[1];


            MessageBox.Show(teacher_name +" "+ teacher_surname);
            //add information to database
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `groups` (`group_name`, `status`, `type`, `id_teacher`, `capacity`, `name_subject`) VALUES (@group_name, @status, @type, @id_teacher, @capacity, @name_subject);", db.getConnection());
            command.Parameters.Add("@group_name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = statusComboBox.Text;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = typeComboBox.Text;
            // taking teacher id
            MySqlCommand command1 = new MySqlCommand("SELECT `id_teacher` FROM `teachers` JOIN `users` ON users.name = '"+teacher_name+ "' AND users.surname = '" + teacher_surname + "' AND users.id_user = teachers.id_user", db.getConnection());
            db.openConnection();
            teacher_id = (int)command1.ExecuteScalar();
            db.closeConnection();
            command.Parameters.Add("@id_teacher", MySqlDbType.Int64).Value = teacher_id;
            command.Parameters.Add("@capacity", MySqlDbType.Int64).Value = capacityTextBox.Text;
            command.Parameters.Add("@name_subject", MySqlDbType.VarChar).Value = subjectComboBox.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Группа успешно зарегестрирована");
                this.Hide();
            }
            db.closeConnection();
        }
    }
}
