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
    public partial class groupForm : Form
    {
        public string groupName = "";
        public groupForm()
        {
            InitializeComponent();
        }
        private void groupForm_Load(object sender, EventArgs e)
        {
            searchData();
        }

        private void groupAddButton_Click(object sender, EventArgs e)
        {
            Forms.DataForms.groupRegisterForm groupRegisterForm = new Forms.DataForms.groupRegisterForm();
            groupRegisterForm.ShowDialog();
        }
        private void searchData()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id_group, group_name, groups.name_subject, status, type, concat(users.name,' ', users.surname), capacity " +
                "FROM `groups` JOIN `teachers` ON groups.id_teacher = teachers.id_teacher " +
                "JOIN `users` on teachers.id_user = users.id_user " +
                "WHERE groups.group_name LIKE '" + groupName + "%' ", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            groupDataGridView.DataSource = table;
            groupDataGridView.Columns[0].Visible = false;
            groupDataGridView.Columns[1].HeaderText = "Название группы";
            groupDataGridView.Columns[1].Name = "group_name";
            groupDataGridView.Columns[2].HeaderText = "Дисциплина";
            groupDataGridView.Columns[3].HeaderText = "Статус группы";
            groupDataGridView.Columns[4].HeaderText = "Тип группы";
            groupDataGridView.Columns[5].HeaderText = "Преподаватель";
            groupDataGridView.Columns[6].HeaderText = "Вместимость";
        }

        private void groupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (groupDataGridView.Columns[e.ColumnIndex].Name == "group_name")
            {
                DataBank.group_id = Convert.ToInt32(groupDataGridView.Rows[e.RowIndex].Cells[0].Value);
                Forms.DataForms.groupEditForm groupeditform = new Forms.DataForms.groupEditForm();
                groupeditform.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForms = new MainForm();
            mainForms.formNameLabel.Text = "1123";
            mainForms.groupEditFormOpen();

        }

        private void nameSearchBox_Enter(object sender, EventArgs e)
        {
            if (nameSearchBox.Text == "Название группы")
            {
                nameSearchBox.Text = "";
                nameSearchBox.ForeColor = Color.White;
            }
        }

        private void nameSearchBox_Leave(object sender, EventArgs e)
        {
            if (nameSearchBox.Text == "")
            {
                nameSearchBox.Text = "Название группы";
                nameSearchBox.ForeColor = Color.Silver;
                groupName = "";
            }
        }

        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            warningDataLabel.Visible = false;
            if (nameSearchBox.Text == "Название группы")
            {
                groupName = "";
            }
            else
            {
                groupName = nameSearchBox.Text;
                searchData();
            }
            if (groupDataGridView.Rows.Count == 0)
                warningDataLabel.Visible = true;
        }
    }
}
