using Npgsql;
using pboFinalProfject.Model;
using pboFinalProfject.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pboFinalProfject.Repositories
{
    public class BookingRepository
    {
        private readonly DatabaseHelper _db;

        public BookingRepository()
        {
            _db = new DatabaseHelper();
        }

        /// <summary>
        /// Update booking's jadwal and psikolog (used for reschedule from mahasiswa)
        /// </summary>
        public bool UpdateBookingJadwal(int bookingId, int psikologId, int jadwalId, string catatanUser = null)
        {
            string query = @"
                UPDATE booking
                SET psikolog_id = @psikolog_id,
                    jadwal_id = @jadwal_id,
                    catatan_user = @catatan_user,
                    status = 'Pending'
                WHERE booking_id = @booking_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@psikolog_id", psikologId),
                new NpgsqlParameter("@jadwal_id", jadwalId),
                new NpgsqlParameter("@catatan_user", string.IsNullOrEmpty(catatanUser) ? DBNull.Value : (object)catatanUser),
                new NpgsqlParameter("@booking_id", bookingId)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public Booking GetById(int bookingId)
        {
            string query = "SELECT * FROM booking WHERE booking_id = @booking_id";
            var parameters = new[] { new NpgsqlParameter("@booking_id", bookingId) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToBooking(dt.Rows[0]);
            return null;
        }

        public DataTable GetByUserId(int userId)
        {
            string query = @"
                SELECT b.*, u.nama_lengkap as psikolog_nama, j.hari, j.jam_mulai, j.jam_selesai, j.metode
                FROM booking b
                JOIN psikolog p ON b.psikolog_id = p.psikolog_id
                JOIN users u ON p.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                WHERE b.user_id = @user_id
                ORDER BY b.created_at DESC";

            var parameters = new[] { new NpgsqlParameter("@user_id", userId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public DataTable GetByPsikologId(int psikologId)
        {
            string query = @"
                SELECT b.*, u.username as mahasiswa, j.hari, j.jam_mulai, j.jam_selesai, j.metode
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                WHERE b.psikolog_id = @psikolog_id
                ORDER BY 
                    CASE b.status
                        WHEN 'Pending' THEN 1
                        WHEN 'Disetujui' THEN 2
                        WHEN 'Selesai' THEN 3
                        WHEN 'Ditolak' THEN 4
                        WHEN 'Batal' THEN 5
                    END,
                    b.created_at DESC";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public DataTable GetPendingByPsikologId(int psikologId)
        {
            string query = @"
                SELECT b.*, u.username as mahasiswa, j.hari, j.jam_mulai, j.jam_selesai, j.metode
                FROM booking b
                JOIN users u ON b.user_id = u.user_id
                JOIN jadwal_psikolog j ON b.jadwal_id = j.jadwal_id
                WHERE b.psikolog_id = @psikolog_id AND b.status = 'Pending'
                ORDER BY b.created_at ASC";

            var parameters = new[] { new NpgsqlParameter("@psikolog_id", psikologId) };
            return _db.ExecuteQuery(query, parameters);
        }

        public List<Booking> GetByStatus(string status)
        {
            List<Booking> list = new List<Booking>();
            string query = "SELECT * FROM booking WHERE status = @status ORDER BY created_at DESC";
            var parameters = new[] { new NpgsqlParameter("@status", status) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToBooking(row));

            return list;
        }

        public bool Insert(Booking entity)
        {
            string query = @"
                INSERT INTO booking (user_id, psikolog_id, jadwal_id, status, catatan_user, catatan_psikolog, hasil_assessment_id, created_at) 
                VALUES (@user_id, @psikolog_id, @jadwal_id, @status, @catatan_user, @catatan_psikolog, @hasil_assessment_id, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@user_id", entity.UserId),
                new NpgsqlParameter("@psikolog_id", entity.PsikologId),
                new NpgsqlParameter("@jadwal_id", entity.JadwalId),
                new NpgsqlParameter("@status", entity.Status),
                new NpgsqlParameter("@catatan_user", string.IsNullOrEmpty(entity.CatatanUser) ? DBNull.Value : (object)entity.CatatanUser),
                new NpgsqlParameter("@catatan_psikolog", string.IsNullOrEmpty(entity.CatatanPsikolog) ? DBNull.Value : (object)entity.CatatanPsikolog),
                new NpgsqlParameter("@hasil_assessment_id", entity.HasilAssessmentId.HasValue ? (object)entity.HasilAssessmentId.Value : DBNull.Value),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(Booking entity)
        {
            string query = @"
                UPDATE booking 
                SET status = @status, 
                    catatan_psikolog = @catatan_psikolog 
                WHERE booking_id = @booking_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@booking_id", value: GetBookingId(entity)),
                new NpgsqlParameter("@status", entity.Status),
                new NpgsqlParameter("@catatan_psikolog", string.IsNullOrEmpty(entity.CatatanPsikolog) ? DBNull.Value : (object)entity.CatatanPsikolog)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        private static int GetBookingId(Booking entity)
        {
            return GetBookingId1(entity);
        }

        private static int GetBookingId1(Booking entity)
        {
            return GetBookingId2(entity);

            static int GetBookingId2(Booking entity)
            {
                return entity.BookingId;
            }
        }

        public bool UpdateStatus(int bookingId, string status, string catatanPsikolog = null)
        {
            string query = @"
                UPDATE booking 
                SET status = @status, 
                    catatan_psikolog = @catatan_psikolog 
                WHERE booking_id = @booking_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@booking_id", bookingId),
                new NpgsqlParameter("@status", status),
                new NpgsqlParameter("@catatan_psikolog", string.IsNullOrEmpty(catatanPsikolog) ? DBNull.Value : (object)catatanPsikolog)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM booking WHERE booking_id = @id";
            var parameters = new[] { new NpgsqlParameter("@id", id) };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool IsSlotTersedia(int jadwalId)
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

        public bool CekDoubleBooking(int userId, int jadwalId)
        {
            string query = @"
                SELECT COUNT(*) FROM booking b
                WHERE b.user_id = @user_id 
                AND b.jadwal_id = @jadwal_id
                AND b.status IN ('Pending', 'Disetujui')";

            var parameters = new[]
            {
                new NpgsqlParameter("@user_id", userId),
                new NpgsqlParameter("@jadwal_id", jadwalId)
            };

            int count = Convert.ToInt32(_db.ExecuteScalar(query, parameters));
            return count > 0;
        }

        private Booking MapToBooking(DataRow row)
        {
            return new Booking
            {
                BookingId = row.Field<int>("booking_id"),
                UserId = row.Field<int>("user_id"),
                PsikologId = row.Field<int>("psikolog_id"),
                JadwalId = row.Field<int>("jadwal_id"),
                Status = row.Field<string>("status"),
                CatatanUser = row["catatan_user"] != DBNull.Value ? row.Field<string>("catatan_user") : null,
                CatatanPsikolog = row["catatan_psikolog"] != DBNull.Value ? row.Field<string>("catatan_psikolog") : null,
                HasilAssessmentId = row["hasil_assessment_id"] != DBNull.Value ? row.Field<int?>("hasil_assessment_id") : null,
                CreatedAt = row.Field<DateTime>("created_at")
            };
        }
    }
}
