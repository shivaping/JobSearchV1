using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.WebAPIHelper.Models.Mapping
{
    public class User_TypeMap : EntityTypeConfiguration<User_Type>
    {
        public User_TypeMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Type_Id);

            // Properties
            this.Property(t => t.User_Type_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.User_Type_Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.User_Type_Description)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("User_Type");
            this.Property(t => t.User_Type_Id).HasColumnName("User_Type_Id");
            this.Property(t => t.User_Type_Name).HasColumnName("User_Type_Name");
            this.Property(t => t.User_Type_Description).HasColumnName("User_Type_Description");
            this.Property(t => t.Created_Date).HasColumnName("Created_Date");
            this.Property(t => t.Updated_Date).HasColumnName("Updated_Date");
        }
    }
}
