namespace PT.Services;

public interface IFeedBackService
{
    bool AlreadyExist { get; }
    
    bool WriteFeedback(string feedback);
}