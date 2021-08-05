using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class Exercise
    {
        public Exercise()
        {
       
            PatientProgramsExercises = new HashSet<PatientProgramsExercise>();
        }

        public int ExerciseId { get; set; }
        public string ExerciseTitle { get; set; }
        public string ExerciseDescription { get; set; }
        public TimeSpan? Time { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }

      
        public virtual ICollection<PatientProgramsExercise> PatientProgramsExercises { get; set; }
    }
}
