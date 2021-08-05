using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class Surgery
    {
        public Surgery()
        {
            Assesments = new HashSet<Assesment>();
        }

        public int SurgeryId { get; set; }
        public string SurgeryName { get; set; }
        public DateTime? SurgeryDate { get; set; }
        public string SurgeryTreatment { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
