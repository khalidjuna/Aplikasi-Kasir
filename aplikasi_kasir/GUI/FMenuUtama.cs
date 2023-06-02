using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aplikasi_kasir.GUI;

namespace aplikasi_kasir.Gui
{
    public partial class FMenuUtama : Form
    {
        //Membuat variabel dari form yang terkait
        public static FMenuUtama mdiobj;
        FAboutProgrammer prog;
        FBarang barang;
        FTransaksi transaksi;
  
        void proc_AboutProgrammerClosed(object sender, FormClosedEventArgs e)
        {
            prog = null;
        }


        void proc_BarangClosed(object sender, FormClosedEventArgs e)
        {
            barang = null;
        }

        void proc_TransaksiClosed(Object sender, FormClosedEventArgs e)
        {
            transaksi = null;
        }

        
        public FMenuUtama()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FMenuUtama_Load(object sender, EventArgs e)
        {
            //Menonaktifkan Yng tidak dipakai
            MenuMaster.Enabled = false;
            MenuUser.Enabled = true;
            Submenu_logout.Enabled = false;
            Submenu_login.Enabled = true;
            ToolTransaksi.Enabled = false;
            ToolBarang.Enabled = false;
            //ToolJadwal.Enabled= true;
            //Tools.Enabled = true;

            //Memberikan value variable menu utama adalah mdiobj
            mdiobj = this;
            FLogin Login = new FLogin();
            Login.ShowDialog();
        }

        private void submen_barang_Click(object sender, EventArgs e)
        {

        }

        private void Submenu_login_Click(object sender, EventArgs e)
        {
            //memanggil form login saat masuk aplikasi
            FLogin Login = new FLogin();
            Login.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void Submenu_exit_Click(object sender, EventArgs e)
        {
            // membuat kode keluar aplikasi
            if (MessageBox.Show("Anda yakin ingin keluar dari aplikasi ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Submenu_logout_Click(object sender, EventArgs e)
        {
            //Memberikan kondisi setelah logout di clik maka submenu logout tidak aktif sebelum login kembali
            MenuMaster.Enabled = false;
            MenuUser.Enabled = true;
            Submenu_logout.Enabled = false;
            Submenu_login.Enabled = true;
            ToolBarang.Enabled = false;
            ToolTransaksi.Enabled = false;
           // Tools.Enabled = true;
        }

        private void Submenu_barang_Click(object sender, EventArgs e)
        {
            //memanggil form Barang
            if (barang == null)
            {
                barang = new FBarang();
                barang.MdiParent = this;
                barang.FormClosed += new FormClosedEventHandler(proc_TransaksiClosed);
                barang.Show();
            }
            else
            {
                barang.Activate();
            }
        }

        private void Submenu_penjualan_Click(object sender, EventArgs e)
        {
            //memanggil form Transaksi
            if (transaksi == null)
            {
                transaksi = new FTransaksi();
                transaksi.MdiParent = this;
                transaksi.FormClosed += new FormClosedEventHandler(proc_BarangClosed);
                transaksi.Show();
            }
            else
            {
                transaksi.Activate();

            }
        }

        private void ToolExit_Click(object sender, EventArgs e)
        {
            ///membuat kode keluar aplikasi
            if (MessageBox.Show("Anda yakin ingin keluar dari aplikasi ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ToolBarang_Click(object sender, EventArgs e)
        {
            Submenu_barang_Click(sender, e);
        }

        private void ToolTransaksi_Click(object sender, EventArgs e)
        {
            Submenu_penjualan_Click(sender, e);
        }

        private void MenuPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void kwitansi_Click(object sender, EventArgs e)
        {
            //memanggil form Transaksi
            if (transaksi == null)
            {
                transaksi = new FTransaksi();
                transaksi.MdiParent = this;
                transaksi.FormClosed += new FormClosedEventHandler(proc_BarangClosed);
                transaksi.Show();
            }
            else
            {
                transaksi.Activate();

            }
        }

        private void ToolAboutProgrammer_Click(object sender, EventArgs e)
        {
            if (prog == null)
            {
                prog = new FAboutProgrammer();
                prog.MdiParent = this;
                prog.FormClosed += new FormClosedEventHandler(proc_AboutProgrammerClosed);
                prog.Show();
            }
            else
            {
                prog.Activate();
            }
        }
    }
}
