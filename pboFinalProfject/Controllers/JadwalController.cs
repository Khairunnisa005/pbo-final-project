using System;
using System.Data;
using pboFinalProfject.Services;

namespace pboFinalProfject.Controllers
{
    public class JadwalController
    {
        private readonly JadwalService _service;

        public JadwalController()
        {
            _service = new JadwalService();
        }

        public DataTable GetByPsikologId(int psikologId)
        {
            return _service.GetByPsikologId(psikologId);
        }

        public bool TambahJadwal(int psikologId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            try
            {
                return _service.TambahJadwal(psikologId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateJadwal(int jadwalId, string hari, TimeSpan jamMulai, TimeSpan jamSelesai, string metode, int kuota, bool isActive)
        {
            try
            {
                return _service.UpdateJadwal(jadwalId, hari, jamMulai, jamSelesai, metode, kuota, isActive);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool HapusJadwal(int jadwalId)
        {
            try
            {
                return _service.HapusJadwal(jadwalId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
