using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class CategoriesByUser
    {
        public CategoriesByUser()
        {
            Assesments = new HashSet<Assesment>();
        }
        [Key]
        public int CategoryByUserId { get; set; }
        public string CategoryByUserName { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
    }
}
