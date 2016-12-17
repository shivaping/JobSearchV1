using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class User_SkillMap : EntityTypeConfiguration<User_Skill>
    {
        public User_SkillMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Skill_Id);

            // Properties
            this.Property(t => t.User_Skill_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("User_Skill");
            this.Property(t => t.User_Skill_Id).HasColumnName("User_Skill_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.Skill_Id).HasColumnName("Skill_Id");

            // Relationships
            this.HasRequired(t => t.Skill)
                .WithMany(t => t.User_Skill)
                .HasForeignKey(d => d.Skill_Id);
            this.HasRequired(t => t.User)
                .WithMany(t => t.User_Skill)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
