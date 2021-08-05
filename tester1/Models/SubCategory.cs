using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Assesments = new HashSet<Assesment>();
            PatientPrograms = new HashSet<PatientProgram>();
        }

        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Assesment> Assesments { get; set; }
        public virtual ICollection<PatientProgram> PatientPrograms { get; set; }
    }
}
