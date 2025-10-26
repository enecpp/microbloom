namespace microbloom.DTOs
{
    public class ApplicationDto
    {
public int Id { get; set; }
        public int JobPostingId { get; set; }
        public string? JobTitle { get; set; }
        public string? AppUserId { get; set; }
  public DateTime ApplicationDate { get; set; }
        public string? Status { get; set; }
    }
}
