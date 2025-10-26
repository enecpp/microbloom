using microbloom.DTOs;
using microbloom.Services.Interfaces; 
using Microsoft.AspNetCore.Mvc;

namespace microbloom.Controllers
{
    [Route("api/jobpostings")] 
    [ApiController]
    public class JobPostingsController : ControllerBase
    {

        private readonly IJobService _jobService;

        public JobPostingsController(IJobService jobService)
        {
            _jobService = jobService;
        }


        [HttpGet]
        public async Task<ActionResult<List<JobPostingDto>>> GetAllJobs()
        {
            var jobs = await _jobService.GetAllJobsAsync();
            return Ok(jobs);
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<JobPostingDetailDto>> GetJobById(int id)
        {
            var job = await _jobService.GetJobByIdAsync(id);
            if (job == null)
            {
                return NotFound("İş ilanı bulunamadı.");
            }
            return Ok(job);
        }

        [HttpGet("search")]
        public async Task<ActionResult<List<JobPostingDto>>> SearchJobs(
            [FromQuery] string keyword,
            [FromQuery] string location)
        {
            var jobs = await _jobService.SearchJobsAsync(keyword, location);
            return Ok(jobs);
        }
    }
}