using System;
using System.Data;
using Npgsql;

namespace pboFinalProfject.Utils
{
    public class DatabaseHelper
    {
        // GANTI CONNECTION STRING INI SESUAI DENGAN POSTGRESQL-MU
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=unimind;Username=postgres;Password=12345678;";

        // Alternatif connection string yang sering dipakai:
        // "Host=localhost;Database=unimind;Username=postgres;Password=postgres;"
        // "Host=127.0.0.1;Database=unimind;Username=postgres;Password=12345;"

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

        // Untuk test koneksi
        public bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Koneksi gagal: {ex.Message}");
                return false;
            }
        }

        // Untuk SELECT query (mengembalikan DataTable)
        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Untuk INSERT, UPDATE, DELETE (mengembalikan jumlah baris terpengaruh)
        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Untuk query yang mengembalikan 1 nilai (COUNT, SUM, dll)
        public object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}