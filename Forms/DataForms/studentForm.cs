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
    public partial class studentForm : Form
    {
        public string StudName ="";
        public string SexType = "";
        public studentForm()
        {
            InitializeComponent();
        }   
        private void studentForm_Load(object sender, EventArgs e)
        {
            searchData();
        }
        private void studentAddButton_Click_1(object sender, EventArgs e)
        {
            studentRegisterForm studentRegisterForm = new studentRegisterForm();
            studentRegisterForm.Show();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (nameSearchBox.Text == "Имя, фамилия, отчество")
            {
                nameSearchBox.Text = "";
                nameSearchBox.ForeColor = Color.White;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (nameSearchBox.Text == "")
            {
                nameSearchBox.Text = "Имя, фамилия, отчество";
                nameSearchBox.ForeColor = Color.Silver;
                StudName = "";
            }
        }
        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            warningDataLabel.Visible = false;
            if (nameSearchBox.Text == "Имя, фамилия, отчество")
            {
                StudName = "";
            }
            else
            {
                StudName = nameSearchBox.Text;
                searchData();
            }
            if (EmpoyeesListDataGridView.Rows.Count == 0)
                warningDataLabel.Visible = true;
        }
        private void sexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sexComboBox.Text == "-")
            {
                SexType = "";
                searchData();
            }
            else
            {
                SexType = sexComboBox.Text;
                searchData();
            }
        }
        private void searchData()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `students` " +
                "WHERE `sex` LIKE '%" + SexType + "%'" +
                "AND (`name` LIKE '" + StudName + "%' " +
                "OR `surname` LIKE '" + StudName + "%')", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            EmpoyeesListDataGridView.DataSource = table;
            EmpoyeesListDataGridView.Columns[0].HeaderText = "Номер ученика";
            EmpoyeesListDataGridView.Columns[1].HeaderText = "Имя";
            EmpoyeesListDataGridView.Columns[2].HeaderText = "Фамилия";
            EmpoyeesListDataGridView.Columns[3].HeaderText = "Отчество";
            EmpoyeesListDataGridView.Columns[4].HeaderText = "Пол";
            EmpoyeesListDataGridView.Columns[5].HeaderText = "Дата рождения";
            EmpoyeesListDataGridView.Columns[6].HeaderText = "Дата обращения";
            EmpoyeesListDataGridView.Columns[7].HeaderText = "Рекламный источник";
            EmpoyeesListDataGridView.Columns[8].HeaderText = "Цель обращения";
            this.EmpoyeesListDataGridView.Columns[0].Visible = false;
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
