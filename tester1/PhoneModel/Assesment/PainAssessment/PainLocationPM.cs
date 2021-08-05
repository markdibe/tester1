using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tester1.Models;

namespace tester1.PhoneModel.Assesment.PainAssessment
{
    public class PainLocationPM
    {
        public int PatientPainInfoId { get; set; }

        public int SelectedPainLocationId { get; set; }

        public string SelectedPainLocationName { get; set; }

        public List<PatientPainLocation> PatientPainLocations { get; set; }

        public int AssessmentId { get; set; }
    }
}
