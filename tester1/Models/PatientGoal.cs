using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class PatientGoal
    {
        public PatientGoal()
        {
            Assesments = new HashSet<Assesment>();
        }

        public int PatientGoalId { get; set; }
        public string PatientGoalName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
