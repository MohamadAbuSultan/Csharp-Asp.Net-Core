var builder = WebApplication.CreateBuilder(args);

// Registering MyService as a Transient service
// Each time IMyService is requested, a new instance of MyService will be created
builder.Services.AddTransient<IMyService, MyService>();

var app = builder.Build();

// First middleware to log service creation
app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService<IMyService>();
    myService.LogCreation("First Middleware");
    await next.Invoke();
});

// Second middleware to log service creation
app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService<IMyService>();
    myService.LogCreation("Second Middleware");
    await next.Invoke();
});

// Endpoint to log service creation and return a response
app.MapGet("/", (IMyService myService) =>
{
    myService.LogCreation("Root");

    return Results.Ok("Check The Console For Service Creation Logs.");
});

app.Run();

public interface IMyService
{
    void LogCreation(string message);
}

public class MyService : IMyService
{
    private readonly int _serviceId;

    // Constructor to initialize the service with a random ID
    public MyService()
    {
        _serviceId = new Random().Next(100000, 999999);
    }

    // Method to log the creation message with the service ID
    public void LogCreation(string message)
    {
        Console.WriteLine($"{message} - Service ID: {_serviceId}");
    }
}