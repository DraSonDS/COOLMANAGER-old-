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
    public partial class teachersEditForm : Form
    {
        public teachersEditForm()
        {
            InitializeComponent();
        }

        private void teachersEditForm_Load(object sender, EventArgs e)
        {
            comboboxAddInfo();
        }
        private void comboboxAddInfo()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name, surname FROM `users` " +
                "JOIN teachers ON users.id_user = teachers.id_user ", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string rowz = string.Format("{0} {1}", row.ItemArray[0], row.ItemArray[1]);
                teacherComboBox.Items.Add(rowz);
            }

            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT name_subject FROM `subjects`"
              , db.getConnection());
            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            foreach (DataRow row in table1.Rows)
            {
                string rowz = string.Format("{0}", row.ItemArray[0]);
                subjectСomboBox.Items.Add(rowz);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGroupReg_Click(object sender, EventArgs e)
        {
            if (teacherComboBox.Text == "" && subjectСomboBox.Text == "")
            {
                MessageBox.Show("Внесите значения для изменения");
                return;
            }
            string str = Convert.ToString(teacherComboBox.Text);
            string[] split = str.Split(' ');
            DB db = new DB();
            // MySqlCommand command = new MySqlCommand("UPDATE `tasks`SET (`date`, `description`, `responsible`, `orderedBy`, `priority`) VALUES (@date, @description, @responsible, @orderedBy, @priority);", db.getConnection());
            MySqlCommand command = new MySqlCommand("UPDATE `teachers` " +
                "JOIN users " +
                "ON users.id_user = teachers.id_user " +
                "SET `name_subject` = @name_subject " +
                "WHERE users.name = '"+ split[0] +"' " +
                "AND users.surname = '"+ split[1] +"';", db.getConnection());
            command.Parameters.Add("@name_subject", MySqlDbType.VarChar).Value = subjectСomboBox.Text;
            
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Предмет преподавателя изменён");
                this.Hide();
            }
            db.closeConnection();

        }
    }
}