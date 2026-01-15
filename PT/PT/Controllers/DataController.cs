using Microsoft.AspNetCore.Mvc;
using PT.API;
using PT.Services;

namespace PT.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController(ICollectionService dataService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SendData([FromBody] AnswerModel requestData)
    {
        if (requestData == null)
            return BadRequest(new { message = "Data is required." });

        var result = await dataService.DoRecord(requestData);
        
        if (result)
        {
            return Ok(new
            {
                message = "Data received",
                data = requestData
            });
        }

        return BadRequest(new { message = "Data is invalid." });
    }
}