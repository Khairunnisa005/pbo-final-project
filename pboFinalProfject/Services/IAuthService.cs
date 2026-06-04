using pboFinalProfject.Model;

namespace pboFinalProfject.Services
{
    public interface IAuthService
    {
        /// Login dengan email dan password
        User LoginByEmail(string email, string password);

        /// Login dengan username dan password
        User LoginByUsername(string username, string password);

        /// Registrasi mahasiswa baru dengan nama anonim
        bool RegisterMahasiswa(string username, string email, string noTelepon, string password, string nama);

        /// Registrasi psikolog (hanya oleh admin)
        bool RegisterPsikolog(User user);

        /// Cek apakah email sudah terdaftar
        bool IsEmailExist(string email);

        /// Cek apakah username sudah terdaftar
        bool IsUsernameExist(string username);

        /// Cek apakah no telepon sudah terdaftar
        bool IsNoTeleponExist(string noTelepon);
    }
}