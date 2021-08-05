using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class Injury
    {
        public Injury()
        {
            Assesments = new HashSet<Assesment>();
        }
        [Key]
        public int InjuriesId { get; set; }
        public string InjuryName { get; set; }
        public DateTime? InjuryDate { get; set; }
        public string InjuryTreatment { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
