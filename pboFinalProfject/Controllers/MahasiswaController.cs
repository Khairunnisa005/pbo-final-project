using System;
using System.Data;
using pboFinalProfject.Repositories;
using pboFinalProfject.Models;

namespace pboFinalProfject.Controllers
{
    public class MahasiswaController
    {
        private readonly JadwalRepository _jadwalRepo;
        private readonly HasilAssessmentRepository _hasilRepo;

        public MahasiswaController()
        {
            _jadwalRepo = new JadwalRepository();
            _hasilRepo = new HasilAssessmentRepository();
        }

        public DataTable GetJadwalAktif()
        {
            return _jadwalRepo.GetAllActive();
        }

        public HasilAssessment GetLatestHasil(int userId)
        {
            return _hasilRepo.GetLatestByUserId(userId);
        }
    }
}
