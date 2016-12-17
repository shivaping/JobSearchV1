using System;
using System.Collections.Generic;

namespace JobSearch.WebAPIHelper.Models
{
    public partial class User_Detail
    {
        public int User_Detail_Id { get; set; }
        public int User_Id { get; set; }
        public byte[] Address1 { get; set; }
        public string Address2 { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public int State_Id { get; set; }
        public int Country_Id { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public Nullable<int> Fax { get; set; }
        public byte[] Email { get; set; }
        public string Secondary_Email { get; set; }
        public string Website { get; set; }
        public string Profile { get; set; }
        public Nullable<bool> Married { get; set; }
        public System.DateTime Created_Date { get; set; }
        public System.DateTime Updated_Date { get; set; }
        public virtual User User { get; set; }
    }
}
