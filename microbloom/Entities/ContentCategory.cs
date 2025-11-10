namespace microbloom.Entities 
{
    public class ContentCategory 
    {
        public int Id { get; set; }
        public string Title { get; init; } = null!; 
        public string Slug { get; init; } = null!;
 
        public ICollection<ContentArticle>? Articles { get; set; }
    }
}