namespace microbloom.DTOs
{
    public class ContentCategoryDto
    {
        public required string Title { get; set; }
        public required string Slug { get; set; }
        public List<ContentArticleDto> Articles { get; set; } = new List<ContentArticleDto>();
    }
}
