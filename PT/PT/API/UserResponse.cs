using PT.DTO;

namespace PT.API;

[Serializable]
public class UserResponse
{
    public AnswerEntity[] Answers { get; set; }
}