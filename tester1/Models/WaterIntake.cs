using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class WaterIntake
    {
        public WaterIntake()
        {
            WaterIntakeRecords = new HashSet<WaterIntakeRecord>();
        }

        public int WaterIntakeId { get; set; }
        public string WaterIntakeName { get; set; }

        public virtual ICollection<WaterIntakeRecord> WaterIntakeRecords { get; set; }
    }
}
