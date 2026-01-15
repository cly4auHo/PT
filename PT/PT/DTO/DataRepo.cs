using Microsoft.EntityFrameworkCore;
using PT.API;
using PT.Config;

namespace PT.DTO;

public class DataRepo(AppDbContextFactory dbContextFactory) : IDataREPO
{
    public async Task DoRecord(AnswerModel model)
    {
        await using var dbContext = dbContextFactory.CreateDbContext();

        dbContext.Currency.Add(model);
        
        try
        {
            await dbContext.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
        }
    }
}