using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class User_DetailMap : EntityTypeConfiguration<User_Detail>
    {
        public User_DetailMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Detail_Id);

            // Properties
            this.Property(t => t.User_Detail_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Address2)
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Secondary_Email)
                .HasMaxLength(100);

            this.Property(t => t.Website)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("User_Detail");
            this.Property(t => t.User_Detail_Id).HasColumnName("User_Detail_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State_Id).HasColumnName("State_Id");
            this.Property(t => t.Country_Id).HasColumnName("Country_Id");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Secondary_Email).HasColumnName("Secondary_Email");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.Profile).HasColumnName("Profile");
            this.Property(t => t.Married).HasColumnName("Married");
            this.Property(t => t.Created_Date).HasColumnName("Created_Date");
            this.Property(t => t.Updated_Date).HasColumnName("Updated_Date");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.User_Detail)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
