namespace aplikasi_kasir.Gui
{
    partial class FTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTransaksi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpTanggalKwitansi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNoKwitansi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtbayar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnKurang = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.TxtJumlahJual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtHargaBarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBrowseBarang = new System.Windows.Forms.Button();
            this.TxtNamaBarang = new System.Windows.Forms.TextBox();
            this.TxtKodeBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListPenjualan1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotalBayar = new System.Windows.Forms.Label();
            this.ListPenjualan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.Btnkeluar = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblKembalian = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListPenjualan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPenjualan)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.DtpTanggalKwitansi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNoKwitansi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ":: Data Penjualan ::";
            // 
            // DtpTanggalKwitansi
            // 
            this.DtpTanggalKwitansi.CustomFormat = "MM/dd/yyyy";
            this.DtpTanggalKwitansi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTanggalKwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTanggalKwitansi.Location = new System.Drawing.Point(300, 31);
            this.DtpTanggalKwitansi.Name = "DtpTanggalKwitansi";
            this.DtpTanggalKwitansi.Size = new System.Drawing.Size(131, 21);
            this.DtpTanggalKwitansi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal :";
            // 
            // TxtNoKwitansi
            // 
            this.TxtNoKwitansi.Location = new System.Drawing.Point(100, 32);
            this.TxtNoKwitansi.Multiline = true;
            this.TxtNoKwitansi.Name = "TxtNoKwitansi";
            this.TxtNoKwitansi.Size = new System.Drawing.Size(125, 19);
            this.TxtNoKwitansi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Kwitansi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nama Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.Txtbayar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BtnKurang);
            this.groupBox2.Controls.Add(this.BtnTambah);
            this.groupBox2.Controls.Add(this.TxtJumlahJual);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtHargaBarang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnBrowseBarang);
            this.groupBox2.Controls.Add(this.TxtNamaBarang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtKodeBarang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 223);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ":: Detail Barang ::";
            // 
            // Txtbayar
            // 
            this.Txtbayar.Location = new System.Drawing.Point(100, 180);
            this.Txtbayar.Multiline = true;
            this.Txtbayar.Name = "Txtbayar";
            this.Txtbayar.Size = new System.Drawing.Size(192, 29);
            this.Txtbayar.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bayar";
            // 
            // BtnKurang
            // 
            this.BtnKurang.Image = ((System.Drawing.Image)(resources.GetObject("BtnKurang.Image")));
            this.BtnKurang.Location = new System.Drawing.Point(381, 141);
            this.BtnKurang.Name = "BtnKurang";
            this.BtnKurang.Size = new System.Drawing.Size(50, 31);
            this.BtnKurang.TabIndex = 22;
            this.BtnKurang.UseVisualStyleBackColor = true;
            this.BtnKurang.Click += new System.EventHandler(this.BtnKurang_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Image = ((System.Drawing.Image)(resources.GetObject("BtnTambah.Image")));
            this.BtnTambah.Location = new System.Drawing.Point(309, 140);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(49, 32);
            this.BtnTambah.TabIndex = 21;
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // TxtJumlahJual
            // 
            this.TxtJumlahJual.Location = new System.Drawing.Point(101, 142);
            this.TxtJumlahJual.Multiline = true;
            this.TxtJumlahJual.Name = "TxtJumlahJual";
            this.TxtJumlahJual.Size = new System.Drawing.Size(192, 29);
            this.TxtJumlahJual.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Jumlah Beli";
            // 
            // TxtHargaBarang
            // 
            this.TxtHargaBarang.Location = new System.Drawing.Point(101, 105);
            this.TxtHargaBarang.Multiline = true;
            this.TxtHargaBarang.Name = "TxtHargaBarang";
            this.TxtHargaBarang.Size = new System.Drawing.Size(192, 29);
            this.TxtHargaBarang.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Harga";
            // 
            // BtnBrowseBarang
            // 
            this.BtnBrowseBarang.Image = ((System.Drawing.Image)(resources.GetObject("BtnBrowseBarang.Image")));
            this.BtnBrowseBarang.Location = new System.Drawing.Point(309, 27);
            this.BtnBrowseBarang.Name = "BtnBrowseBarang";
            this.BtnBrowseBarang.Size = new System.Drawing.Size(49, 29);
            this.BtnBrowseBarang.TabIndex = 16;
            this.BtnBrowseBarang.UseVisualStyleBackColor = true;
            this.BtnBrowseBarang.Click += new System.EventHandler(this.BtnBrowseBarang_Click_1);
            // 
            // TxtNamaBarang
            // 
            this.TxtNamaBarang.Location = new System.Drawing.Point(101, 70);
            this.TxtNamaBarang.Multiline = true;
            this.TxtNamaBarang.Name = "TxtNamaBarang";
            this.TxtNamaBarang.Size = new System.Drawing.Size(192, 29);
            this.TxtNamaBarang.TabIndex = 15;
            // 
            // TxtKodeBarang
            // 
            this.TxtKodeBarang.Location = new System.Drawing.Point(101, 27);
            this.TxtKodeBarang.Multiline = true;
            this.TxtKodeBarang.Name = "TxtKodeBarang";
            this.TxtKodeBarang.Size = new System.Drawing.Size(192, 29);
            this.TxtKodeBarang.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kode Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListPenjualan1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(460, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 245);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ":: Detail Pembelian barang ::";
            // 
            // ListPenjualan1
            // 
            this.ListPenjualan1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListPenjualan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPenjualan1.Location = new System.Drawing.Point(5, 22);
            this.ListPenjualan1.Name = "ListPenjualan1";
            this.ListPenjualan1.Size = new System.Drawing.Size(633, 214);
            this.ListPenjualan1.TabIndex = 1;
            this.ListPenjualan1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPenjualan1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Bayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rp.";
            // 
            // LblTotalBayar
            // 
            this.LblTotalBayar.AutoSize = true;
            this.LblTotalBayar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalBayar.Location = new System.Drawing.Point(632, 270);
            this.LblTotalBayar.Name = "LblTotalBayar";
            this.LblTotalBayar.Size = new System.Drawing.Size(106, 19);
            this.LblTotalBayar.TabIndex = 11;
            this.LblTotalBayar.Text = "LblTotalBayar";
            // 
            // ListPenjualan
            // 
            this.ListPenjualan.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListPenjualan.Location = new System.Drawing.Point(6, 19);
            this.ListPenjualan.Name = "ListPenjualan";
            this.ListPenjualan.Size = new System.Drawing.Size(627, 174);
            this.ListPenjualan.TabIndex = 0;
            this.ListPenjualan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPenjualan_CellClick);
            this.ListPenjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPenjualan_CellContentClick_1);
            this.ListPenjualan.Click += new System.EventHandler(this.ListBarang_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.BtnHitung);
            this.panel1.Controls.Add(this.BtnHapus);
            this.panel1.Controls.Add(this.Btnkeluar);
            this.panel1.Controls.Add(this.BtnSimpan);
            this.panel1.Controls.Add(this.BtnBaru);
            this.panel1.Location = new System.Drawing.Point(13, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 182);
            this.panel1.TabIndex = 12;
            // 
            // BtnHitung
            // 
            this.BtnHitung.Image = ((System.Drawing.Image)(resources.GetObject("BtnHitung.Image")));
            this.BtnHitung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHitung.Location = new System.Drawing.Point(165, 89);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(85, 45);
            this.BtnHitung.TabIndex = 4;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Image = ((System.Drawing.Image)(resources.GetObject("BtnHapus.Image")));
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHapus.Location = new System.Drawing.Point(226, 21);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(85, 45);
            this.BtnHapus.TabIndex = 3;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // Btnkeluar
            // 
            this.Btnkeluar.Image = ((System.Drawing.Image)(resources.GetObject("Btnkeluar.Image")));
            this.Btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnkeluar.Location = new System.Drawing.Point(331, 21);
            this.Btnkeluar.Name = "Btnkeluar";
            this.Btnkeluar.Size = new System.Drawing.Size(82, 42);
            this.Btnkeluar.TabIndex = 2;
            this.Btnkeluar.Text = "&Keluar";
            this.Btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnkeluar.UseVisualStyleBackColor = true;
            this.Btnkeluar.Click += new System.EventHandler(this.Btnkeluar_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("BtnSimpan.Image")));
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(112, 20);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(84, 42);
            this.BtnSimpan.TabIndex = 1;
            this.BtnSimpan.Text = "&Bayar";
            this.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnBaru
            // 
            this.BtnBaru.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaru.Image")));
            this.BtnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaru.Location = new System.Drawing.Point(15, 20);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(75, 42);
            this.BtnBaru.TabIndex = 0;
            this.BtnBaru.Text = "&Baru";
            this.BtnBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBaru.UseVisualStyleBackColor = true;
            this.BtnBaru.Click += new System.EventHandler(this.BtnBaru_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ListPenjualan);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(465, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(639, 199);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = ":: Detail Kwitansi ::";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(462, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Kembalian";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(573, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Rp.";
            // 
            // LblKembalian
            // 
            this.LblKembalian.AutoSize = true;
            this.LblKembalian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKembalian.Location = new System.Drawing.Point(632, 310);
            this.LblKembalian.Name = "LblKembalian";
            this.LblKembalian.Size = new System.Drawing.Size(103, 19);
            this.LblKembalian.TabIndex = 17;
            this.LblKembalian.Text = "LblKembalian";
            // 
            // FTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1116, 574);
            this.Controls.Add(this.LblKembalian);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LblTotalBayar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FTransaksi";
            this.Load += new System.EventHandler(this.FTransaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListPenjualan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPenjualan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpTanggalKwitansi;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNoKwitansi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnKurang;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.TextBox TxtJumlahJual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtHargaBarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBrowseBarang;
        private System.Windows.Forms.TextBox TxtNamaBarang;
        private System.Windows.Forms.TextBox TxtKodeBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ListPenjualan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btnkeluar;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTotalBayar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblKembalian;
        private System.Windows.Forms.Button BtnHitung;
        public System.Windows.Forms.TextBox Txtbayar;
        public System.Windows.Forms.DataGridView ListPenjualan1;




    }
}