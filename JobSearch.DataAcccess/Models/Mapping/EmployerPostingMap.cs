using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class EmployerPostingMap : EntityTypeConfiguration<EmployerPosting>
    {
        public EmployerPostingMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Department)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Jobcode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JobDescription)
                .IsRequired();

            this.Property(t => t.PostedBy)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("EmployerPosting");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PostingTypeID).HasColumnName("PostingTypeID");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Jobcode).HasColumnName("Jobcode");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Education_LevelID).HasColumnName("Education_LevelID");
            this.Property(t => t.JobTypeId).HasColumnName("JobTypeId");
            this.Property(t => t.MinSalary).HasColumnName("MinSalary");
            this.Property(t => t.MaxSalary).HasColumnName("MaxSalary");
            this.Property(t => t.JobDescription).HasColumnName("JobDescription");
            this.Property(t => t.PostingDate).HasColumnName("PostingDate");
            this.Property(t => t.PostedBy).HasColumnName("PostedBy");
        }
    }
}
