using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.ViewModels
{
    public partial class PatientProgramVM
    {
       

        public int PatientProgramId { get; set; }

        public string PatientId { get; set; }

        public string TherapistId { get; set; }
        public DateTime? ProgramStart { get; set; }
        public DateTime? ProgramEnd { get; set; }
        public int? NumberOfSessions { get; set; }
        public int? InjuryTypeId { get; set; }
        public bool? IsSeen { get; set; }
        public string EffortNeeded { get; set; }

      
    }
}
