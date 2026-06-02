using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using KnockoutAddictions.API.Data;
using KnockoutAddictions.API.DTOs;
using KnockoutAddictions.API.Models;

namespace KnockoutAddictions.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProgressController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProgressController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProgressDto dto)
        {
            var progress = new DailyProgress
            {
                UserId = dto.UserId,
                Date = DateTime.UtcNow,
                MorningRoundCompleted = dto.MorningRoundCompleted,
                AfternoonRoundCompleted = dto.AfternoonRoundCompleted,
                EveningRoundCompleted = dto.EveningRoundCompleted,
                PunchingBagCompleted = dto.PunchingBagCompleted,
                DayNumber = dto.DayNumber
            };

            _context.DailyProgresses.Add(progress);

            var user = await _context.Users.FindAsync(dto.UserId);

            if (user != null)
            {
                user.TotalCheckIns++;
                user.CurrentStreak++;

                if (user.CurrentStreak > user.LongestStreak)
                    user.LongestStreak = user.CurrentStreak;
            }

            await _context.SaveChangesAsync();

            return Ok(new
            {
                progress.Id,
                progress.UserId,
                progress.Date,
                progress.DayNumber,
                progress.MorningRoundCompleted,
                progress.AfternoonRoundCompleted,
                progress.EveningRoundCompleted,
                progress.PunchingBagCompleted
            });
        }
    }
}