using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class PathologiesByTherapist
    {
        public PathologiesByTherapist()
        {
            Assesments = new HashSet<Assesment>();
        }
        [Key]
        public int PathologyId { get; set; }
        public string PathologyCase { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
