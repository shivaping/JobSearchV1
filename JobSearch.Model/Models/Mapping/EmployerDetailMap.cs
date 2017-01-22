using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.Model.Models.Mapping
{
    public class EmployerDetailMap : EntityTypeConfiguration<EmployerDetail>
    {
        public EmployerDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CompanyType)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.IndustryType)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ContactPerson)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ContactDesignation)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.WebsiteURL)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.EntityType)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PANNumber)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EmployerDetails");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.CompanyType).HasColumnName("CompanyType");
            this.Property(t => t.IndustryType).HasColumnName("IndustryType");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.ContactDesignation).HasColumnName("ContactDesignation");
            this.Property(t => t.WebsiteURL).HasColumnName("WebsiteURL");
            this.Property(t => t.EntityType).HasColumnName("EntityType");
            this.Property(t => t.PANNumber).HasColumnName("PANNumber");
        }
    }
}
