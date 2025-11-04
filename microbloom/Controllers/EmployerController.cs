using microbloom.DTOs;
using microbloom.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace microbloom.Controllers
{
    [Route("api/employer")]
    [ApiController]
    [Authorize] // Tüm employer endpoints'leri sadece giriþ yapmýþ kullanýcýlar eriþebilir
    public class EmployerController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public EmployerController(ICompanyService companyService)
     {
   _companyService = companyService;
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
  // TODO: Þu an hardcoded companyId kullanýyoruz. 
         // Gerçek uygulamada, kullanýcýnýn þirketi belirlenecek.
          var companyId = 1; // Test için

     var jobPosting = await _companyService.CreateJobPostingAsync(createJobDto, companyId);
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
        // TODO: Kullanýcýnýn þirketi belirlenecek.
         var companyId = 1; // Test için

        var jobs = await _companyService.GetJobsByCompanyAsync(companyId);
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
