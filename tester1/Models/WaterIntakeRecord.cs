using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.Models
{
    public partial class WaterIntakeRecord
    {
        public WaterIntakeRecord()
        {
            Assesments = new HashSet<Assesment>();
        }

        public int WaterIntakeRecordId { get; set; }
        public int? WaterIntakeId { get; set; }

        [ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }
        public DateTime? NullEvery24Hour { get; set; }

        public virtual ApplicationUser Patient { get; set; }
        public virtual WaterIntake WaterIntake { get; set; }
        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
