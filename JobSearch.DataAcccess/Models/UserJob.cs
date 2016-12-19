using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class UserJob
    {
        public int UserJobId { get; set; }
        public int PostingID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public Nullable<int> Status { get; set; }
        public int ResumeID { get; set; }
        public Nullable<int> NoticePeriod { get; set; }
        public string CurrentCTC { get; set; }
        public string ExpectedCTC { get; set; }
        public string UserExp { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
