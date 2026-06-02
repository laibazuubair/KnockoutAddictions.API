namespace KnockoutAddictions.API.Models
{
    public class Challenge
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public int DurationDays { get; set; }

        public string AddictionCategory { get; set; } = "";
    }
}