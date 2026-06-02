using UniMind.Models;

namespace UniMind.Session
{
    public static class UserSession
    {
        private static User _currentUser;

        public static User CurrentUser
        {
            get => _currentUser;
            set => _currentUser = value;
        }

        public static bool IsLoggedIn => _currentUser != null;

        public static bool IsMahasiswa => _currentUser != null && _currentUser.Role == "Mahasiswa";

        public static bool IsPsikolog => _currentUser != null && _currentUser.Role == "Psikolog";

        public static bool IsAdmin => _currentUser != null && _currentUser.Role == "Admin";

        public static void Clear()
        {
            _currentUser = null;
        }

        public static int GetCurrentUserId()
        {
            if (_currentUser == null)
                throw new System.Exception("Tidak ada user yang login");
            return _currentUser.UserId;
        }

        public static string GetCurrentUsername()
        {
            if (_currentUser == null)
                throw new System.Exception("Tidak ada user yang login");
            return _currentUser.Username;
        }
    }
}