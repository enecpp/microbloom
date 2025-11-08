using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using microbloom.Services.Interfaces;
using System.Security.Claims;

namespace microbloom.Controllers
{
    [Route("api/company")]
  [ApiController]
    [Authorize(Roles = "Employer")]
    public class CompanyController : ControllerBase
    {
  private readonly ICompanyService _companyService;
       private readonly IUserService _userService;
     private readonly UserManager<AppUser> _userManager;

    public CompanyController(
  ICompanyService companyService, 
      IUserService userService,
            UserManager<AppUser> userManager)
        {
      _companyService = companyService;
        _userService = userService;
 _userManager = userManager;
      }

      // POST: /api/company/jobs (Yeni iþ ilaný oluþturma)
       [HttpPost("jobs")]
   public async Task<IActionResult> CreateJob([FromBody] CreateJobDto createJobDto)
    {
     try
       {
   if (!ModelState.IsValid)
       return BadRequest(ModelState);

 var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
 if (userId == null)
       return Unauthorized("Kullanýcý kimliði bulunamadý.");

  var user = await _userService.GetUserByIdAsync(userId);
 if (user == null || user.CompanyId == null)
          return Unauthorized("Bu iþlemi yapmak için bir þirkete baðlý olmalýsýnýz.");

       var newJobPosting = await _companyService.CreateJobPostingAsync(createJobDto, user.CompanyId.Value);

  return CreatedAtAction("GetJobById", "JobPostings", 
 new { id = newJobPosting.Id }, newJobPosting);
   }
 catch (Exception ex)
           {
          return BadRequest(new { Message = $"Hata: {ex.Message}" });
       }
   }

    // GET: /api/company/jobs/{jobId:int}/applications (Bir ilana gelen baþvurularý görme)
       [HttpGet("jobs/{jobId:int}/applications")]
    public async Task<ActionResult<List<ApplicationDto>>> GetJobApplications(int jobId)
      {
        try
        {
    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
      if (userId == null)
 return Unauthorized("Kullanýcý kimliði bulunamadý.");

         var user = await _userService.GetUserByIdAsync(userId);
              if (user == null || user.CompanyId == null)
        return Unauthorized("Bir þirkete baðlý deðilsiniz.");

 var applications = await _companyService.GetApplicationsForJobAsync(jobId);
  return Ok(applications);
    }
    catch (Exception ex)
  {
  return BadRequest(new { Message = $"Hata: {ex.Message}" });
       }
  }

// GET: /api/company/jobs (Þirketin kendi ilanlarýný görmesi)
  [HttpGet("jobs")]
     public async Task<ActionResult<List<JobPostingDto>>> GetMyCompanyJobs()
       {
  try
     {
 var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
 if (userId == null)
 return Unauthorized("Kullanýcý kimliði bulunamadý.");

     var user = await _userService.GetUserByIdAsync(userId);
  if (user == null || user.CompanyId == null)
return Unauthorized("Bir þirkete baðlý deðilsiniz.");

  var jobs = await _companyService.GetJobsByCompanyAsync(user.CompanyId.Value);
      return Ok(jobs);
  }
     catch (Exception ex)
  {
      return BadRequest(new { Message = $"Hata: {ex.Message}" });
      }
   }
   }
}
