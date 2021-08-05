using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class SleepingQuality
    {
        public SleepingQuality()
        {
            Assesments = new HashSet<Assesment>();
        }

        public int SleepingQualityId { get; set; }
        public string SleepingQualityName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
