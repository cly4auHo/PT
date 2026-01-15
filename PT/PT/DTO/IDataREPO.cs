using PT.API;

namespace PT.DTO;

public interface IDataREPO
{
    Task DoRecord(AnswerModel model);
}