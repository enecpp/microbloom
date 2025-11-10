namespace microbloom.DTOs
{
    public class UniversityDto
    {
        public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
     public bool IsStateUniversity { get; set; }
        public string? LogoUrl { get; set; }
        public string? WebSite { get; set; }
        public int DepartmentCount { get; set; }
    }

    public class UniversityDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
 public string City { get; set; } = string.Empty;
    public bool IsStateUniversity { get; set; }
        public string? LogoUrl { get; set; }
public string? WebSite { get; set; }
     public List<DepartmentDto> Departments { get; set; } = new();
    }

    public class DepartmentDto
    {
    public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ScoreType { get; set; } = string.Empty;
        public double LastYearBaseScore { get; set; }
        public int LastYearBaseRanking { get; set; }
        public string UniversityName { get; set; } = string.Empty;
    }

    public class CvSampleDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FileDownloadUrl { get; set; } = string.Empty;
 public string? ThumbnailImageUrl { get; set; }
    }
}