using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.WebAPIHelper.Models.Mapping
{
    public class Employer_Posting_TypeMap : EntityTypeConfiguration<Employer_Posting_Type>
    {
        public Employer_Posting_TypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Employer_Posting_Type_Id);

            // Properties
            this.Property(t => t.Employer_Posting_Type_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Employer_Posting_Type");
            this.Property(t => t.Employer_Posting_Type_Id).HasColumnName("Employer_Posting_Type_Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
