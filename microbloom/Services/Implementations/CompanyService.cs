using Microsoft.EntityFrameworkCore;
using microbloom.Data;
using microbloom.DTOs;
using microbloom.Services.Interfaces;

namespace microbloom.Services.Implementations
{
    public class CompanyService : ICompanyService
    {
        private readonly KariyerDBContext _context;

        public CompanyService(KariyerDBContext context)
        {
            _context = context;
        }

        public async Task<JobPosting> CreateJobPostingAsync(CreateJobDto jobDto, int companyId)
        {
            var jobPosting = new JobPosting
            {
                Title = jobDto.Title,
                Description = jobDto.Description,
                Location = jobDto.Location,
                PostedDate = DateTime.UtcNow,
                IsActive = true,
                CompanyId = companyId
            };

            var postings = _context.JobPostings;
            if (postings == null)
                throw new InvalidOperationException("Database baðlantýsýnda hata.");

            postings.Add(jobPosting);
            await _context.SaveChangesAsync();

            return jobPosting;
        }

        public async Task<List<JobPostingDto>> GetJobsByCompanyAsync(int companyId)
        {
            var postings = _context.JobPostings;
            if (postings == null)
                return new();

            return await postings
                .Include(jp => jp.Company)
                .Where(jp => jp.CompanyId == companyId && jp.IsActive)
                .OrderByDescending(jp => jp.PostedDate)
                .Select(jp => new JobPostingDto
                {
                    Id = jp.Id,
                    Title = jp.Title,
                    Description = jp.Description,
                    Location = jp.Location,
                    PostedDate = jp.PostedDate,
                    IsActive = jp.IsActive,
                    CompanyName = jp.Company == null ? "" : jp.Company.Name
                })
                .ToListAsync();
        }

        public async Task<List<ApplicationDto>> GetApplicationsForJobAsync(int jobId)
        {
            var applications = _context.JobApplications;
            if (applications == null)
                return new();

            return await applications
                .Include(ja => ja.AppUser)
                .Include(ja => ja.JobPosting)
                .Where(ja => ja.JobPostingId == jobId)
                .OrderByDescending(ja => ja.ApplicationDate)
                .Select(ja => new ApplicationDto
                {
                    Id = ja.Id,
                    JobPostingId = ja.JobPostingId,
                    JobTitle = ja.JobPosting == null ? "" : ja.JobPosting.Title,
                    AppUserId = ja.AppUserId,
                    ApplicationDate = ja.ApplicationDate,
                    Status = ja.Status
                })
                .ToListAsync();
        }
    }
}
