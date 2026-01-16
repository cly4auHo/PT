using PT.API;

namespace PT.Services;

public interface ICollectionService
{
    Task<bool> DoRecord(UserRequestData model);
}