using System.ComponentModel.DataAnnotations;

namespace KnockoutAddictions.API.DTOs
{
    public class RegisterDto
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string MedicalProfile { get; set; }
    }
}