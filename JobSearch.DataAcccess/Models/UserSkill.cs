using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class UserSkill
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int SkillID { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
