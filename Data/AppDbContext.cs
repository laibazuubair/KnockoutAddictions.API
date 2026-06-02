using Microsoft.EntityFrameworkCore;
using KnockoutAddictions.API.Models;

namespace KnockoutAddictions.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Addiction> Addictions { get; set; }
        public DbSet<Relapse> Relapses { get; set; }

        public DbSet<DailyProgress> DailyProgresses { get; set; }

        public DbSet<Challenge> Challenges { get; set; }

        public DbSet<CheckIn> CheckIns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}