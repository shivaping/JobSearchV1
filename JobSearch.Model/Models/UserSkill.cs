using System;
using System.Collections.Generic;

namespace JobSearch.Model.Models
{
    public partial class UserSkill
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int SkillID { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
