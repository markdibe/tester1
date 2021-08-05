using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class TipsCategory
    {
        public TipsCategory()
        {
            Tips = new HashSet<Tip>();
        }
        [Key]
        public int TipCategoryId { get; set; }
        public string TipCategoryName { get; set; }

        public virtual ICollection<Tip> Tips { get; set; }
    }
}
