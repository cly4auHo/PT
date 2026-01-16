using Microsoft.EntityFrameworkCore;

namespace PT.DTO;

[Index(nameof(Id), IsUnique = true)]
public class AnswerEntity
{
    public int Id { get; set; }
    public bool Solved { get; set; }
    public int Time { get; set; }
}