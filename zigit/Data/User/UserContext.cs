using Microsoft.EntityFrameworkCore;
using zigit.Models;

namespace zigit.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> opt) : base(opt)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    BugsCount = 3,
                    DurationInDays = 7,
                    Id = 1,
                    MadeDadeline = true,
                    Name = "Full Stack Dev",
                    Score = 100,
                },
                new Project
                {
                    BugsCount = 1,
                    DurationInDays = 20,
                    Id = 2,
                    MadeDadeline = true,
                    Name = "Python Web Scraping",
                    Score = 93
                },
                new Project
                {
                    BugsCount = 6,
                    DurationInDays = 2,
                    Id = 3,
                    MadeDadeline = true,
                    Name = "Fintech Marketing",
                    Score = 88
                }
             );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = "ormizrahi777@gmail.com",
                    Password = "aaa111",
                    ProjectId = 1
                },
                new User
                {
                    Id = 2,
                    Email = "yifatpaldi@gmail.com",
                    Password = "bbb222",
                    ProjectId = 2
                },
                new User
                {
                    Id = 3,
                    Email = "shmuelm@gmail.com",
                    Password = "ccc333",
                    ProjectId = 3
                }
             );
        }
    }
}
