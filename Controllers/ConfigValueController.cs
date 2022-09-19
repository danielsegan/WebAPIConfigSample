using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebAPIConfigSample.Controllers;

[ApiController]
[Route("[controller]")]
public class ConfigValueController : ControllerBase
{
    private readonly ILogger<ConfigValueController> _logger;
    private readonly IConfiguration _config;

    public ConfigValueController(ILogger<ConfigValueController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _config = configuration;
    }

    [HttpGet(Name = "GetConfigValue")]
    public ConfigValue Get()
    {
        return new ConfigValue { Value = _config["TestSetting"] };
    }
}