using Microsoft.EntityFrameworkCore;
using PT.DTO;

namespace PT.Config;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<CurrencyEntity> Currency { get; set; }
}