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

namespace ExampleSQLApp
{
    public partial class teacherForm : Form
    {
        public string teachersName = "";
        public teacherForm()
        {
            InitializeComponent();
        }
        private void teachersTextBox_Enter(object sender, EventArgs e)
        {
            if (teachersTextBox.Text == "Имя, фамилия")
            {
                teachersTextBox.Text = "";
                teachersTextBox.ForeColor = Color.White;
            }
        }

        private void teachersTextBox_Leave(object sender, EventArgs e)
        {
            if (teachersTextBox.Text == "")
            {
                teachersTextBox.Text = "Имя, фамилия";
                teachersTextBox.ForeColor = Color.Silver;
                teachersName = "";
            }
        }

        private void teachersTextBox_TextChanged(object sender, EventArgs e)
        {
            warningDataLabel.Visible = false;
            if (teachersTextBox.Text == "Имя, фамилия")
            {
                teachersName = "";
            }
            else
            {
                teachersName = teachersTextBox.Text;
                searchData();
            }
            if (teacherDataGridView.Rows.Count == 0)
                warningDataLabel.Visible = true;
        }

        private void teacherForm_Load(object sender, EventArgs e)
        {
            searchData();
            teachersTextBox.Text = "Имя, фамилия";
        }
        private void searchData()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name, surname, teachers.name_subject FROM `users` " +
                "JOIN teachers ON users.id_user = teachers.id_user " +
                "WHERE users.name LIKE '" + teachersName + "%' " +
                "OR users.surname LIKE '" + teachersName + "%' ", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            teacherDataGridView.DataSource = table;
            teacherDataGridView.Columns[0].HeaderText = "Имя";
            teacherDataGridView.Columns[1].HeaderText = "Фамилия";
            teacherDataGridView.Columns[2].HeaderText = "Предмет";

        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void teacherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacherAddButton_Click(object sender, EventArgs e)
        {
            Forms.DataForms.teachersEditForm teachersEditForm = new Forms.DataForms.teachersEditForm();
            teachersEditForm.ShowDialog();
        }
    }
}
