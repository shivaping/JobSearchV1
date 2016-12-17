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

        public DbSet<EmployerPosting> EmployerPostings { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserEducation> UserEducations { get; set; }
        public DbSet<UserJob> UserJobs { get; set; }
        public DbSet<UserResume> UserResumes { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployerPostingMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new JobTypeMap());
            modelBuilder.Configurations.Add(new SkillMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserDetailMap());
            modelBuilder.Configurations.Add(new UserEducationMap());
            modelBuilder.Configurations.Add(new UserJobMap());
            modelBuilder.Configurations.Add(new UserResumeMap());
            modelBuilder.Configurations.Add(new UserSkillMap());
        }
    }
}
