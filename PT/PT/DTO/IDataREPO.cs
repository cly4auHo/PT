namespace PT.DTO;

public interface IDataRepo
{
    Task<bool> DoRecord(AnswerEntity entity); 
}