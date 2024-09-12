
namespace pf_project
{
    partial class Patient_Appointment
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
            this.Cross_btn = new System.Windows.Forms.Button();
            this.logout_ = new System.Windows.Forms.Button();
            this.Appointment_grid = new System.Windows.Forms.DataGridView();
            this.title_appointment = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.doc_id_label = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.doc_years = new System.Windows.Forms.Label();
            this.doc_name = new System.Windows.Forms.Label();
            this.doc_gen = new System.Windows.Forms.Label();
            this.ADD_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Appointment_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Cross_btn
            // 
            this.Cross_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Cross_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cross_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_btn.ForeColor = System.Drawing.Color.Black;
            this.Cross_btn.Location = new System.Drawing.Point(763, 0);
            this.Cross_btn.Name = "Cross_btn";
            this.Cross_btn.Size = new System.Drawing.Size(52, 32);
            this.Cross_btn.TabIndex = 38;
            this.Cross_btn.Text = "X";
            this.Cross_btn.UseVisualStyleBackColor = false;
            this.Cross_btn.Click += new System.EventHandler(this.Cross_btn_Click);
            // 
            // logout_
            // 
            this.logout_.BackColor = System.Drawing.Color.CadetBlue;
            this.logout_.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_.ForeColor = System.Drawing.Color.Black;
            this.logout_.Location = new System.Drawing.Point(640, 269);
            this.logout_.Name = "logout_";
            this.logout_.Size = new System.Drawing.Size(163, 44);
            this.logout_.TabIndex = 92;
            this.logout_.Text = " BACK TO LOGIN";
            this.logout_.UseVisualStyleBackColor = false;
            this.logout_.Click += new System.EventHandler(this.logout__Click);
            // 
            // Appointment_grid
            // 
            this.Appointment_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.Appointment_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointment_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Appointment_grid.Location = new System.Drawing.Point(0, 319);
            this.Appointment_grid.Name = "Appointment_grid";
            this.Appointment_grid.Size = new System.Drawing.Size(815, 131);
            this.Appointment_grid.TabIndex = 93;
            this.Appointment_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Appointment_grid_CellContentClick);
            // 
            // title_appointment
            // 
            this.title_appointment.AutoSize = true;
            this.title_appointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_appointment.Location = new System.Drawing.Point(115, 51);
            this.title_appointment.Name = "title_appointment";
            this.title_appointment.Size = new System.Drawing.Size(386, 29);
            this.title_appointment.TabIndex = 95;
            this.title_appointment.Text = " APPOINTMENT SCHEDULING ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::pf_project.Properties.Resources.icons8_appointment_100;
            this.pictureBox6.Location = new System.Drawing.Point(2, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(102, 77);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 94;
            this.pictureBox6.TabStop = false;
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.CadetBlue;
            this.text3.Location = new System.Drawing.Point(414, 149);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(118, 20);
            this.text3.TabIndex = 103;
            // 
            // doc_id_label
            // 
            this.doc_id_label.AutoSize = true;
            this.doc_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_id_label.Location = new System.Drawing.Point(15, 110);
            this.doc_id_label.Name = "doc_id_label";
            this.doc_id_label.Size = new System.Drawing.Size(194, 25);
            this.doc_id_label.TabIndex = 102;
            this.doc_id_label.Text = "Patient receipt ID";
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.CadetBlue;
            this.text1.Location = new System.Drawing.Point(35, 149);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(141, 20);
            this.text1.TabIndex = 101;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.CadetBlue;
            this.text2.Location = new System.Drawing.Point(231, 149);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(130, 20);
            this.text2.TabIndex = 100;
            // 
            // text4
            // 
            this.text4.BackColor = System.Drawing.Color.CadetBlue;
            this.text4.Location = new System.Drawing.Point(604, 149);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(118, 20);
            this.text4.TabIndex = 99;
            // 
            // doc_years
            // 
            this.doc_years.AutoSize = true;
            this.doc_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_years.Location = new System.Drawing.Point(577, 109);
            this.doc_years.Name = "doc_years";
            this.doc_years.Size = new System.Drawing.Size(168, 25);
            this.doc_years.TabIndex = 98;
            this.doc_years.Text = "Schedule Time";
            // 
            // doc_name
            // 
            this.doc_name.AutoSize = true;
            this.doc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_name.Location = new System.Drawing.Point(221, 110);
            this.doc_name.Name = "doc_name";
            this.doc_name.Size = new System.Drawing.Size(153, 25);
            this.doc_name.TabIndex = 97;
            this.doc_name.Text = "Patient Name";
            // 
            // doc_gen
            // 
            this.doc_gen.AutoSize = true;
            this.doc_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_gen.Location = new System.Drawing.Point(403, 110);
            this.doc_gen.Name = "doc_gen";
            this.doc_gen.Size = new System.Drawing.Size(148, 25);
            this.doc_gen.TabIndex = 96;
            this.doc_gen.Text = "Doctor Name";
            // 
            // ADD_btn
            // 
            this.ADD_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.ADD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_btn.ForeColor = System.Drawing.Color.Black;
            this.ADD_btn.Location = new System.Drawing.Point(35, 269);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(104, 44);
            this.ADD_btn.TabIndex = 104;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = false;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // Patient_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.doc_id_label);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.doc_years);
            this.Controls.Add(this.doc_name);
            this.Controls.Add(this.doc_gen);
            this.Controls.Add(this.title_appointment);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Appointment_grid);
            this.Controls.Add(this.logout_);
            this.Controls.Add(this.Cross_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Appointment";
            this.Load += new System.EventHandler(this.Patient_Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Appointment_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cross_btn;
        private System.Windows.Forms.Button logout_;
        private System.Windows.Forms.DataGridView Appointment_grid;
        private System.Windows.Forms.Label title_appointment;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label doc_id_label;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.Label doc_years;
        private System.Windows.Forms.Label doc_name;
        private System.Windows.Forms.Label doc_gen;
        private System.Windows.Forms.Button ADD_btn;
    }
}