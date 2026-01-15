using PT.API;

namespace PT.Services;

public interface ICollectionService
{
    Task<bool> DoRecord(AnswerModel answer);
}