using System;
using System.Data;
using Npgsql;
using pboFinalProfject.Utils;

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

            var param = new Npgsql.NpgsqlParameter[] { new Npgsql.NpgsqlParameter("@keahlian", keahlian) };
            return _db.ExecuteQuery(query, param);
        }
    }
}
