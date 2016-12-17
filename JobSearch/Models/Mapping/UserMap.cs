using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.WebAPIHelper.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Id);

            // Properties
            this.Property(t => t.User_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.User_Type_Id).HasColumnName("User_Type_Id");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Created_Date).HasColumnName("Created_Date");
            this.Property(t => t.Updated_Date).HasColumnName("Updated_Date");

            // Relationships
            this.HasRequired(t => t.User_Type)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.User_Type_Id);

        }
    }
}
