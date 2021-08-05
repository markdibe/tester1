using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class SleepingQuantity
    {
        public SleepingQuantity()
        {
            Assesments = new HashSet<Assesment>();
        }

        public int SleepingQuantityId { get; set; }
        public string SleepingQuantityName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
