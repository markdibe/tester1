using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.ViewModels
{
    public partial class TipsImageVM
    {
       
        public int TipImageId { get; set; }
        public string TipImageUrl { get; set; }
        public int? TipId { get; set; }

        
    }
}
