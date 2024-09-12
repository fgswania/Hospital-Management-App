
namespace pf_project
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.medlabel = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.Cross_btn = new System.Windows.Forms.Button();
            this.home_btn1 = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.text3 = new System.Windows.Forms.ComboBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.doc_years = new System.Windows.Forms.Label();
            this.doc_name = new System.Windows.Forms.Label();
            this.doc_gen = new System.Windows.Forms.Label();
            this.inventory_grid = new System.Windows.Forms.DataGridView();
            this.title_inventory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.Image = global::pf_project.Properties.Resources.icons8_inventory_64;
            this.pictureBox7.Location = new System.Drawing.Point(6, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(102, 77);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // medlabel
            // 
            this.medlabel.AutoSize = true;
            this.medlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medlabel.Location = new System.Drawing.Point(12, 127);
            this.medlabel.Name = "medlabel";
            this.medlabel.Size = new System.Drawing.Size(174, 25);
            this.medlabel.TabIndex = 43;
            this.medlabel.Text = "Medicine Name";
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.CadetBlue;
            this.text1.Location = new System.Drawing.Point(30, 171);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(146, 20);
            this.text1.TabIndex = 42;
            // 
            // Cross_btn
            // 
            this.Cross_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Cross_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cross_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_btn.ForeColor = System.Drawing.Color.Black;
            this.Cross_btn.Location = new System.Drawing.Point(934, 1);
            this.Cross_btn.Name = "Cross_btn";
            this.Cross_btn.Size = new System.Drawing.Size(52, 32);
            this.Cross_btn.TabIndex = 41;
            this.Cross_btn.Text = "X";
            this.Cross_btn.UseVisualStyleBackColor = false;
            this.Cross_btn.Click += new System.EventHandler(this.Cross_btn_Click);
            // 
            // home_btn1
            // 
            this.home_btn1.BackColor = System.Drawing.Color.CadetBlue;
            this.home_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn1.ForeColor = System.Drawing.Color.Black;
            this.home_btn1.Location = new System.Drawing.Point(829, 424);
            this.home_btn1.Name = "home_btn1";
            this.home_btn1.Size = new System.Drawing.Size(104, 32);
            this.home_btn1.TabIndex = 40;
            this.home_btn1.Text = "HOME";
            this.home_btn1.UseVisualStyleBackColor = false;
            this.home_btn1.Click += new System.EventHandler(this.home_btn1_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(829, 264);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(104, 32);
            this.update_btn.TabIndex = 39;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(829, 321);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 32);
            this.delete_btn.TabIndex = 38;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.Location = new System.Drawing.Point(829, 373);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(104, 32);
            this.reset_btn.TabIndex = 37;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // ADD_btn
            // 
            this.ADD_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.ADD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_btn.ForeColor = System.Drawing.Color.Black;
            this.ADD_btn.Location = new System.Drawing.Point(829, 213);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(104, 32);
            this.ADD_btn.TabIndex = 36;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = false;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.CadetBlue;
            this.text3.FormattingEnabled = true;
            this.text3.Items.AddRange(new object[] {
            "In stock",
            "Out of Stock"});
            this.text3.Location = new System.Drawing.Point(375, 170);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(121, 21);
            this.text3.TabIndex = 35;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.CadetBlue;
            this.text2.Location = new System.Drawing.Point(231, 171);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 34;
            // 
            // text4
            // 
            this.text4.BackColor = System.Drawing.Color.CadetBlue;
            this.text4.Location = new System.Drawing.Point(569, 169);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(129, 20);
            this.text4.TabIndex = 33;
            // 
            // doc_years
            // 
            this.doc_years.AutoSize = true;
            this.doc_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_years.Location = new System.Drawing.Point(564, 127);
            this.doc_years.Name = "doc_years";
            this.doc_years.Size = new System.Drawing.Size(134, 25);
            this.doc_years.TabIndex = 31;
            this.doc_years.Text = "Expiry Date";
            // 
            // doc_name
            // 
            this.doc_name.AutoSize = true;
            this.doc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_name.Location = new System.Drawing.Point(226, 127);
            this.doc_name.Name = "doc_name";
            this.doc_name.Size = new System.Drawing.Size(100, 25);
            this.doc_name.TabIndex = 29;
            this.doc_name.Text = "Quantity";
            // 
            // doc_gen
            // 
            this.doc_gen.AutoSize = true;
            this.doc_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_gen.Location = new System.Drawing.Point(381, 127);
            this.doc_gen.Name = "doc_gen";
            this.doc_gen.Size = new System.Drawing.Size(115, 25);
            this.doc_gen.TabIndex = 28;
            this.doc_gen.Text = "Stockings";
            // 
            // inventory_grid
            // 
            this.inventory_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventory_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.inventory_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_grid.Location = new System.Drawing.Point(1, 243);
            this.inventory_grid.Name = "inventory_grid";
            this.inventory_grid.Size = new System.Drawing.Size(792, 222);
            this.inventory_grid.TabIndex = 50;
            this.inventory_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_grid_CellClick);
            // 
            // title_inventory
            // 
            this.title_inventory.AutoSize = true;
            this.title_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_inventory.Location = new System.Drawing.Point(133, 55);
            this.title_inventory.Name = "title_inventory";
            this.title_inventory.Size = new System.Drawing.Size(163, 29);
            this.title_inventory.TabIndex = 51;
            this.title_inventory.Text = "INVENTORY";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(988, 468);
            this.Controls.Add(this.title_inventory);
            this.Controls.Add(this.inventory_grid);
            this.Controls.Add(this.medlabel);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Cross_btn);
            this.Controls.Add(this.home_btn1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.doc_years);
            this.Controls.Add(this.doc_name);
            this.Controls.Add(this.doc_gen);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label medlabel;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button Cross_btn;
        private System.Windows.Forms.Button home_btn1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.ComboBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.Label doc_years;
        private System.Windows.Forms.Label doc_name;
        private System.Windows.Forms.Label doc_gen;
        private System.Windows.Forms.DataGridView inventory_grid;
        private System.Windows.Forms.Label title_inventory;
    }
}