using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.ViewModels
{
    public partial class PatientsMoodScaleVM
    {
       
        public int PatientMoodScaleId { get; set; }

       
        public string PatientId { get; set; }
        public int? MoodScaleId { get; set; }
        public DateTime? Date { get; set; }

       
    }
}
