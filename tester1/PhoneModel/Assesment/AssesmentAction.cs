using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Data;

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
    }
}
