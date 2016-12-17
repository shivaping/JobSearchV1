using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class Employer_Posting_Type
    {
        public Employer_Posting_Type()
        {
            this.Employer_Posting = new List<Employer_Posting>();
        }

        public int Employer_Posting_Type_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Employer_Posting> Employer_Posting { get; set; }
    }
}
