using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class ListOfMedication
    {
        public ListOfMedication()
        {
            Assesments = new HashSet<Assesment>();
        }
        [Key]
        public int MedicationId { get; set; }
        public string MedicationName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
