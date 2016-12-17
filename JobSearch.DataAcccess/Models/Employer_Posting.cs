using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class Employer_Posting
    {
        public Employer_Posting()
        {
            this.User_Jobs = new List<User_Jobs>();
        }

        public int Employer_Posting_Id { get; set; }
        public int User_Id { get; set; }
        public int Employer_Posting_Type_Id { get; set; }
        public string Contact_Person { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Jobcode { get; set; }
        public string City { get; set; }
        public int State_Id { get; set; }
        public int Country_Id { get; set; }
        public int Education_Levelid { get; set; }
        public int Job_Type_Id { get; set; }
        public Nullable<decimal> Min_Salary { get; set; }
        public Nullable<decimal> Max_Salary { get; set; }
        public string Job_Description { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public string Posted_By { get; set; }
        public virtual Employer_Posting_Type Employer_Posting_Type { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<User_Jobs> User_Jobs { get; set; }
    }
}
