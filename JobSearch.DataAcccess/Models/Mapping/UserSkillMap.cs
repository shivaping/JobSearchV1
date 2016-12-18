using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class UserSkillMap : EntityTypeConfiguration<UserSkill>
    {
        public UserSkillMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("UserSkill");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.SkillID).HasColumnName("SkillID");

            // Relationships
            this.HasRequired(t => t.Skill)
                .WithOptional(t => t.UserSkill);
            this.HasRequired(t => t.UserDetail)
                .WithMany(t => t.UserSkills)
                .HasForeignKey(d => d.UserID);

        }
    }
}
