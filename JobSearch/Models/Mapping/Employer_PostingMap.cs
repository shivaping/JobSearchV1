using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.WebAPIHelper.Models.Mapping
{
    public class Employer_PostingMap : EntityTypeConfiguration<Employer_Posting>
    {
        public Employer_PostingMap()
        {
            // Primary Key
            this.HasKey(t => t.Employer_Posting_Id);

            // Properties
            this.Property(t => t.Employer_Posting_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Contact_Person)
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

            this.Property(t => t.Job_Description)
                .IsRequired();

            this.Property(t => t.Posted_By)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Employer_Posting");
            this.Property(t => t.Employer_Posting_Id).HasColumnName("Employer_Posting_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.Employer_Posting_Type_Id).HasColumnName("Employer_Posting_Type_Id");
            this.Property(t => t.Contact_Person).HasColumnName("Contact_Person");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Jobcode).HasColumnName("Jobcode");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State_Id).HasColumnName("State_Id");
            this.Property(t => t.Country_Id).HasColumnName("Country_Id");
            this.Property(t => t.Education_Levelid).HasColumnName("Education_Levelid");
            this.Property(t => t.Job_Type_Id).HasColumnName("Job_Type_Id");
            this.Property(t => t.Min_Salary).HasColumnName("Min_Salary");
            this.Property(t => t.Max_Salary).HasColumnName("Max_Salary");
            this.Property(t => t.Job_Description).HasColumnName("Job_Description");
            this.Property(t => t.Posting_Date).HasColumnName("Posting_Date");
            this.Property(t => t.Posted_By).HasColumnName("Posted_By");

            // Relationships
            this.HasRequired(t => t.Employer_Posting_Type)
                .WithMany(t => t.Employer_Posting)
                .HasForeignKey(d => d.Employer_Posting_Type_Id);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Employer_Posting)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
