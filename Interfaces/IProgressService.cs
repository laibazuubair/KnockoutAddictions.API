using KnockoutAddictions.API.DTOs;

namespace KnockoutAddictions.API.Interfaces
{
    public interface IProgressService
    {
        Task CreateProgressAsync(int userId, ProgressDto dto);
    }
}