using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class UserEducation
    {
        public int User_Education_Id { get; set; }
        public string UserID { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public string Institute { get; set; }
        public int Year { get; set; }
    }
}
