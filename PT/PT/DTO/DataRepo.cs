using PT.Config;
using Microsoft.EntityFrameworkCore;

namespace PT.DTO;

public class DataRepo(AppDbContextFactory dbContextFactory) : IDataRepo
{
    public async Task<bool> DoRecord(AnswerEntity entity)
    {
        await using var dbContext = dbContextFactory.CreateDbContext();

        dbContext.Answers.Add(entity);

        try
        {
            var result = await dbContext.SaveChangesAsync();
            
            return result == 1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException?.Message ?? e.Message);
            
            return false;
        }
    }
    
    public async Task<List<AnswerEntity>> GetAllAsync()
    {
        await using var dbContext = dbContextFactory.CreateDbContext();
        
        return await dbContext.Answers.AsNoTracking().ToListAsync();
    }
}