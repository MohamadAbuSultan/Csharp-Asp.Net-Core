public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services and configure dependency injection
        builder.Services.AddControllers();

        var app = builder.Build();

        app.MapGet("/", () => "This is the root!");

        // Error-handling middleware should run first
        // app.UseMiddleware<ErrorHandlingMiddleware>();

        // Logging middleware should record requests before authentication
        app.UseMiddleware<LoggingMiddleware>();

        // Authentication middleware runs AFTER error handling
        // app.UseMiddleware<AuthenticationMiddleware>();
        app.UseAuthorization();

        app.MapControllers();
        app.Run();
    }
}