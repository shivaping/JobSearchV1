using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class EmployerPosting
    {
        public int ID { get; set; }
        public int PostingTypeID { get; set; }
        public string ContactPerson { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Jobcode { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public int JobTypeId { get; set; }
        public Nullable<decimal> MinSalary { get; set; }
        public Nullable<decimal> MaxSalary { get; set; }
        public string JobDescription { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string PostedBy { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
