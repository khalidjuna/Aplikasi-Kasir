using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_kasir
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>D:\Kuliah\BAHASA PEMROGRAMAN\Visual Studio\aplikasi_kasir_23-10\aplikasi_kasir_22-10\aplikasi_kasir\aplikasi_kasir\aplikasi_kasir\Program.cs
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gui.FTransaksi());
        }
    }
}
