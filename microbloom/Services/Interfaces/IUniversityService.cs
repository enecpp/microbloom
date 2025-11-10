namespace microbloom.Services.Interfaces
{
    public interface IUniversityService
    {
 Task<List<UniversityDto>> GetAllUniversitiesAsync();
    Task<UniversityDetailDto?> GetUniversityByIdAsync(int id);
        Task<List<UniversityDto>> SearchUniversitiesAsync(string searchTerm, bool? isStateUniversity = null);
    }

    public interface IDepartmentService
    {
   Task<List<DepartmentDto>> GetAllDepartmentsAsync();
     Task<List<DepartmentDto>> GetDepartmentsByUniversityIdAsync(int universityId);
        Task<List<DepartmentDto>> SearchDepartmentsAsync(string searchTerm, string? scoreType = null);
    }

    public interface ICvSampleService
    {
        Task<List<CvSampleDto>> GetAllCvSamplesAsync();
    Task<CvSampleDto?> GetCvSampleByIdAsync(int id);
    }
}
