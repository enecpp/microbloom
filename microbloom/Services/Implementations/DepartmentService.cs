using Microsoft.EntityFrameworkCore;
using microbloom.Services.Interfaces;
using microbloom.DTOs;

namespace microbloom.Services.Implementations
{
    public class DepartmentService : IDepartmentService
    {
  private readonly KariyerDBContext _context;

        public DepartmentService(KariyerDBContext context)
  {
          _context = context;
        }

 public async Task<List<DepartmentDto>> GetAllDepartmentsAsync()
     {
  return await _context.Departments
     .Include(d => d.University)
  .Select(d => new DepartmentDto
    {
        Id = d.Id,
   Name = d.Name,
         ScoreType = d.ScoreType,
  LastYearBaseScore = d.LastYearBaseScore,
  LastYearBaseRanking = d.LastYearBaseRanking,
         UniversityName = d.University != null ? d.University.Name : ""
      })
         .ToListAsync();
}

 public async Task<List<DepartmentDto>> GetDepartmentsByUniversityIdAsync(int universityId)
      {
            return await _context.Departments
     .Where(d => d.UniversityId == universityId)
     .Select(d => new DepartmentDto
     {
    Id = d.Id,
            Name = d.Name,
      ScoreType = d.ScoreType,
   LastYearBaseScore = d.LastYearBaseScore,
      LastYearBaseRanking = d.LastYearBaseRanking,
       UniversityName = d.University != null ? d.University.Name : ""
   })
      .ToListAsync();
        }

      public async Task<List<DepartmentDto>> SearchDepartmentsAsync(string searchTerm, string? scoreType = null)
     {
      var query = _context.Departments.Include(d => d.University).AsQueryable();

   if (!string.IsNullOrWhiteSpace(searchTerm))
    {
       query = query.Where(d => d.Name.Contains(searchTerm) || 
             (d.University != null && d.University.Name.Contains(searchTerm)));
  }

    if (!string.IsNullOrWhiteSpace(scoreType))
  {
            query = query.Where(d => d.ScoreType == scoreType);
   }

       return await query
    .Select(d => new DepartmentDto
     {
       Id = d.Id,
     Name = d.Name,
        ScoreType = d.ScoreType,
   LastYearBaseScore = d.LastYearBaseScore,
     LastYearBaseRanking = d.LastYearBaseRanking,
        UniversityName = d.University != null ? d.University.Name : ""
   })
 .ToListAsync();
        }
    }
}
