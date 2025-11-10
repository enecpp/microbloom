namespace microbloom.Entities
{
    public class CvSample
    {
        public int Id { get; set; }
        public required string Title { get; set; } // Örn: "Yeni Mezun Bilgisayar Müh. CV'si"
        public required string Description { get; set; }
        public required string FileDownloadUrl { get; set; } // CV'nin indirileceði adres
        public string? ThumbnailImageUrl { get; set; } // Örnek bir önizleme resmi
    }
}
