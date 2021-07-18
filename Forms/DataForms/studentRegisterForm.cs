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
    public partial class studentRegisterForm : Form
    {
        public studentRegisterForm()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите имя")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.White;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.Text = "Введите имя";
                nameField.ForeColor = Color.Silver;
            }
        }
        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text == "Введите фамилию")
            {
                surnameField.Text = "";
                surnameField.ForeColor = Color.White;
            }
        }
        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text == "")
            {
                surnameField.Text = "Введите фамилию";
                surnameField.ForeColor = Color.Silver;
            }
        }
        private void LastnameField_Enter(object sender, EventArgs e)
        {
            if (LastnameField.Text == "Введите отчество")
            {
                LastnameField.Text = "";
                LastnameField.ForeColor = Color.White;
            }
        }
        private void LastnameField_Leave(object sender, EventArgs e)
        {
            if(LastnameField.Text == "")
            {
                LastnameField.Text = "Введите отчество";
                LastnameField.ForeColor = Color.Silver;
            }
        }
        private void buttonStudentReg_Click(object sender, EventArgs e)
        {
            //Проверка заполнены ли все поля регистрации
            warningchecklabel.Visible = false;
            if (nameField.Text == "Введите имя")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (surnameField.Text == "Введите фамилию")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (LastnameField.Text == "Введите отчество")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (sexComboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }
            if (advertComboBox.Text == "")
            {
                advertComboBox.Visible = true;
                return;
            }
            if (studTargetComboBox.Text == "")
            {
                warningchecklabel.Visible = true;
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `students` (`name`, `surname`, `lastname`, `sex`, `bitrh_date`, `reg_date`, `advet_type`, `request_type`) VALUES (@name, @surname, @lastname, @sex, @birth, @regdate, @advert, @request);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = LastnameField.Text;
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sexComboBox.Text;
            command.Parameters.Add("@birth", MySqlDbType.DateTime).Value = birthDateTimePicker.Value;
            command.Parameters.Add("@regdate", MySqlDbType.DateTime).Value = registerDateTimePicker.Value;
            command.Parameters.Add("@advert", MySqlDbType.VarChar).Value = advertComboBox.Text;
            command.Parameters.Add("@request", MySqlDbType.VarChar).Value = studTargetComboBox.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно зарегестрирован");
                this.Hide();
            }
            else
                MessageBox.Show("Аккаунт не был зарегестрирован");
            db.closeConnection();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
