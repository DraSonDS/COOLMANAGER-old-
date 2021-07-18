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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            //инициализация запуска окна по нажатию кнопки
            formNameLabel.Text = "Ученики";
            this.formOpener.Controls.Clear();
            studentForm FrmOpen = new studentForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
            loginLabel.Text = DataBank.loginShow;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            studentButton.BackColor = Color.FromArgb(130, 130, 130);
            teacherButton.BackColor = Color.Transparent;
            groupButton.BackColor= Color.Transparent;
            formNameLabel.Text = "Ученики";
            //инициализация запуска окна по нажатию кнопки
            this.formOpener.Controls.Clear();
            studentForm FrmOpen = new studentForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            studentButton.BackColor = Color.Transparent;
            teacherButton.BackColor = Color.FromArgb(130, 130, 130);
            groupButton.BackColor = Color.Transparent;
           
            formNameLabel.Text = "Преподаватели";
            //инициализация запуска окна по нажатию кнопки
            this.formOpener.Controls.Clear();
            teacherForm FrmOpen = new teacherForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            studentButton.BackColor = Color.Transparent;
            teacherButton.BackColor = Color.Transparent;
            groupButton.BackColor = Color.FromArgb(130, 130, 130);
            formNameLabel.Text = "Группы";
            //инициализация запуска окна по нажатию кнопки
            this.formOpener.Controls.Clear();
            groupForm FrmOpen = new groupForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            studentButton.BackColor = Color.Transparent;
            teacherButton.BackColor = Color.Transparent;
            groupButton.BackColor = Color.Transparent;
            formNameLabel.Text = "Финансы";
            this.formOpener.Controls.Clear();
            Forms.DataForms.groupEditForm FrmOpen = new Forms.DataForms.groupEditForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            formNameLabel.Text = "Пользователь";
            //инициализация запуска окна по нажатию кнопки
            this.formOpener.Controls.Clear();
            UserForm FrmOpen = new UserForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            formNameLabel.Text = "Пользователь";
            //инициализация запуска окна по нажатию кнопки
            this.formOpener.Controls.Clear();
            UserForm FrmOpen = new UserForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
        }


        public void groupEditFormOpen()
        {
            this.formOpener.Controls.Clear();
            Forms.DataForms.groupEditForm FrmOpen = new Forms.DataForms.groupEditForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOpen.FormBorderStyle = FormBorderStyle.None;
            this.formOpener.Controls.Add(FrmOpen);
            FrmOpen.Show();
        }

    }
}
