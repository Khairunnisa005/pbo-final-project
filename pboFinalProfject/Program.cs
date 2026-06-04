using pboFinalProfject;
using pboFinalProfject.Utils;

namespace pboFinalProfject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //// TEST KONEKSI DATABASE
            //DatabaseHelper db = new DatabaseHelper();
            //if (db.TestConnection())
            //{
            //    MessageBox.Show("✅ Koneksi database BERHASIL!", "Info",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("❌ Koneksi database GAGAL!\n\nPeriksa:\n1. Apakah PostgreSQL sudah running?\n2. Apakah database 'unimind' sudah dibuat?\n3. Apakah username/password di connection string benar?",
            //        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return; // Hentikan program jika koneksi gagal
            //}

            // Lanjut ke aplikasi
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin()); // Ganti dengan form login kalian
        }
    }
}