using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using pf_project.Model;
using static System.Net.Mime.MediaTypeNames;
namespace pf_project
{
    public partial class Doctor : Form
    {
       
        ADODoctor _doctors = new ADODoctor();
        public Doctor()
        {
            InitializeComponent();                           


                                                               
}
        DataTable table = new DataTable();
        int indexRow;

        private void Doctor_Load(object sender, EventArgs e)             
        { 

            doctor_grid.ColumnCount = 6;
            doctor_grid.Columns[0].Name = " DOC ID";
            doctor_grid.Columns[1].Name = " DOC NAME";
            doctor_grid.Columns[2].Name = "DOC GENDER";
            doctor_grid.Columns[3].Name = "YEARS OF EXPERIENCE ";
            doctor_grid.Columns[4].Name = " MEDICAL LICENSE NO";
            doctor_grid.Columns[5].Name = "DOCTOR TIMINGS";
                                                     
            doctor_grid.Rows.Add(new object[] { 1, " Dr. Farhan Ahmad", "MALE", 3.5, 1001, "2 pm to 9 pm" });  
            doctor_grid.Rows.Add(new object[] { 2, "Dr. Usman Khalid", "MALE", 4, 1002 , "3 pm to 10 pm"});  
            doctor_grid.Rows.Add(new object[] { 3, "Dr. Talha rizwan", "MALE", 2, 1003 , "4 pm to 11 pm" });  
            doctor_grid.Rows.Add(new object[] { 4, "Dr. Sumaira rizvi", "Female", 3,  1004 , "5 pm to 8 pm" });    
            doctor_grid.Rows.Add(new object[] { 5, "Dr. Samra Khanzada", "Female", 3.5, 1005 , "3 pm to 9 pm"});    

                                                           
                                                              
        }
        private void label5_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var _data = _doctors.GetAllData();

            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            if (docbox_1.Text == "" && Docbox_2.Text == "" && Doccombo_3.Text == "" && Docbox_4.Text == "" )
            {
                MessageBox.Show("Please enter something! ");
            }
            else
            {
                doctor_grid.Rows.Add(new object[] { docbox_1.Text, Docbox_2.Text, Doccombo_3.Text, Docbox_4.Text, Docbox_5.Text , Docbox_6.Text
    });
            }
        }
       

        private void update_btn_Click(object sender, EventArgs e)
    {
            DataGridViewRow newDataRow = doctor_grid.Rows[indexRow];
            newDataRow.Cells[0].Value = docbox_1.Text;
            newDataRow.Cells[1].Value = Docbox_2.Text;
            newDataRow.Cells[2].Value = Doccombo_3.Text;  
            newDataRow.Cells[3].Value = Docbox_4.Text; 
            newDataRow.Cells[4].Value = Docbox_5.Text;
            newDataRow.Cells[5].Value = Docbox_6.Text; 
          

        }

        private void doctor_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void doctor_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = doctor_grid.Rows[indexRow];
            docbox_1.Text = row.Cells[0].Value.ToString();
            Docbox_2.Text = row.Cells[1].Value.ToString();
            Doccombo_3.Text = row.Cells[2].Value.ToString();
            Docbox_4.Text = row.Cells[3].Value.ToString();
            Docbox_5.Text = row.Cells[4].Value.ToString();
            Docbox_6.Text = row.Cells[5].Value.ToString();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int rowindex = doctor_grid.CurrentCell.RowIndex;
            doctor_grid.Rows.RemoveAt(rowindex);
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            docbox_1.Text = "";
            Docbox_2.Text = "";
            Doccombo_3.Text = "";
            Docbox_4.Text = "";
            Docbox_5.Text = "";
            Docbox_6.Text = "";

        }
    }
}
