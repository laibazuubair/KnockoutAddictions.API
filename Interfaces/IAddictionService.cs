using KnockoutAddictions.API.DTOs;

namespace KnockoutAddictions.API.Interfaces
{
    public interface IAddictionService
    {
        Task AddAsync(int userId, AddictionDto dto);
    }
}