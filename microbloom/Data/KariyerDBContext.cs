using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using microbloom.Entities;

namespace microbloom.Data
{
    public class KariyerDBContext : IdentityDbContext<AppUser>
    {
        public KariyerDBContext(DbContextOptions<KariyerDBContext> options) : base(options)
        {
        }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<JobPosting>? JobPostings { get; set; }
        public DbSet<JobApplication>? JobApplications { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<JobPosting>()
                .HasOne(jp => jp.Company)
                .WithMany(c => c.JobPostings)
                .HasForeignKey(jp => jp.CompanyId);

            builder.Entity<JobApplication>()
                .HasOne(ja => ja.JobPosting)
                .WithMany()
                .HasForeignKey(ja => ja.JobPostingId);
            builder.Entity<JobApplication>()
                .HasOne(ja => ja.AppUser)
                .WithMany(u => u.Applications)
                .HasForeignKey(ja => ja.AppUserId);

            // --- TEST DATA SEEDING ---

            // Add test companies
            builder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Google",
                    Description = "Global teknoloji lideri.",
                    LogoUrl = "google.png"
                },
                new Company
                {
                    Id = 2,
                    Name = "Microsoft",
                    Description = "Yazılım ve bulut çözümleri.",
                    LogoUrl = "microsoft.png"
                }
            );

            // Add test job postings
            builder.Entity<JobPosting>().HasData(
                new JobPosting
                {
                    Id = 1,
                    Title = "Kıdemli .NET Geliştiricisi",
                    Description = "ASP.NET Core ve Azure konusunda deneyimli...",
                    Location = "İstanbul",
                    PostedDate = DateTime.UtcNow,
                    IsActive = true,
                    CompanyId = 2 // Microsoft
                },
                new JobPosting
                {
                    Id = 2,
                    Title = "Frontend Geliştirici (React)",
                    Description = "React ve TypeScript bilen...",
                    Location = "Ankara",
                    PostedDate = DateTime.UtcNow,
                    IsActive = true,
                    CompanyId = 1 // Google
                },
                new JobPosting
                {
                    Id = 3,
                    Title = "DevOps Mühendisi",
                    Description = "CI/CD süreçlerine hakim...",
                    Location = "İstanbul",
                    PostedDate = DateTime.UtcNow,
                    IsActive = true,
                    CompanyId = 2 // Microsoft
                }
            );
        }
    }
}
