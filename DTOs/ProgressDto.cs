namespace KnockoutAddictions.API.DTOs
{
    public class ProgressDto
    {
        public int UserId { get; set; }

        public bool MorningRoundCompleted { get; set; }

        public bool AfternoonRoundCompleted { get; set; }

        public bool EveningRoundCompleted { get; set; }

        public bool PunchingBagCompleted { get; set; }

        public int DayNumber { get; set; }
    }
}