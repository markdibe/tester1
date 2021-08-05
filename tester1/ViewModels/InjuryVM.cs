using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace tester1.ViewModels
{
    public partial class InjuryVM
    {
      
        public int InjuriesId { get; set; }
        public string InjuryName { get; set; }
        public DateTime? InjuryDate { get; set; }
        public string InjuryTreatment { get; set; }

    }
}
