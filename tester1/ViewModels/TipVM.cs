using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.ViewModels
{
    public partial class TipVM
    {
        

        public int TipId { get; set; }
        public string TipName { get; set; }
        public string TipTitle { get; set; }
        public string TipDescription { get; set; }
        public int? TipsImagesId { get; set; }
        public string TipVideoUrl { get; set; }
        public int? TipCategoryId { get; set; }

       
    }
}
