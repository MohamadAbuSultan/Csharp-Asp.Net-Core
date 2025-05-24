

# Constructor Injection in ASP .NET Core

## Interfaces
```csharp
public interface INotificationService
{
    void Send(string message);
}

public interface ILoggerService
{
    void Log(string message);
}
```

## Implementations
```csharp
public class EmailNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class LoggerService : ILoggerService
{
    public void Log(string message)
    {
        Console.WriteLine($"Log entry: {message}");
    }
}
```

## Constructor Injection in Controller
```csharp
public class OrderController : ControllerBase
{
    private readonly INotificationService _notificationService;
    private readonly ILoggerService _loggerService;

    public OrderController(INotificationService notificationService, ILoggerService loggerService)
    {
        _notificationService = notificationService;
        _loggerService = loggerService;
    }

    public IActionResult CreateOrder(Order order)
    {
        _notificationService.Send("Order created successfully.");
        _loggerService.Log("Order creation logged.");
        return Ok();
    }
}
```

## Registering in DI Container
```csharp
services.AddScoped<INotificationService, EmailNotificationService>();
services.AddScoped<ILoggerService, LoggerService>();
```

---

- **Constructor Injection** means we add dependencies to a class through its constructor.  
- **Interfaces** define what a service should do.  
- **Classes** implement the interfaces to provide real functionality.  
- **DI Container** (Dependency Injection Container) helps manage dependencies automatically.  
- Using `services.AddScoped<>`, we tell ASP .NET Core to create and manage these objects.  
- **Scoped** means a new object is created for each HTTP request.  
