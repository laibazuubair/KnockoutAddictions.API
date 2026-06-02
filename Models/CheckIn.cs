namespace KnockoutAddictions.API.Models
{
    public class CheckIn
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }
        public DateTime CheckInTime { get; set; }

        public string Notes { get; set; } = "";
    }
}