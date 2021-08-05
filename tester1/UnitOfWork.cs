using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Data;
using tester1.IServices;
using tester1.Models;
using tester1.Services;

namespace tester1
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        #region private Instances
        private IAccountTypeRepos accountTypeRepos;
        private IAssesmentRepos assesmentRepos;
        private ICategoryByUserRepos categoryByUserRepos;
        private ICategoryRepos categoryRepos;
        private IExerciseRepos exerciseRepos;
        private IExercisesCategoryRepos exercisesCategoryRepos;
        private IInjuryRepos injuryRepos;
        private IListOfMedicationRepos listOfMedicationRepos;
        private IMeetingRepos meetingRepos ;
        private IPathologiesByTherapistRepos pathologiesByTherapistRepos ;
        private IPatientGoalRepos patientGoalRepos ;
        private IPatientProgramRepos patientProgramRepos ;
        private IPatientsMoodScaleRepos patientsMoodScaleRepos ;
        private IPatientProgramsExerciseRepos patientProgramsExerciseRepos ;
        private IPatientsPainScaleRepos patientsPainScaleRepos ;
        
        private ISleepingPositionRepos sleepingPositionRepos ;
        private ISleepingQuantityRepos sleepingQuantityRepos ;
        private ISleepingQualityRepos sleepingQualityRepos ;
        private ISubCategoryRepos subCategoryRepos ;
        private ISurgeryRepos surgeryRepos ;
        private ITipsCategoryRepos tipsCategoryRepos ;
        private ITipsImageRepos tipsImageRepos ;
        private ITipsRepos tipsRepos ;
        private ITypesOfPainRepos typesOfPainRepos ;
        private ITypesOfResponderRepos typesOfResponderRepos ;
        private IUserRepos userRepos ;
        private IWaterIntakeRepos waterIntakeRepos ;
        private IWaterIntakeRecordRepos waterIntakeRecordRepos;

        #endregion


        #region public instance
        public IAccountTypeRepos AccountTypeRepos => accountTypeRepos ?? new AccountTypeRepos(_context);

        public IAssesmentRepos AssesmentRepos => assesmentRepos ?? new AssesmentRepos(_context);

        public ICategoryByUserRepos CategoryByUserRepos => categoryByUserRepos ?? new CategoriesByUserRepos(_context);
        public ICategoryRepos CategoryRepos => categoryRepos ?? new CategoryRepos(_context);

        public IExerciseRepos ExerciseRepos => exerciseRepos ?? new ExerciseRepos(_context);

        public IExercisesCategoryRepos ExercisesCategoryRepos => exercisesCategoryRepos ?? new ExercisesCategoryRepos(_context);

        public IInjuryRepos InjuryRepos => injuryRepos ?? new InjuryRepos(_context);

        public IListOfMedicationRepos ListOfMedicationRepos => listOfMedicationRepos ?? new ListOfMedicationRepos(_context);

        public IMeetingRepos MeetingRepos => meetingRepos ?? new MeetingRepos(_context);

        public IPathologiesByTherapistRepos PathologiesByTherapistRepos => pathologiesByTherapistRepos ?? new PathologiesByTherapistRepos(_context);

        public IPatientGoalRepos PatientGoalRepos => patientGoalRepos ?? new PatientGoalRepos(_context);

        public IPatientProgramRepos PatientProgramRepos => patientProgramRepos ?? new PatientProgramRepos(_context);

        public IPatientProgramsExerciseRepos PatientProgramsExerciseRepos => patientProgramsExerciseRepos ?? new PatientProgramsExerciseRepos(_context);

        public IPatientsMoodScaleRepos PatientsMoodScaleRepos => patientsMoodScaleRepos ?? new PatientMoodScaleRepos(_context);

        public IPatientsPainScaleRepos PatientsPainScaleRepos => patientsPainScaleRepos ?? new PatientPainScaleRepos(_context);

        

        public ISleepingPositionRepos SleepingPositionRepos => sleepingPositionRepos ?? new SleepingPositionRepos(_context);

        public ISleepingQualityRepos SleepingQualityRepos => sleepingQualityRepos ?? new SleepingQualityRepos(_context);

        public ISleepingQuantityRepos SleepingQuantityRepos => sleepingQuantityRepos ?? new SleepingQuantityRepos(_context);

        public ISubCategoryRepos SubCategoryRepos => subCategoryRepos?? new SubCategoryRepos(_context);

        public ISurgeryRepos SurgeryRepos => surgeryRepos ?? new SurgeryRepos(_context);

        public ITipsCategoryRepos TipsCategoryRepos => tipsCategoryRepos ?? new TipsCategoryRepos(_context);

        public ITipsImageRepos TipsImageRepos => tipsImageRepos ?? new TipsImageRepos(_context);

        public ITipsRepos TipsRepos => tipsRepos ?? new TipRepos(_context);

        public ITypesOfPainRepos TypesOfPainRepos => typesOfPainRepos ?? new TypesOfPainRepos(_context);

        public ITypesOfResponderRepos TypesOfResponderRepos => typesOfResponderRepos ?? new TypesOfResponderRepos(_context);

        public IUserRepos UserRepos => userRepos ?? new UserRepos(_context);

        public IWaterIntakeRecordRepos WaterIntakeRecordRepos => waterIntakeRecordRepos ?? new WaterIntakeRecordRepos(_context);

        public IWaterIntakeRepos WaterIntakeRepos => waterIntakeRepos ?? new WaterIntakeRepos(_context);
        #endregion

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
