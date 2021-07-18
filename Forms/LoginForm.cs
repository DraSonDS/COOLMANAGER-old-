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
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
         InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 40);
            loginField.Text = "Введите логин";
            passField.Text = "Введите пароль";
            loginField.ForeColor = Color.Gray;
            passField.ForeColor = Color.Gray;
            passField.UseSystemPasswordChar = false;
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
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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
        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
        //Создаю ивент когда при нажатии кнопки программа идентифицировала пользователя через его логин и пароль
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Получили данные от пользователя
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            //Выполнили подключение к базе данных
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Произвожу MySql команду для выбора логина и пароля из базы данных
                 //Сначала я присваиваю данные "заглужкам" (@uL, @up), ради безопасности
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
                //И тут присваиваю данные переменным из заглужек
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            //Выбераю нужную комманду и выполняю её
            adapter.SelectCommand = command;
            //Помещаю в объект "table" 
            adapter.Fill(table);

            //Сравнение количества совпадений в базе данных. Если совпадения есть, то пользователь идентифицируется.
            if (table.Rows.Count > 0)
            {
                DataBank.loginShow = loginUser;
                namefind();
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        public void namefind()
        {
        DB db = new DB();
        MySqlCommand command = new MySqlCommand("SELECT name FROM `users` WHERE login ='"+DataBank.loginShow+"'", db.getConnection());
            db.openConnection();
            DataBank.userName = (string)command.ExecuteScalar();
            db.closeConnection();
        MySqlCommand command1 = new MySqlCommand("SELECT surname FROM `users` WHERE login ='" + DataBank.loginShow + "'", db.getConnection());
            db.openConnection();
            DataBank.userName = DataBank.userName + " " + (string)command1.ExecuteScalar();
            db.closeConnection();
        MySqlCommand command2 = new MySqlCommand("SELECT post FROM `users` WHERE login ='" + DataBank.loginShow + "'", db.getConnection());
            db.openConnection();
            DataBank.userPost = (string)command2.ExecuteScalar();
            db.closeConnection();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
