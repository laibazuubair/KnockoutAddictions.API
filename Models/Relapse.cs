namespace KnockoutAddictions.API.Models
{
    public class Relapse
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

        public string Notes { get; set; } = "";

        public DateTime RelapseDate { get; set; } = DateTime.UtcNow;
    }
}