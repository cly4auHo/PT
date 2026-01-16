using PT.DTO;
using Microsoft.EntityFrameworkCore;

namespace PT.Config;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<AnswerEntity> Answers { get; set; }
}