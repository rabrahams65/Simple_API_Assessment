using Microsoft.EntityFrameworkCore;
using Simple_API_Assessment.Models;

namespace Simple_API_Assessment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        
        }

        public DbSet<Applicant>? Applicant { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Seed
            modelBuilder.Entity<Applicant>().HasData(
                new Applicant
                {
                    Id = 1,
                    Name = "Rowan"
                });

            modelBuilder.Entity<Skill>().HasData(
                new Skill
                {
                    Id = 1,
                    Name = "C#",
                    ApplicantId = 1,
                },
                new Skill
                {
                    Id = 2,
                    Name = "MS SQL",
                    ApplicantId = 1
                },
                new Skill
                {
                    Id = 3,
                    Name = "Angular",
                    ApplicantId= 1
                });
        }

        
    }
}
