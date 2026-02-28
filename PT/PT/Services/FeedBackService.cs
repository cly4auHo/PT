namespace PT.Services;

public class FeedBackService : IFeedBackService
{
    public bool AlreadyExist => File.Exists(FilePath);

    private string FilePath 
        => Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "Feedback"), "feedback.txt");

    public bool WriteFeedback(string feedback)
    {
        try
        {
            if (AlreadyExist)
                return false;
            
            using var writer = new StreamWriter(FilePath);
            writer.WriteLine(feedback);

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }
}