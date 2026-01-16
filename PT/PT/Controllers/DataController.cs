using PT.API;
using PT.Services;
using Microsoft.AspNetCore.Mvc;

namespace PT.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController(ICollectionService collectionService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SendData([FromBody] UserRequestData requestData)
    {
        if (requestData == null)
            return BadRequest(new { message = "Data is required." });

        var result = await collectionService.DoRecord(requestData);
        
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