using System.ComponentModel.DataAnnotations;

namespace KnockoutAddictions.API.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string PasswordHash { get; set; } = "";

        public string Country { get; set; } = "";

        public int Age { get; set; }

        public string Gender { get; set; } = "";

        public string MedicalProfile { get; set; } = "";

        public int CurrentStreak { get; set; }

        public int LongestStreak { get; set; }

        public int TotalCheckIns { get; set; }

        public DateTime? LastRelapseDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Addiction> Addictions { get; set; } = new List<Addiction>();

        public ICollection<DailyProgress> DailyProgresses { get; set; } = new List<DailyProgress>();
    }
}