using Microsoft.AspNetCore.Mvc;
using microbloom.Services.Interfaces;
using microbloom.DTOs;

namespace microbloom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CvSampleController : ControllerBase
    {
        private readonly ICvSampleService _cvSampleService;
        private readonly ILogger<CvSampleController> _logger;

        public CvSampleController(ICvSampleService cvSampleService, ILogger<CvSampleController> logger)
        {
            _cvSampleService = cvSampleService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<CvSampleDto>>> GetAll()
        {
            try
            {
                var cvSamples = await _cvSampleService.GetAllCvSamplesAsync();
                return Ok(cvSamples);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all CV samples");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CvSampleDto>> GetById(int id)
        {
            try
            {
                var cvSample = await _cvSampleService.GetCvSampleByIdAsync(id);
                if (cvSample == null)
                    return NotFound();

                return Ok(cvSample);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error getting CV sample with id {id}");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
