namespace KnockoutAddictions.API.DTOs
{
    public class AddictionDto
    {
        public int UserId { get; set; }

        public string Category { get; set; } = "";

        public string Description { get; set; } = "";
    }
}