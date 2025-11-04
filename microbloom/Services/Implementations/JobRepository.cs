using Microsoft.EntityFrameworkCore;
using microbloom.Data;
using microbloom.DTOs;
using microbloom.Services.Interfaces;

namespace microbloom.Services.Implementations
{
    public class JobService : IJobService
    {
        private readonly KariyerDBContext _context;

        public JobService(KariyerDBContext context)
        {
            _context = context;
        }

        public async Task<List<JobPostingDto>> GetAllJobsAsync()
        {
            var jobPostings = _context.JobPostings;
            if (jobPostings == null)
                return new();

            return await jobPostings
                .Include(jp => jp.Company)
                .Where(jp => jp.IsActive)
                .OrderByDescending(jp => jp.PostedDate)
                .Select(jp => new JobPostingDto
                {
                    Id = jp.Id,
                    Title = jp.Title,
                    Description = jp.Description,
                    CompanyName = jp.Company == null ? "" : jp.Company.Name,
                    Location = jp.Location,
                    PostedDate = jp.PostedDate,
                    IsActive = jp.IsActive
                })
                .ToListAsync();
        }

        public async Task<JobPostingDetailDto?> GetJobByIdAsync(int jobId)
        {
            var jobPostings = _context.JobPostings;
            if (jobPostings == null)
                return null;

            return await jobPostings
                .Include(jp => jp.Company)
                .Where(jp => jp.Id == jobId)
                .Select(jp => new JobPostingDetailDto
                {
                    Id = jp.Id,
                    Title = jp.Title,
                    CompanyName = jp.Company == null ? "" : jp.Company.Name,
                    CompanyDescription = jp.Company == null ? "" : jp.Company.Description,
                    CompanyId = jp.CompanyId,
                    Location = jp.Location,
                    JobDescription = jp.Description,
                    PostedDate = jp.PostedDate,
                    IsActive = jp.IsActive
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<JobPostingDto>> SearchJobsAsync(string keyword, string location)
        {
            var jobPostings = _context.JobPostings;
            if (jobPostings == null)
                return new();

            var query = jobPostings
                .Include(jp => jp.Company)
                .Where(jp => jp.IsActive);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(jp =>
                    (jp.Title != null && jp.Title.Contains(keyword)) ||
                    (jp.Description != null && jp.Description.Contains(keyword)));
            }

            if (!string.IsNullOrWhiteSpace(location))
            {
                query = query.Where(jp => jp.Location != null && jp.Location.Contains(location));
            }

            return await query
                .OrderByDescending(jp => jp.PostedDate)
                .Select(jp => new JobPostingDto
                {
                    Id = jp.Id,
                    Title = jp.Title,
                    Description = jp.Description,
                    CompanyName = jp.Company == null ? "" : jp.Company.Name,
                    Location = jp.Location,
                    PostedDate = jp.PostedDate,
                    IsActive = jp.IsActive
                })
                .ToListAsync();
        }

        public async Task ApplyForJobAsync(int jobId, string userId)
        {
            var applications = _context.JobApplications;
            if (applications == null)
                throw new InvalidOperationException("Database bağlantısında hata.");

            // Çift başvuru kontrol et
            var existingApplication = await applications
                .FirstOrDefaultAsync(ja => ja.JobPostingId == jobId && ja.AppUserId == userId);

            if (existingApplication != null)
            {
                throw new InvalidOperationException("Bu ilana zaten başvurdunuz.");
            }

            var application = new JobApplication
            {
                JobPostingId = jobId,
                AppUserId = userId,
                ApplicationDate = DateTime.UtcNow,
                Status = "Pending"
            };

            applications.Add(application);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ApplicationDto>> GetUserApplicationsAsync(string userId)
        {
            var applications = _context.JobApplications;
            if (applications == null)
                return new();

            return await applications
                .Include(ja => ja.JobPosting)
                .Where(ja => ja.AppUserId == userId)
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