using Microsoft.EntityFrameworkCore;

namespace PT.Config;

public class AppDbContextFactory : IDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=answers;Username=user;Password=password");

        return new AppDbContext(optionsBuilder.Options);
    }
}