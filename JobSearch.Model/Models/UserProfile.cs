using System;
using System.Collections.Generic;

namespace JobSearch.Model.Models
{
    public partial class UserProfile
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileDescription { get; set; }
        public byte[] Resume { get; set; }
        public string CurrentLocation { get; set; }
        public string PreferredLocation { get; set; }
        public string CurrentRole { get; set; }
        public System.DateTime Dob { get; set; }
        public string Gender { get; set; }
        public double Experience { get; set; }
        public decimal CurrentCtc { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
