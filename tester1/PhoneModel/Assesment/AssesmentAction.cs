using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Data;
using tester1.Models;
using tester1.PhoneModel.Assesment.PainAssessment;

namespace tester1.PhoneModel.Assesment
{
    public class AssesmentAction
    {
        private readonly ApplicationDbContext _context;
        public AssesmentAction(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<GoalAssesmentPM> AddUpdateGoalAssesment(GoalAssesmentPM gapm)
        {
            if(string.IsNullOrEmpty(gapm.AssesmentId))
            {
                var assesment = new tester1.Models.Assesment() { AssesmentId = Guid.NewGuid().ToString() };
                assesment.PatientGoalId = gapm.SelectedGoalId;
                await _context.Assesments.AddAsync(assesment);
                _context.SaveChanges();
            }
            else
            {
                var assesment = await _context.Assesments.FirstOrDefaultAsync(x => x.AssesmentId == gapm.AssesmentId);
                assesment.PatientGoalId = gapm.SelectedGoalId;
                _context.SaveChanges();

            }
            return gapm;
        }
        public async Task<PainLocationPM> AddUpdatePainLocation(PainLocationPM painLocation)
        {
            if (painLocation.PatientPainInfoId == default(int))
            {
                PatientPainInfo patientPainInfo = new PatientPainInfo
                {
                    AssessmentId = painLocation.AssessmentId,
                    PatientPainLocationId = painLocation.SelectedPainLocationId
                };
                if(painLocation.SelectedPainLocationId == default(int))
                {
                    PatientPainLocation patientPainLocation = new PatientPainLocation { PainLocation = painLocation.SelectedPainLocationName };
                    _context.PatientPainLocations.Add(patientPainLocation);
                    _context.SaveChanges();
                    patientPainInfo.PatientPainLocationId = patientPainLocation.Id;
                }
                _context.PatientPainInfos.Add(patientPainInfo);
                _context.SaveChanges();

                return new PainLocationPM { AssessmentId = patientPainInfo.AssessmentId, PatientPainInfoId = patientPainInfo.Id, SelectedPainLocationId = patientPainInfo.PatientPainLocationId };
            }

            else
            {
                PatientPainInfo patientPainInfo = await _context.PatientPainInfos.FirstOrDefaultAsync(x => x.Id == painLocation.PatientPainInfoId);
                patientPainInfo.PatientPainLocationId = painLocation.SelectedPainLocationId;
                if (painLocation.SelectedPainLocationId == default(int))
                {
                    PatientPainLocation patientPainLocation = new PatientPainLocation { PainLocation = painLocation.SelectedPainLocationName };
                    _context.PatientPainLocations.Add(patientPainLocation);
                    _context.SaveChanges();
                    patientPainInfo.PatientPainLocationId = patientPainLocation.Id;
                }
                await _context.SaveChangesAsync();
                return new PainLocationPM { AssessmentId = patientPainInfo.AssessmentId, PatientPainInfoId = patientPainInfo.Id, SelectedPainLocationId = patientPainInfo.PatientPainLocationId };
            }
        }



    }
}
