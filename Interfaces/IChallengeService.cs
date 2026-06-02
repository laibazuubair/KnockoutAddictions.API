using KnockoutAddictions.API.DTOs;

namespace KnockoutAddictions.API.Interfaces
{
    public interface IChallengeService
    {
        Task<List<ChallengeDto>> GetAllAsync();
    }
}