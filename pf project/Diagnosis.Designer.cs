
namespace pf_project
{
    partial class diagnosis
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
            this.title_diagnosis = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.diagnosis_id = new System.Windows.Forms.Label();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.patient_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.symptoms = new System.Windows.Forms.Label();
            this.medicines = new System.Windows.Forms.Label();
            this.diagnostic_test = new System.Windows.Forms.Label();
            this.textBox_6 = new System.Windows.Forms.TextBox();
            this.textBox_5 = new System.Windows.Forms.TextBox();
            this.textBox_4 = new System.Windows.Forms.TextBox();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.home_btn1 = new System.Windows.Forms.Button();
            this.diagnosis_grid = new System.Windows.Forms.DataGridView();
            this.Cross_btn = new System.Windows.Forms.Button();
            this.textBox_3 = new System.Windows.Forms.TextBox();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosis_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // title_diagnosis
            // 
            this.title_diagnosis.AutoSize = true;
            this.title_diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_diagnosis.Location = new System.Drawing.Point(143, 80);
            this.title_diagnosis.Name = "title_diagnosis";
            this.title_diagnosis.Size = new System.Drawing.Size(153, 29);
            this.title_diagnosis.TabIndex = 8;
            this.title_diagnosis.Text = "DIAGNOSIS";
            this.title_diagnosis.Click += new System.EventHandler(this.title_diagnosis_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::pf_project.Properties.Resources._1194548_cardiogram_diagnostic_medical_diagnosis_medical_file_icon;
            this.pictureBox4.Location = new System.Drawing.Point(12, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // diagnosis_id
            // 
            this.diagnosis_id.AutoSize = true;
            this.diagnosis_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis_id.Location = new System.Drawing.Point(12, 158);
            this.diagnosis_id.Name = "diagnosis_id";
            this.diagnosis_id.Size = new System.Drawing.Size(164, 25);
            this.diagnosis_id.TabIndex = 11;
            this.diagnosis_id.Text = "DIAGNOSIS ID";
            // 
            // textBox_1
            // 
            this.textBox_1.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox_1.Location = new System.Drawing.Point(233, 163);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(166, 20);
            this.textBox_1.TabIndex = 14;
            // 
            // patient_name
            // 
            this.patient_name.AutoSize = true;
            this.patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_name.Location = new System.Drawing.Point(12, 239);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(179, 25);
            this.patient_name.TabIndex = 15;
            this.patient_name.Text = "PATIENT NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "PATIENT ID";
            // 
            // symptoms
            // 
            this.symptoms.AutoSize = true;
            this.symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms.Location = new System.Drawing.Point(440, 156);
            this.symptoms.Name = "symptoms";
            this.symptoms.Size = new System.Drawing.Size(142, 25);
            this.symptoms.TabIndex = 25;
            this.symptoms.Text = "SYMPTOMS";
            // 
            // medicines
            // 
            this.medicines.AutoSize = true;
            this.medicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicines.Location = new System.Drawing.Point(435, 238);
            this.medicines.Name = "medicines";
            this.medicines.Size = new System.Drawing.Size(136, 25);
            this.medicines.TabIndex = 26;
            this.medicines.Text = "MEDICINES";
            this.medicines.Click += new System.EventHandler(this.medicines_Click);
            // 
            // diagnostic_test
            // 
            this.diagnostic_test.AutoSize = true;
            this.diagnostic_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnostic_test.Location = new System.Drawing.Point(430, 197);
            this.diagnostic_test.Name = "diagnostic_test";
            this.diagnostic_test.Size = new System.Drawing.Size(215, 25);
            this.diagnostic_test.TabIndex = 27;
            this.diagnostic_test.Text = "DIAGNOSTIC TEST";
            // 
            // textBox_6
            // 
            this.textBox_6.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox_6.Location = new System.Drawing.Point(664, 238);
            this.textBox_6.Name = "textBox_6";
            this.textBox_6.Size = new System.Drawing.Size(237, 20);
            this.textBox_6.TabIndex = 28;
            // 
            // textBox_5
            // 
            this.textBox_5.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox_5.Location = new System.Drawing.Point(664, 202);
            this.textBox_5.Name = "textBox_5";
            this.textBox_5.Size = new System.Drawing.Size(237, 20);
            this.textBox_5.TabIndex = 29;
            // 
            // textBox_4
            // 
            this.textBox_4.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox_4.Location = new System.Drawing.Point(664, 158);
            this.textBox_4.Name = "textBox_4";
            this.textBox_4.Size = new System.Drawing.Size(237, 20);
            this.textBox_4.TabIndex = 30;
            // 
            // ADD_btn
            // 
            this.ADD_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.ADD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_btn.ForeColor = System.Drawing.Color.Black;
            this.ADD_btn.Location = new System.Drawing.Point(87, 338);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(104, 32);
            this.ADD_btn.TabIndex = 31;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = false;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(226, 338);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(104, 32);
            this.update_btn.TabIndex = 32;
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
            this.delete_btn.Location = new System.Drawing.Point(370, 338);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(104, 32);
            this.delete_btn.TabIndex = 33;
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
            this.reset_btn.Location = new System.Drawing.Point(505, 338);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(104, 32);
            this.reset_btn.TabIndex = 34;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // home_btn1
            // 
            this.home_btn1.BackColor = System.Drawing.Color.CadetBlue;
            this.home_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn1.ForeColor = System.Drawing.Color.Black;
            this.home_btn1.Location = new System.Drawing.Point(628, 338);
            this.home_btn1.Name = "home_btn1";
            this.home_btn1.Size = new System.Drawing.Size(104, 32);
            this.home_btn1.TabIndex = 35;
            this.home_btn1.Text = "HOME";
            this.home_btn1.UseVisualStyleBackColor = false;
            this.home_btn1.Click += new System.EventHandler(this.home_btn1_Click);
            // 
            // diagnosis_grid
            // 
            this.diagnosis_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosis_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.diagnosis_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosis_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.diagnosis_grid.Location = new System.Drawing.Point(0, 400);
            this.diagnosis_grid.Name = "diagnosis_grid";
            this.diagnosis_grid.Size = new System.Drawing.Size(1028, 154);
            this.diagnosis_grid.TabIndex = 36;
            this.diagnosis_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diagnosis_grid_CellClick);
            // 
            // Cross_btn
            // 
            this.Cross_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Cross_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cross_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cross_btn.ForeColor = System.Drawing.Color.Black;
            this.Cross_btn.Location = new System.Drawing.Point(976, -1);
            this.Cross_btn.Name = "Cross_btn";
            this.Cross_btn.Size = new System.Drawing.Size(52, 32);
            this.Cross_btn.TabIndex = 37;
            this.Cross_btn.Text = "X";
            this.Cross_btn.UseVisualStyleBackColor = false;
            this.Cross_btn.Click += new System.EventHandler(this.Cross_btn_Click);
            // 
            // textBox_3
            // 
            this.textBox_3.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox_3.Location = new System.Drawing.Point(233, 244);
            this.textBox_3.Name = "textBox_3";
            this.textBox_3.Size = new System.Drawing.Size(166, 20);
            this.textBox_3.TabIndex = 38;
            // 
            // textBox_2
            // 
            this.textBox_2.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox_2.Location = new System.Drawing.Point(233, 199);
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(166, 20);
            this.textBox_2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "DISEASE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textbox_7
            // 
            this.textbox_7.BackColor = System.Drawing.Color.CadetBlue;
            this.textbox_7.Location = new System.Drawing.Point(664, 285);
            this.textbox_7.Name = "textbox_7";
            this.textbox_7.Size = new System.Drawing.Size(237, 20);
            this.textbox_7.TabIndex = 41;
            // 
            // diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1028, 554);
            this.Controls.Add(this.textbox_7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.textBox_3);
            this.Controls.Add(this.Cross_btn);
            this.Controls.Add(this.diagnosis_grid);
            this.Controls.Add(this.home_btn1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.textBox_4);
            this.Controls.Add(this.textBox_5);
            this.Controls.Add(this.textBox_6);
            this.Controls.Add(this.diagnostic_test);
            this.Controls.Add(this.medicines);
            this.Controls.Add(this.symptoms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patient_name);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.diagnosis_id);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.title_diagnosis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "diagnosis";
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosis_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_diagnosis;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label diagnosis_id;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.Label patient_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label symptoms;
        private System.Windows.Forms.Label medicines;
        private System.Windows.Forms.Label diagnostic_test;
        private System.Windows.Forms.TextBox textBox_6;
        private System.Windows.Forms.TextBox textBox_5;
        private System.Windows.Forms.TextBox textBox_4;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button home_btn1;
        private System.Windows.Forms.DataGridView diagnosis_grid;
        private System.Windows.Forms.Button Cross_btn;
        private System.Windows.Forms.TextBox textBox_3;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_7;
    }
}