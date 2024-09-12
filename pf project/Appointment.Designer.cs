
namespace pf_project
{
    partial class Appointment
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.doc_id_label = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.Cross_btn = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.text5 = new System.Windows.Forms.TextBox();
            this.doc_years = new System.Windows.Forms.Label();
            this.doc_license = new System.Windows.Forms.Label();
            this.doc_name = new System.Windows.Forms.Label();
            this.doc_gen = new System.Windows.Forms.Label();
            this.home_btn1 = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.appointment_grid = new System.Windows.Forms.DataGridView();
            this.title_appointment = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::pf_project.Properties.Resources.icons8_appointment_100;
            this.pictureBox6.Location = new System.Drawing.Point(9, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(102, 77);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // doc_id_label
            // 
            this.doc_id_label.AutoSize = true;
            this.doc_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_id_label.Location = new System.Drawing.Point(74, 115);
            this.doc_id_label.Name = "doc_id_label";
            this.doc_id_label.Size = new System.Drawing.Size(115, 25);
            this.doc_id_label.TabIndex = 43;
            this.doc_id_label.Text = "Patient ID";
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.CadetBlue;
            this.text1.Location = new System.Drawing.Point(78, 187);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 42;
            // 
            // Cross_btn
            // 
            this.Cross_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Cross_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cross_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_btn.ForeColor = System.Drawing.Color.Black;
            this.Cross_btn.Location = new System.Drawing.Point(938, 2);
            this.Cross_btn.Name = "Cross_btn";
            this.Cross_btn.Size = new System.Drawing.Size(52, 32);
            this.Cross_btn.TabIndex = 41;
            this.Cross_btn.Text = "X";
            this.Cross_btn.UseVisualStyleBackColor = false;
            this.Cross_btn.Click += new System.EventHandler(this.Cross_btn_Click);
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.CadetBlue;
            this.text2.Location = new System.Drawing.Point(229, 187);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 34;
            // 
            // text4
            // 
            this.text4.BackColor = System.Drawing.Color.CadetBlue;
            this.text4.Location = new System.Drawing.Point(567, 186);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(100, 20);
            this.text4.TabIndex = 33;
            // 
            // text5
            // 
            this.text5.BackColor = System.Drawing.Color.CadetBlue;
            this.text5.Location = new System.Drawing.Point(722, 186);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(169, 20);
            this.text5.TabIndex = 32;
            this.text5.TextChanged += new System.EventHandler(this.text5_TextChanged);
            // 
            // doc_years
            // 
            this.doc_years.AutoSize = true;
            this.doc_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_years.Location = new System.Drawing.Point(583, 115);
            this.doc_years.Name = "doc_years";
            this.doc_years.Size = new System.Drawing.Size(61, 25);
            this.doc_years.TabIndex = 31;
            this.doc_years.Text = "Date";
            // 
            // doc_license
            // 
            this.doc_license.AutoSize = true;
            this.doc_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_license.Location = new System.Drawing.Point(699, 115);
            this.doc_license.Name = "doc_license";
            this.doc_license.Size = new System.Drawing.Size(196, 25);
            this.doc_license.TabIndex = 30;
            this.doc_license.Text = "Consultated Time";
            // 
            // doc_name
            // 
            this.doc_name.AutoSize = true;
            this.doc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_name.Location = new System.Drawing.Point(209, 115);
            this.doc_name.Name = "doc_name";
            this.doc_name.Size = new System.Drawing.Size(153, 25);
            this.doc_name.TabIndex = 29;
            this.doc_name.Text = "Patient Name";
            // 
            // doc_gen
            // 
            this.doc_gen.AutoSize = true;
            this.doc_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_gen.Location = new System.Drawing.Point(391, 115);
            this.doc_gen.Name = "doc_gen";
            this.doc_gen.Size = new System.Drawing.Size(148, 25);
            this.doc_gen.TabIndex = 28;
            this.doc_gen.Text = "Doctor Name";
            // 
            // home_btn1
            // 
            this.home_btn1.BackColor = System.Drawing.Color.CadetBlue;
            this.home_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn1.ForeColor = System.Drawing.Color.Black;
            this.home_btn1.Location = new System.Drawing.Point(827, 440);
            this.home_btn1.Name = "home_btn1";
            this.home_btn1.Size = new System.Drawing.Size(104, 32);
            this.home_btn1.TabIndex = 48;
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
            this.update_btn.Location = new System.Drawing.Point(827, 280);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(104, 32);
            this.update_btn.TabIndex = 47;
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
            this.delete_btn.Location = new System.Drawing.Point(827, 337);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 32);
            this.delete_btn.TabIndex = 46;
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
            this.reset_btn.Location = new System.Drawing.Point(827, 389);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(104, 32);
            this.reset_btn.TabIndex = 45;
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
            this.ADD_btn.Location = new System.Drawing.Point(827, 229);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(104, 32);
            this.ADD_btn.TabIndex = 44;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = false;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // appointment_grid
            // 
            this.appointment_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointment_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.appointment_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointment_grid.Location = new System.Drawing.Point(1, 256);
            this.appointment_grid.Name = "appointment_grid";
            this.appointment_grid.Size = new System.Drawing.Size(773, 227);
            this.appointment_grid.TabIndex = 49;
            this.appointment_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointment_grid_CellClick);
            // 
            // title_appointment
            // 
            this.title_appointment.AutoSize = true;
            this.title_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_appointment.Location = new System.Drawing.Point(141, 57);
            this.title_appointment.Name = "title_appointment";
            this.title_appointment.Size = new System.Drawing.Size(321, 29);
            this.title_appointment.TabIndex = 50;
            this.title_appointment.Text = "APPOINTMENT HISTORY";
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.CadetBlue;
            this.text3.Location = new System.Drawing.Point(414, 186);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(100, 20);
            this.text3.TabIndex = 51;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(994, 484);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.title_appointment);
            this.Controls.Add(this.appointment_grid);
            this.Controls.Add(this.home_btn1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.doc_id_label);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Cross_btn);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.doc_years);
            this.Controls.Add(this.doc_license);
            this.Controls.Add(this.doc_name);
            this.Controls.Add(this.doc_gen);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label doc_id_label;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button Cross_btn;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.Label doc_years;
        private System.Windows.Forms.Label doc_license;
        private System.Windows.Forms.Label doc_name;
        private System.Windows.Forms.Label doc_gen;
        private System.Windows.Forms.Button home_btn1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.DataGridView appointment_grid;
        private System.Windows.Forms.Label title_appointment;
        private System.Windows.Forms.TextBox text3;
    }
}