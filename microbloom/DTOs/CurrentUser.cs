namespace microbloom.DTOs
{
    public class CurrentUser
    {
        public string? UserName { get; set; }
        public Dictionary<string, string>? Claims { get; set; }
    }
}
