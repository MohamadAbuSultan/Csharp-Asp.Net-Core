using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

[ApiController]
[Route("[controller]")]
public class ConfigController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IOptions<AttachmentOptions> _attachmentOptions;

    public ConfigController(IConfiguration configuration, IOptions<AttachmentOptions> attachmentOptions)
    {
        _configuration = configuration;
        _attachmentOptions = attachmentOptions;
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
            SigningKey = _configuration["SigningKey"],
            AttachmentsOptions = _attachmentOptions.Value
        };
        return Ok(config);
    }
}