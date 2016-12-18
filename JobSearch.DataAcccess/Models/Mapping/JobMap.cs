using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Location)
                .HasMaxLength(100);

            this.Property(t => t.JobTitle)
                .HasMaxLength(100);

            this.Property(t => t.Technology)
                .HasMaxLength(100);

            this.Property(t => t.Category)
                .HasMaxLength(20);

            this.Property(t => t.Client)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Experience)
                .HasMaxLength(255);

            this.Property(t => t.AboutClient)
                .IsRequired();

            this.Property(t => t.ReferralAmount)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Jobs");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.JobTitle).HasColumnName("JobTitle");
            this.Property(t => t.Technology).HasColumnName("Technology");
            this.Property(t => t.JobDescription).HasColumnName("JobDescription");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.Client).HasColumnName("Client");
            this.Property(t => t.Experience).HasColumnName("Experience");
            this.Property(t => t.GeneralSkills).HasColumnName("GeneralSkills");
            this.Property(t => t.TechnicalSkills).HasColumnName("TechnicalSkills");
            this.Property(t => t.AboutClient).HasColumnName("AboutClient");
            this.Property(t => t.Positions).HasColumnName("Positions");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ReferralAmount).HasColumnName("ReferralAmount");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.JobType).HasColumnName("JobType");
            this.Property(t => t.PostedDate).HasColumnName("PostedDate");

            // Relationships
            this.HasOptional(t => t.JobType1)
                .WithMany(t => t.Jobs)
                .HasForeignKey(d => d.JobType);
            this.HasRequired(t => t.UserDetail)
                .WithMany(t => t.Jobs)
                .HasForeignKey(d => d.CreatedBy);

        }
    }
}
