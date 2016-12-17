using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class UserResumeMap : EntityTypeConfiguration<UserResume>
    {
        public UserResumeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.ResumeTitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ResumeDescription)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Resume)
                .IsRequired();

            this.Property(t => t.PreferredLocation)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.CurrentRole)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("UserResume");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ResumeTitle).HasColumnName("ResumeTitle");
            this.Property(t => t.ResumeDescription).HasColumnName("ResumeDescription");
            this.Property(t => t.Resume).HasColumnName("Resume");
            this.Property(t => t.CurrentLocation).HasColumnName("CurrentLocation");
            this.Property(t => t.PreferredLocation).HasColumnName("PreferredLocation");
            this.Property(t => t.CurrentRole).HasColumnName("CurrentRole");
            this.Property(t => t.Dob).HasColumnName("Dob");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Experience).HasColumnName("Experience");
            this.Property(t => t.CurrentCtc).HasColumnName("CurrentCtc");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
