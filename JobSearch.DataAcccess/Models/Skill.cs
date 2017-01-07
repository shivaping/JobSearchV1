using System;
using System.Collections.Generic;

namespace JobSearch.DataAcccess.Models
{
    public partial class Skill
    {
        public Skill()
        {
            this.UserSkills = new List<UserSkill>();
        }

        public int ID { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
