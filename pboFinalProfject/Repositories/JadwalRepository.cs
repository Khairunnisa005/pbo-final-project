using Npgsql;
using pboFinalProfject.Models;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql;
using pboFinalProfject.Utils;

namespace pboFinalProfject.Repositories
{
    public class JadwalRepository
    {
        private readonly DatabaseHelper _db;

        public JadwalRepository()
        {
            _db = new DatabaseHelper();
        }

        public DataTable GetAllActive()
        {
            string query = @"SELECT j.jadwal_id, j.psikolog_id, j.hari, j.jam_mulai, j.jam_selesai, j.metode, j.kuota, u.nama_lengkap as psikolog_nama
                             FROM jadwal_psikolog j
                             JOIN psikolog p ON j.psikolog_id = p.psikolog_id
                             JOIN users u ON p.user_id = u.user_id
                             WHERE j.is_active = true
                             ORDER BY
                                CASE j.hari
                                    WHEN 'Senin' THEN 1
                                    WHEN 'Selasa' THEN 2
                                    WHEN 'Rabu' THEN 3
                                    WHEN 'Kamis' THEN 4
                                    WHEN 'Jumat' THEN 5
                                    WHEN 'Sabtu' THEN 6
                                    WHEN 'Minggu' THEN 7
                                END, j.jam_mulai";

            return _db.ExecuteQuery(query);
        }

        public DataTable GetByPsikologId(int psikologId)
        {
            string query = @"
                SELECT jadwal_id, hari, jam_mulai, jam_selesai, metode, kuota, is_active 
                FROM jadwal_psikolog 
                WHERE psikolog_id = @psikolog_id 
                ORDER BY 
                    CASE hari 
                        WHEN 'Senin' THEN 1
                        WHEN 'Selasa' THEN 2
                        WHEN 'Rabu' THEN 3
                        WHEN 'Kamis' THEN 4
                        WHEN 'Jumat' THEN 5
                        WHEN 'Sabtu' THEN 6
                        WHEN 'Minggu' THEN 7
                    END, 
                    jam_mulai";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public bool TambahJadwal(int psikologId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            if (jamMulai >= jamSelesai)
                throw new Exception("Jam mulai harus lebih awal dari jam selesai!");

            // Cek bentrok
            string cekQuery = @"SELECT COUNT(*) FROM jadwal_psikolog 
                WHERE psikolog_id = @psikolog_id 
                AND hari = @hari 
                AND ((jam_mulai <= @jam_mulai AND jam_selesai > @jam_mulai)
                  OR (jam_mulai < @jam_selesai AND jam_selesai >= @jam_selesai)
                  OR (@jam_mulai <= jam_mulai AND @jam_selesai >= jam_selesai))";

            var cekParams = new[]
            {
                new NpgsqlParameter("@psikolog_id", psikologId),
                new NpgsqlParameter("@hari", hari),
                new NpgsqlParameter("@jam_mulai", jamMulai),
                new NpgsqlParameter("@jam_selesai", jamSelesai)
            };

            int count = Convert.ToInt32(_db.ExecuteScalar(cekQuery, cekParams));
            if (count > 0)
                throw new Exception("Jadwal bentrok dengan jadwal yang sudah ada!");

            string query = @"INSERT INTO jadwal_psikolog (psikolog_id, hari, jam_mulai, jam_selesai, metode, kuota, is_active, created_at) 
                             VALUES (@psikolog_id, @hari, @jam_mulai, @jam_selesai, @metode, @kuota, @is_active, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@psikolog_id", psikologId),
                new NpgsqlParameter("@hari", hari),
                new NpgsqlParameter("@jam_mulai", jamMulai),
                new NpgsqlParameter("@jam_selesai", jamSelesai),
                new NpgsqlParameter("@metode", metode),
                new NpgsqlParameter("@kuota", kuota),
                new NpgsqlParameter("@is_active", isActive),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateJadwal(int jadwalId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            if (jamMulai >= jamSelesai)
                throw new Exception("Jam mulai harus lebih awal dari jam selesai!");

            string query = @"UPDATE jadwal_psikolog 
                             SET hari = @hari, jam_mulai = @jam_mulai, jam_selesai = @jam_selesai, metode = @metode, kuota = @kuota, is_active = @is_active 
                             WHERE jadwal_id = @jadwal_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@jadwal_id", jadwalId),
                new NpgsqlParameter("@hari", hari),
                new NpgsqlParameter("@jam_mulai", jamMulai),
                new NpgsqlParameter("@jam_selesai", jamSelesai),
                new NpgsqlParameter("@metode", metode),
                new NpgsqlParameter("@kuota", kuota),
                new NpgsqlParameter("@is_active", isActive)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool HapusJadwal(int jadwalId)
        {
            string cekQuery = "SELECT COUNT(*) FROM booking WHERE jadwal_id = @jadwal_id";
            var cekParams = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            int count = Convert.ToInt32(_db.ExecuteScalar(cekQuery, cekParams));

            if (count > 0)
                throw new Exception("Tidak dapat menghapus jadwal karena sudah ada booking yang terkait!");

            string query = "DELETE FROM jadwal_psikolog WHERE jadwal_id = @jadwal_id";
            var parameters = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }
    public class JadwalRepository
    {
        private readonly DatabaseHelper _db;

        public JadwalRepository()
        {
            _db = new DatabaseHelper();
        }

        public JadwalPsikolog GetById(int jadwalId)
        {
            string query = "SELECT * FROM jadwal_psikolog WHERE jadwal_id = @jadwal_id";
            var parameters = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToJadwal(dt.Rows[0]);
            return null;
        }

        public DataTable GetByPsikologId(int psikologId)
        {
            string query = @"
                SELECT jadwal_id, hari, jam_mulai, jam_selesai, metode, kuota, is_active, created_at 
                FROM jadwal_psikolog 
                WHERE psikolog_id = @psikolog_id 
                ORDER BY 
                    CASE hari 
                        WHEN 'Senin' THEN 1
                        WHEN 'Selasa' THEN 2
                        WHEN 'Rabu' THEN 3
                        WHEN 'Kamis' THEN 4
                        WHEN 'Jumat' THEN 5
                        WHEN 'Sabtu' THEN 6
                        WHEN 'Minggu' THEN 7
                    END, 
                    jam_mulai";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public DataTable GetAll()
        {
            string query = @"
                SELECT j.*, u.nama_lengkap as psikolog_nama
                FROM jadwal_psikolog j
                JOIN psikolog p ON j.psikolog_id = p.psikolog_id
                JOIN users u ON p.user_id = u.user_id
                ORDER BY j.created_at DESC";

            return _db.ExecuteQuery(query);
        }

        public bool Insert(JadwalPsikolog entity)
        {
            string query = @"
                INSERT INTO jadwal_psikolog (psikolog_id, hari, jam_mulai, jam_selesai, metode, kuota, is_active, created_at) 
                VALUES (@psikolog_id, @hari, @jam_mulai, @jam_selesai, @metode, @kuota, @is_active, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@psikolog_id", entity.PsikologId),
                new NpgsqlParameter("@hari", entity.Hari),
                new NpgsqlParameter("@jam_mulai", entity.JamMulai),
                new NpgsqlParameter("@jam_selesai", entity.JamSelesai),
                new NpgsqlParameter("@metode", entity.Metode),
                new NpgsqlParameter("@kuota", entity.Kuota),
                new NpgsqlParameter("@is_active", entity.IsActive),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(JadwalPsikolog entity)
        {
            string query = @"
                UPDATE jadwal_psikolog 
                SET hari = @hari, 
                    jam_mulai = @jam_mulai, 
                    jam_selesai = @jam_selesai, 
                    metode = @metode, 
                    kuota = @kuota, 
                    is_active = @is_active 
                WHERE jadwal_id = @jadwal_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@jadwal_id", entity.JadwalId),
                new NpgsqlParameter("@hari", entity.Hari),
                new NpgsqlParameter("@jam_mulai", entity.JamMulai),
                new NpgsqlParameter("@jam_selesai", entity.JamSelesai),
                new NpgsqlParameter("@metode", entity.Metode),
                new NpgsqlParameter("@kuota", entity.Kuota),
                new NpgsqlParameter("@is_active", entity.IsActive)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(int jadwalId)
        {
            string query = "DELETE FROM jadwal_psikolog WHERE jadwal_id = @jadwal_id";
            var parameters = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsSlotAvailable(int jadwalId)
        {
            string query = @"
                SELECT 
                    CASE 
                        WHEN j.kuota > COALESCE(b.jumlah_booking, 0) AND j.is_active = true 
                        THEN true 
                        ELSE false 
                    END as tersedia
                FROM jadwal_psikolog j
                LEFT JOIN (
                    SELECT jadwal_id, COUNT(*) as jumlah_booking
                    FROM booking
                    WHERE status IN ('Pending', 'Disetujui')
                    GROUP BY jadwal_id
                ) b ON j.jadwal_id = b.jadwal_id
                WHERE j.jadwal_id = @jadwal_id";

            var parameters = new[] { new NpgsqlParameter("@jadwal_id", jadwalId) };
            object result = _db.ExecuteScalar(query, parameters);
            return result != null && Convert.ToBoolean(result);
        }

        private JadwalPsikolog MapToJadwal(DataRow row)
        {
            return new JadwalPsikolog
            {
                JadwalId = Convert.ToInt32(row["jadwal_id"]),
                PsikologId = Convert.ToInt32(row["psikolog_id"]),
                Hari = row["hari"].ToString(),
                JamMulai = (TimeSpan)row["jam_mulai"],
                JamSelesai = (TimeSpan)row["jam_selesai"],
                Metode = row["metode"].ToString(),
                Kuota = Convert.ToInt32(row["kuota"]),
                IsActive = Convert.ToBoolean(row["is_active"]),
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }

    }
}
