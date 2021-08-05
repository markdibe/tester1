using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class Scale
    {
        public Scale()
        {
            AssesmentMaxPainScales = new HashSet<Assesment>();
            AssesmentScaleOfDiscomforts = new HashSet<Assesment>();
            PatientsMoodScales = new HashSet<PatientsMoodScale>();
            PatientsPainScales = new HashSet<PatientsPainScale>();
        }

        public int ScaleId { get; set; }
        public string ScaleRate { get; set; }

        public virtual ICollection<Assesment> AssesmentMaxPainScales { get; set; }
        public virtual ICollection<Assesment> AssesmentScaleOfDiscomforts { get; set; }
        public virtual ICollection<PatientsMoodScale> PatientsMoodScales { get; set; }
        public virtual ICollection<PatientsPainScale> PatientsPainScales { get; set; }
    }
}
