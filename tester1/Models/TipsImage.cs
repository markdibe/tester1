using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.Models
{
    public partial class TipsImage
    {
        [Key]
        public int TipImageId { get; set; }
        public string TipImageUrl { get; set; }
        public int? TipId { get; set; }

        public virtual Tip Tip { get; set; }
    }
}
