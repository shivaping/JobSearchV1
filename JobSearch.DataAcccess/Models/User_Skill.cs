using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class User_Skill
    {
        public int User_Skill_Id { get; set; }
        public int User_Id { get; set; }
        public int Skill_Id { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual User User { get; set; }
    }
}
