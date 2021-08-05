using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.ViewModels
{
    public partial class ApplicationUseVMr:IdentityUser
    {
        
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string Country { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public bool? IsActivated { get; set; }
        public int? ParentId { get; set; }
        public string Gender { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Height { get; set; }
        public decimal? Bmi { get; set; }
        public string DominantHand { get; set; }

      
    }
}
