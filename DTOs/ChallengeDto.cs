namespace KnockoutAddictions.API.DTOs
{
    public class ChallengeDto
    {
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public int DurationDays { get; set; }

        public string AddictionCategory { get; set; } = "";
    }
}