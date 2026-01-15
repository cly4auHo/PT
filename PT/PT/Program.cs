using Microsoft.EntityFrameworkCore;
using PT;
using PT.Config;
using PT.DTO;
using PT.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICollectionService, CollectionService>();
builder.Services.AddSingleton<IDataREPO, DataRepo>();
builder.Services.AddSingleton<AppDbContextFactory, AppDbContextFactory>();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddSingleton(resolver =>
    resolver.GetRequiredService<Microsoft.Extensions.Options.IOptions<AppSettings>>().Value);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.Run();