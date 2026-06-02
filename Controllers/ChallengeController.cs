using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KnockoutAddictions.API.Data;

namespace KnockoutAddictions.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChallengeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ChallengeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var challenges = await _context.Challenges.ToListAsync();
            return Ok(challenges);
        }
    }
}