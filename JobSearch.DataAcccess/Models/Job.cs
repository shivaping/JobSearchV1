using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class Job
    {
        public int job_id { get; set; }
        public string location { get; set; }
        public string jobtitle { get; set; }
        public string technology { get; set; }
        public string job_description { get; set; }
        public string category { get; set; }
        public string client { get; set; }
        public string experience { get; set; }
        public string generalskills { get; set; }
        public string technicalskills { get; set; }
        public string About_Client { get; set; }
        public Nullable<int> positions { get; set; }
        public bool IsActive { get; set; }
        public string referralamount { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<int> JobType { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
    }
}
