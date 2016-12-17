using System;
using System.Collections.Generic;

namespace JobSearch.WebAPIHelper.Models
{
    public partial class User_Job_Details
    {
        public int User_Job_Id { get; set; }
        public int User_Id { get; set; }
        public string Resume_Title { get; set; }
        public string Resume_Description { get; set; }
        public byte[] Resume { get; set; }
        public int Current_Location { get; set; }
        public string Preferred_Location { get; set; }
        public string Current_Role { get; set; }
        public System.DateTime Dob { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public decimal Current_Ctc { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
    }
}
