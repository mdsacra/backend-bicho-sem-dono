using Microsoft.AspNetCore.Mvc;

namespace BichoSemDono.Controllers;

[ApiController]
[Route("configuration")]
public class ConfigurationController : ControllerBase
{
    private readonly ILogger<ConfigurationController> _logger;
    private readonly IConfiguration _configuration;

    public ConfigurationController(ILogger<ConfigurationController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet()]
    public IActionResult GetConfig()
        => Ok(new
        {
            Environment = _configuration["Environment"]
        });
}