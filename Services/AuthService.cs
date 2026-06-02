using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using KnockoutAddictions.API.Data;
using KnockoutAddictions.API.DTOs;
using KnockoutAddictions.API.Interfaces;
using KnockoutAddictions.API.Models;

namespace KnockoutAddictions.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly TokenService _tokenService;

        public AuthService(
            AppDbContext context,
            TokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public async Task<string?> RegisterAsync(RegisterDto dto)
        {
            var exists = await _context.Users
                .AnyAsync(x => x.Email == dto.Email);

            if (exists)
                return null;

            var user = new User
            {
                FullName = dto.FullName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Country = dto.Country,
                Age = dto.Age,
                Gender = dto.Gender,
                MedicalProfile = dto.MedicalProfile
            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return _tokenService.CreateToken(user);
        }

        public async Task<string?> LoginAsync(LoginDto dto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.Email == dto.Email);

            if (user == null)
                return null;

            bool valid = BCrypt.Net.BCrypt.Verify(
                dto.Password,
                user.PasswordHash);

            if (!valid)
                return null;

            return _tokenService.CreateToken(user);
        }
    }
}