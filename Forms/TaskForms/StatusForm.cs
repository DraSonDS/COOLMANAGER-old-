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
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
            statusComboBox.SelectedItem = DataBank.status;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void statusEditButton_Click(object sender, EventArgs e)
        {
  
            DB db = new DB();
            // MySqlCommand command = new MySqlCommand("UPDATE `tasks`SET (`date`, `description`, `responsible`, `orderedBy`, `priority`) VALUES (@date, @description, @responsible, @orderedBy, @priority);", db.getConnection());
            MySqlCommand command = new MySqlCommand("UPDATE `tasks`SET `status` = @status WHERE `tasks`.`id` = " + DataBank.taskId + ";", db.getConnection());
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = statusComboBox.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Статус изменён");
                this.Hide();
            }
            db.closeConnection();
        }
    }
}
