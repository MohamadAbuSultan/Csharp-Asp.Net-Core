using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ConfigController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ConfigController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    [Route("")]
    public ActionResult GetConfig()
    {
        var config = new
        {
            AllowedHosts = _configuration["AllowedHosts"],
            DefaultConnection = _configuration["ConnectionStrings:DefaultConnection"],
            // DefaultConnection = _configuration.GetConnectionString("DefaultConnection"),
            DefaultLogLevel = _configuration["Logging:LogLevel:Default"],
            SigningKey = _configuration["SigningKey"]
        };
        return Ok(config);
    }
}