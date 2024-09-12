using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pf_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Admin.Text = "";
            Password.Text = "";
        }

        private void Cross_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
           


            if (Admin.Text== "" && Password.Text== "")
            {
                MessageBox.Show("Missing Information");

            }
            else if (Admin.Text== "Admin" && Password.Text == "password")
            {

             
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter the correct Username and Password");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void Admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else if (richTextBox1.Text == "Doctor" && textBox1.Text == "password")
            {


              Patient_Appointment obj = new Patient_Appointment();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter the correct Username and Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
        }
    }
}
