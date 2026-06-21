using Npgsql;
using pboFinalProfject.Model;
using pboFinalProfject.Utils;
using System;
using System.Data;
using System.Collections.Generic;

namespace pboFinalProfject.Repositories
{
    public class PsikologRepository
    {
        private readonly DatabaseHelper _db;

        public PsikologRepository()
        {
            _db = new DatabaseHelper();
        }
        public int GetPsikologIdbyUserId(int userId)
        {
            string query = "SELECT psikolog_id FROM psikolog WHERE user_id = @user_id";
            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };

            object result = _db.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetDaftarPasienbyPsikologId(int psikologId)
        {
            string query = @"
                SELECT 
                    b.booking_id,
                    b.user_id,
                    b.psikolog_id,
                    u.username as mahasiswa,
                    b.created_at as tgl_booking,
                    j.jam_mulai,
                    j.jam_selesai,
                    j.metode,
                    b.status,
                    b.catatan_user,
                    b.catatan_psikolog
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                WHERE b.psikolog_id = @psikolog_id
                ORDER BY b.created_at DESC, j.jam_mulai ASC";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public DataTable GetProfilPsikologbyUserId(int userId)
        {
            // 1. Definisikan string kueri SQL
            string query = @"SELECT u.username, u.nama_lengkap, u.email, u.no_telepon, 
                                    p.gelar, p.pendidikan, p.no_izin_praktek, p.deskripsi_singkat, 
                                    p.melayani_online, p.melayani_offline 
                             FROM ""users"" u
                             JOIN ""psikolog"" p ON u.user_id = p.user_id 
                             WHERE u.user_id = @userId";

            // 2. Siapkan parameter yang dibutuhkan kueri
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@userId", userId)
            };

            try
            {
                // 3. Eksekusi kueri langsung melalui perantara DatabaseHelper
                return _db.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan pada Controller saat mengambil profil: {ex.Message}");
            }
        }

        public bool UpdateprofilPsikolog(int userId, string nama, string email, string telepon, string gelar, string pendidikan, string izin, string deskripsi, bool online, bool offline)
        {
            // 1. Kumpulkan kueri-kueri yang akan dijalankan
            List<string> queries = new List<string>
            {
                @"UPDATE users 
                  SET nama_lengkap = @nama, email = @email, no_telepon = @telepon 
                  WHERE user_id = @userId",

                @"UPDATE psikolog
                  SET gelar = @gelar, pendidikan = @pendidikan, 
                      no_izin_praktek = @izin, deskripsi_singkat = @deskripsi, 
                      melayani_online = @online, melayani_offline = @offline 
                  WHERE user_id = @userId"
            };

            // 2. Siapkan parameter untuk masing-masing kueri secara berurutan
            NpgsqlParameter[] paramUser = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@telepon", telepon),
                new NpgsqlParameter("@userId", userId)
            };

            NpgsqlParameter[] paramPsikolog = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@gelar", gelar),
                new NpgsqlParameter("@pendidikan", pendidikan),
                new NpgsqlParameter("@izin", izin),
                new NpgsqlParameter("@deskripsi", deskripsi),
                new NpgsqlParameter("@online", online),
                new NpgsqlParameter("@offline", offline),
                new NpgsqlParameter("@userId", userId)
            };

            List<NpgsqlParameter[]> parameterSets = new List<NpgsqlParameter[]> { paramUser, paramPsikolog };

            try
            {
                using (var conn = _db.GetConnection())
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var cmd = new NpgsqlCommand(queries[0], conn, trans))
                            {
                                cmd.Parameters.AddRange(paramUser);
                                cmd.ExecuteNonQuery();
                            }

                            using (var cmd2 = new NpgsqlCommand(queries[1], conn, trans))
                            {
                                cmd2.Parameters.AddRange(paramPsikolog);
                                cmd2.ExecuteNonQuery();
                            }

                            trans.Commit();
                            return true;
                        }
                        catch
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Kesalahan pada Controller saat update profil: {ex.Message}");
            }
        }

        public DataTable GetAll()
        {
            string query = @"SELECT p.psikolog_id, p.user_id, u.nama_lengkap, u.username, u.email, p.gelar, p.pendidikan, p.deskripsi_singkat,
                                    CASE WHEN p.melayani_online = true AND p.melayani_offline = true THEN 'Online, Offline'
                                         WHEN p.melayani_online = true THEN 'Online'
                                         WHEN p.melayani_offline = true THEN 'Offline'
                                         ELSE 'Tidak tersedia'
                                    END as layanan
                             FROM psikolog p
                             JOIN users u ON p.user_id = u.user_id
                             ORDER BY u.nama_lengkap";

            return _db.ExecuteQuery(query);
        }

        public DataTable GetDistinctKeahlian()
        {
            string query = @"
                SELECT DISTINCT nama_keahlian
                FROM keahlian_psikolog
                WHERE nama_keahlian IS NOT NULL AND TRIM(nama_keahlian) <> ''
                ORDER BY nama_keahlian";

            return _db.ExecuteQuery(query);
        }

        public DataTable GetByKeahlian(string keahlian)
        {
            string query = @"
                SELECT p.psikolog_id, p.user_id, u.nama_lengkap, u.username, u.email, p.gelar, p.pendidikan, p.deskripsi_singkat,
                       CASE WHEN p.melayani_online = true AND p.melayani_offline = true THEN 'Online, Offline'
                            WHEN p.melayani_online = true THEN 'Online'
                            WHEN p.melayani_offline = true THEN 'Offline'
                            ELSE 'Tidak tersedia'
                       END as layanan
                FROM psikolog p
                JOIN users u ON p.user_id = u.user_id
                JOIN keahlian_psikolog k ON p.psikolog_id = k.psikolog_id
                WHERE k.nama_keahlian = @keahlian
                ORDER BY u.nama_lengkap";

            var param = new[] { new NpgsqlParameter("@keahlian", keahlian) };
            return _db.ExecuteQuery(query, param);
        }

        public Psikolog GetById(int psikologId)
        {
            string query = @"
                SELECT p.*, u.username, u.email, u.no_telepon, u.nama_lengkap, u.role
                FROM psikolog p
                JOIN users u ON p.user_id = u.user_id
                WHERE p.psikolog_id = @psikolog_id";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToPsikolog(dt.Rows[0]);
            return null;
        }

        public Psikolog GetByUserId(int userId)
        {
            string query = @"
                SELECT p.*, u.username, u.email, u.no_telepon, u.nama_lengkap, u.role
                FROM psikolog p
                JOIN users u ON p.user_id = u.user_id
                WHERE p.user_id = @user_id";

            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToPsikolog(dt.Rows[0]);
            return null;
        }

        public bool Insert(Psikolog entity)
        {
            string query = @"
                INSERT INTO psikolog (user_id, gelar, pendidikan, no_izin_praktek, deskripsi_singkat, melayani_online, melayani_offline, created_at) 
                VALUES (@user_id, @gelar, @pendidikan, @no_izin_praktek, @deskripsi_singkat, @melayani_online, @melayani_offline, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@user_id", entity.UserId),
                new NpgsqlParameter("@gelar", string.IsNullOrEmpty(entity.Gelar) ? DBNull.Value : (object)entity.Gelar),
                new NpgsqlParameter("@pendidikan", string.IsNullOrEmpty(entity.Pendidikan) ? DBNull.Value : (object)entity.Pendidikan),
                new NpgsqlParameter("@no_izin_praktek", string.IsNullOrEmpty(entity.NoIzinPraktek) ? DBNull.Value : (object)entity.NoIzinPraktek),
                new NpgsqlParameter("@deskripsi_singkat", string.IsNullOrEmpty(entity.DeskripsiSingkat) ? DBNull.Value : (object)entity.DeskripsiSingkat),
                new NpgsqlParameter("@melayani_online", entity.MelayaniOnline),
                new NpgsqlParameter("@melayani_offline", entity.MelayaniOffline),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(Psikolog entity)
        {
            string query = @"
                UPDATE psikolog 
                SET gelar = @gelar, 
                    pendidikan = @pendidikan, 
                    no_izin_praktek = @no_izin_praktek, 
                    deskripsi_singkat = @deskripsi_singkat, 
                    melayani_online = @melayani_online, 
                    melayani_offline = @melayani_offline 
                WHERE psikolog_id = @psikolog_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@psikolog_id", entity.PsikologId),
                new NpgsqlParameter("@gelar", string.IsNullOrEmpty(entity.Gelar) ? DBNull.Value : (object)entity.Gelar),
                new NpgsqlParameter("@pendidikan", string.IsNullOrEmpty(entity.Pendidikan) ? DBNull.Value : (object)entity.Pendidikan),
                new NpgsqlParameter("@no_izin_praktek", string.IsNullOrEmpty(entity.NoIzinPraktek) ? DBNull.Value : (object)entity.NoIzinPraktek),
                new NpgsqlParameter("@deskripsi_singkat", string.IsNullOrEmpty(entity.DeskripsiSingkat) ? DBNull.Value : (object)entity.DeskripsiSingkat),
                new NpgsqlParameter("@melayani_online", entity.MelayaniOnline),
                new NpgsqlParameter("@melayani_offline", entity.MelayaniOffline)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(int psikologId)
        {
            string query = "DELETE FROM psikolog WHERE psikolog_id = @psikolog_id";
            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        private Psikolog MapToPsikolog(DataRow row)
        {
            return new Psikolog
            {
                PsikologId = Convert.ToInt32(row["psikolog_id"]),
                UserId = Convert.ToInt32(row["user_id"]),
                Gelar = row.Table.Columns.Contains("gelar") && row["gelar"] != DBNull.Value ? row["gelar"].ToString() : null,
                Pendidikan = row.Table.Columns.Contains("pendidikan") && row["pendidikan"] != DBNull.Value ? row["pendidikan"].ToString() : null,
                NoIzinPraktek = row.Table.Columns.Contains("no_izin_praktek") && row["no_izin_praktek"] != DBNull.Value ? row["no_izin_praktek"].ToString() : null,
                DeskripsiSingkat = row.Table.Columns.Contains("deskripsi_singkat") && row["deskripsi_singkat"] != DBNull.Value ? row["deskripsi_singkat"].ToString() : null,
                MelayaniOnline = row.Table.Columns.Contains("melayani_online") && row["melayani_online"] != DBNull.Value && Convert.ToBoolean(row["melayani_online"]),
                MelayaniOffline = row.Table.Columns.Contains("melayani_offline") && row["melayani_offline"] != DBNull.Value && Convert.ToBoolean(row["melayani_offline"]),
                CreatedAt = row.Table.Columns.Contains("created_at") && row["created_at"] != DBNull.Value ? Convert.ToDateTime(row["created_at"]) : DateTime.MinValue,

                User = new User
                {
                    Username = row.Table.Columns.Contains("username") ? row["username"].ToString() : null,
                    Email = row.Table.Columns.Contains("email") ? row["email"].ToString() : null,
                    NoTelepon = row.Table.Columns.Contains("no_telepon") && row["no_telepon"] != DBNull.Value ? row["no_telepon"].ToString() : null,
                    NamaLengkap = row.Table.Columns.Contains("nama_lengkap") && row["nama_lengkap"] != DBNull.Value ? row["nama_lengkap"].ToString() : null,
                    Role = row.Table.Columns.Contains("role") ? row["role"].ToString() : null
                }
            };
        }
    }
}
