using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.WebAPIHelper.Models.Mapping
{
    public class User_JobsMap : EntityTypeConfiguration<User_Jobs>
    {
        public User_JobsMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Job_Id);

            // Properties
            this.Property(t => t.User_Job_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("User_Jobs");
            this.Property(t => t.User_Job_Id).HasColumnName("User_Job_Id");
            this.Property(t => t.Employer_Posting_Id).HasColumnName("Employer_Posting_Id");
            this.Property(t => t.Created_Date).HasColumnName("Created_Date");

            // Relationships
            this.HasRequired(t => t.Employer_Posting)
                .WithMany(t => t.User_Jobs)
                .HasForeignKey(d => d.Employer_Posting_Id);

        }
    }
}
