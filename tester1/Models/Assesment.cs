using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.Models
{
    public partial class Assesment
    {
        public string AssesmentId { get; set; }

        //[ForeignKey(nameof(Therapist))]
        public string TherapistId { get; set; }


        //[ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }
        public int? CategoryByUserId { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string CheifComplaint { get; set; }
        public DateTime? WhenTheProbStart { get; set; }
        public int? PathologyId { get; set; }
        public int? InjuriesId { get; set; }
        public string Diseases { get; set; }
        public int? SurgeriesId { get; set; }
        public bool? CtScan { get; set; }
        public string CtScanUrl { get; set; }
        public bool? Xray { get; set; }
        public string XrayUrl { get; set; }
        public bool? Mri { get; set; }
        public string Mriurl { get; set; }
        public bool? Report { get; set; }
        public string ReportUrl { get; set; }
        public string PreviousTreatment { get; set; }
        public string Medication { get; set; }
        public string FunctionalImpact { get; set; }
        public string ActivityLevel { get; set; }
        public bool? Smokes { get; set; }
        public int? CigarettesPerDay { get; set; }
        public int? ScaleOfDiscomfortId { get; set; }
        public int? TypeOfResponderId { get; set; }
        public int? SleepingQuantityId { get; set; }
        public int? SleepingQualityId { get; set; }
        public int? SleepingPositionId { get; set; }
        public int? WaterIntakeRecordId { get; set; }
        public bool? PsychologicalProblems { get; set; }
        public string PsychologicalProblemsDescrption { get; set; }
        public int? ListOfMedicationsId { get; set; }
        public bool? TestedCovidPositive { get; set; }
        public bool? ExperiencedAnyLoss { get; set; }
        public string SymptomsOfCovid { get; set; }
        public string QuinematicUserName { get; set; }
        public int? PatientGoalId { get; set; }
        public string PatientGoalInput { get; set; }
        public int? TypeOfPainId { get; set; }
        public int? MaxPainScaleId { get; set; }
        public string Conclusion { get; set; }

        public virtual Category Category { get; set; }
        public virtual CategoriesByUser CategoryByUser { get; set; }
        public virtual Injury Injuries { get; set; }
        public virtual ListOfMedication ListOfMedications { get; set; }
        //public virtual Scale MaxPainScale { get; set; }
        //public virtual PathologiesbyTherapist Pathology { get; set; }
        //public virtual ApplicationUser Patient { get; set; }

        //public virtual ApplicationUser Therapist { get; set; }
        public virtual PatientGoal PatientGoal { get; set; }
        //public virtual Scale ScaleOfDiscomfort { get; set; }
        public virtual SleepingPosition SleepingPosition { get; set; }
        public virtual SleepingQuality SleepingQuality { get; set; }
        public virtual SleepingQuantity SleepingQuantity { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Surgery Surgeries { get; set; }
        
        public virtual TypesOfPain TypeOfPain { get; set; }
        public virtual TypesOfResponder TypeOfResponder { get; set; }
        public virtual WaterIntakeRecord WaterIntakeRecord { get; set; }
    }
}
