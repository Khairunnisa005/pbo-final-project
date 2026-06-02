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
                FullName = "Administrator",
                Email = "admin@demo.com",
                Username = "admin",
                Password = "admin123",
                Phone = "+628000000000"
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
                                             && u.Password == password);
        }
    }
}

Git failed with a fatal error.
error: open(".vs/pbo-final-project.slnx/FileContentIndex/07d3a62b-67bb-4ac0-8048-a1755e9e13b1.vsidx"): Permission denied
fatal: Unable to process path .vs/pbo-final-project.slnx/FileContentIndex/07d3a62b-67bb-4ac0-8048-a1755e9e13b1.vsidx 