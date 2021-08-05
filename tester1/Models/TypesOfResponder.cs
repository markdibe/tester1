using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class TypesOfResponder
    {
        public TypesOfResponder()
        {
            Assesments = new HashSet<Assesment>();
        }
        [Key]
        public int TypeOfResponderId { get; set; }
        public string TypeOfResponderName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
