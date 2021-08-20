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
    public partial class OwnerLogin : Form
    {
        //string cs = ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString;
        public OwnerLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM OwnerReg WHERE Id= " + Convert.ToInt32(textBoxUserId.Text) + "AND Password=" + textBoxPass.Text;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                OwnerHome f1 = new OwnerHome();
                f1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Check your User Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //sajkdbjhasbdhbjadbsh
            //if (textBoxUserId.Text != "" && textBoxPass.Text != "")

            //{





            //    SqlConnection con = new SqlConnection(cs);
            //    string query = "SELECT * FROM Admin WHERE Id=@id and Password=@password";
            //    SqlCommand cmd = new SqlCommand(query, con);




            //    cmd.Parameters.AddWithValue("@id", textBoxUserId.Text);



            //    cmd.Parameters.AddWithValue("@password", textBoxPass.Text);
            //    con.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows == true)
            //    {
            //        MessageBox.Show("LOG IN SUCCESSFUL");
            //        this.Hide();
            //        Home userr = new Home();
            //        userr.Show();




            //    }
            //    else
            //    {
            //        MessageBox.Show("INVALID INFORMATION");

            //    }



            //    con.Close();


            //}

            //private void textBoxPass_TextChanged(object sender, EventArgs e)
            //{

            //}

            //private void buttonBack_Click(object sender, EventArgs e)
            //{
            //    Home f2 = new Home();
            //    f2.Show();
            //    this.Hide();
            //}

            //private void ButtonExit_Click(object sender, EventArgs e)
            ////{
            //Application.Exit();
            //}
            //}
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            f2.Show();
            this.Hide();

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}