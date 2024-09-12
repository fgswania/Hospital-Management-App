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
    public partial class Patient_Appointment : Form
    {
        public Patient_Appointment()
        {
            InitializeComponent();
        }

        private void Cross_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patient_Appointment_Load(object sender, EventArgs e)
        {
            Appointment_grid.ColumnCount = 4;
            Appointment_grid.Columns[0].Name = " PATIENT RECEIPT ID";
            Appointment_grid.Columns[1].Name = " PATIENT NAME";
            Appointment_grid.Columns[2].Name = "DOCTOR NAME";
            Appointment_grid.Columns[3].Name = "SCHEDULE TIME";
            Appointment_grid.Rows.Add(new object[] { "AA01", "Farhan Ahmad", "Dr. Rizwan", "10pm - 11pm" });
            Appointment_grid.Rows.Add(new object[] { "BB01", "Usman Khalid", "Dr. Hadi", "8m - 9pm" });
            Appointment_grid.Rows.Add(new object[] { "CC01", "Talha rizwan", "Dr. Uroosa", "7pm - 8pm " });
        }

        private void Appointment_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            if (text1.Text == "" && text2.Text == "" && text3.Text== "" && text4.Text== "")
            {
                MessageBox.Show("Please enter something! ");
            }
            else
            {
                Appointment_grid.Rows.Add(new object[] { text1.Text, text2.Text, text3.Text, text4.Text });
                MessageBox.Show($"  {text2.Text}'s  appointment has been Scheduled with Dr.{text3.Text}  b/w  {text4.Text} ");
            }
        }

        private void logout__Click(object sender, EventArgs e)
        {

            login login_btn = new login();
            login_btn.Show();
            this.Hide();
        }
    }
}
