using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobSearch.WebAPIHelper.Models.Mapping
{
    public class User_Job_DetailsMap : EntityTypeConfiguration<User_Job_Details>
    {
        public User_Job_DetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.User_Job_Id);

            // Properties
            this.Property(t => t.User_Job_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Resume_Title)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Resume_Description)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Resume)
                .IsRequired();

            this.Property(t => t.Preferred_Location)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Current_Role)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("User_Job_Details");
            this.Property(t => t.User_Job_Id).HasColumnName("User_Job_Id");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.Resume_Title).HasColumnName("Resume_Title");
            this.Property(t => t.Resume_Description).HasColumnName("Resume_Description");
            this.Property(t => t.Resume).HasColumnName("Resume");
            this.Property(t => t.Current_Location).HasColumnName("Current_Location");
            this.Property(t => t.Preferred_Location).HasColumnName("Preferred_Location");
            this.Property(t => t.Current_Role).HasColumnName("Current_Role");
            this.Property(t => t.Dob).HasColumnName("Dob");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Experience).HasColumnName("Experience");
            this.Property(t => t.Current_Ctc).HasColumnName("Current_Ctc");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.User_Job_Details)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
