using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.IServices;

namespace tester1
{
    public interface IUnitOfWork
    {
        IAccountTypeRepos AccountTypeRepos { get; }
        IAssesmentRepos AssesmentRepos { get; }
        ICategoryByUserRepos CategoryByUserRepos { get; }
        ICategoryRepos CategoryRepos { get; }
        IExerciseRepos ExerciseRepos { get; }
        IExercisesCategoryRepos ExercisesCategoryRepos { get; }
        IInjuryRepos InjuryRepos { get; }
        IListOfMedicationRepos ListOfMedicationRepos { get; }
        IMeetingRepos MeetingRepos { get; }
        IPathologiesByTherapistRepos PathologiesByTherapistRepos { get; }
        IPatientGoalRepos PatientGoalRepos { get; }
        IPatientProgramRepos PatientProgramRepos { get; }
        IPatientProgramsExerciseRepos PatientProgramsExerciseRepos { get; }
        IPatientsMoodScaleRepos PatientsMoodScaleRepos { get; }
        IPatientsPainScaleRepos PatientsPainScaleRepos { get; }
        
        ISleepingPositionRepos SleepingPositionRepos { get; }
        ISleepingQualityRepos SleepingQualityRepos { get; }
        ISleepingQuantityRepos SleepingQuantityRepos { get; }
        ISubCategoryRepos SubCategoryRepos { get; }
        ISurgeryRepos SurgeryRepos { get; }
        ITipsCategoryRepos TipsCategoryRepos { get; }
        ITipsImageRepos TipsImageRepos { get; }
        ITipsRepos TipsRepos { get; }
        ITypesOfPainRepos TypesOfPainRepos { get; }
        ITypesOfResponderRepos TypesOfResponderRepos { get; }
        IUserRepos UserRepos { get; }
        IWaterIntakeRecordRepos WaterIntakeRecordRepos { get; }
        IWaterIntakeRepos WaterIntakeRepos { get; }
        
    }
}
