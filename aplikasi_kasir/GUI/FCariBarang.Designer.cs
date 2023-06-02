namespace aplikasi_kasir.Gui
{
    partial class FCariBarang
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
            this.txtCari = new System.Windows.Forms.TextBox();
            this.ListBarang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan Kode/Nama Barang :";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(12, 41);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(583, 20);
            this.txtCari.TabIndex = 1;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // ListBarang
            // 
            this.ListBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBarang.Location = new System.Drawing.Point(13, 67);
            this.ListBarang.Name = "ListBarang";
            this.ListBarang.Size = new System.Drawing.Size(582, 248);
            this.ListBarang.TabIndex = 2;
            this.ListBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListBarang_CellClick);
            this.ListBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListBarang_CellContentClick);
            // 
            // FCariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(607, 328);
            this.Controls.Add(this.ListBarang);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Name = "FCariBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FCariBarang";
            ((System.ComponentModel.ISupportInitialize)(this.ListBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView ListBarang;
    }
}