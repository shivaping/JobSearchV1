using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.WebAPIHelper.Models.Mapping
{
    public class SkillMap : EntityTypeConfiguration<Skill>
    {
        public SkillMap()
        {
            // Primary Key
            this.HasKey(t => t.Skill_Id);

            // Properties
            this.Property(t => t.Skill_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Skill_Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Skill_Description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Skill");
            this.Property(t => t.Skill_Id).HasColumnName("Skill_Id");
            this.Property(t => t.Skill_Name).HasColumnName("Skill_Name");
            this.Property(t => t.Skill_Description).HasColumnName("Skill_Description");
        }
    }
}
