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
    public partial class FCariBarang : Form
    {

        //import kelas koneksi
        Kelas.koneksi konn = new Kelas.koneksi();
        //Menambahkan variable

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private string kodebarang, namabarang, hargabarang = "";

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
        public FCariBarang()
        {
            InitializeComponent();
            txtCari.Clear();
            refresh_barang();

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConnection();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM barang WHERE NamaBarang Like '%" +
                txtCari.Text + "%' OR KodeBarang Like '%" +
                    txtCari.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "barang");
            ListBarang.DataSource = ds;
            ListBarang.DataMember = "barang";
            ListBarang.Refresh();
            conn.Close();
        }

        public string ambil_kode_barang
        {
            get
            {
                return kodebarang;
            }
        }

        public string ambil_nama_barang
        {
            get
            {
                return namabarang;
            }
        }

        public string ambil_harga_barang
        {
            get
            {
                return hargabarang;
            }
        }

        private void ListBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mengambil nilai record yang dipilih
            try
            {
                DataGridViewRow row = this.ListBarang.Rows[e.RowIndex];
                kodebarang = row.Cells["KodeBarang"].Value.ToString();
                namabarang = row.Cells["NamaBarang"].Value.ToString();
                hargabarang = row.Cells["HargaBarang"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

    }
}
