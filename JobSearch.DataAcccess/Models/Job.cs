using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class Job
    {
        public int ID { get; set; }
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
        public Nullable<int> Positions { get; set; }
        public bool IsActive { get; set; }
        public string ReferralAmount { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> JobType { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public virtual JobType JobType1 { get; set; }
        public virtual UserJob UserJob { get; set; }
    }
}
