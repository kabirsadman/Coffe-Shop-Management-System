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
    public partial class EmployeeDetails : Form
    {

        public EmployeeDetails()
        {
            InitializeComponent();
        }
        
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-03VU7SV\SQLEXPRESS;Initial Catalog=Coffe_Shop_Management;Integrated Security=True");
        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            GetEmployeeRecord();
        }

        private void GetEmployeeRecord()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("Select * from Employee", connection);
            DataTable dt = new DataTable();


            SqlDataReader Sdr = cmd.ExecuteReader(); 
            dt.Load(Sdr);
            connection.Close();

            EmployeedataGridView.DataSource = dt;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
           // if (isValid())
          // {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
                connection.Open();
                string sql = "INSERT INTO Employee(Id,name,Gender,dob,address,PhoneNo,password) VALUES('" + Convert.ToInt32(textId.Text) + "','" + textName.Text + "','" + comboGender.Text + "','" + dateTimeDob.Text + "','" + textAddres.Text + "','" + Convert.ToInt32(textPhn.Text) + "','" + textPass.Text + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
             //SqlCommand cmd = new SqlCommand("INSERT INTO Employee(Id,name,Gender,dob,address,PhoneNo,password) VALUES('" + Convert.ToInt32(textId.Text) + "','" + textName.Text + "','" + comboGender.Text + "','" + dateTimeDob.Text + "','" + textAddres.Text + "','" + Convert.ToInt32(textPhn.Text) + "','" + textPass.Text + "')");
            if (result>0)
                {
                    MessageBox.Show("User Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                //SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES (@Id, @name, @Gender, @dob, @address, @PhoneNo, @password)", con);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@Id", textId.Text);
                //cmd.Parameters.AddWithValue("@name", textName.Text);
                //cmd.Parameters.AddWithValue("@Gender", comboGender.Text);
                //cmd.Parameters.AddWithValue("@dob", dateTimeDob.Text);
                //cmd.Parameters.AddWithValue("@address", textAddres.Text);
                //cmd.Parameters.AddWithValue("@PhoneNo", textPhn.Text);
                //cmd.Parameters.AddWithValue("@password", textPass.Text);

                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();

                //MessageBox.Show("New Employee are Successfully saved in the Database","Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeRecord();
                ResetFormControls();
            //}
        }

        private bool isValid()
        {
            if(textName.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            OwnerHome f1 = new OwnerHome();
            f1.Show();
            this.Hide();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            textId.Clear();
            textName.Clear();
            comboGender.Text = "";
            textAddres.Clear();
            textPhn.Clear();
            textPass.Clear();
            dateTimeDob.Clear();
            textId.Focus();
        }
        //GridView selecting then data sending to the text field start
        private void EmployeedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = EmployeedataGridView.SelectedRows[0].Cells[0].Value.ToString();
            textName.Text = EmployeedataGridView.SelectedRows[0].Cells[1].Value.ToString();
            comboGender.Text = EmployeedataGridView.SelectedRows[0].Cells[2].Value.ToString();
            dateTimeDob.Text = EmployeedataGridView.SelectedRows[0].Cells[3].Value.ToString();
            textAddres.Text = EmployeedataGridView.SelectedRows[0].Cells[4].Value.ToString();
            textPhn.Text = EmployeedataGridView.SelectedRows[0].Cells[5].Value.ToString();
            textPass.Text = EmployeedataGridView.SelectedRows[0].Cells[6].Value.ToString();

        }
        //End

        private void buttonUpate_Click(object sender, EventArgs e)
        {
            if(textId.Text != "")
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
                //connection.Open();

                //SqlCommand cmd = new SqlCommand("UPDATE Employee SET Id="+Convert.ToInt32(textId.Text)+", name="+textName.Text+", Gender="+comboGender.Text+", dob="+dateTimeDob.Text+", address="+textAddres+", PhoneNo="+Convert.ToInt32(textPhn.Text)+", password="+textPass.Text+" WHERE Id ="+Convert.ToInt32(textId.Text), connection);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@Id", textId.Text);
                //cmd.Parameters.AddWithValue("@name", textName.Text);
                //cmd.Parameters.AddWithValue("@Gender", comboGender.Text);
                //cmd.Parameters.AddWithValue("@dob", dateTimeDob.Text);
                //cmd.Parameters.AddWithValue("@address", textAddres.Text);
                //cmd.Parameters.AddWithValue("@PhoneNo", textPhn.Text);
                //cmd.Parameters.AddWithValue("@password", textPass.Text);


                ////con.Open();
                //cmd.ExecuteNonQuery();
                //connection.Close();

                //MessageBox.Show("Employee Information is Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //GetEmployeeRecord();
                //ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select a Employee to Update his information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textId.Text != "")
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Id ="+Convert.ToInt32(textId.Text), connection);
                //cmd.CommandType = CommandType.Text;
                ///cmd.Parameters.AddWithValue("@Id", textId.Text);


                //con.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Employee is Deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select a Employee to Delete his information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
