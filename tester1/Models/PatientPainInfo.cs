using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tester1.Models
{
    public class PatientPainInfo
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(PatientPainLocation))]
        public int PatientPainLocationId { get; set; }

        [ForeignKey(nameof(Assesment))]
        public int AssessmentId { get; set; }
        
        [Range(1,10)]
        public int PainScale { get; set; }

        public string HurtTime { get; set; }

        public PatientPainLocation PatientPainLocation { get; set; }

        public Assesment Assesment { get; set; }

        

    }
}
