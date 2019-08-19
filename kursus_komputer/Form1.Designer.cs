namespace kursus_komputer
{
    partial class Form1
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
            this.no_pendaftaran = new System.Windows.Forms.TextBox();
            this.jenis_kursus = new System.Windows.Forms.ComboBox();
            this.nama_kursus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.malam = new System.Windows.Forms.RadioButton();
            this.pagi = new System.Windows.Forms.RadioButton();
            this.beberapa_hari = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.konsumsi = new System.Windows.Forms.CheckBox();
            this.internet = new System.Windows.Forms.CheckBox();
            this.biaya_kursus = new System.Windows.Forms.TextBox();
            this.biaya_fasilitas = new System.Windows.Forms.TextBox();
            this.total_pembayaran = new System.Windows.Forms.TextBox();
            this.proses = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_pendaftaran
            // 
            this.no_pendaftaran.Location = new System.Drawing.Point(148, 41);
            this.no_pendaftaran.Name = "no_pendaftaran";
            this.no_pendaftaran.Size = new System.Drawing.Size(100, 20);
            this.no_pendaftaran.TabIndex = 0;
            // 
            // jenis_kursus
            // 
            this.jenis_kursus.FormattingEnabled = true;
            this.jenis_kursus.Location = new System.Drawing.Point(148, 82);
            this.jenis_kursus.Name = "jenis_kursus";
            this.jenis_kursus.Size = new System.Drawing.Size(121, 21);
            this.jenis_kursus.TabIndex = 1;
            this.jenis_kursus.SelectedIndexChanged += new System.EventHandler(this.Jenis_kursus_SelectedIndexChanged);
            // 
            // nama_kursus
            // 
            this.nama_kursus.Enabled = false;
            this.nama_kursus.Location = new System.Drawing.Point(148, 122);
            this.nama_kursus.Name = "nama_kursus";
            this.nama_kursus.Size = new System.Drawing.Size(100, 20);
            this.nama_kursus.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.malam);
            this.groupBox1.Controls.Add(this.pagi);
            this.groupBox1.Location = new System.Drawing.Point(148, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // malam
            // 
            this.malam.AutoSize = true;
            this.malam.Location = new System.Drawing.Point(107, 43);
            this.malam.Name = "malam";
            this.malam.Size = new System.Drawing.Size(63, 17);
            this.malam.TabIndex = 14;
            this.malam.TabStop = true;
            this.malam.Text = "MALAM";
            this.malam.UseVisualStyleBackColor = true;
            // 
            // pagi
            // 
            this.pagi.AutoSize = true;
            this.pagi.Location = new System.Drawing.Point(15, 43);
            this.pagi.Name = "pagi";
            this.pagi.Size = new System.Drawing.Size(50, 17);
            this.pagi.TabIndex = 13;
            this.pagi.TabStop = true;
            this.pagi.Text = "PAGI";
            this.pagi.UseVisualStyleBackColor = true;
            // 
            // beberapa_hari
            // 
            this.beberapa_hari.FormattingEnabled = true;
            this.beberapa_hari.Location = new System.Drawing.Point(148, 290);
            this.beberapa_hari.Name = "beberapa_hari";
            this.beberapa_hari.Size = new System.Drawing.Size(121, 21);
            this.beberapa_hari.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.konsumsi);
            this.groupBox2.Controls.Add(this.internet);
            this.groupBox2.Location = new System.Drawing.Point(69, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fasilitas";
            // 
            // konsumsi
            // 
            this.konsumsi.AutoSize = true;
            this.konsumsi.Location = new System.Drawing.Point(112, 45);
            this.konsumsi.Name = "konsumsi";
            this.konsumsi.Size = new System.Drawing.Size(83, 17);
            this.konsumsi.TabIndex = 1;
            this.konsumsi.Text = "KONSUMSI";
            this.konsumsi.UseVisualStyleBackColor = true;
            // 
            // internet
            // 
            this.internet.AutoSize = true;
            this.internet.Location = new System.Drawing.Point(15, 45);
            this.internet.Name = "internet";
            this.internet.Size = new System.Drawing.Size(81, 17);
            this.internet.TabIndex = 0;
            this.internet.Text = "INTERNET";
            this.internet.UseVisualStyleBackColor = true;
            // 
            // biaya_kursus
            // 
            this.biaya_kursus.Enabled = false;
            this.biaya_kursus.Location = new System.Drawing.Point(633, 26);
            this.biaya_kursus.Name = "biaya_kursus";
            this.biaya_kursus.Size = new System.Drawing.Size(100, 20);
            this.biaya_kursus.TabIndex = 6;
            // 
            // biaya_fasilitas
            // 
            this.biaya_fasilitas.Enabled = false;
            this.biaya_fasilitas.Location = new System.Drawing.Point(633, 82);
            this.biaya_fasilitas.Name = "biaya_fasilitas";
            this.biaya_fasilitas.Size = new System.Drawing.Size(100, 20);
            this.biaya_fasilitas.TabIndex = 7;
            // 
            // total_pembayaran
            // 
            this.total_pembayaran.Enabled = false;
            this.total_pembayaran.Location = new System.Drawing.Point(633, 147);
            this.total_pembayaran.Name = "total_pembayaran";
            this.total_pembayaran.Size = new System.Drawing.Size(100, 20);
            this.total_pembayaran.TabIndex = 8;
            // 
            // proses
            // 
            this.proses.Location = new System.Drawing.Point(446, 254);
            this.proses.Name = "proses";
            this.proses.Size = new System.Drawing.Size(75, 23);
            this.proses.TabIndex = 9;
            this.proses.Text = "Proses";
            this.proses.UseVisualStyleBackColor = true;
            this.proses.Click += new System.EventHandler(this.Proses_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(542, 254);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(633, 254);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 23);
            this.keluar.TabIndex = 11;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(431, 95);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(0, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "NO PENDAFTARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "JENIS KHURSUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "NAMA KHURSUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "WAKTU KHURSUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "BEBERAPA HARI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "BIAYA KHURSUS";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "BIAYA FASILITAS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "TOTAL PEMBAYARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.proses);
            this.Controls.Add(this.total_pembayaran);
            this.Controls.Add(this.biaya_fasilitas);
            this.Controls.Add(this.biaya_kursus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.beberapa_hari);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nama_kursus);
            this.Controls.Add(this.jenis_kursus);
            this.Controls.Add(this.no_pendaftaran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox no_pendaftaran;
        private System.Windows.Forms.ComboBox jenis_kursus;
        private System.Windows.Forms.TextBox nama_kursus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox beberapa_hari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox biaya_kursus;
        private System.Windows.Forms.TextBox biaya_fasilitas;
        private System.Windows.Forms.TextBox total_pembayaran;
        private System.Windows.Forms.Button proses;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton malam;
        private System.Windows.Forms.RadioButton pagi;
        private System.Windows.Forms.CheckBox konsumsi;
        private System.Windows.Forms.CheckBox internet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

