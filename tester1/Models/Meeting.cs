using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.Models
{
    public partial class Meeting
    {
        public int MeetingId { get; set; }
        public string MeetingTitle { get; set; }

        //[ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }
        public DateTime? MeetingDate { get; set; }

        //[ForeignKey(nameof(Therapist))]
        public string TherapistId { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public bool? IsConfirmed { get; set; }
        public string MeetingDescription { get; set; }

        //public virtual ApplicationUser Patient { get; set; }
        //public virtual ApplicationUser Therapist { get; set; }
    }
}
