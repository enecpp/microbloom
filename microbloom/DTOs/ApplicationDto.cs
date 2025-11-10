namespace microbloom.DTOs
{
    public class ApplicationDto
    {
        public int Id { get; set; }
        public int JobPostingId { get; set; }
        public string? JobTitle { get; set; }
        public string? AppUserId { get; set; }
  
        // ? Baþvuran kullanýcý bilgileri
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserFullName => $"{UserFirstName} {UserLastName}";

        public DateTime ApplicationDate { get; set; }
        public string? Status { get; set; }
    }
}
