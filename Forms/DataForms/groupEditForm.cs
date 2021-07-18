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
    public partial class groupEditForm : Form
    {
        public groupEditForm()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void groupEditForm_Load(object sender, EventArgs e)
        {
            AddGroupInfo();
        }
        private void studentAddButton_Click(object sender, EventArgs e)
        {
            studentAddToGroupForm studentAddToGroupForm = new studentAddToGroupForm();
            studentAddToGroupForm.ShowDialog();
        }


        public void AddGroupInfo()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT group_name, name_subject, status FROM `groups` " +
                "WHERE id_group = '"+ DataBank.group_id +"'", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                groupNameLabel.Text = string.Format("{0}", row.ItemArray[0]);
                groupStatuslabel.Text = string.Format("{0}", row.ItemArray[2]);
                subjectNameLabel.Text = string.Format("{0}", row.ItemArray[1]);
            }

            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT name, surname FROM `users` " +
                "JOIN `teachers` ON users.id_user = teachers.id_user " +
                "JOIN `groups` ON groups.id_teacher = teachers.id_teacher " +
                "WHERE groups.id_group = '"+ DataBank.group_id + "'", db.getConnection());

            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            foreach (DataRow row in table1.Rows)
            {
                teacherNameLabel.Text = string.Format("{0} {1}", row.ItemArray[0], row.ItemArray[1]);
            }

            //add students information in table
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand("SELECT name, surname, bitrh_date FROM `students` " +
                "JOIN `groups_and_students` ON students.id_student = groups_and_students.id_student " +
                "JOIN `groups` ON groups.id_group = groups_and_students.id_group " +
                "WHERE groups.id_group = '"+ DataBank.group_id +"'", db.getConnection());

            adapter2.SelectCommand = command2;
            adapter2.Fill(table2);
            groupDataGridView.DataSource = table2;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentGroupDeleteButton_Click(object sender, EventArgs e)
        {
            studentRemoveFromGroupForm removeFromGroupForm = new studentRemoveFromGroupForm();
            removeFromGroupForm.ShowDialog();
        }
    }
}
