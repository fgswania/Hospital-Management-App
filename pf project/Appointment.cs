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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int indexRow;

    




        private void Appointment_Load(object sender, EventArgs e)
        {
            appointment_grid.ColumnCount = 5;
            appointment_grid.Columns[0].Name = " PATIENT ID";
            appointment_grid.Columns[1].Name = " PATIENT NAME";
            appointment_grid.Columns[2].Name = "DOCTOR NAME";
            appointment_grid.Columns[3].Name = "DATE";
            appointment_grid.Columns[4].Name = " CONSULTATION TIME";
            appointment_grid.Rows.Add(new object[] { 1, "Farhan Ahmad", "Dr. Rizwan","20-12-23", "2pm" });
            appointment_grid.Rows.Add(new object[] { 2, "Usman Khalid", "Dr. Hadi", "21-12-23", "3pm" });
            appointment_grid.Rows.Add(new object[] { 3, "Talha rizwan", "Dr. Uroosa", "23-12-23", "5pm" });
            appointment_grid.Rows.Add(new object[] { 4, "Sumaira rizvi","Dr. Maryam ", "24-12-23", "6pm" });
            appointment_grid.Rows.Add(new object[] { 5,"Samra Khanzada","Dr. Sameer ","25-12-23", "8pm" });
        }

        private void Cross_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void home_btn1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            appointment_grid.Rows.Add(new object[] { text1.Text, text2.Text, text3.Text, text4.Text , text5.Text});
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = appointment_grid.Rows[indexRow];
            newDataRow.Cells[0].Value = text1.Text;
            newDataRow.Cells[1].Value = text2.Text;
            newDataRow.Cells[2].Value = text3.Text;
            newDataRow.Cells[3].Value = text4.Text;
            newDataRow.Cells[4].Value = text5.Text;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int rowindex = appointment_grid.CurrentCell.RowIndex;
            appointment_grid.Rows.RemoveAt(rowindex);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
        }

        private void appointment_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = appointment_grid.Rows[indexRow];
            text1.Text = row.Cells[0].Value.ToString();
            text2.Text = row.Cells[1].Value.ToString();
            text3.Text = row.Cells[2].Value.ToString();
            text4.Text = row.Cells[3].Value.ToString();
            text5.Text = row.Cells[4].Value.ToString();
        }

        private void text5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
