using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;
using pboFinalProfject.Model;

namespace pboFinalProfject.Model
{
    public class Booking : BaseEntity
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int PsikologId { get; set; }
        public int JadwalId { get; set; }
        public string CatatanUser { get; set; }
        public string CatatanPsikolog { get; set; }
        public int? HasilAssessment { get; set; } //Nullable, opsional

        //Navigation properties 
        public Microsoft.VisualBasic.ApplicationServices.User User { get; set; }
        public Psikolog Psikolog { get; set; }
        public JadwalPsikolog JadwalPsikolog { get; set; }

        // Gunakan int? (nullable) karena di awal booking, hasil assessment bisa jadi belum ada (null)
        public int? HasilAssessmentId { get; set; }

        // encapsulation untuk status booking
        private string _status;
        public string Status
        {
            get => _status;
            set
            {
                string[] validStatus = { "Pending", "Disetujui", "Ditolak", "Selesai", "Batal" };
                bool isValid = false;
                foreach (string s in validStatus)
                {
                    if (s == value)
                    {
                        isValid = true;
                        break;
                    }
                }

                if (!isValid)
                    throw new ArgumentException($"Status harus salah satu dari: {string.Join(", ", validStatus)}");

                _status = value;
            }

        }
        // inheritance: implementasi abstract method dari BaseEntity
        public override string GetDisplayName()
        {
            return $"Booking #{BookingId} - {Status}";
        }

        // override virtual method dari BaseEntity
        public override string GetSummary()
        {
            return $"Booking #{BookingId} | Status: {Status} | Dibuat: {CreatedAt:dd MMM yyyy HH:mm}";
        }

        // readonly property
        public bool IsPending => _status == "Pending";
        public bool IsDisetujui => _status == "Disetujui";
        public bool IsSelesai => _status == "Selesai";
        public bool IsDitolak => _status == "Ditolak";
        public bool IsBatal => _status == "Batal";

        public bool CanBeConfirmed => _status == "Pending";
        public bool CanBeCompleted => _status == "Disetujui";

        // behavior method untuk mengubah status booking
        public void Approve()
        {
            if (!CanBeConfirmed)
                throw new InvalidOperationException($"Booking dengan status '{_status}' tidak dapat disetujui!");
            Status = "Disetujui";
        }

        public void Reject(string alasan)
        {
            if (!CanBeConfirmed)
                throw new InvalidOperationException($"Booking dengan status '{_status}' tidak dapat ditolak!");
            Status = "Ditolak";
            CatatanPsikolog = alasan;
        }

        public void Complete(string catatan)
        {
            if (!CanBeCompleted)
                throw new InvalidOperationException($"Booking dengan status '{_status}' tidak dapat diselesaikan!");
            Status = "Selesai";
            CatatanPsikolog = catatan;
        }

        public void Cancel()
        {
            if (!CanBeConfirmed)
                throw new InvalidOperationException($"Booking dengan status '{_status}' tidak dapat dibatalkan!");
            Status = "Batal";
        }

    }
}
