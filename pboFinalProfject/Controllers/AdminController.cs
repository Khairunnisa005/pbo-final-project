using pboFinalProfject.Model;
using pboFinalProfject.Repositories;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pboFinalProfject.Controllers
{
    internal class AdminController
    {
        private readonly AdminRepository _adminRepository;
        public AdminController()
        {
            _adminRepository = new AdminRepository();
        }

        // dashboard
        public DataTable GetStatistikDashboard()
        {
            return _adminRepository.GetStatistikDashboard();
        }

        public DataTable GetDaftarBookingTerbaru(int limit)
        {
            return _adminRepository.GetDaftarBookingTerbaru(limit);
        }

        public DataTable GetDaftarBookingHariIni()
        {
            return _adminRepository.GetDaftarBookingHariIni();
        }

        // kelola psikolog
        public DataTable GetDaftarPsikolog()
        {
            return _adminRepository.GetDaftarPsikolog();
        }

        public DataTable GetPsikologById(int psikologId)
        {
            return _adminRepository.GetPsikologById(psikologId);
        }

        public bool TambahPsikolog(User user, Psikolog psikolog, List<string> keahlianList = null)
        {
            return _adminRepository.TambahPsikolog(user, psikolog, keahlianList);
        }

        public bool UpdatePsikolog(User user, Psikolog psikolog)
        {
            return _adminRepository.UpdatePsikolog(user, psikolog);
        }

        public bool HapusPsikolog(int psikologId)
        {
            return _adminRepository.HapusPsikolog(psikologId);
        }

        // kelola mahasiswa
        public DataTable GetDaftarMahasiswa()
        {
            return _adminRepository.GetDaftarMahasiswa();
        }

        public bool UpdateMahasiswa(User mahasiswa)
        {
            return _adminRepository.UpdateMahasiswa(mahasiswa);
        }

        public bool HapusMahasiswa(int userId)
        {
            return _adminRepository.HapusMahasiswa(userId);
        }

        // laporan
        public DataTable GetLaporanBooking(DateTime startDate, DateTime endDate, string status = null)
        {
            return _adminRepository.GetLaporanBooking(startDate, endDate, status);
        }

        public string ExportLaporanToCsv(DateTime startDate, DateTime endDate, string status = null)
        {
            return _adminRepository.ExportLaporanToCsv(startDate, endDate, status);
        }




        //// Dashboard Statistik
        //public DataTable GetStatistikDashboard()
        //{
        //    string query = @"
        //        SELECT 
        //            (SELECT COUNT (*) FROM users WHERE role = 'Mahasiswa') as total_mahasiswa,
        //            (SELECT COUNT (*) FROM users WHERE role = 'Psikolog') as total_psikolog,
        //            (SELECT COUNT (*) FROM booking) as total_booking,
        //            (SELECT COUNT (*) FROM booking WHERE status = 'Pending' AND created_at = CURRENT_DATE) as antrean_hari_ini,
        //            (SELECT COUNT (*) FROM booking WHERE status = 'Pending') as booking_pending,
        //            (SELECT COUNT (*) FROM booking WHERE status = 'Selesai') as booking_selesai";
        //    return _db.ExecuteQuery(query);
        //}
        //public DataTable GetDaftarBookingTerbaru(int limit)
        //{
        //    string query = @"
        //        SELECT 
        //            b.booking_id,
        //            b.created_at as tanggal,
        //            u.username as mahasiswa,
        //            p2.nama_lengkap as psikolog,
        //            b.status
        //        FROM booking b 
        //        JOIN users u ON b.user_id = u.user_id
        //        JOIN psikolog ps ON b.psikolog_id = ps.psikolog_id
        //        JOIN users p2 ON ps.user_id = p2.user_id
        //       ORDER BY b.created_at DESC LIMIT @limit";

        //    var parameters = new[] { new NpgsqlParameter("@limit", limit) };
        //    return _db.ExecuteQuery(query, parameters);
        //}

        //public DataTable GetDaftarBookingHariIni()
        //{
        //    string query = @"
        //        SELECT 
        //            b.booking_id,
        //            b.jam_mulai,
        //            u.username as mahasiswa,
        //            p2.nama_lengkap as psikolog,
        //            j.metode,
        //            b.status
        //        FROM booking b
        //        JOIN users u ON b.user_id = u.user_id
        //        JOIN psikolog ps ON b.psikolog_id = ps.psikolog_id
        //        JOIN users p2 ON ps.user_id = p2.user_id
        //        JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
        //        WHERE b.created_at = CURRENT_DATE
        //        AND b.status IN ('Pending', 'Disetujui')
        //        ORDER BY b.jam_mulai ASC";

        //    return _db.ExecuteQuery(query);
        //}

        //public DataTable GetDaftarPsikolog()
        //{
        //    string query = @"
        //        SELECT 
        //            p.psikolog_id,
        //            u.user_id,
        //            u.username,
        //            u.email,
        //            u.no_telepon,
        //            u.nama_lengkap,
        //            p.gelar,
        //            p.pendidikan,
        //            p.no_izin_praktek,
        //            p.deskripsi_singkat,
        //            p.melayani_online,
        //            p.melayani_offline,
        //            u.created_at as tgl_bergabung,
        //            (SELECT string_agg(nama_keahlian, ', ') FROM keahlian_psikolog WHERE psikolog_id = p.psikolog_id) as keahlian
        //        FROM psikolog p
        //        JOIN users u ON p.user_id = u.user_id
        //        ORDER BY u.created_at DESC";
        //    return _db.ExecuteQuery(query);
        //}

        //public bool TambahPsikolog(User user, Psikolog psikolog)
        //{
        //    using (var conn = _db.GetConnection())
        //    {
        //        conn.Open();
        //        using (var trans = conn.BeginTransaction())
        //        {
        //            try
        //            {
        //                // Insert ke users
        //                string userQuery = @"
        //                    INSERT INTO users (username, email, no_telepon, password_hash, nama_lengkap, role, created_at) 
        //                    VALUES (@username, @email, @no_telepon, @password_hash, @nama_lengkap, 'Psikolog', @created_at)
        //                    RETURNING user_id";

        //                using (var cmd = new NpgsqlCommand(userQuery, conn, trans))
        //                {
        //                    cmd.Parameters.AddWithValue("@username", user.Username);
        //                    cmd.Parameters.AddWithValue("@email", user.Email);
        //                    cmd.Parameters.AddWithValue("@no_telepon", (object)user.NoTelepon ?? DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@password_hash", user.PasswordHash);
        //                    cmd.Parameters.AddWithValue("@nama_lengkap", (object)user.NamaLengkap ?? DBNull.Value);
        //                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

        //                    int userId = Convert.ToInt32(cmd.ExecuteScalar());

        //                    // Insert ke psikolog
        //                    string psikologQuery = @"
        //                        INSERT INTO psikolog (user_id, gelar, pendidikan, no_izin_praktek, deskripsi_singkat, melayani_online, melayani_offline, created_at) 
        //                        VALUES (@user_id, @gelar, @pendidikan, @no_izin_praktek, @deskripsi_singkat, @melayani_online, @melayani_offline, @created_at)";

        //                    using (var cmd2 = new NpgsqlCommand(psikologQuery, conn, trans))
        //                    {
        //                        cmd2.Parameters.AddWithValue("@user_id", userId);
        //                        cmd2.Parameters.AddWithValue("@gelar", (object)psikolog.Gelar ?? DBNull.Value);
        //                        cmd2.Parameters.AddWithValue("@pendidikan", (object)psikolog.Pendidikan ?? DBNull.Value);
        //                        cmd2.Parameters.AddWithValue("@no_izin_praktek", (object)psikolog.NoIzinPraktek ?? DBNull.Value);
        //                        cmd2.Parameters.AddWithValue("@deskripsi_singkat", (object)psikolog.DeskripsiSingkat ?? DBNull.Value);
        //                        cmd2.Parameters.AddWithValue("@melayani_online", psikolog.MelayaniOnline);
        //                        cmd2.Parameters.AddWithValue("@melayani_offline", psikolog.MelayaniOffline);
        //                        cmd2.Parameters.AddWithValue("@created_at", DateTime.Now);

        //                        cmd2.ExecuteNonQuery();
        //                    }
        //                }

        //                trans.Commit();
        //                return true;
        //            }
        //            catch
        //            {
        //                trans.Rollback();
        //                throw;
        //            }
        //        }
        //    }
        //}

        //public DataTable GetPsikologById(int psikologId)
        //{
        //    string query = @"
        //        SELECT 
        //            p.psikolog_id,
        //            u.user_id,
        //            u.username,
        //            u.email,
        //            u.no_telepon,
        //            u.nama_lengkap,
        //            p.gelar,
        //            p.pendidikan,
        //            p.no_izin_praktek,
        //            p.deskripsi_singkat,
        //            p.melayani_online,
        //            p.melayani_offline,
        //            u.created_at
        //        FROM psikolog p
        //        JOIN users u ON p.user_id = u.user_id
        //        WHERE p.psikolog_id = @psikolog_id";

        //    var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
        //    return _db.ExecuteQuery(query, parameters);
        //}

        //public bool TambahPsikolog(User user, Psikolog psikolog)
        //{
        //    // Gunakan transaksi untuk insert ke users dan psikolog
        //    using (var conn = _db.GetConnection())
        //    {
        //        conn.Open();
        //        using (var trans = conn.BeginTransaction())
        //        {
        //            try
        //            {
        //                // Insert ke users
        //                string userQuery = @"
        //                    INSERT INTO users (username, email, no_telepon, password_hash, nama_lengkap, role, created_at) 
        //                    VALUES (@username, @email, @no_telepon, @password_hash, @nama_lengkap, 'Psikolog', @created_at)
        //                    RETURNING user_id";

        //                var userParams = new[]
        //                {
        //                    new NpgsqlParameter("@username", user.Username),
        //                    new NpgsqlParameter("@email", user.Email),
        //                    new NpgsqlParameter("@no_telepon", (object)user.NoTelepon ?? DBNull.Value),
        //                    new NpgsqlParameter("@password_hash", user.PasswordHash),
        //                    new NpgsqlParameter("@nama_lengkap", user.NamaLengkap),
        //                    new NpgsqlParameter("@created_at", DateTime.Now)
        //                };

        //                using (var cmd = new NpgsqlCommand(userQuery, conn, trans))
        //                {
        //                    cmd.Parameters.AddRange(userParams);
        //                    int userId = Convert.ToInt32(cmd.ExecuteScalar());

        //                    // Insert ke psikolog
        //                    string psikologQuery = @"
        //                        INSERT INTO psikolog (user_id, gelar, pendidikan, no_izin_praktek, deskripsi_singkat, melayani_online, melayani_offline, created_at) 
        //                        VALUES (@user_id, @gelar, @pendidikan, @no_izin_praktek, @deskripsi_singkat, @melayani_online, @melayani_offline, @created_at)";

        //                    var psikologParams = new[]
        //                    {
        //                        new NpgsqlParameter("@user_id", userId),
        //                        new NpgsqlParameter("@gelar", (object)psikolog.Gelar ?? DBNull.Value),
        //                        new NpgsqlParameter("@pendidikan", (object)psikolog.Pendidikan ?? DBNull.Value),
        //                        new NpgsqlParameter("@no_izin_praktek", (object)psikolog.NoIzinPraktek ?? DBNull.Value),
        //                        new NpgsqlParameter("@deskripsi_singkat", (object)psikolog.DeskripsiSingkat ?? DBNull.Value),
        //                        new NpgsqlParameter("@melayani_online", psikolog.MelayaniOnline),
        //                        new NpgsqlParameter("@melayani_offline", psikolog.MelayaniOffline),
        //                        new NpgsqlParameter("@created_at", DateTime.Now)

        //                    };

        //                    using (var cmd2 = new NpgsqlCommand(psikologQuery, conn, trans))
        //                    {
        //                        cmd2.Parameters.AddRange(psikologParams);
        //                        cmd2.ExecuteNonQuery();
        //                    }
        //                }

        //                trans.Commit();
        //                return true;
        //            }
        //            catch
        //            {
        //                trans.Rollback();
        //                throw;
        //            }
        //        }
        //    }
        //}
        //public bool UpdatePsikolog(User user, Psikolog psikolog)
        //{
        //    string userQuery = @"
        //        UPDATE users 
        //        SET username = @username, email = @email, no_telepon = @no_telepon, nama_lengkap = @nama_lengkap
        //        WHERE user_id = @user_id";

        //    var userParams = new[]
        //    {
        //        new NpgsqlParameter("@user_id", user.UserId),
        //        new NpgsqlParameter("@username", user.Username),
        //        new NpgsqlParameter("@email", user.Email),
        //        new NpgsqlParameter("@no_telepon", (object)user.NoTelepon ?? DBNull.Value),
        //        new NpgsqlParameter("@nama_lengkap", user.NamaLengkap)
        //    };

        //    bool userUpdated = _db.ExecuteNonQuery(userQuery, userParams) > 0;

        //    string psikologQuery = @"
        //        UPDATE psikolog 
        //        SET gelar = @gelar, pendidikan = @pendidikan, no_izin_praktek = @no_izin_praktek,
        //            deskripsi_singkat = @deskripsi_singkat, melayani_online = @melayani_online, melayani_offline = @melayani_offline
        //        WHERE psikolog_id = @psikolog_id";

        //    var psikologParams = new[]
        //    {
        //        new NpgsqlParameter("@psikolog_id", psikolog.PsikologId),
        //        new NpgsqlParameter("@gelar", (object)psikolog.Gelar ?? DBNull.Value),
        //        new NpgsqlParameter("@pendidikan", (object)psikolog.Pendidikan ?? DBNull.Value),
        //        new NpgsqlParameter("@no_izin_praktek", (object)psikolog.NoIzinPraktek ?? DBNull.Value),
        //        new NpgsqlParameter("@deskripsi_singkat", (object)psikolog.DeskripsiSingkat ?? DBNull.Value),
        //        new NpgsqlParameter("@melayani_online", psikolog.MelayaniOnline),
        //        new NpgsqlParameter("@melayani_offline", psikolog.MelayaniOffline)
        //    };

        //    bool psikologUpdated = _db.ExecuteNonQuery(psikologQuery, psikologParams) > 0;
        //    return userUpdated && psikologUpdated;
        //}

        //public bool HapusPsikolog(int psikologId)
        //{
        //    // Cari user_id terlebih dahulu
        //    string getUserIdQuery = "SELECT user_id FROM psikolog WHERE psikolog_id = @psikolog_id";
        //    var getParams = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
        //    var userIdObj = _db.ExecuteScalar(getUserIdQuery, getParams);

        //    if (userIdObj == null) return false;
        //    int userId = Convert.ToInt32(userIdObj);

        //    // Hapus psikolog (CASCADE akan menghapus user juga jika ON DELETE CASCADE)
        //    string query = "DELETE FROM psikolog WHERE psikolog_id = @psikolog_id";
        //    var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
        //    return _db.ExecuteNonQuery(query, parameters) > 0;
        //}

        // Kelola Mahasiswa

        //public DataTable GetDaftarMahasiswa()
        //{
        //    string query = @"
        //        SELECT 
        //            user_id,
        //            username,
        //            email,
        //            no_telepon,
        //            nama_lengkap,
        //            preferensi_waktu,
        //            created_at as tgl_daftar,
        //            (SELECT COUNT(*) FROM booking WHERE user_id = users.user_id) as total_konseling
        //        FROM users 
        //        WHERE role = 'Mahasiswa'
        //        ORDER BY created_at DESC";
        //    return _db.ExecuteQuery(query);
        //}

        //public bool ResetPassword(int userId, string passwordBaru)
        //{
        //    string query = "UPDATE users SET password_hash = @password WHERE user_id = @user_id";
        //    var parameters = new[]
        //    {
        //        new NpgsqlParameter("@user_id", userId),
        //        new NpgsqlParameter("@password", passwordBaru)
        //    };
        //    return _db.ExecuteNonQuery(query, parameters) > 0;
        //}

        //public bool HapusMahasiswa(int userId)
        //{
        //    string query = "DELETE FROM users WHERE user_id = @user_id AND role = 'Mahasiswa'";
        //    var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
        //    return _db.ExecuteNonQuery(query, parameters) > 0;
        //}

        // Laporan

        //public DataTable GetLaporanBooking(DateTime startDate, DateTime endDate, string status = null)
        //{
        //    // Tambah 1 hari ke endDate agar mencakup seluruh hari
        //    DateTime endDateInclusive = endDate.AddDays(1);

        //    string query = @"
        //        SELECT 
        //            b.booking_id,
        //            b.created_at as tgl_booking,
        //            u.username as mahasiswa,
        //            u.email as email_mahasiswa,
        //            p2.nama_lengkap as psikolog,
        //            COALESCE(j.metode, '-') as metode,
        //            b.status,
        //            COALESCE(b.catatan_user, '-') as catatan_user,
        //            COALESCE(b.catatan_psikolog, '-') as catatan_psikolog
        //        FROM booking b
        //        INNER JOIN users u ON b.user_id = u.user_id
        //        INNER JOIN psikolog ps ON b.psikolog_id = ps.psikolog_id
        //        INNER JOIN users p2 ON ps.user_id = p2.user_id
        //        LEFT JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
        //        WHERE b.created_at >= @start_date AND b.created_at < @end_date";

        //            var parameters = new List<NpgsqlParameter>
        //    {
        //        new NpgsqlParameter("@start_date", startDate),
        //        new NpgsqlParameter("@end_date", endDateInclusive)
        //    };

        //            if (!string.IsNullOrEmpty(status) && status != "Semua")
        //            {
        //                query += " AND b.status = @status";
        //                parameters.Add(new NpgsqlParameter("@status", status));
        //            }

        //            query += " ORDER BY b.created_at DESC";

        //            return _db.ExecuteQuery(query, parameters.ToArray());
        //}

        //public string ExportLaporanToCsv(DateTime startDate, DateTime endDate, string status = null)
        //{
        //    DataTable dt = GetLaporanBooking(startDate, endDate, status);

        //    if (dt.Rows.Count == 0)
        //        return "";

        //    string csv = "";

        //    // Header
        //    string[] headers = { "Tanggal Booking", "Mahasiswa", "Email", "Psikolog", "Metode", "Status", "Catatan User", "Catatan Psikolog" };
        //    csv += string.Join(",", headers) + "\n";

        //    // Data
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        string tanggal = Convert.ToDateTime(row["tgl_booking"]).ToString("dd/MM/yyyy HH:mm");
        //        string mahasiswa = row["mahasiswa"].ToString().Replace(",", ";");
        //        string email = row["email_mahasiswa"].ToString().Replace(",", ";");
        //        string psikolog = row["psikolog"].ToString().Replace(",", ";");
        //        string metode = row["metode"].ToString();
        //        string statusVal = row["status"].ToString();
        //        string catatanUser = row["catatan_user"]?.ToString().Replace(",", ";").Replace("\n", " ") ?? "";
        //        string catatanPsikolog = row["catatan_psikolog"]?.ToString().Replace(",", ";").Replace("\n", " ") ?? "";

        //        csv += $"{tanggal},{mahasiswa},{email},{psikolog},{metode},{statusVal},{catatanUser},{catatanPsikolog}\n";
        //    }

        //    return csv;
        //}

        //public bool UpdateMahasiswa(User user)
        //{
        //    if (user == null)
        //    {
        //        throw new ArgumentNullException(nameof(user), "Data mahasiswa tidak boleh kosong.");
        //    }

        //    if (user.UserId == 0)
        //    {
        //        throw new Exception("ID Mahasiswa tidak valid untuk proses update.");
        //    }

        //    // Panggil fungsi update yang ada di layer Repository / Data Access
        //    // Sesuaikan '_adminRepository' dengan nama instance repository milik Anda
        //    return _adminRepository.UpdateMahasiswa(user);
        //}
    }
    
}
