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
            return await _context.JobPostings
                .Include(jp => jp.Company)
                .Where(jp => jp.IsActive)
                .OrderByDescending(jp => jp.PostedDate)
                .Select(jp => new JobPostingDto
                {
                    Id = jp.Id,
                    Title = jp.Title,
                    Description = jp.Description,
                    CompanyName = jp.Company.Name,
                    Location = jp.Location,
                    PostedDate = jp.PostedDate,
                    IsActive = jp.IsActive
                })
                .ToListAsync();
        }

        public async Task<JobPostingDetailDto> GetJobByIdAsync(int jobId)
        {
            return await _context.JobPostings
                .Include(jp => jp.Company)
                .Where(jp => jp.Id == jobId)
                .Select(jp => new JobPostingDetailDto
                {
                    Id = jp.Id,
                    Title = jp.Title,
                    CompanyName = jp.Company.Name,
                    CompanyDescription = jp.Company.Description,
                    CompanyId = jp.Id,
                    Location = jp.Location,
                    JobDescription = jp.Description,
                    PostedDate = jp.PostedDate,
                    IsActive = jp.IsActive
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<JobPostingDto>> SearchJobsAsync(string keyword, string location)
        {
            var query = _context.JobPostings
                .Include(jp => jp.Company)
                .Where(jp => jp.IsActive);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(jp =>
                    jp.Title.Contains(keyword) ||
                    jp.Description.Contains(keyword));
            }

            if (!string.IsNullOrWhiteSpace(location))
            {
                query = query.Where(jp => jp.Location.Contains(location));
            }

            return await query
                .OrderByDescending(jp => jp.PostedDate)
                .Select(jp => new JobPostingDto
                {
                    Id = jp.Id,
                    Title = jp.Title,
                    Description = jp.Description,
                    CompanyName = jp.Company.Name,
                    Location = jp.Location,
                    PostedDate = jp.PostedDate,
                    IsActive = jp.IsActive
                })
                .ToListAsync();
        }

        public async Task ApplyForJobAsync(int jobId, string userId)
        {
            var application = new JobApplication
            {
                JobPostingId = jobId,
                AppUserId = userId,
                ApplicationDate = DateTime.UtcNow,
                Status = "Pending"
            };

            _context.JobApplications.Add(application);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ApplicationDto>> GetUserApplicationsAsync(string userId)
        {
            return await _context.JobApplications
                .Include(ja => ja.JobPosting)
                .Where(ja => ja.AppUserId == userId)
                .OrderByDescending(ja => ja.ApplicationDate)
                .Select(ja => new ApplicationDto
                {
                    Id = ja.Id,
                    JobPostingId = ja.JobPostingId,
                    JobTitle = ja.JobPosting.Title,
                    AppUserId = ja.AppUserId,
                    ApplicationDate = ja.ApplicationDate,
                    Status = ja.Status
                })
                .ToListAsync();
        }
    }
}