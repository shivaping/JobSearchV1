using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.Model.Models.Mapping
{
    public class SkillMap : EntityTypeConfiguration<Skill>
    {
        public SkillMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SkillName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SkillDescription)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Skill");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SkillName).HasColumnName("SkillName");
            this.Property(t => t.SkillDescription).HasColumnName("SkillDescription");
        }
    }
}
