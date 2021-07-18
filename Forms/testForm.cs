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
using System.Data.SqlClient;

namespace ExampleSQLApp
{
    public partial class testForm : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public testForm()
        {
            InitializeComponent();
            
        }

        private void testForm_Load(object sender, EventArgs e) { 
        
        }
        private void EmpoyeesListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.textForm2 tsf = new Forms.textForm2(this);
            tsf.Show();
        }
    }
}
