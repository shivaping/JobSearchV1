using System;
using System.Collections.Generic;

namespace JobSearch.WebAPIHelper.Models
{
    public partial class User_Education
    {
        public int User_Education_Id { get; set; }
        public int User_Id { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public string Institute { get; set; }
        public int Year { get; set; }
        public virtual User User { get; set; }
    }
}
