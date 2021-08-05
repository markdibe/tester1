using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.Models
{
    public partial class PatientsPainScale
    {
        [Key]
        public int PatientPainScaleId { get; set; }

        [ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }
        public int? PainScaleId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Scale PainScale { get; set; }
        public virtual ApplicationUser Patient { get; set; }
    }
}
