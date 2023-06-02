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
using aplikasi_kasir.GUI;

namespace aplikasi_kasir.Gui
{
    public partial class FTransaksi : Form
    {
        public static FTransaksi ObjTransaksi;

        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        public SqlDataAdapter da;
       

        Kelas.koneksi konn = new Kelas.koneksi();

        void Atur_Tombol(Boolean status)
        {
            BtnHapus.Enabled = status;
        }

        private void bersih()
        {
            TxtNoKwitansi.Text = "";
            DtpTanggalKwitansi.Value = DateTime.Now;
            TxtKodeBarang.Text = "";
            TxtNamaBarang.Text = "";
            TxtHargaBarang.Text = "";
            TxtJumlahJual.Text = "";
            LblTotalBayar.Text = "-";
            LblKembalian.Text = "-";
        }

        private void awal()
        {
            //panggil prosedur bersih di dalam prosedur awal
            bersih();
            ListPenjualan.Enabled = false;//menonaktifkan datagrid penjualan
            SqlConnection conn = konn.GetConnection();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM kwitansi order by NomorKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "kwitansi");
                    ListPenjualan.DataSource = ds;
                    ListPenjualan.DataMember = "kwitansi";
                    ListPenjualan.Refresh();
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
        }


        //6.private auto number
        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConnection();
            conn.Open();
            cmd = new SqlCommand("SELECT NomorKwitansi from kwitansi WHERE NomorKwitansi in(SELECT MAX(NomorKwitansi)  FROM kwitansi) order by NomorKwitansi DESC"
                , conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)//jika ada data transaksi sebelumnya
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NomorKwitansi"].ToString().Length - 4, 4)) + 1;
                string joinstr = "000" + hitung;
                urut = "K" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else //jika belum ada data transaksi
            {
                urut = "K0001";
            }
            rd.Close();
            TxtNoKwitansi.Text = urut;
            conn.Close();
        }



        private void TotalSeluruh()
        {
            SqlConnection conn = konn.GetConnection();
            {
                conn.Open();

                cmd = new SqlCommand("SELECT SUM(JumlahBayar) AS TotalBayar "
                    + "FROM view_detailkwitansi "
                    + "WHERE NomorKwitansi = '"
                    + TxtNoKwitansi.Text + "'", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                String TotalSeluruh = result.ToString();
                LblTotalBayar.Text = result.ToString("#,##0");
                conn.Close();
            }
        }

        private void kembalian()
        {
            SqlConnection conn = konn.GetConnection();
            {
                conn.Open();

                cmd = new SqlCommand("SELECT SUM(JumlahBayar) AS TotalBayar "
                    + "FROM view_detailkwitansi "
                    + "WHERE NomorKwitansi = '"
                    + TxtNoKwitansi.Text + "'", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                int bayar = int.Parse(Txtbayar.Text);
                int result2 = result - bayar;

                String TotalSeluruh = result.ToString();
                LblKembalian.Text = result.ToString("#,##0");
                conn.Close();
            }
        }

        private void FTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void BtnBrowseBarang_Click(object sender, EventArgs e)
        {
            FCariBarang cariBarang = new FCariBarang();
            cariBarang.ShowDialog();
            TxtKodeBarang.Text = cariBarang.ambil_kode_barang;
            TxtNamaBarang.Text = cariBarang.ambil_nama_barang;
            TxtHargaBarang.Text = cariBarang.ambil_harga_barang;
            TxtKodeBarang.Focus();
            TxtNamaBarang.Focus();
            TxtHargaBarang.Focus();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
             // Simpan data pembelian per barang (buat trigger dahulu di Sql Server untuk Automasi stok)
            ListPenjualan.Enabled = true; //Mengaktifkan datagrid pembelian
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConnection();
            {
                //Jika ada data yang kosong
                if (TxtNoKwitansi.Text.Trim() == "" || TxtNamaBarang.Text.Trim() == ""|| 
                    TxtJumlahJual.Text.Trim() == "0")
                {
                    //Pesan data belum lengkap
                    MessageBox.Show("Data belum lengkap, lengkapi data", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else //Jika data sudah terisi semua
                {
                    conn.Open();

                    cmd = new SqlCommand("SELECT * FROM kwitansi where NomorKwitansi = '"
                        + TxtNoKwitansi.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) //Jika data pembelian sudah ada
                    {
                        //Refresh koneksi
                        conn.Close();
                        conn.Open();

                        cmd = new SqlCommand("SELECT * FROM detail_kwitansi WHERE NomorKwitansi = '"
                            + TxtNoKwitansi.Text + "' AND KodeBarang = '" + TxtKodeBarang.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        if (reader.Read()) //Jika data barang sudah diinputkan ke tabel detail_kwitansi
                        {
                            MessageBox.Show("Data barang " + TxtNamaBarang.Text
                                + "sudah diinputkan, harap pilih barang yang lain",
                                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        } 

                        else //Jika data barang belum diinputkan ke tabel detail_faktur
                        {
                            //panggil prosedur detail pembelian
                            Simpan_DetailPenjualan();
                            //Panggil prosedur total seluruh
                            TotalSeluruh();
                        }
                    }

                    else //Jika data pembelian belum ada
                    {
                        //Panggil prosedur simpan master dan detail pembelian
                        Simpan_MasterPenjualan();
                        Simpan_DetailPenjualan();
                        //Panggil prosedur total seluruh
                        TotalSeluruh();
                    }
                    //panggil prosedur refresh transaksi
                    RefreshTransaksi();
                }
            }
        }

        private void BtnKurang_Click(object sender, EventArgs e)
        {

            ListPenjualan1.Enabled = true;
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConnection();
            {

                cmd = new SqlCommand("EXECUTE hapus_detailkwitansi'" + TxtNoKwitansi.Text + "','"
                    + TxtKodeBarang.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT * FROM detail_kwitansi WHERE NomorKwitansi = '"  
                    + TxtNoKwitansi.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TotalSeluruh();
                }
                else
                {
                    LblTotalBayar.Text = "0";
                }
                RefreshTransaksi();
            }
        }

        //Prosedur Simpan Master Penjualan
        private void Simpan_MasterPenjualan()
        {
            SqlConnection conn = konn.GetConnection();
            {
                cmd = new SqlCommand("EXECUTE simpan_kwitansi '" + TxtNoKwitansi.Text + "','"
                    + DtpTanggalKwitansi.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Prosedur Simpan Detail Penjualan
        private void Simpan_DetailPenjualan()
        {
            SqlConnection conn = konn.GetConnection();
            {
                cmd = new SqlCommand("EXECUTE simpan_detailkwitansi '" + TxtNoKwitansi.Text + "','"
                    + TxtKodeBarang.Text + "','" + TxtJumlahJual.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void TxtHargaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        public FTransaksi()
        {
            InitializeComponent();
            ObjTransaksi = this;
            awal();
            
        }

        private void BtnBrowseBarang_Click_1(object sender, EventArgs e)
        {
            FCariBarang cariBarang = new FCariBarang();
            cariBarang.ShowDialog();
            TxtKodeBarang.Text = cariBarang.ambil_kode_barang;
            TxtNamaBarang.Text = cariBarang.ambil_nama_barang;
            TxtHargaBarang.Text = cariBarang.ambil_harga_barang;
            TxtKodeBarang.Focus();
            TxtNamaBarang.Focus();
            TxtHargaBarang.Focus();
        }

        private void BtnBaru_Click(object sender, EventArgs e)
        {
            //14. Memanggil prosedur awal dan auto_number ketika button baru dijalankan
            awal();
            auto_number();
            DtpTanggalKwitansi.Focus();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            //18. Transaksi selesai dan cetak laporan
            MessageBox.Show("Transaksi Selesai");

            //.report memanggil report kwitansi
            FKwitansi kw = new FKwitansi();
            kw.Show();
            awal();
        }

        private void Btnkeluar_Click(object sender, EventArgs e)
        {
            //19. Keluar form faktur
            Close();
        }



        private void ListBarang_CellClick(object sender, EventArgs e)
        {
            
        }


        //SAMA INI JUGA
        private void ListPenjualan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.ListPenjualan.Rows[e.RowIndex];
            TxtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
            DtpTanggalKwitansi.Text = row.Cells["TanggalKwitansi"].Value.ToString();
        }

        //KODINGAN MASIH SALAH 
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            //Perintah menghapus data
            if (MessageBox.Show("Anda yakin ingin mengahapus data kwitansi?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                //query menghapus data berdasarkan nomorkwitansi

                SqlConnection conn = konn.GetConnection();
                cmd = new SqlCommand("EXECUTE hapus_kwitansi'" + TxtKodeBarang.Text + "'", conn);
                //Buka koneksi database
                conn.Open();
                //eksekusi query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh_kwitansi();
                bersih();
            }
        }

        private void refresh_kwitansi()
        {
            SqlConnection conn = konn.GetConnection();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Select * From view_detailkwitansi where NomorKwitansi='"
                        + TxtNoKwitansi.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "view_detailkwitansi ");
                    ListPenjualan1.DataSource = ds;
                    ListPenjualan1.DataMember = "view_detailkwitansi ";
                    ListPenjualan1.Refresh();
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
        }

       private void RefreshTransaksi()
       {

           refresh_kwitansi();
           TxtKodeBarang.Clear();
           TxtNamaBarang.Clear();
           TxtHargaBarang.Text = "0";
           TxtJumlahJual.Text = "0";
           TxtKodeBarang.Focus();
       }

        //INI JUGA SALAH
       private void ListPenjualan1_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           //Tampilan data 
           Atur_Tombol(true);
           DataGridViewRow row = this.ListPenjualan1.Rows[e.RowIndex];
           TxtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
           TxtNamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
           TxtHargaBarang.Text = row.Cells["HargaBarang"].Value.ToString();
           TxtJumlahJual.Text = row.Cells["JumlahJual"].Value.ToString();
       }

        //KODINGAN MASIH SALAH
       private void refresh_kwitansi1()
        {
            SqlConnection conn = konn.GetConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * From kwitansi where NomorKwitansi='"
                    + TxtNoKwitansi.Text + "'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "kwitansi");
                ListPenjualan.DataSource = ds;
                ListPenjualan.DataMember = "kwitansi";
                ListPenjualan.Refresh();
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

        //INI JUGA MASIH SALAH
       private void ListPenjualan_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           Atur_Tombol(true);
           DataGridViewRow row = this.ListPenjualan.Rows[e.RowIndex];
           TxtKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
           DtpTanggalKwitansi.Text = row.Cells["TanggalKwitansi"].Value.ToString();
       }

       private void label8_Click(object sender, EventArgs e)
       {

       }

       private void BtnHitung_Click(object sender, EventArgs e)
       {

           SqlConnection conn = konn.GetConnection();
           {
               conn.Open();

               cmd = new SqlCommand("SELECT SUM(JumlahBayar) AS TotalBayar "
                   + "FROM view_detailkwitansi "
                   + "WHERE NomorKwitansi = '"
                   + TxtNoKwitansi.Text + "'", conn);
               cmd.Connection = conn;
               int result = ((int)cmd.ExecuteScalar());
               int bayar = int.Parse(Txtbayar.Text);
               int result2 = bayar - result;

               String TotalSeluruh = result.ToString();
               LblKembalian.Text = result2.ToString("#,##0");
               conn.Close();
           }
       }

      }
 }


