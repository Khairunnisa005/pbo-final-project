//using System.Data;
//using Npgsql;
//using pboFinalProfject.Utils;

//namespace pboFinalProfject.Services
//{
//    public abstract class BaseService
//    {
//        protected readonly DatabaseHelper _db;

//        protected BaseService()
//        {
//            _db = new DatabaseHelper();
//        }

//        // Convenience wrappers to keep service code concise
//        protected DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
//        {
//            return _db.ExecuteQuery(query, parameters);
//        }

//        protected int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
//        {
//            return _db.ExecuteNonQuery(query, parameters);
//        }

//        protected object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
//        {
//            return _db.ExecuteScalar(query, parameters);
//        }
//    }
//}
