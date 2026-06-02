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
    public class AddictionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AddictionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddictionDto dto)
        {
            var addiction = new Addiction
            {
                UserId = dto.UserId,
                Category = dto.Category,
                Description = dto.Description,
                StartDate = DateTime.UtcNow,
                IsActive = true
            };

            _context.Addictions.Add(addiction);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                addiction.Id,
                addiction.UserId,
                addiction.Category,
                addiction.Description,
                addiction.StartDate,
                addiction.IsActive
            });
        }
    }
}