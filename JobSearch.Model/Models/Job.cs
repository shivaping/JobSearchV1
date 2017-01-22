using System;
using System.Collections.Generic;

namespace JobSearch.Model.Models
{
    public partial class Job
    {
        public int ID { get; set; }
        public int EmployerID { get; set; }
        public string Location { get; set; }
        public string JobTitle { get; set; }
        public string Technology { get; set; }
        public string JobDescription { get; set; }
        public string Category { get; set; }
        public string Client { get; set; }
        public string Experience { get; set; }
        public string GeneralSkills { get; set; }
        public string TechnicalSkills { get; set; }
        public string AboutClient { get; set; }
        public int Positions { get; set; }
        public bool IsActive { get; set; }
        public string ReferralAmount { get; set; }
        public string CreatedBy { get; set; }
        public int JobType { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public virtual EmployerDetail EmployerDetail { get; set; }
        public virtual JobType JobType1 { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
