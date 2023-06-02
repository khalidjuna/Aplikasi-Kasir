using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;    
using System.Data.SqlClient;

namespace aplikasi_kasir.Kelas
{
    class koneksi
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=LH;Initial Catalog=penjualan;Integrated Security=True";
            return conn;
        }
    }
}
