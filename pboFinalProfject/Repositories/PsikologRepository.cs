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
