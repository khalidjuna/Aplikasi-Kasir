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
using CrystalDecisions.CrystalReports.Engine;
using aplikasi_kasir.Gui;

namespace aplikasi_kasir.GUI
{
    public partial class FKwitansi : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.koneksi konn = new Kelas.koneksi();


        public FKwitansi()
        {
            InitializeComponent();
        }

        public void Fkwitansi_Load(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConnection();
            conn.Open();
            da = new SqlDataAdapter("select * from View_Kwitansi where NomorKwitansi  = '" +
               FTransaksi.ObjTransaksi.TxtNoKwitansi.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "View_Kwitansi");

            //memanggil report cetakkwitansi yang ada pada packages laporan
            Laporan.CetakKwitansi myReport = new Laporan.CetakKwitansi();
            myReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myReport;
            crystalReportViewer1.Refresh();
        }

        private void CetakKwitansi1_InitReport(object sender, EventArgs e)
        {

        }

        private void CetakKwitansi1_InitReport_1(object sender, EventArgs e)
        {

        }


        }
    }
