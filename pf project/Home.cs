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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

    

        private void Cross_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Doctor__Click_1(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void patient__Click_1(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void Diagnosis__Click_1(object sender, EventArgs e)
        {
            diagnosis obj = new diagnosis();
            obj.Show();
            this.Hide();
        }

        private void appointment_btn_Click_1(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            ap.Show();
            this.Hide();
        }

        private void inentory_btn_Click_2(object sender, EventArgs e)
        {
            Inventory obj = new Inventory();
            obj.Show();
            this.Hide();
        }

        private void logout__Click_1(object sender, EventArgs e)
        {
            login login_btn = new login();
            login_btn.Show();
            this.Hide();
        }
    }
}
