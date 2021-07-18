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
    public partial class studentRemoveFromGroupForm : Form
    {
        public studentRemoveFromGroupForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentRemoveFromGroupForm_Load(object sender, EventArgs e)
        {
        addStudentsToListBox();
        }

        private void studentAddButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Rectangle itemRect = listBox1.GetItemRectangle(listBox1.SelectedIndex);
            if (itemRect.Contains(e.Location))
            {
                if (MessageBox.Show("Вы действительно хотите удалить ученика "+ listBox1.SelectedItem + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string str = Convert.ToString(listBox1.SelectedItem);
                    string[] split = str.Split(' ');
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand("DELETE w FROM `groups_and_students` w JOIN students" +
                        " ON w.id_student = students.id_student " +
                        "WHERE students.name = '"+ split[0] + "' AND students.surname = '"+ split[1] +"' " +
                        "AND w.id_group = "+ DataBank.group_id +" ", db.getConnection());
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Ученик " + listBox1.SelectedItem + " удалён из группы");
                        
                    }
                    db.closeConnection();
                    listBox1.Items.Clear();
                    addStudentsToListBox();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addStudentsToListBox()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand
                ("SELECT students.name, students.surname " +
                "FROM `students` " +
                    "LEFT JOIN groups_and_students ON students.id_student = groups_and_students.id_student " +
                    "LEFT JOIN groups ON groups.id_group = groups_and_students.id_group " +
                "WHERE groups_and_students.id_group = " + DataBank.group_id + "", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string rowz = string.Format("{0} {1}", row.ItemArray[0], row.ItemArray[1]);
                listBox1.Items.Add(rowz);
            }
        }
    }
}
