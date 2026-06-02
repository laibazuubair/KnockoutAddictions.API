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
    public class RelapseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RelapseController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(RelapseDto dto)
        {
            var relapse = new Relapse
            {
                UserId = dto.UserId,
                Notes = dto.Notes,
                RelapseDate = DateTime.UtcNow
            };

            _context.Relapses.Add(relapse);

            var user = await _context.Users.FindAsync(dto.UserId);

            if (user != null)
            {
                user.LastRelapseDate = DateTime.UtcNow;
                user.CurrentStreak = 0;
            }

            await _context.SaveChangesAsync();

            return Ok(new
            {
                relapse.Id,
                relapse.UserId,
                relapse.Notes,
                relapse.RelapseDate
            });
        }
    }
}