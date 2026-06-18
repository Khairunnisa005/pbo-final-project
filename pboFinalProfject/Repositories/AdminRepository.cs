using Npgsql;
using pboFinalProfject.Utils;
using pboFinalProfject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.Repositories
{
    public class AdminRepository
    {
        private readonly DatabaseHelper _db;

        public AdminRepository()
        {
            _db = new DatabaseHelper();
        }
        public bool UpdateMahasiswa(User mahasiswa)
        {
            // Query untuk mengupdate data di tabel users (atau tabel mahasiswa jika dipisah)
            // Sesuaikan 'users', 'nama_lengkap', 'email', 'no_telepon', 'username', dan 'user_id' dengan kolom database Anda
            string query = @"UPDATE users 
                             SET username = @username,
                                 nama_lengkap = @nama, 
                                 email = @email, 
                                 no_telepon = @telepon
                             WHERE user_id = @userId";

            try
            {
                // Hubungkan dengan class koneksi database Anda (misal: DatabaseConnection atau DBHelper)
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Parameterized Query untuk mencegah SQL Injection
                        cmd.Parameters.AddWithValue("@username", mahasiswa.Username); // NIM biasanya di username
                        cmd.Parameters.AddWithValue("@nama", mahasiswa.NamaLengkap);
                        cmd.Parameters.AddWithValue("@email", mahasiswa.Email);
                        cmd.Parameters.AddWithValue("@telepon", mahasiswa.NoTelepon);
                        cmd.Parameters.AddWithValue("@userId", mahasiswa.UserId);

                        // Jalankan query ke database
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Jika ada baris yang terupdate, kembalikan nilai true
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Lempar error ke layer atas agar bisa ditangkap oleh MessageBox di View
                throw new Exception("Gagal mengupdate database mahasiswa: " + ex.Message);
            }
        }
    }
}
