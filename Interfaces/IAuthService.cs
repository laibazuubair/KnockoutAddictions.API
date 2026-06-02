using KnockoutAddictions.API.DTOs;

namespace KnockoutAddictions.API.Interfaces
{
    public interface IAuthService
    {
        Task<string?> RegisterAsync(RegisterDto dto);
        Task<string?> LoginAsync(LoginDto dto);
    }
}