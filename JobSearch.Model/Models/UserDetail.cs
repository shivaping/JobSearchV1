using System;
using System.Collections.Generic;

namespace JobSearch.Model.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            this.Jobs = new List<Job>();
            this.UserEducations = new List<UserEducation>();
            this.UserJobs = new List<UserJob>();
            this.UserProfiles = new List<UserProfile>();
            this.UserSkills = new List<UserSkill>();
        }

        public string UserID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Secondary_Email { get; set; }
        public string Website { get; set; }
        public Nullable<bool> Married { get; set; }
        public System.DateTime Created_Date { get; set; }
        public System.DateTime Updated_Date { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<UserEducation> UserEducations { get; set; }
        public virtual ICollection<UserJob> UserJobs { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
