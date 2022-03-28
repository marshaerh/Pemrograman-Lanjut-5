namespace AppLatihan1814
{
    partial class FrmMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.MaskedTextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbPerempuan = new System.Windows.Forms.RadioButton();
            this.rdbLaki = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisKelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempatLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramStudi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(91, 28);
            this.txtNim.Mask = "00,00,0000";
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(139, 20);
            this.txtNim.TabIndex = 2;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(91, 54);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(226, 20);
            this.txtNama.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(15, 309);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(103, 309);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tempat Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tanggal Lahir";
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Location = new System.Drawing.Point(91, 103);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(139, 20);
            this.txtTempatLahir.TabIndex = 8;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(91, 129);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalLahir.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProdi);
            this.groupBox1.Controls.Add(this.txtAlamat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdbPerempuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpTanggalLahir);
            this.groupBox1.Controls.Add(this.rdbLaki);
            this.groupBox1.Controls.Add(this.txtTempatLahir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNim);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 226);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Items.AddRange(new object[] {
            "D3 Teknik Informatika",
            "D3 Manajemen Informasi",
            "S1 Informatika",
            "S1 Sistem Informasi",
            "S1 Arsitektur"});
            this.cmbProdi.Location = new System.Drawing.Point(91, 181);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(139, 21);
            this.cmbProdi.TabIndex = 12;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(91, 155);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(139, 20);
            this.txtAlamat.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Jenis Kelamin";
            // 
            // rdbPerempuan
            // 
            this.rdbPerempuan.AutoSize = true;
            this.rdbPerempuan.Location = new System.Drawing.Point(182, 80);
            this.rdbPerempuan.Name = "rdbPerempuan";
            this.rdbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdbPerempuan.TabIndex = 5;
            this.rdbPerempuan.TabStop = true;
            this.rdbPerempuan.Text = "Perempuan";
            this.rdbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rdbLaki
            // 
            this.rdbLaki.AutoSize = true;
            this.rdbLaki.Location = new System.Drawing.Point(91, 80);
            this.rdbLaki.Name = "rdbLaki";
            this.rdbLaki.Size = new System.Drawing.Size(68, 17);
            this.rdbLaki.TabIndex = 4;
            this.rdbLaki.TabStop = true;
            this.rdbLaki.Text = "Laki-Laki";
            this.rdbLaki.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DATA MAHASISWA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMahasiswa);
            this.groupBox2.Location = new System.Drawing.Point(373, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 226);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NPM,
            this.Nama,
            this.JenisKelamin,
            this.TempatLahir,
            this.TanggalLahir,
            this.Alamat,
            this.ProgramStudi});
            this.dgvMahasiswa.Location = new System.Drawing.Point(6, 19);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.Size = new System.Drawing.Size(685, 201);
            this.dgvMahasiswa.TabIndex = 13;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            // 
            // NPM
            // 
            this.NPM.HeaderText = "NPM";
            this.NPM.Name = "NPM";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.HeaderText = "Jenis Kelamin";
            this.JenisKelamin.Name = "JenisKelamin";
            // 
            // TempatLahir
            // 
            this.TempatLahir.HeaderText = "Tempat Lahir";
            this.TempatLahir.Name = "TempatLahir";
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.HeaderText = "Tanggal Lahir";
            this.TanggalLahir.Name = "TanggalLahir";
            // 
            // Alamat
            // 
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.Name = "Alamat";
            // 
            // ProgramStudi
            // 
            this.ProgramStudi.HeaderText = "Program Studi";
            this.ProgramStudi.Name = "ProgramStudi";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(403, 312);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 0;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // FrmMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 460);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSimpan);
            this.Name = "FrmMahasiswa";
            this.Text = "Form Data Mahasiswa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtNim;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbPerempuan;
        private System.Windows.Forms.RadioButton rdbLaki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisKelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempatLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramStudi;
        private System.Windows.Forms.Button btnKeluar;
    }
}

