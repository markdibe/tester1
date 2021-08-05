using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace tester1.ViewModels
{
    public partial class MeetingVM
    {
        public int MeetingId { get; set; }
        public string MeetingTitle { get; set; }
        public string PatientId { get; set; }
        public DateTime? MeetingDate { get; set; }
        public string TherapistId { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public bool? IsConfirmed { get; set; }
        public string MeetingDescription { get; set; }

       
    }
}
