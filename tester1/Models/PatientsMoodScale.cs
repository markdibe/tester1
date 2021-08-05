using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.Models
{
    public partial class PatientsMoodScale
    {
        [Key]
        public int PatientMoodScaleId { get; set; }

        [ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }
        public int? MoodScaleId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Scale MoodScale { get; set; }
        public virtual ApplicationUser Patient { get; set; }
    }
}
