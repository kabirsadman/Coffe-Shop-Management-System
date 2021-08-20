using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void butOwner_Click(object sender, EventArgs e)
        {
            OwnerLogin mynewfrom = new OwnerLogin();

            mynewfrom.Show();
            this.Hide();
        }

        private void butEmp_Click(object sender, EventArgs e)
        {
            EmployeeLogin mynewfrom2 = new EmployeeLogin();

            mynewfrom2.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OwnerReg ow = new OwnerReg();
            ow.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
