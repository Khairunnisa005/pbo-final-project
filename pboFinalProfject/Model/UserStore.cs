using System.Collections.Generic;
using System.Linq;

namespace pboFinalProfject.Model
{
    public static class UserStore
    {
        private static readonly List<User> users = new List<User>();

        // Seed a default user for convenience
        static UserStore()
        {
            users.Add(new User
            {
                NamaLengkap = "Administrator",
                Email = "admin@demo.com",
                Username = "admin",
                PasswordHash = "admin123",
                NoTelepon = "+628000000000"
            });
        }

        public static void Add(User user)
        {
            users.Add(user);
        }

        public static User? GetByEmail(string email)
        {
            return users.FirstOrDefault(u => u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase));
        }

        public static User? ValidateCredentials(string email, string password)
        {
            return users.FirstOrDefault(u => u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase)
                                             && u.PasswordHash == password);
        }
    }
}
