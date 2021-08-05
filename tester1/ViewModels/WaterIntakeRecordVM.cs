using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.ViewModels
{
    public partial class WaterIntakeRecordVM
    {
       

        public int WaterIntakeRecordId { get; set; }
        public int? WaterIntakeId { get; set; }

        public string PatientId { get; set; }
        public DateTime? NullEvery24Hour { get; set; }

        
    }
}
