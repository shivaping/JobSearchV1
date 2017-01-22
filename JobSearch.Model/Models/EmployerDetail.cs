using System;
using System.Collections.Generic;

namespace JobSearch.Model.Models
{
    public partial class EmployerDetail
    {
        public EmployerDetail()
        {
            this.Jobs = new List<Job>();
        }

        public int ID { get; set; }
        public System.Guid UserID { get; set; }
        public string CompanyType { get; set; }
        public string IndustryType { get; set; }
        public string ContactPerson { get; set; }
        public string ContactDesignation { get; set; }
        public string WebsiteURL { get; set; }
        public string EntityType { get; set; }
        public string PANNumber { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
