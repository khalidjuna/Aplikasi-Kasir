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
    public partial class FLogin : Form
    {
        private SqlCommand cmd;
        Kelas.koneksi konn = new Kelas.koneksi();

        public FLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Membuat perintah login ke sql pada button login
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConnection();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_login where username = '" + TxtUserName.Text + "' and password = '" +
                     TxtPasswd.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read()) //Jika username dan password benar
            {
                MessageBox.Show("LOGIN BERHASIL", "INFORMASI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FMenuUtama.mdiobj.MenuMaster.Enabled = true;
                FMenuUtama.mdiobj.MenuUser.Enabled = true;
                FMenuUtama.mdiobj.Submenu_logout.Enabled = true;
                FMenuUtama.mdiobj.Submenu_login.Enabled = false;
                FMenuUtama.mdiobj.ToolBarang.Enabled = true;
                FMenuUtama.mdiobj.ToolTransaksi.Enabled = true;

                this.Close(); // untuk keluar dari form login
            }
            else //jika user atau password salah
            {
                MessageBox.Show("Username Atau Password Salah", "WARNING",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUserName.Text = "";
                TxtPasswd.Text = "";
                TxtUserName.Focus();
            }
            conn.Close(); //untuk menutup koneksi
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            //Keluar Form Login
            this.Close();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
