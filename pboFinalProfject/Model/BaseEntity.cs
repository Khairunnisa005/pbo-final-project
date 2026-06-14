using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.Model
{
    public abstract class BaseEntity
    {
        // properti inheritance
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // abstract method (wajib diimplementasikan oleh kelas turunan)
        public abstract string GetDisplayName();

        // virtual method (bisa di override oleh kelas turunan, tapi tidak wajib)
        public virtual string GetSummary()
        {
            return $"Created At: {CreatedAt}";
        }
    }
}
