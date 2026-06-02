namespace KnockoutAddictions.API.Models
{
    public class Addiction
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }
        public string Category { get; set; } = "";

        public string Description { get; set; } = "";

        public DateTime StartDate { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;
    }
}