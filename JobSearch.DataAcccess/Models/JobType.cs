using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class JobType
    {
        public JobType()
        {
            this.Jobs = new List<Job>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
