using System;
using System.Collections.Generic;

namespace JobSearch.WebAPIHelper.Models
{
    public partial class User_Jobs
    {
        public int User_Job_Id { get; set; }
        public int Employer_Posting_Id { get; set; }
        public System.DateTime Created_Date { get; set; }
        public virtual Employer_Posting Employer_Posting { get; set; }
    }
}
