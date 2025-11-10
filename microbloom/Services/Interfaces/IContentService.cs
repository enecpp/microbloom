public interface IContentService
{
    Task<List<ContentCategoryDto>> GetAllCategoriesWithArticlesAsync();
    Task<ContentArticleDetailDto?> GetArticleBySlugAsync(string categorySlug, string articleSlug);
}