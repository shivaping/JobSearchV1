using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.Model.Models.Mapping
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.ProfileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProfileDescription)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Resume)
                .IsRequired();

            this.Property(t => t.CurrentLocation)
                .IsRequired()
                .HasMaxLength(255);

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

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PhoneNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserProfile");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ProfileName).HasColumnName("ProfileName");
            this.Property(t => t.ProfileDescription).HasColumnName("ProfileDescription");
            this.Property(t => t.Resume).HasColumnName("Resume");
            this.Property(t => t.CurrentLocation).HasColumnName("CurrentLocation");
            this.Property(t => t.PreferredLocation).HasColumnName("PreferredLocation");
            this.Property(t => t.CurrentRole).HasColumnName("CurrentRole");
            this.Property(t => t.Dob).HasColumnName("Dob");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Experience).HasColumnName("Experience");
            this.Property(t => t.CurrentCtc).HasColumnName("CurrentCtc");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");

            // Relationships
            this.HasRequired(t => t.UserDetail)
                .WithMany(t => t.UserProfiles)
                .HasForeignKey(d => d.UserID);

        }
    }
}
