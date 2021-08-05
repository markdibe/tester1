using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class ApplicationUser:IdentityUser
    {
        public ApplicationUser()
        {
            AssesmentPatients = new HashSet<Assesment>();
            AssesmentTherapists = new HashSet<Assesment>();
            //ClientExercisePatients = new HashSet<ClientExercise>();
            //ClientExerciseTherapists = new HashSet<ClientExercise>();
            MeetingPatients = new HashSet<Meeting>();
            MeetingTherapists = new HashSet<Meeting>();
            PatientProgramPatients = new HashSet<PatientProgram>();
            PatientProgramTherapists = new HashSet<PatientProgram>();
            PatientsMoodScales = new HashSet<PatientsMoodScale>();
            PatientsPainScales = new HashSet<PatientsPainScale>();
            WaterIntakeRecords = new HashSet<WaterIntakeRecord>();
        }

        
        
        
        
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string Country { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public bool? IsActivated { get; set; }
        public int? ParentId { get; set; }
        public string Gender { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
        public decimal? Bmi { get; set; }
        public string DominantHand { get; set; }

        public virtual AccountTypeVM AccountType { get; set; }


        public virtual ICollection<Assesment> AssesmentPatients { get; set; }
        public virtual ICollection<Assesment> AssesmentTherapists { get; set; }
        //public virtual ICollection<ClientExercise> ClientExercisePatients { get; set; }
        //public virtual ICollection<ClientExercise> ClientExerciseTherapists { get; set; }
        public virtual ICollection<Meeting> MeetingPatients { get; set; }
        public virtual ICollection<Meeting> MeetingTherapists { get; set; }
        public virtual ICollection<PatientProgram> PatientProgramPatients { get; set; }
        public virtual ICollection<PatientProgram> PatientProgramTherapists { get; set; }
        public virtual ICollection<PatientsMoodScale> PatientsMoodScales { get; set; }
        public virtual ICollection<PatientsPainScale> PatientsPainScales { get; set; }
        public virtual ICollection<WaterIntakeRecord> WaterIntakeRecords { get; set; }
    }
}
