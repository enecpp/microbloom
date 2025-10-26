using microbloom.DTOs;
using microbloom.Entities;

namespace microbloom.Services.Interfaces
{
    public interface ICompanyService
    {
        Task<JobPosting> CreateJobPostingAsync(CreateJobDto jobDto, int companyId);
        Task<List<JobPostingDto>> GetJobsByCompanyAsync(int companyId);
        Task<List<ApplicationDto>> GetApplicationsForJobAsync(int jobId);
    }
}

