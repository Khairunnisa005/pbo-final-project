using System;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using pboFinalProfject.Model;
using pboFinalProfject.Utils;

namespace pboFinalProfject.Repositories
{
    public class UserRepository
    {
        private readonly DatabaseHelper _db;

        public UserRepository()
        {
            _db = new DatabaseHelper();
        }

        // Get user by ID
        public User GetById(int id)
        {
            string query = "SELECT * FROM users WHERE user_id = @id";
            var parameters = new[] { new NpgsqlParameter("@id", id) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToUser(dt.Rows[0]);
            return null;
        }

        // Get user by email
        public User GetByEmail(string email)
        {
            string query = "SELECT * FROM users WHERE email = @email";
            var parameters = new[] { new NpgsqlParameter("@email", email) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToUser(dt.Rows[0]);
            return null;
        }

        // Get user by username (nama anonim)
        public User GetByUsername(string username)
        {
            string query = "SELECT * FROM users WHERE username = @username";
            var parameters = new[] { new NpgsqlParameter("@username", username) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToUser(dt.Rows[0]);
            return null;
        }

        // Get user by no telepon
        public User GetByNoTelepon(string noTelepon)
        {
            string query = "SELECT * FROM users WHERE no_telepon = @no_telepon";
            var parameters = new[] { new NpgsqlParameter("@no_telepon", noTelepon) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
                return MapToUser(dt.Rows[0]);
            return null;
        }

        // Get all users
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM users ORDER BY user_id";
            DataTable dt = _db.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
                users.Add(MapToUser(row));

            return users;
        }

        // Get users by role
        public List<User> GetByRole(string role)
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM users WHERE role = @role";
            var parameters = new[] { new NpgsqlParameter("@role", role) };
            DataTable dt = _db.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
                users.Add(MapToUser(row));

            return users;
        }

        // Insert new user
        public bool Insert(User entity)
        {
            string query = @"
                INSERT INTO users (username, email, no_telepon, password_hash, nama_lengkap, role, preferensi_waktu, created_at) 
                VALUES (@username, @email, @no_telepon, @password_hash, @nama_lengkap, @role, @preferensi_waktu, @created_at)";

            var parameters = new[]
            {
                new NpgsqlParameter("@username", entity.Username),
                new NpgsqlParameter("@email", entity.Email),
                new NpgsqlParameter("@no_telepon", entity.NoTelepon),
                new NpgsqlParameter("@password_hash", entity.PasswordHash),
                new NpgsqlParameter("@nama_lengkap", string.IsNullOrEmpty(entity.NamaLengkap) ? DBNull.Value : (object)entity.NamaLengkap),
                new NpgsqlParameter("@role", entity.Role),
                new NpgsqlParameter("@preferensi_waktu", string.IsNullOrEmpty(entity.PreferensiWaktu) ? DBNull.Value : (object)entity.PreferensiWaktu),
                new NpgsqlParameter("@created_at", DateTime.Now)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update user
        public bool Update(User entity)
        {
            string query = @"
                UPDATE users 
                SET username = @username, 
                    email = @email, 
                    no_telepon = @no_telepon, 
                    password_hash = @password_hash, 
                    nama_lengkap = @nama_lengkap, 
                    preferensi_waktu = @preferensi_waktu 
                WHERE user_id = @user_id";

            var parameters = new[]
            {
                new NpgsqlParameter("@user_id", entity.UserId),
                new NpgsqlParameter("@username", entity.Username),
                new NpgsqlParameter("@email", entity.Email),
                new NpgsqlParameter("@no_telepon", entity.NoTelepon),
                new NpgsqlParameter("@password_hash", entity.PasswordHash),
                new NpgsqlParameter("@nama_lengkap", string.IsNullOrEmpty(entity.NamaLengkap) ? DBNull.Value : (object)entity.NamaLengkap),
                new NpgsqlParameter("@preferensi_waktu", string.IsNullOrEmpty(entity.PreferensiWaktu) ? DBNull.Value : (object)entity.PreferensiWaktu)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete user
        public bool Delete(int id)
        {
            string query = "DELETE FROM users WHERE user_id = @id";
            var parameters = new[] { new NpgsqlParameter("@id", id) };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        // Check if email exists
        public bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @email";
            var parameters = new[] { new NpgsqlParameter("@email", email) };
            int count = Convert.ToInt32(_db.ExecuteScalar(query, parameters));
            return count > 0;
        }

        // Check if username exists
        public bool IsUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username";
            var parameters = new[] { new NpgsqlParameter("@username", username) };
            int count = Convert.ToInt32(_db.ExecuteScalar(query, parameters));
            return count > 0;
        }

        // Get last inserted ID
        public int GetLastInsertedId()
        {
            string query = "SELECT lastval()";
            return Convert.ToInt32(_db.ExecuteScalar(query));
        }

        // Mapping DataRow ke User object
        private User MapToUser(DataRow row)
        {
            return new User
            {
                UserId = Convert.ToInt32(row["user_id"]),
                Username = row["username"].ToString(),
                Email = row["email"].ToString(),
                NoTelepon = row["no_telepon"].ToString(),
                PasswordHash = row["password_hash"].ToString(),
                NamaLengkap = row["nama_lengkap"] != DBNull.Value ? row["nama_lengkap"].ToString() : null,
                Role = row["role"].ToString(),
                PreferensiWaktu = row["preferensi_waktu"] != DBNull.Value ? row["preferensi_waktu"].ToString() : null,
                CreatedAt = Convert.ToDateTime(row["created_at"])
            };
        }
    }
}