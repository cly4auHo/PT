using Microsoft.EntityFrameworkCore;

namespace PT.Config;

public class AppDbContextFactory(AppSettings appSettings) : IDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(appSettings.DefaultConnection);

        return new AppDbContext(optionsBuilder.Options);
    }
}