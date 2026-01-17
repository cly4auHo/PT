using PT.API;
using PT.DTO;

namespace PT.Services;

public interface ICollectionService
{
    Task<bool> DoRecord(UserRequestData model);
    Task<List<AnswerEntity>> GetAllAsync();
}