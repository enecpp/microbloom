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
         IsActive = true
         };

            _context.JobPostings.Add(jobPosting);
            await _context.SaveChangesAsync();

   return jobPosting;
        }

        public async Task<List<JobPostingDto>> GetJobsByCompanyAsync(int companyId)
    {
        return await _context.JobPostings
        .Include(jp => jp.Company)
                .Where(jp => jp.Id == companyId && jp.IsActive)
   .OrderByDescending(jp => jp.PostedDate)
       .Select(jp => new JobPostingDto
  {
     Id = jp.Id,
   Title = jp.Title,
    Description = jp.Description,
            Location = jp.Location,
         PostedDate = jp.PostedDate,
      IsActive = jp.IsActive,
     CompanyName = jp.Company.Name
                })
       .ToListAsync();
        }

     public async Task<List<ApplicationDto>> GetApplicationsForJobAsync(int jobId)
        {
            return await _context.JobApplications
                .Include(ja => ja.AppUser)
                .Where(ja => ja.JobPostingId == jobId)
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
