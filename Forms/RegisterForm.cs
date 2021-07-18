using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userSurnameField.Text = "Введите фамилию";
            loginField.Text = "Введите логин";
            passField.Text = "Введите пароль";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.ForeColor = Color.Gray;
            loginField.ForeColor = Color.Gray;
            passField.ForeColor = Color.Gray;
            passField.UseSystemPasswordChar = false;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(84, 84, 84);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(64, 64, 64);
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AutLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }
        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }
        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }
        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
                passField.UseSystemPasswordChar = true;
            }
        }
        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
                passField.UseSystemPasswordChar = false;
            }
        }
        private void userSurnameField_TextChanged(object sender, EventArgs e)
        {

        }
        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            warningchecklabel.Visible = false;
            warningLabel.Visible = false;
            if (userNameField.Text == "Введите имя")
            {
                warningLabel.Visible = true;
                return;
            }
            if (userSurnameField.Text == "Введите фамилию")
            {
                warningLabel.Visible = true;
                return;
            }
            if (loginField.Text == "Введите логин")
            {
                warningLabel.Visible = true;
                return;
            }
            if (passField.Text == "Введите пароль")
            {
                warningLabel.Visible = true;
                return;
            }
            if (postComboBox.Text == "")
            {
                warningLabel.Visible = true;
                return;
            }


            if (isUserExists())
                return;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`, `post`) VALUES (@login, @pass, @name, @surname, @post);", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            command.Parameters.Add("@post", MySqlDbType.VarChar).Value = postComboBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                if (postComboBox.Text == "Учитель")
                {
                    addTeacher();
                }
                MessageBox.Show("Аккаунт успешно зарегестрирован");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
                MessageBox.Show("Аккаунт не был зарегестрирован");
                db.closeConnection();
        }


        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Произвожу MySql команду для выбора логина и пароля из базы данных
            //Сначала я присваиваю данные "заглужкам" (@uL, @up), ради безопасности
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            //И тут присваиваю данные переменным из заглужек
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            //Выбераю нужную комманду и выполняю её
            adapter.SelectCommand = command;
            //Помещаю в объект "table" 
            adapter.Fill(table);

            //Сравнение количества совпадений в базе данных. Если совпадения есть, то пользователь идентифицируется.
            if (table.Rows.Count > 0)
            {
                warningchecklabel.Visible = true;
                return true;
            }
            else
                return false;
        }
        public void addTeacher()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT id_user FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
                 db.openConnection();
                 int user_id = (int)command.ExecuteScalar();
                 db.closeConnection();

            MySqlCommand command1 = new MySqlCommand("INSERT INTO `teachers` (`id_teacher`, `experience`, `name_subject`, `id_user`) VALUES (NULL, NULL, NULL, @id_user);", db.getConnection());
            command1.Parameters.Add("@id_user", MySqlDbType.Int64).Value = user_id ;
                db.openConnection();
                if (command1.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно зарегестрирован");
                }
                db.closeConnection();
        }
    }
    
}

