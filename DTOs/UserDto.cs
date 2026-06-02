namespace KnockoutAddictions.API.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string FullName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Country { get; set; } = "";

        public int Age { get; set; }

        public string Gender { get; set; } = "";

        public string MedicalProfile { get; set; } = "";
    }
}