using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class TypesOfPain
    {
        public TypesOfPain()
        {
            Assesments = new HashSet<Assesment>();
        }
        [Key]
        public int TypeOfPainId { get; set; }
        public string TypeOfPainName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
