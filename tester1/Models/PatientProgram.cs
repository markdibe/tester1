using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.Models
{
    public partial class PatientProgram
    {
        public PatientProgram()
        {
            PatientProgramsExercises = new HashSet<PatientProgramsExercise>();
        }

        public int PatientProgramId { get; set; }

        //[ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }

        //[ForeignKey(nameof(Therapist))]
        public string TherapistId { get; set; }
        public DateTime? ProgramStart { get; set; }
        public DateTime? ProgramEnd { get; set; }
        public int? NumberOfSessions { get; set; }
        public int? InjuryTypeId { get; set; }
        public bool? IsSeen { get; set; }
        public string EffortNeeded { get; set; }

        public virtual SubCategory InjuryType { get; set; }
        //public virtual ApplicationUser Patient { get; set; }
        //public virtual ApplicationUser Therapist { get; set; }
        public virtual ICollection<PatientProgramsExercise> PatientProgramsExercises { get; set; }
    }
}
