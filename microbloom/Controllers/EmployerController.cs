using Microsoft.AspNetCore.Authorization;
using microbloom.DTOs;
using microbloom.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace microbloom.Controllers
{
    [Route("api/employer")]
    [ApiController]
    [Authorize(Roles = "Employer")]
    public class EmployerController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IUserService _userService;

        public EmployerController(ICompanyService companyService, IUserService userService)
        {
            _companyService = companyService;
            _userService = userService;
        }

        // POST: /api/employer/job-postings
        [HttpPost("job-postings")]
        public async Task<IActionResult> CreateJobPosting([FromBody] CreateJobDto createJobDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (userId == null)
                    return Unauthorized("Kullanýcý kimliði bulunamadý.");

                var user = await _userService.GetUserByIdAsync(userId);
                if (user?.CompanyId == null)
                    return BadRequest(new { Message = "Kullanýcý hiçbir þirkete ait deðil." });

                var jobPosting = await _companyService.CreateJobPostingAsync(createJobDto, user.CompanyId.Value);
                return Ok(new { Message = "Ýþ ilaný baþarýyla oluþturuldu.", JobId = jobPosting.Id });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
        }

        // GET: /api/employer/job-postings
        [HttpGet("job-postings")]
        public async Task<IActionResult> GetMyJobPostings()
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (userId == null)
                    return Unauthorized("Kullanýcý kimliði bulunamadý.");

                var user = await _userService.GetUserByIdAsync(userId);
                if (user?.CompanyId == null)
                    return BadRequest(new { Message = "Kullanýcý hiçbir þirkete ait deðil." });

                var jobs = await _companyService.GetJobsByCompanyAsync(user.CompanyId.Value);
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
        }

        // GET: /api/employer/applications/{jobId}
        [HttpGet("applications/{jobId:int}")]
        public async Task<IActionResult> GetApplicationsForJob(int jobId)
        {
            try
            {
                var applications = await _companyService.GetApplicationsForJobAsync(jobId);
                return Ok(applications);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
        }
    }
}
