namespace KnockoutAddictions.API.Models
{
    public class DailyProgress
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }
        public DateTime Date { get; set; }

        public bool MorningRoundCompleted { get; set; }

        public bool AfternoonRoundCompleted { get; set; }

        public bool EveningRoundCompleted { get; set; }

        public bool PunchingBagCompleted { get; set; }

        public int DayNumber { get; set; }
    }
}