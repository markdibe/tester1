using System;
using System.Collections.Generic;

#nullable disable

namespace tester1.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            Users = new HashSet<ApplicationUser>();
        }

        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; }
        public string Dscription { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
