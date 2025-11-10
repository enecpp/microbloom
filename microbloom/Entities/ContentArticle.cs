namespace microbloom.Entities
{
    public class ContentArticle
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Slug { get; set; } 
        public required string Summary { get; set; } 
        public required string Content { get; set; } 

        public int ContentCategoryId { get; set; }
        public ContentCategory? ContentCategory { get; set; }
    }
}