using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class User_Type
    {
        public User_Type()
        {
            this.Users = new List<User>();
        }

        public int User_Type_Id { get; set; }
        public string User_Type_Name { get; set; }
        public string User_Type_Description { get; set; }
        public System.DateTime Created_Date { get; set; }
        public System.DateTime Updated_Date { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
