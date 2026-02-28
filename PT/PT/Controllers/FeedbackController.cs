using Microsoft.AspNetCore.Mvc;
using PT.API;
using PT.Services;

namespace PT.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeedbackController(IFeedBackService feedBackService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SendFeedback([FromBody] FeedbackRequestData data)
    {
        if (data == null)
            return BadRequest(new { message = "Data is required." });
        
        var result = feedBackService.WriteFeedback(data.Feedback);
        
        return result 
            ? Ok(new { exist = result }) 
            : BadRequest(new { message = "Feedback is invalid." });
    }

    [HttpGet]
    public async Task<IActionResult> GetFeedback()
    {
        return Ok(new { exist = feedBackService.AlreadyExist });
    }
}