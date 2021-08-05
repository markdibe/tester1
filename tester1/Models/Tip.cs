using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class Tip
    {
        public Tip()
        {
            TipsImages = new HashSet<TipsImage>();
        }

        public int TipId { get; set; }
        public string TipName { get; set; }
        public string TipTitle { get; set; }
        public string TipDescription { get; set; }
        public int? TipsImagesId { get; set; }
        public string TipVideoUrl { get; set; }
        public int? TipCategoryId { get; set; }

        public virtual TipsCategory TipCategory { get; set; }
        public virtual ICollection<TipsImage> TipsImages { get; set; }
    }
}
