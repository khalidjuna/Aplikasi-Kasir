namespace aplikasi_kasir.Gui
{
    partial class FBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBarang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbSatuan = new System.Windows.Forms.ComboBox();
            this.TxtStokBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtHargaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKodeBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBarang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCari = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBarang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orchid;
            this.groupBox1.Controls.Add(this.CmbSatuan);
            this.groupBox1.Controls.Add(this.TxtStokBarang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtHargaBarang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNamaBarang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtKodeBarang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ":: Input data barang ::";
            // 
            // CmbSatuan
            // 
            this.CmbSatuan.FormattingEnabled = true;
            this.CmbSatuan.Items.AddRange(new object[] {
            "Unit",
            "Lusin",
            "Pack"});
            this.CmbSatuan.Location = new System.Drawing.Point(124, 197);
            this.CmbSatuan.Name = "CmbSatuan";
            this.CmbSatuan.Size = new System.Drawing.Size(131, 25);
            this.CmbSatuan.TabIndex = 19;
            // 
            // TxtStokBarang
            // 
            this.TxtStokBarang.Location = new System.Drawing.Point(124, 158);
            this.TxtStokBarang.Name = "TxtStokBarang";
            this.TxtStokBarang.Size = new System.Drawing.Size(131, 24);
            this.TxtStokBarang.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stok Barang";
            // 
            // TxtHargaBarang
            // 
            this.TxtHargaBarang.Location = new System.Drawing.Point(124, 118);
            this.TxtHargaBarang.Name = "TxtHargaBarang";
            this.TxtHargaBarang.Size = new System.Drawing.Size(131, 24);
            this.TxtHargaBarang.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Harga Barang";
            // 
            // TxtNamaBarang
            // 
            this.TxtNamaBarang.Location = new System.Drawing.Point(124, 76);
            this.TxtNamaBarang.Name = "TxtNamaBarang";
            this.TxtNamaBarang.Size = new System.Drawing.Size(161, 24);
            this.TxtNamaBarang.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nama Barang";
            // 
            // TxtKodeBarang
            // 
            this.TxtKodeBarang.Location = new System.Drawing.Point(124, 36);
            this.TxtKodeBarang.Name = "TxtKodeBarang";
            this.TxtKodeBarang.Size = new System.Drawing.Size(161, 24);
            this.TxtKodeBarang.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kode Barang";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.BtnSimpan);
            this.panel1.Controls.Add(this.BtnKeluar);
            this.panel1.Controls.Add(this.BtnHapus);
            this.panel1.Controls.Add(this.BtnBaru);
            this.panel1.Location = new System.Drawing.Point(12, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 136);
            this.panel1.TabIndex = 1;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.BtnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("BtnSimpan.Image")));
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(162, 72);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(94, 45);
            this.BtnSimpan.TabIndex = 0;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Image = ((System.Drawing.Image)(resources.GetObject("BtnKeluar.Image")));
            this.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeluar.Location = new System.Drawing.Point(162, 14);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(94, 45);
            this.BtnKeluar.TabIndex = 3;
            this.BtnKeluar.Text = "Edit";
            this.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Image = ((System.Drawing.Image)(resources.GetObject("BtnHapus.Image")));
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHapus.Location = new System.Drawing.Point(14, 83);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(94, 45);
            this.BtnHapus.TabIndex = 1;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnBaru
            // 
            this.BtnBaru.Image = ((System.Drawing.Image)(resources.GetObject("BtnBaru.Image")));
            this.BtnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaru.Location = new System.Drawing.Point(14, 14);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(93, 45);
            this.BtnBaru.TabIndex = 0;
            this.BtnBaru.Text = "Baru";
            this.BtnBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBaru.UseVisualStyleBackColor = true;
            this.BtnBaru.Click += new System.EventHandler(this.BtnBaru_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orchid;
            this.groupBox2.Controls.Add(this.ListBarang);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 356);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ":: Tampil Data Barang ::";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ListBarang
            // 
            this.ListBarang.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ListBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBarang.Location = new System.Drawing.Point(7, 20);
            this.ListBarang.Name = "ListBarang";
            this.ListBarang.Size = new System.Drawing.Size(574, 330);
            this.ListBarang.TabIndex = 0;
            this.ListBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListBarang_CellClick);
            this.ListBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListBarang_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cari Nama Barang :";
            // 
            // TxtCari
            // 
            this.TxtCari.Location = new System.Drawing.Point(507, 373);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Size = new System.Drawing.Size(287, 20);
            this.TxtCari.TabIndex = 5;
            this.TxtCari.TextChanged += new System.EventHandler(this.TxtCari_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 130);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Keluar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btnkeluar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(296, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 136);
            this.panel2.TabIndex = 4;
            // 
            // FBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(976, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtCari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FBarang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListBarang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbSatuan;
        private System.Windows.Forms.TextBox TxtStokBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtHargaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKodeBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ListBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCari;
        public System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}