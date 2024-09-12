
namespace pf_project
{
    partial class Doctor
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
            this.title = new System.Windows.Forms.Label();
            this.doc_gen = new System.Windows.Forms.Label();
            this.doc_name = new System.Windows.Forms.Label();
            this.doc_license = new System.Windows.Forms.Label();
            this.doc_years = new System.Windows.Forms.Label();
            this.Docbox_2 = new System.Windows.Forms.TextBox();
            this.Docbox_4 = new System.Windows.Forms.TextBox();
            this.Docbox_5 = new System.Windows.Forms.TextBox();
            this.Doccombo_3 = new System.Windows.Forms.ComboBox();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.home_btn1 = new System.Windows.Forms.Button();
            this.Cross_btn = new System.Windows.Forms.Button();
            this.doctor_grid = new System.Windows.Forms.DataGridView();
            this.docbox_1 = new System.Windows.Forms.TextBox();
            this.doc_id_label = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Docbox_6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(107, 48);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 29);
            this.title.TabIndex = 6;
            this.title.Text = "Doctor";
            // 
            // doc_gen
            // 
            this.doc_gen.AutoSize = true;
            this.doc_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_gen.Location = new System.Drawing.Point(285, 126);
            this.doc_gen.Name = "doc_gen";
            this.doc_gen.Size = new System.Drawing.Size(165, 25);
            this.doc_gen.TabIndex = 7;
            this.doc_gen.Text = "Doctor Gender";
            // 
            // doc_name
            // 
            this.doc_name.AutoSize = true;
            this.doc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_name.Location = new System.Drawing.Point(128, 126);
            this.doc_name.Name = "doc_name";
            this.doc_name.Size = new System.Drawing.Size(148, 25);
            this.doc_name.TabIndex = 8;
            this.doc_name.Text = "Doctor Name";
            // 
            // doc_license
            // 
            this.doc_license.AutoSize = true;
            this.doc_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_license.Location = new System.Drawing.Point(696, 126);
            this.doc_license.Name = "doc_license";
            this.doc_license.Size = new System.Drawing.Size(219, 25);
            this.doc_license.TabIndex = 10;
            this.doc_license.Text = "Medical License No";
            // 
            // doc_years
            // 
            this.doc_years.AutoSize = true;
            this.doc_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_years.Location = new System.Drawing.Point(456, 126);
            this.doc_years.Name = "doc_years";
            this.doc_years.Size = new System.Drawing.Size(230, 25);
            this.doc_years.TabIndex = 11;
            this.doc_years.Text = "Years Of Experience";
            this.doc_years.Click += new System.EventHandler(this.label5_Click);
            // 
            // Docbox_2
            // 
            this.Docbox_2.BackColor = System.Drawing.Color.CadetBlue;
            this.Docbox_2.Location = new System.Drawing.Point(150, 169);
            this.Docbox_2.Name = "Docbox_2";
            this.Docbox_2.Size = new System.Drawing.Size(100, 20);
            this.Docbox_2.TabIndex = 16;
            // 
            // Docbox_4
            // 
            this.Docbox_4.BackColor = System.Drawing.Color.CadetBlue;
            this.Docbox_4.Location = new System.Drawing.Point(504, 169);
            this.Docbox_4.Name = "Docbox_4";
            this.Docbox_4.Size = new System.Drawing.Size(130, 20);
            this.Docbox_4.TabIndex = 14;
            // 
            // Docbox_5
            // 
            this.Docbox_5.BackColor = System.Drawing.Color.CadetBlue;
            this.Docbox_5.Location = new System.Drawing.Point(758, 168);
            this.Docbox_5.Name = "Docbox_5";
            this.Docbox_5.Size = new System.Drawing.Size(100, 20);
            this.Docbox_5.TabIndex = 13;
            // 
            // Doccombo_3
            // 
            this.Doccombo_3.BackColor = System.Drawing.Color.CadetBlue;
            this.Doccombo_3.FormattingEnabled = true;
            this.Doccombo_3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Doccombo_3.Location = new System.Drawing.Point(307, 168);
            this.Doccombo_3.Name = "Doccombo_3";
            this.Doccombo_3.Size = new System.Drawing.Size(121, 21);
            this.Doccombo_3.TabIndex = 17;
            // 
            // ADD_btn
            // 
            this.ADD_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.ADD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_btn.ForeColor = System.Drawing.Color.Black;
            this.ADD_btn.Location = new System.Drawing.Point(63, 489);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(104, 32);
            this.ADD_btn.TabIndex = 19;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = false;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.Location = new System.Drawing.Point(530, 489);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(104, 32);
            this.reset_btn.TabIndex = 20;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(381, 489);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 32);
            this.delete_btn.TabIndex = 21;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(229, 489);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(104, 32);
            this.update_btn.TabIndex = 22;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // home_btn1
            // 
            this.home_btn1.BackColor = System.Drawing.Color.CadetBlue;
            this.home_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn1.ForeColor = System.Drawing.Color.Black;
            this.home_btn1.Location = new System.Drawing.Point(675, 489);
            this.home_btn1.Name = "home_btn1";
            this.home_btn1.Size = new System.Drawing.Size(104, 32);
            this.home_btn1.TabIndex = 23;
            this.home_btn1.Text = "HOME";
            this.home_btn1.UseVisualStyleBackColor = false;
            this.home_btn1.Click += new System.EventHandler(this.home_btn1_Click);
            // 
            // Cross_btn
            // 
            this.Cross_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Cross_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cross_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_btn.ForeColor = System.Drawing.Color.Black;
            this.Cross_btn.Location = new System.Drawing.Point(967, 0);
            this.Cross_btn.Name = "Cross_btn";
            this.Cross_btn.Size = new System.Drawing.Size(52, 32);
            this.Cross_btn.TabIndex = 24;
            this.Cross_btn.Text = "X";
            this.Cross_btn.UseVisualStyleBackColor = false;
            this.Cross_btn.Click += new System.EventHandler(this.Cross_btn_Click);
            // 
            // doctor_grid
            // 
            this.doctor_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctor_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.doctor_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.doctor_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.doctor_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_grid.GridColor = System.Drawing.Color.White;
            this.doctor_grid.Location = new System.Drawing.Point(19, 257);
            this.doctor_grid.Name = "doctor_grid";
            this.doctor_grid.Size = new System.Drawing.Size(973, 214);
            this.doctor_grid.TabIndex = 25;
            this.doctor_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctor_grid_CellClick);
            this.doctor_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.doctor_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctor_grid_CellDoubleClick);
            // 
            // docbox_1
            // 
            this.docbox_1.BackColor = System.Drawing.Color.CadetBlue;
            this.docbox_1.Location = new System.Drawing.Point(19, 169);
            this.docbox_1.Name = "docbox_1";
            this.docbox_1.Size = new System.Drawing.Size(100, 20);
            this.docbox_1.TabIndex = 26;
            // 
            // doc_id_label
            // 
            this.doc_id_label.AutoSize = true;
            this.doc_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_id_label.Location = new System.Drawing.Point(7, 126);
            this.doc_id_label.Name = "doc_id_label";
            this.doc_id_label.Size = new System.Drawing.Size(110, 25);
            this.doc_id_label.TabIndex = 27;
            this.doc_id_label.Text = "Doctor ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::pf_project.Properties.Resources._4041815_doctor_health_hospital_man_medic_icon;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Doctor Timings";
            // 
            // Docbox_6
            // 
            this.Docbox_6.BackColor = System.Drawing.Color.CadetBlue;
            this.Docbox_6.Location = new System.Drawing.Point(219, 215);
            this.Docbox_6.Name = "Docbox_6";
            this.Docbox_6.Size = new System.Drawing.Size(150, 20);
            this.Docbox_6.TabIndex = 29;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1019, 538);
            this.Controls.Add(this.Docbox_6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doc_id_label);
            this.Controls.Add(this.docbox_1);
            this.Controls.Add(this.doctor_grid);
            this.Controls.Add(this.Cross_btn);
            this.Controls.Add(this.home_btn1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.Doccombo_3);
            this.Controls.Add(this.Docbox_2);
            this.Controls.Add(this.Docbox_4);
            this.Controls.Add(this.Docbox_5);
            this.Controls.Add(this.doc_years);
            this.Controls.Add(this.doc_license);
            this.Controls.Add(this.doc_name);
            this.Controls.Add(this.doc_gen);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctor_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label doc_gen;
        private System.Windows.Forms.Label doc_name;
        private System.Windows.Forms.Label doc_license;
        private System.Windows.Forms.Label doc_years;
        private System.Windows.Forms.TextBox Docbox_2;
        private System.Windows.Forms.TextBox Docbox_4;
        private System.Windows.Forms.TextBox Docbox_5;
        private System.Windows.Forms.ComboBox Doccombo_3;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button home_btn1;
        private System.Windows.Forms.Button Cross_btn;
        private System.Windows.Forms.DataGridView doctor_grid;
        private System.Windows.Forms.TextBox docbox_1;
        private System.Windows.Forms.Label doc_id_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Docbox_6;
    }
}