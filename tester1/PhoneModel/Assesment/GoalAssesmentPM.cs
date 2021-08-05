using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Models;

namespace tester1.PhoneModel.Assesment
{
    public class GoalAssesmentPM
    {
        List<PatientGoal> patientGoals { get; set; }
        public string UserId { get; set; }
        public int SelectedGoalId { get; set; }
        public string SelectedGoalName { get; set; }
        public string AssesmentId { get; set; }
       

    }
}
