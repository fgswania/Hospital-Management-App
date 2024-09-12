using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pf_project
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        int indexRow;

        private void Inventory_Load(object sender, EventArgs e)
        {
            inventory_grid.ColumnCount = 4;
            inventory_grid.Columns[0].Name = "Medicine Name";
            inventory_grid.Columns[1].Name = "Quantity";
            inventory_grid.Columns[2].Name = "Stockings";
            inventory_grid.Columns[3].Name = "Expiry Date";
            inventory_grid.Rows.Add(new object[] {  "Ativan", "5000", "In stock", "21-12-23"   });
            inventory_grid.Rows.Add(new object[] { "Atorvastatin", "4000", "In stock"  ,  "21-12-23"  });
            inventory_grid.Rows.Add(new object[] {  "Adderall", "200","In stock",  "23-12-23"  });
            inventory_grid.Rows.Add(new object[] {  "Amlodipine", "500",  "In stock", "24-12-23"  });
            inventory_grid.Rows.Add(new object[] { "Amoxicillin", "0",  "Out of Stock" ,"25-12-23" });
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
            if (text1.Text == "" && text2.Text == "" && text3.Text == "" && text4.Text == "")
            {
                MessageBox.Show("Please enter something! ");
            }
            else
            {
                inventory_grid.Rows.Add(new object[] { text1.Text, text2.Text, text3.Text, text4.Text
    });
            }
        }
        private void update_btn_Click(object sender, EventArgs e)
    {
        DataGridViewRow newDataRow = inventory_grid.Rows[indexRow];
        newDataRow.Cells[0].Value = text1.Text;
        newDataRow.Cells[1].Value = text2.Text;
        newDataRow.Cells[2].Value = text3.Text;
        newDataRow.Cells[3].Value = text4.Text;
    }
    private void delete_btn_Click(object sender, EventArgs e)
    {
        int rowindex = inventory_grid.CurrentCell.RowIndex;
        inventory_grid.Rows.RemoveAt(rowindex);
    }
    private void reset_btn_Click(object sender, EventArgs e)
    {
        text1.Text = "";
        text2.Text = "";
        text3.Text = "";
        text4.Text = "";
    }
    private void inventory_grid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        indexRow = e.RowIndex;
        DataGridViewRow row = inventory_grid.Rows[indexRow];
            text1.Text = row.Cells[0].Value.ToString();
            text2.Text = row.Cells[1].Value.ToString();
            text3.Text = row.Cells[2].Value.ToString();
            text4.Text = row.Cells[3].Value.ToString();
        }
    }
}
