using PT.API;
using PT.DTO;

namespace PT.Services;

public class CollectionService(IDataRepo dataRepo) : ICollectionService
{
    public async Task<bool> DoRecord(UserRequestData data)
    {
        try
        {
            var model = new AnswerEntity
            {
                Solved = data.Solved,
                Time = data.Time
            };
        
            return await dataRepo.DoRecord(model);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }
}