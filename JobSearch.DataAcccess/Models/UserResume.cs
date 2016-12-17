using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class UserResume
    {
        public UserResume()
        {
            this.UserJobs = new List<UserJob>();
        }

        public int ID { get; set; }
        public string UserID { get; set; }
        public string ResumeTitle { get; set; }
        public string ResumeDescription { get; set; }
        public byte[] Resume { get; set; }
        public int CurrentLocation { get; set; }
        public string PreferredLocation { get; set; }
        public string CurrentRole { get; set; }
        public System.DateTime Dob { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public decimal CurrentCtc { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<UserJob> UserJobs { get; set; }
    }
}
