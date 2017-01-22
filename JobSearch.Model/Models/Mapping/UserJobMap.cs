using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.Model.Models.Mapping
{
    public class UserJobMap : EntityTypeConfiguration<UserJob>
    {
        public UserJobMap()
        {
            // Primary Key
            this.HasKey(t => t.UserJobId);

            // Properties
            this.Property(t => t.UserID)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.CurrentCTC)
                .HasMaxLength(20);

            this.Property(t => t.ExpectedCTC)
                .HasMaxLength(20);

            this.Property(t => t.UserExp)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("UserJobs");
            this.Property(t => t.UserJobId).HasColumnName("UserJobId");
            this.Property(t => t.PostingID).HasColumnName("PostingID");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ApplyDate).HasColumnName("ApplyDate");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.ResumeID).HasColumnName("ResumeID");
            this.Property(t => t.NoticePeriod).HasColumnName("NoticePeriod");
            this.Property(t => t.CurrentCTC).HasColumnName("CurrentCTC");
            this.Property(t => t.ExpectedCTC).HasColumnName("ExpectedCTC");
            this.Property(t => t.UserExp).HasColumnName("UserExp");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");

            // Relationships
            this.HasRequired(t => t.UserDetail)
                .WithMany(t => t.UserJobs)
                .HasForeignKey(d => d.UserID);

        }
    }
}
