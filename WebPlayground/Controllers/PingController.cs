using Microsoft.AspNetCore.Mvc;
using WebPlayground.Request;

namespace WebPlayground.Controllers;

[ApiController]
[Route("/api/ping")]
public class PingController(ILogger<PingController> logger) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("PONG");
    }

    [HttpPost("hello")]
    public IActionResult UpdateValue([FromBody] PingRequest request)
    {
        logger.LogInformation("User said \"{}\"", request.message);
        return Ok(new
        {
            request.message,
            timestamp = DateTime.Now
        });
    }
}