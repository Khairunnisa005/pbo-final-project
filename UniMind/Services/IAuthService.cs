using UniMind.Models;

namespace UniMind.Services
{
    public interface IAuthService
    {
        /// <summary>
        /// Login dengan username dan password
        /// </summary>
        User Login(string Username, string password);

        /// <summary>
        /// Registrasi mahasiswa baru dengan nama anonim
        /// </summary>
        bool RegisterMahasiswa(string username, string email, string noTelepon, string password, string namaLengkap = null);

        /// <summary>
        /// Registrasi psikolog (hanya oleh admin)
        /// </summary>
        bool RegisterPsikolog(User user);

        /// <summary>
        /// Cek apakah email sudah terdaftar
        /// </summary>
        bool IsEmailExist(string email);

        /// <summary>
        /// Cek apakah username sudah terdaftar
        /// </summary>
        bool IsUsernameExist(string username);

        /// <summary>
        /// Cek apakah no telepon sudah terdaftar
        /// </summary>
        bool IsNoTeleponExist(string noTelepon);
    }
}