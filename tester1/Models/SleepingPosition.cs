using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class SleepingPosition
    {
        public SleepingPosition()
        {
            Assesments = new HashSet<Assesment>();
        }

        public int SleepingPositionId { get; set; }
        public string SleepingPositionName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
