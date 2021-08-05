using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.ViewModels
{
    public partial class PatientProgramsExerciseVM
    {
       
        public int PatientProgramsExercisesId { get; set; }
        public int? PatientProgramId { get; set; }
        public int? ExerciseId { get; set; }
        public TimeSpan? Duration { get; set; }
        public int? Repetition { get; set; }

        
    }
}
