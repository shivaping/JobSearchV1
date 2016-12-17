using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class User
    {
        public User()
        {
            this.Employer_Posting = new List<Employer_Posting>();
            this.User_Education = new List<User_Education>();
            this.User_Job_Details = new List<User_Job_Details>();
            this.User_Skill = new List<User_Skill>();
            this.User_Detail = new List<User_Detail>();
        }

        public int User_Id { get; set; }
        public int User_Type_Id { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public System.DateTime Created_Date { get; set; }
        public System.DateTime Updated_Date { get; set; }
        public virtual ICollection<Employer_Posting> Employer_Posting { get; set; }
        public virtual ICollection<User_Education> User_Education { get; set; }
        public virtual ICollection<User_Job_Details> User_Job_Details { get; set; }
        public virtual ICollection<User_Skill> User_Skill { get; set; }
        public virtual ICollection<User_Detail> User_Detail { get; set; }
        public virtual User_Type User_Type { get; set; }
    }
}
