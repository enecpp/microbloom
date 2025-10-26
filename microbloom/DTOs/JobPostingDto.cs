namespace microbloom.DTOs
{
    public class JobPostingDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime PostedDate { get; set; }
        public bool IsActive { get; set; }
        public string? CompanyName { get; set; }
    }
}
