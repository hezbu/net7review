using Microsoft.AspNetCore.Mvc;

namespace net7webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class OAuthController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<OAuthController> _logger;

    public OAuthController(ILogger<OAuthController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<object> Get(string code)
    {
       return new { a = 2};
    }
}
