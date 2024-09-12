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
    public partial class diagnosis : Form
    {
        public diagnosis()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        int indexRow;

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

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            diagnosis_grid.ColumnCount = 7;
            diagnosis_grid.Columns[0].Name = " Diagnosis ID";
            diagnosis_grid.Columns[1].Name = " Patient ID";
            diagnosis_grid.Columns[2].Name = " Patient Name";
            diagnosis_grid.Columns[3].Name = "Patient Symptoms";
            diagnosis_grid.Columns[4].Name = "Diagnosis Test";
            diagnosis_grid.Columns[5].Name = "Medicines";
            diagnosis_grid.Columns[6].Name = "Disease Name";
            diagnosis_grid.Rows.Add(new object[] {1001 , 1 , "Ali khan", "fever, headache, Rash, Sore throat", "AT, NATs", "Integrase Inhibitor","AIDs"});
            diagnosis_grid.Rows.Add(new object[] { 1002 , 2 , "Usama Shehzad", "Fever Fatigue, Loss Of Appetite", "Blood test, Liver ultrasound", "Enticavir, Sofosbuvir", "Hepaptitis" });
            diagnosis_grid.Rows.Add(new object[] { 1003 , 3 ,  "Nabeel Shakeel", "High pulpation, High Body temperature", " - ", "Paracetamol" , "fever" });
            diagnosis_grid.Rows.Add(new object[] { 1004 , 4 , "Mahnoor", "Heavy breathlessness,Persistant Cough", "IgE", "terbutaline","Asthma" });
        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            diagnosis_grid.Rows.Add(new object[] { textBox_1.Text, textBox_2.Text, textBox_3.Text, textBox_4.Text, textBox_5.Text, textBox_6.Text ,textbox_7.Text });
        }

        private void diagnosis_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = diagnosis_grid.Rows[indexRow];
            textBox_1.Text = row.Cells[0].Value.ToString();
            textBox_2.Text = row.Cells[1].Value.ToString();
            textBox_3.Text = row.Cells[2].Value.ToString();
            textBox_4.Text = row.Cells[3].Value.ToString();
            textBox_5.Text = row.Cells[4].Value.ToString();
            textBox_6.Text = row.Cells[5].Value.ToString();
            textbox_7.Text = row.Cells[6].Value.ToString();

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = diagnosis_grid.Rows[indexRow];
            newDataRow.Cells[0].Value = textBox_1.Text;
            newDataRow.Cells[1].Value = textBox_2.Text;
            newDataRow.Cells[2].Value = textBox_3.Text;
            newDataRow.Cells[3].Value = textBox_4.Text;
            newDataRow.Cells[4].Value = textBox_5.Text;
            newDataRow.Cells[5].Value = textBox_6.Text;
            newDataRow.Cells[6].Value = textbox_7.Text;

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int rowindex = diagnosis_grid.CurrentCell.RowIndex;
            diagnosis_grid.Rows.RemoveAt(rowindex);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            textBox_1.Text = "";
            textBox_2.Text = "";
            textBox_3.Text = "";
            textBox_4.Text = "";
            textBox_5.Text = "";
            textBox_6.Text = "";
            textbox_7.Text = "";
        }

        private void medicines_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void title_diagnosis_Click(object sender, EventArgs e)
        {

        }
    }
}
