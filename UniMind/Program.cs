//using UniMind.Utils;

//namespace UniMind
//{
//    internal static class Program
//    {
//        /// <summary>
//        ///  The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            // To customize application configuration such as set high DPI settings or default font,
//            // see https://aka.ms/applicationconfiguration.
//            ApplicationConfiguration.Initialize();
//            Application.Run(new Form1());
//        }
//    }
//}



//using UniMind.Utils;

//static void Main()
//{
//    // Test koneksi database
//    DatabaseHelper db = new DatabaseHelper();
//    if (db.TestConnection())
//    {
//        MessageBox.Show("Koneksi database BERHASIL!", "Info",
//            MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    else
//    {
//        MessageBox.Show("Koneksi database GAGAL! Periksa connection string.", "Error",
//            MessageBoxButtons.OK, MessageBoxIcon.Error);
//        return;
//    }

//    // Lanjut ke form login
//    Application.EnableVisualStyles();
//    Application.SetCompatibleTextRenderingDefault(false);
//    Application.Run(new Form());
//}

using System;
using System.Windows.Forms;
//using pboFinalProfject.Views.Mahasiswa;  // nanti sesuaikan dengan namespace view

namespace pboFinalProfject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // ganti Form1 dengan FormLogin nantinya
        }
    }
}