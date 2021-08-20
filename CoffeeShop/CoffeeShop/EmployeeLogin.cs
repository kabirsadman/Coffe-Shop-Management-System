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
using System.Configuration;

namespace CoffeeShop
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM Employee WHERE id= " + Convert.ToInt32(textBoxUserId.Text) + "AND Password=" + textBoxPass.Text;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                //EmployeeDetails f1 = new EmployeeDetails();
                //f1.Show();
                //this.Hide();
                bill f1 = new bill();
                       this.Hide();
                        f1.Show();
            }
            
            else
            {
                MessageBox.Show("Check your User Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            f1.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
