using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            // Primary Key
            this.HasKey(t => t.job_id);

            // Properties
            this.Property(t => t.location)
                .HasMaxLength(100);

            this.Property(t => t.jobtitle)
                .HasMaxLength(100);

            this.Property(t => t.technology)
                .HasMaxLength(100);

            this.Property(t => t.category)
                .HasMaxLength(20);

            this.Property(t => t.client)
                .HasMaxLength(255);

            this.Property(t => t.experience)
                .HasMaxLength(255);

            this.Property(t => t.referralamount)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Jobs");
            this.Property(t => t.job_id).HasColumnName("job_id");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.jobtitle).HasColumnName("jobtitle");
            this.Property(t => t.technology).HasColumnName("technology");
            this.Property(t => t.job_description).HasColumnName("job_description");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.client).HasColumnName("client");
            this.Property(t => t.experience).HasColumnName("experience");
            this.Property(t => t.generalskills).HasColumnName("generalskills");
            this.Property(t => t.technicalskills).HasColumnName("technicalskills");
            this.Property(t => t.About_Client).HasColumnName("About_Client");
            this.Property(t => t.positions).HasColumnName("positions");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.referralamount).HasColumnName("referralamount");
            this.Property(t => t.userid).HasColumnName("userid");
            this.Property(t => t.JobType).HasColumnName("JobType");
            this.Property(t => t.PostedDate).HasColumnName("PostedDate");
        }
    }
}
