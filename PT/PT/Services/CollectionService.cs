using PT.API;
using PT.DTO;

namespace PT.Services;

public class CollectionService(IDataREPO appSettings) : ICollectionService
{
    public async Task<bool> DoRecord(AnswerModel answerModel)
    {
        return false;
    }
}