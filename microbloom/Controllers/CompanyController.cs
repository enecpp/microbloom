using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using microbloom.DTOs;
using microbloom.Entities;
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

        // POST: /api/company/jobs (Yeni i� ilan� olu�turma)
        [HttpPost("jobs")]
        public async Task<IActionResult> CreateJob([FromBody] CreateJobDto createJobDto)
        {
 try
  {
    if (!ModelState.IsValid)
        return BadRequest(ModelState);

      var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (userId == null)
    return Unauthorized("Kullan�c� kimli�i bulunamad�.");

                var user = await _userService.GetUserByIdAsync(userId);
                if (user == null || user.CompanyId == null)
         return Unauthorized("Bu i�lemi yapmak i�in bir �irkete ba�l� olmal�s�n�z.");

          var newJobPosting = await _companyService.CreateJobPostingAsync(createJobDto, user.CompanyId.Value);

          return CreatedAtAction("GetJobById", "JobPostings", 
     new { id = newJobPosting.Id }, newJobPosting);
            }
  catch (Exception ex)
      {
    return BadRequest(new { Message = $"Hata: {ex.Message}" });
        }
        }

        // GET: /api/company/jobs/{jobId:int}/applications (Bir ilana gelen ba�vurular� g�rme)
        [HttpGet("jobs/{jobId:int}/applications")]
        public async Task<ActionResult<List<ApplicationDto>>> GetJobApplications(int jobId)
        {
  try
            {
      var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    if (userId == null)
       return Unauthorized("Kullan�c� kimli�i bulunamad�.");

var user = await _userService.GetUserByIdAsync(userId);
     if (user == null || user.CompanyId == null)
  return Unauthorized("Bir �irkete ba�l� de�ilsiniz.");

            var applications = await _companyService.GetApplicationsForJobAsync(jobId);
              return Ok(applications);
       }
            catch (Exception ex)
        {
          return BadRequest(new { Message = $"Hata: {ex.Message}" });
   }
    }

        // GET: /api/company/jobs (�irketin kendi ilanlar�n� g�rmesi)
  [HttpGet("jobs")]
    public async Task<ActionResult<List<JobPostingDto>>> GetMyCompanyJobs()
        {
  try
        {
          var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    if (userId == null)
          return Unauthorized("Kullan�c� kimli�i bulunamad�.");

        var user = await _userService.GetUserByIdAsync(userId);
                if (user == null || user.CompanyId == null)
          return Unauthorized("Bir �irkete ba�l� de�ilsiniz.");

         var jobs = await _companyService.GetJobsByCompanyAsync(user.CompanyId.Value);
      return Ok(jobs);
            }
  catch (Exception ex)
     {
         return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
      }

    // ? YEN�: POST: /api/company/applications/{applicationId}/approve (Ba�vuruyu onayla)
        [HttpPost("applications/{applicationId}/approve")]
        public async Task<IActionResult> ApproveApplication(int applicationId)
        {
      try
    {
           var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (userId == null)
            return Unauthorized("Kullan�c� kimli�i bulunamad�.");

    var user = await _userService.GetUserByIdAsync(userId);
      if (user == null || user.CompanyId == null)
   return Unauthorized("Bir �irkete ba�l� de�ilsiniz.");

   await _companyService.UpdateApplicationStatusAsync(applicationId, "Approved", user.CompanyId.Value);
     return Ok(new { Message = "Ba�vuru onayland�!" });
   }
catch (UnauthorizedAccessException ex)
            {
    return Unauthorized(ex.Message);
   }
            catch (Exception ex)
            {
       return BadRequest(new { Message = $"Hata: {ex.Message}" });
         }
        }

        // ? YEN�: POST: /api/company/applications/{applicationId}/reject (Ba�vuruyu reddet)
        [HttpPost("applications/{applicationId}/reject")]
        public async Task<IActionResult> RejectApplication(int applicationId)
   {
 try
            {
     var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
       if (userId == null)
    return Unauthorized("Kullan�c� kimli�i bulunamad�.");

    var user = await _userService.GetUserByIdAsync(userId);
      if (user == null || user.CompanyId == null)
      return Unauthorized("Bir �irkete ba�l� de�ilsiniz.");

    await _companyService.UpdateApplicationStatusAsync(applicationId, "Rejected", user.CompanyId.Value);
              return Ok(new { Message = "Ba�vuru reddedildi." });
      }
            catch (UnauthorizedAccessException ex)
    {
        return Unauthorized(ex.Message);
   }
            catch (Exception ex)
      {
   return BadRequest(new { Message = $"Hata: {ex.Message}" });
       }
    }

        // ? YEN�: DELETE: /api/company/jobs/{jobId} (�lan� sil)
        [HttpDelete("jobs/{jobId}")]
        public async Task<IActionResult> DeleteJob(int jobId)
     {
      try
    {
    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
     if (userId == null)
         return Unauthorized("Kullan�c� kimli�i bulunamad�.");

    var user = await _userService.GetUserByIdAsync(userId);
      if (user == null || user.CompanyId == null)
   return Unauthorized("Bir �irkete ba�l� de�ilsiniz.");

         await _companyService.DeleteJobPostingAsync(jobId, user.CompanyId.Value);
     return Ok(new { Message = "�lan ba�ar�yla silindi." });
            }
   catch (UnauthorizedAccessException ex)
         {
return Unauthorized(ex.Message);
       }
            catch (Exception ex)
      {
         return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
    }

        // ? YEN�: PUT: /api/company/jobs/{jobId}/deactivate (�lan� pasif yap)
        [HttpPut("jobs/{jobId}/deactivate")]
        public async Task<IActionResult> DeactivateJob(int jobId)
        {
      try
         {
       var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
           if (userId == null)
      return Unauthorized("Kullan�c� kimli�i bulunamad�.");

   var user = await _userService.GetUserByIdAsync(userId);
      if (user == null || user.CompanyId == null)
           return Unauthorized("Bir �irkete ba�l� de�ilsiniz.");

     await _companyService.ToggleJobStatusAsync(jobId, false, user.CompanyId.Value);
             return Ok(new { Message = "�lan pasif hale getirildi." });
     }
            catch (UnauthorizedAccessException ex)
       {
     return Unauthorized(ex.Message);
      }
         catch (Exception ex)
            {
           return BadRequest(new { Message = $"Hata: {ex.Message}" });
  }

    }

  [HttpGet("profile")]
    public async Task<ActionResult<CompanyProfileDto>> GetCompanyProfile()
    {
      try
      {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null)
          return Unauthorized("Kullanıcı kimliği bulunamadı.");

        var user = await _userService.GetUserByIdAsync(userId);
        if (user == null || user.CompanyId == null)
          return Unauthorized("Bir şirkete bağlı değilsiniz.");

        var profile = await _companyService.GetCompanyProfileAsync(user.CompanyId.Value);
        if (profile == null)
          return NotFound("Şirket profili bulunamadı.");

        return Ok(profile);
      }
      catch (Exception ex)
      {
        return BadRequest(new { Message = $"Hata: {ex.Message}" });
      }
    }

    [HttpPut("profile")]
    public async Task<IActionResult> UpdateCompanyProfile([FromBody] CompanyProfileDto profileDto)
    {
      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      try
      {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null)
          return Unauthorized("Kullanıcı kimliği bulunamadı.");

        var user = await _userService.GetUserByIdAsync(userId);
        if (user == null || user.CompanyId == null)
          return Unauthorized("Bir şirkete bağlı değilsiniz.");

        await _companyService.UpdateCompanyProfileAsync(user.CompanyId.Value, profileDto);

        return NoContent();
      }
      catch (KeyNotFoundException ex)
      {
        return NotFound(new { Message = ex.Message });
      }
      catch (UnauthorizedAccessException ex)
      {
        return Unauthorized(new { Message = ex.Message });
      }
      catch (Exception ex)
      {
        return BadRequest(new { Message = $"Hata: {ex.Message}" });
      }
    }
}
}

