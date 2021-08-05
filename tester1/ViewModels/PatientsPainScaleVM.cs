using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.ViewModels
{
    public partial class PatientsPainScaleVM
    {
        
        public int PatientPainScaleId { get; set; }

      
        public string PatientId { get; set; }
        public int? PainScaleId { get; set; }
        public DateTime? Date { get; set; }

       
    }
}
