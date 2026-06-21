using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pboFinalProfject
{
    public class PsikologController
    {
        private Repositories.PsikologRepository _psikologRepo;
        private Repositories.JadwalRepository _jadwalRepo;

        public PsikologController()
        {
            _psikologRepo = new Repositories.PsikologRepository();
            _jadwalRepo = new Repositories.JadwalRepository();
        }

        public DataTable GetDistinctKeahlian()
        {
            return _psikologRepo.GetDistinctKeahlian();
        }

        public DataTable GetPsikologByKeahlian(string keahlian)
        {
            return _psikologRepo.GetByKeahlian(keahlian);
        }

        public int GetPsikologIdByUserId(int userId)
        {
            return _psikologRepo.GetPsikologIdbyUserId(userId);
        }

        public DataTable GetAllPsikolog()
        {
            return _psikologRepo.GetAll();
        }

        public DataTable GetDaftarPasienByPsikologId(int psikologId)
        {
            return _psikologRepo.GetDaftarPasienbyPsikologId(psikologId);
        }
        public DataTable GetJadwalByPsikologId(int psikologId)
        {
            return _jadwalRepo.GetByPsikologId(psikologId);
        }

        public bool TambahJadwal(int psikologId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            return _jadwalRepo.TambahJadwal(psikologId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
        }

        public bool UpdateJadwal(int jadwalId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            return _jadwalRepo.UpdateJadwal(jadwalId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
        }

        public bool HapusJadwal(int jadwalId)
        {
            return _jadwalRepo.HapusJadwal(jadwalId);
        }

        public DataTable GetProfilPsikologByUserId(int userId)
        {
            return _psikologRepo.GetProfilPsikologbyUserId(userId);
        }


        public bool UpdateProfilPsikolog(int userId, string nama, string email, string telepon, string gelar, string pendidikan, string izin,string deskripsi, bool online, bool offline)
        {     
            return _psikologRepo.UpdateprofilPsikolog(userId, nama, email, telepon,gelar, pendidikan, izin,deskripsi, online, offline);
        }
    }
}
