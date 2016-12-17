using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.DataAcccess.Models.Mapping
{
    public class User_EducationMap : EntityTypeConfiguration<User_Education>
    {
        public User_EducationMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Education_Id);

            // Properties
            this.Property(t => t.User_Education_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Qualification)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Specialization)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Institute)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("User_Education");
            this.Property(t => t.User_Education_Id).HasColumnName("User_Education_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.Qualification).HasColumnName("Qualification");
            this.Property(t => t.Specialization).HasColumnName("Specialization");
            this.Property(t => t.Institute).HasColumnName("Institute");
            this.Property(t => t.Year).HasColumnName("Year");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.User_Education)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
