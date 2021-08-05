using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Models;

namespace tester1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Assesment> Assesments { get; set; }
        public virtual DbSet<CategoriesByUser> CategoriesByUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Exercise> Exercices { get; set; }
        public virtual DbSet<ExercisesCategory> ExercisesCategories { get; set; }
        public virtual DbSet<Injury> Injuries { get; set; }
        public virtual DbSet<ListOfMedication> ListOfMedications { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<PathologiesByTherapist> PathologiesbyTherapists { get; set; }
        public virtual DbSet<PatientGoal> PatientGoals { get; set; }
        public virtual DbSet<PatientProgram> PatientPrograms { get; set; }
        public virtual DbSet<PatientProgramsExercise> PatientProgramsExercises { get; set; }
        public virtual DbSet<PatientsMoodScale> PatientsMoodScales { get; set; }
        public virtual DbSet<PatientsPainScale> PatientsPainScales { get; set; }
        public virtual DbSet<PatientPainInfo> PatientPainInfos { get; set; }
        public virtual DbSet<PatientPainLocation> PatientPainLocations { get; set; }

        public virtual DbSet<SleepingPosition> SleepingPositions { get; set; }
        public virtual DbSet<SleepingQuantity> SleepingQantities { get; set; }
        public virtual DbSet<SleepingQuality> SleepingQualities { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Surgery> Surgeries { get; set; }
        public virtual DbSet<Tip> Tips { get; set; }
        public virtual DbSet<TipsCategory> TipsCategories { get; set; }
        public virtual DbSet<TipsImage> TipsImages { get; set; }
        public virtual DbSet<TypesOfPain> TypesOfPains { get; set; }
        public virtual DbSet<TypesOfResponder> TypesOfResponders { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<WaterIntake> WaterIntakes { get; set; }
        public virtual DbSet<WaterIntakeRecord> WaterIntakeRecords { get; set; }

    }
}
