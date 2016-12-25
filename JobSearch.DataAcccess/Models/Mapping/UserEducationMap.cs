using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class UserEducationMap : EntityTypeConfiguration<UserEducation>
    {
        public UserEducationMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Education_Id);

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Qualification)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Specialization)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Institute)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserEducation");
            this.Property(t => t.User_Education_Id).HasColumnName("User_Education_Id");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ProfileID).HasColumnName("ProfileID");
            this.Property(t => t.Qualification).HasColumnName("Qualification");
            this.Property(t => t.Specialization).HasColumnName("Specialization");
            this.Property(t => t.Institute).HasColumnName("Institute");
            this.Property(t => t.Year).HasColumnName("Year");

            // Relationships
            this.HasRequired(t => t.UserDetail)
                .WithMany(t => t.UserEducations)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.UserProfile)
                .WithMany(t => t.UserEducations)
                .HasForeignKey(d => d.ProfileID);

        }
    }
}
