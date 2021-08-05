using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class Category
    {
        public Category()
        {
            Assesments = new HashSet<Assesment>();
            SubCategories = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Assesment> Assesments { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
