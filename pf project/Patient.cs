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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int indexRow;
        private void Patient_Load(object sender, EventArgs e)
        {
            patient_grid.ColumnCount = 8;
            patient_grid.Columns[0].Name = " Patient ID";
            patient_grid.Columns[1].Name = " Patient NAME";
            patient_grid.Columns[2].Name = "Patient ADDRESS";
            patient_grid.Columns[3].Name = "Patient Age";
            patient_grid.Columns[4].Name = "MR no.";
            patient_grid.Columns[5].Name = "Patient Gender";
            patient_grid.Columns[6].Name = "Blood Group";
            patient_grid.Columns[7].Name = "Major Disease";
            patient_grid.Rows.Add(new object[] { 1, "Ali khan", "NNZ", 20, +9233223256, "Male", "A+", "Mouth Cancer"});
            patient_grid.Rows.Add(new object[] { 2, "Ali khan", "NNZ", 20, +9233223256, "Male", "A+", "Mouth Cancer"});
            patient_grid.Rows.Add(new object[] { 3, "Ali khan", "NNZ", 20, +9233223256, "Male", "A+", "Mouth Cancer"});
            patient_grid.Rows.Add(new object[] { 4, "Ali khan", "NNZ", 20, +9233223256, "Male", "A+", "Mouth Cancer"});
         
          }

        private void home_btn1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Cross_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && comboBox1.Text == "" && comboBox2.Text == "" && textBox6.Text == "")
            {
                MessageBox.Show("Please enter something! ");
            }
            else
            {
                patient_grid.Rows.Add(new object[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,textBox5.Text,comboBox1.Text, comboBox2.Text,textBox6.Text
                });
        } 
       
    }

        private void Patient_DoubleClick(object sender, EventArgs e)
        {

        }

        private void patient_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = patient_grid.Rows[indexRow];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            comboBox1.Text = row.Cells[5].Value.ToString();
            comboBox2.Text = row.Cells[6].Value.ToString();
            textBox6.Text = row.Cells[7].Value.ToString();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            int rowindex = patient_grid.CurrentCell.RowIndex;
            patient_grid.Rows.RemoveAt(rowindex);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox6.Text = "";
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = patient_grid.Rows[indexRow];
            newDataRow.Cells[0].Value = textBox1.Text;
            newDataRow.Cells[1].Value = textBox2.Text;
            newDataRow.Cells[2].Value = textBox3.Text;
            newDataRow.Cells[3].Value = textBox4.Text;
            newDataRow.Cells[4].Value = textBox5.Text;
            newDataRow.Cells[5].Value = comboBox1.Text;
            newDataRow.Cells[6].Value = comboBox2.Text;
            newDataRow.Cells[7].Value = textBox6.Text;
        }
    }
}
