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
    public partial class studentAddToGroupForm : Form
    {
        public studentAddToGroupForm()
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
        private void studentAddToGroupForm_Load(object sender, EventArgs e)
        {
            //add students into listbox
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand
                ("SELECT students.name, students.surname " +
                "FROM `students` " +
                    "LEFT JOIN groups_and_students ON students.id_student = groups_and_students.id_student " +
                        "AND groups_and_students.id_group = "+ DataBank.group_id +" " +
                    "LEFT JOIN groups ON groups.id_group = groups_and_students.id_group " +
                "WHERE groups_and_students.id_group IS NULL", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string rowz = string.Format("{0} {1}", row.ItemArray[0], row.ItemArray[1]);
                listBox1.Items.Add(rowz);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Rectangle itemRect = listBox1.GetItemRectangle(listBox1.SelectedIndex);
            if (itemRect.Contains(e.Location))
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem == null) return;

            Rectangle itemRect = listBox2.GetItemRectangle(listBox2.SelectedIndex);
            if (itemRect.Contains(e.Location))
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Object[] ItemObject = new System.Object[listBox1.Items.Count];
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {
                ItemObject[i] = listBox1.Items[i];
            }
            listBox2.Items.AddRange(ItemObject);
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Object[] ItemObject = new System.Object[listBox2.Items.Count];
            for (int i = 0; i <= listBox2.Items.Count - 1; i++)
            {
                ItemObject[i] = listBox2.Items[i];
            }
            listBox1.Items.AddRange(ItemObject);
            listBox2.Items.Clear();
        }

        private void studentAddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            for (int i = 0; i < listBox2.Items.Count ; i++)
            {
                string str = Convert.ToString(listBox2.Items[i]);
                string[] split = str.Split(' ');
                MySqlCommand command1 = new MySqlCommand("SELECT `id_student` FROM `students` " +
                    "WHERE name = '"+ split[0] + "' and surname = '"+ split[1]+ "'", db.getConnection());
                        db.openConnection();
                        int stud_id = (int)command1.ExecuteScalar();
                        db.closeConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `groups_and_students` (`id_student` , `id_group`) " +
                    "VALUES (@id_stud, @id_group);", db.getConnection());
                command.Parameters.Add("@id_stud", MySqlDbType.VarChar).Value = stud_id;
                command.Parameters.Add("@id_group", MySqlDbType.VarChar).Value = DataBank.group_id ;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                }
                db.closeConnection();

            }
            MessageBox.Show("Ученики добавлены ");
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
