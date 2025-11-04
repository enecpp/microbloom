using System.ComponentModel.DataAnnotations;

namespace microbloom.DTOs
{
    public class CreateJobDto
    {
        [Required(ErrorMessage = "Ýþ baþlýðý gereklidir.")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Ýþ baþlýðý 5-200 karakter arasýnda olmalýdýr.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Ýþ tanýmý gereklidir.")]
        [StringLength(5000, MinimumLength = 20, ErrorMessage = "Ýþ tanýmý 20-5000 karakter arasýnda olmalýdýr.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Lokasyon gereklidir.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Lokasyon 3-100 karakter arasýnda olmalýdýr.")]
        public string? Location { get; set; }
    }
}
