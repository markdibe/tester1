using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tester1.PhoneModel.Assesment.PainAssessment
{
    public class PainScalePM
    {
        public int PatientPainInfoId { get; set; }

        [Range(1,10)]
        public int PainScale { get; set; }
    }
}
