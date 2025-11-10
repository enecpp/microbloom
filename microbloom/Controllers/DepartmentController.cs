using Microsoft.AspNetCore.Mvc;
using microbloom.Services.Interfaces;
using microbloom.DTOs;

namespace microbloom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
 private readonly IDepartmentService _departmentService;
  private readonly ILogger<DepartmentController> _logger;

 public DepartmentController(IDepartmentService departmentService, ILogger<DepartmentController> logger)
  {
       _departmentService = departmentService;
     _logger = logger;
 }

 [HttpGet]
        public async Task<ActionResult<List<DepartmentDto>>> GetAll()
      {
  try
       {
 var departments = await _departmentService.GetAllDepartmentsAsync();
    return Ok(departments);
     }
  catch (Exception ex)
  {
      _logger.LogError(ex, "Error getting all departments");
      return StatusCode(500, new { error = ex.Message });
    }
    }

 [HttpGet("university/{universityId}")]
  public async Task<ActionResult<List<DepartmentDto>>> GetByUniversityId(int universityId)
  {
   try
   {
  var departments = await _departmentService.GetDepartmentsByUniversityIdAsync(universityId);
      return Ok(departments);
  }
     catch (Exception ex)
 {
     _logger.LogError(ex, $"Error getting departments for university {universityId}");
       return StatusCode(500, new { error = ex.Message });
      }
     }

 [HttpGet("search")]
  public async Task<ActionResult<List<DepartmentDto>>> Search([FromQuery] string? searchTerm, [FromQuery] string? scoreType)
  {
   try
    {
  var departments = await _departmentService.SearchDepartmentsAsync(searchTerm ?? "", scoreType);
   return Ok(departments);
 }
   catch (Exception ex)
 {
       _logger.LogError(ex, "Error searching departments");
  return StatusCode(500, new { error = ex.Message });
  }
        }
    }
}
