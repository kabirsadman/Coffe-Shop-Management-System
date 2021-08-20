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
    public partial class OwnerReg : Form
    {
        public OwnerReg()
        {
            InitializeComponent();
        }

        private void OwnerReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void termsCheckBox_Click(object sender, EventArgs e)
        {
            if(submitButton.Enabled==false)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name can not be empty");

            }
            else if (Idfield.Text == "")
            {
                MessageBox.Show("Id can not be empty");
            }
            else if (EmailTextBox.Text == "")
            {
                MessageBox.Show("Give an Email");
            }
            else if (DateOfBirthdateTimePicker.Text == "")
            {
                MessageBox.Show("Date can not be empty");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a Gender");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password does not match");
                }
                else
                {
                    string name, email, dateOfBirth, gender, password,id;
                    //User user = new User();
                    name = nameTextBox.Text;
                    email = EmailTextBox.Text;
                    dateOfBirth = DateOfBirthdateTimePicker.Text;
                    password = passwordTextBox.Text;
                    id = Idfield.Text;
                    if (maleRadioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
                    connection.Open();
                    string sql = "INSERT INTO OwnerReg(Id,Name,Email,DateOfBirth,Gender,Password) VALUES('"+id+"','" + name + "','" + email + "','" + dateOfBirth + "','" + gender + "','" + password + "')";
                    //Now we will call a method in order to execute the query
                    SqlCommand command = new SqlCommand(sql, connection); //sql is just a string variable,it is not a query or sql command.So we need to build a sql command

                    int result = command.ExecuteNonQuery(); //ExecuteNonQuery returns the number of row affected
                    if (result > 0)
                    {

                        MessageBox.Show("Information Added");
                        Home ho = new Home();
                        ho.Show();
                        this.Hide();



                    }
                    else
                    {
                        MessageBox.Show("Error in Adding");
                    }

                    //OwnerHome ow = new OwnerHome();
                    //ow.Show();
                    //this.Hide();

                }
            }
        }
        //    else
        //    {
        //        string name, email, dateOfBirth, gender;
        //        name = nameTextBox.Text;
        //        email = EmailTextBox.Text;
        //        dateOfBirth = DateOfBirthdateTimePicker.Text;
        //        if(maleRadioButton.Checked)
        //        {
        //            gender = "Male";
        //        }
        //        else
        //        {
        //            gender = "Female";
        //        }
        //        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test_Demo"].ConnectionString);
        //        connection.Open();
        //        string sql = "INSERT INTO OwnerReg(Name,Email,DateOfBirth,Gender) VALUES('"+name+"','"+email+"','"+dateOfBirth+"','"+gender+"')";
        //        //Now we will call a method in order to execute the query
        //        SqlCommand command = new SqlCommand(sql, connection); //sql is just a string variable,it is not a query or sql command.So we need to build a sql command
        //        int result = command.ExecuteNonQuery(); //ExecuteNonQuery returns the number of row affected
        //        if(result>0)
        //        {
        //            MessageBox.Show("Information Added");
        //            Home home = new Home();
        //            home.Show();
        //            this.Hide();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error in Adding");
        //        }

        //        //OwnerHome ow = new OwnerHome();
        //        //ow.Show();
        //        //this.Hide();

        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            ho.Show();
            this.Hide();
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
