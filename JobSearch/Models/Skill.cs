using System;
using System.Collections.Generic;

namespace JobSearch.WebAPIHelper.Models
{
    public partial class Skill
    {
        public Skill()
        {
            this.User_Skill = new List<User_Skill>();
        }

        public int Skill_Id { get; set; }
        public string Skill_Name { get; set; }
        public string Skill_Description { get; set; }
        public virtual ICollection<User_Skill> User_Skill { get; set; }
    }
}
