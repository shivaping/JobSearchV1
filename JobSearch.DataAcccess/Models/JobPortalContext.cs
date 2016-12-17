using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using JobSearch.DataAcccess.Models.Mapping;

namespace JobSearch.DataAcccess.Models
{
    public partial class JobPortalContext : DbContext
    {
        static JobPortalContext()
        {
            Database.SetInitializer<JobPortalContext>(null);
        }

        public JobPortalContext()
            : base("Name=JobPortalContext")
        {
        }

        public DbSet<Employer_Posting> Employer_Posting { get; set; }
        public DbSet<Employer_Posting_Type> Employer_Posting_Type { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Detail> User_Detail { get; set; }
        public DbSet<User_Education> User_Education { get; set; }
        public DbSet<User_Job_Details> User_Job_Details { get; set; }
        public DbSet<User_Jobs> User_Jobs { get; set; }
        public DbSet<User_Skill> User_Skill { get; set; }
        public DbSet<User_Type> User_Type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Employer_PostingMap());
            modelBuilder.Configurations.Add(new Employer_Posting_TypeMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new SkillMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new User_DetailMap());
            modelBuilder.Configurations.Add(new User_EducationMap());
            modelBuilder.Configurations.Add(new User_Job_DetailsMap());
            modelBuilder.Configurations.Add(new User_JobsMap());
            modelBuilder.Configurations.Add(new User_SkillMap());
            modelBuilder.Configurations.Add(new User_TypeMap());
        }
    }
}
