using KnockoutAddictions.API.DTOs;

namespace KnockoutAddictions.API.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDto>> GetUsersAsync();
    }
}