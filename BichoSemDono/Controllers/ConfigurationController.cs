using Microsoft.AspNetCore.Mvc;

namespace BichoSemDono.Controllers;

[ApiController]
[Route("configuration")]
public class ConfigurationController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ConfigurationController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult GetConfig()
        => Ok(new
        {
            Environment = _configuration["Environment"]
        });
}