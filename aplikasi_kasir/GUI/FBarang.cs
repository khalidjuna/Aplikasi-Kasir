using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace aplikasi_kasir.Gui
{
    public partial class FBarang : Form
    {
        //import kelas koneksi
        Kelas.koneksi konn = new Kelas.koneksi();

        //menambahkan beberaka variabel untuk CRUD
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

         void Bersih()
        {
            TxtKodeBarang.Clear();
            TxtNamaBarang.Clear();
            TxtHargaBarang.Clear();
            TxtStokBarang.Clear();
            CmbSatuan.Text = "Pilih";
            
        }

        void Atur_Tombol(Boolean status)
        {
            BtnKeluar.Enabled = status;
            BtnHapus.Enabled = status;
        }



        void refresh_barang()
        {
            SqlConnection conn = konn.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * From barang ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "barang ");
                ListBarang.DataSource = ds;
                ListBarang.DataMember = "barang ";
                ListBarang.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
        public FBarang()
        {
            InitializeComponent();
            Bersih();
            refresh_barang();
            Atur_Tombol(false);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConnection();
            conn.Open();
            cmd = new SqlCommand("SELECT KodeBarang from barang WHERE KodeBarang in(SELECT MAX(KodeBarang)  FROM barang) order by KodeBarang DESC"
                , conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)//jika ada data transaksi sebelumnya
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 4, 4)) + 1;
                string joinstr = "000" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else //jika belum ada data transaksi
            {
                urut = "B0001";
            }
            rd.Close();
            TxtKodeBarang.Text = urut;
            conn.Close();
        }

        private void BtnBaru_Click(object sender, EventArgs e)
        {
            Bersih();
            auto_number();
            TxtKodeBarang.Focus();
            Atur_Tombol(false);
            BtnSimpan.Enabled = true;
        }

        private void BtnKeluar_Click(object sender, EventArgs e)//edit
        {
            if (TxtKodeBarang.Text.Trim() == "" || TxtNamaBarang.Text.Trim() == ""
                || TxtHargaBarang.Text.Trim() == ""  || TxtStokBarang.Text.Trim() == ""
                || CmbSatuan.Text.Trim() == "")
            {
                //menampilkan pesan bahwa data belum lengkap
                MessageBox.Show("Data belum lengkap", "WARNING",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                SqlConnection conn = konn.GetConnection();
                try
                {
                    //Perintah Edit Data
                    cmd = new SqlCommand("Execute ubah_barang '" + TxtNamaBarang.Text + "','"
                    + TxtHargaBarang.Text  + "','" + TxtStokBarang.Text + "','"
                    + CmbSatuan.Text + "','" +  TxtKodeBarang.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Data berhasil diubah", "informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bersih();
                    refresh_barang();
                    Atur_Tombol(false); 
                    BtnSimpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (TxtKodeBarang.Text.Trim() == "" || TxtNamaBarang.Text.Trim() == ""
                || TxtHargaBarang.Text.Trim() == "" || TxtStokBarang.Text.Trim() == ""
                || CmbSatuan.Text.Trim() == "")
            {
                //menampilkan pesan bahwa data belum lengkap
                MessageBox.Show("Data belum lengkap", "WARNING",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            SqlConnection conn = konn.GetConnection();
            try
            {
                //Perintah Simpan Data
                cmd = new SqlCommand("Execute simpan_barang '" + TxtKodeBarang.Text + "','"
                    + TxtNamaBarang.Text + "','" + TxtHargaBarang.Text + "','"
                    + TxtStokBarang.Text + "','" + CmbSatuan.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di simpan", "informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bersih();
                refresh_barang();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            //Perintah menghapus data
            if (MessageBox.Show("Anda yakin ingin mengahapus data barang?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConnection();
                cmd = new SqlCommand("Execute hapus_barang '" + TxtKodeBarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bersih();
                refresh_barang();
                Atur_Tombol(false);
                BtnSimpan.Enabled = true;
            }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConnection();
            conn.Open();
            cmd = new SqlCommand("Execute cari_barang'" + TxtCari.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "barang");
            ListBarang.DataSource = ds;
            ListBarang.DataMember = "barang";
            ListBarang.Refresh();
            conn.Close();

        }

        private void ListBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mengambil nilai record yang dipilih
            try
            {
                BtnSimpan.Enabled = false;
                Atur_Tombol(true);
                DataGridViewRow row = this.ListBarang.Rows[e.RowIndex];
                TxtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
                TxtNamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
                TxtHargaBarang.Text = row.Cells["HargaBarang"].Value.ToString();
                TxtStokBarang.Text = row.Cells["StokBarang"].Value.ToString();
                CmbSatuan.Text = row.Cells["Satuan"].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void ListBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btnkeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
