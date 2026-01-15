using Microsoft.EntityFrameworkCore;
using PT.API;
using PT.DTO;

namespace PT.Config;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<AnswerModel> Currency { get; set; }
}