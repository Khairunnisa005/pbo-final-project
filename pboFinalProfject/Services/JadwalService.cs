using System;
using System.Data;
using pboFinalProfject.Repositories;

namespace pboFinalProfject.Services
{
    public class JadwalService
    {
        private readonly JadwalRepository _repo;

        public JadwalService()
        {
            _repo = new JadwalRepository();
        }

        public DataTable GetByPsikologId(int psikologId)
        {
            return _repo.GetByPsikologId(psikologId);
        }

        public bool TambahJadwal(int psikologId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            // Business rules can be enforced here
            if (string.IsNullOrWhiteSpace(hari)) throw new ArgumentException("Hari tidak boleh kosong");
            if (kuota < 1) throw new ArgumentException("Kuota minimal 1");
            return _repo.TambahJadwal(psikologId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
        }

        public bool UpdateJadwal(int jadwalId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            if (jadwalId <= 0) throw new ArgumentException("jadwalId tidak valid");
            return _repo.UpdateJadwal(jadwalId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
        }

        public bool HapusJadwal(int jadwalId)
        {
            if (jadwalId <= 0) throw new ArgumentException("jadwalId tidak valid");
            return _repo.HapusJadwal(jadwalId);
        }
    }
}
