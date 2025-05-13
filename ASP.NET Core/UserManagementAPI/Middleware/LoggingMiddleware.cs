using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<LoggingMiddleware> _logger;

    public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Log Incoming Request
        _logger.LogInformation($"Incoming Request: {context.Request.Method} {context.Request.Path}");

        // Read and log request body (if applicable)
        context.Request.EnableBuffering();
        var requestBody = await new StreamReader(context.Request.Body, Encoding.UTF8).ReadToEndAsync();
        context.Request.Body.Position = 0; // Reset stream position for further use
        _logger.LogInformation($"Request Body: {requestBody}");

        // Proceed with the request pipeline
        await _next(context);

        // Log Outgoing Response
        _logger.LogInformation($"Outgoing Response: {context.Response.StatusCode}");
    }
}