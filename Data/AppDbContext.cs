using Microsoft.EntityFrameworkCore;
using PasswordValidatorApi.Models;

namespace PasswordValidatorApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ValidationAttempt> ValidationAttempts { get; set; }
}
