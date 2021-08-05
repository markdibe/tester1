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

        [ForeignKey(nameof(Assesment))]
        public int AssesmentId { get; set; }
        public DateTime? Date { get; set; }

        [Range(1,10)]
        public int PainScale { get; set; }
        public virtual Assesment Assesment { get; set; }
    }
}
