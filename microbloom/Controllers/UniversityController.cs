using Microsoft.AspNetCore.Mvc;
using microbloom.Services.Interfaces;
using microbloom.DTOs;

namespace microbloom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
  {
     private readonly IUniversityService _universityService;
        private readonly ILogger<UniversityController> _logger;

        public UniversityController(IUniversityService universityService, ILogger<UniversityController> logger)
        {
  _universityService = universityService;
   _logger = logger;
    }

        [HttpGet]
 public async Task<ActionResult<List<UniversityDto>>> GetAll()
     {
            try
 {
   var universities = await _universityService.GetAllUniversitiesAsync();
 return Ok(universities);
            }
 catch (Exception ex)
  {
    _logger.LogError(ex, "Error getting all universities");
  return StatusCode(500, new { error = ex.Message });
    }
        }

        [HttpGet("{id}")]
  public async Task<ActionResult<UniversityDetailDto>> GetById(int id)
        {
        try
  {
  var university = await _universityService.GetUniversityByIdAsync(id);
       if (university == null)
     return NotFound();

    return Ok(university);
     }
      catch (Exception ex)
 {
      _logger.LogError(ex, $"Error getting university with id {id}");
  return StatusCode(500, new { error = ex.Message });
        }
 }

 [HttpGet("search")]
  public async Task<ActionResult<List<UniversityDto>>> Search([FromQuery] string? searchTerm, [FromQuery] bool? isStateUniversity)
     {
   try
   {
   var universities = await _universityService.SearchUniversitiesAsync(searchTerm ?? "", isStateUniversity);
      return Ok(universities);
       }
            catch (Exception ex)
 {
_logger.LogError(ex, "Error searching universities");
     return StatusCode(500, new { error = ex.Message });
     }
        }
    }
}
