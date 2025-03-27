using MyApp.Services;
using MyWebApp.Interfaces;
using MyWebApp.Services;

// Service Lifetimes: Managing Service Creation in ASP.NET Core

// Concept:Service lifetimes determine how services are instantiated and managed within an ASP.NET Core application.

// Singleton:
//     Created once when the application starts.
//     Reused throughout the entire application's lifetime.
//     Examples:
//         A configuration service that reads settings from a file.
//         A logging service that writes to a shared resource.

// Scoped:
//     Created once per request.
//     Disposed of when the request completes.
//     Examples:
//         A data context that interacts with a database during a web request.
//         A service that manages user-specific data within a single request.

// Transient:
//     Created every time it's requested.
//     Suitable for lightweight, stateless operations.
//     Examples:
//         A service that generates unique identifiers.
//         A service that sends email notifications.

// Service Dependencies:
//     Services can depend on other services through constructor injection.
//     It's crucial to be mindful of service lifetimes to avoid issues (e.g., a singleton depending on a scoped service).
//     ASP.NET Core includes scope validation to detect such misconfigurations.

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddSingleton<IPersonService, PersonService>();
// builder.Services.AddSingleton<IWelcomeService, WelcomeService>();
// builder.Services.AddScoped<IWelcomeService, WelcomeService>();
builder.Services.AddTransient<IWelcomeService, WelcomeService>();

var app = builder.Build();

// app.MapGet("/", (IPersonService personService) =>
// {
//     return $"Hello, {personService.GetPersonName()}!";
// });

// app.MapGet("/", (IWelcomeService welcomeService) =>
//             welcomeService.GetWelcomeMessage());

app.MapGet("/", async (IWelcomeService welcomeService1, IWelcomeService welcomeService2) =>
    {
        string message1 = $"Message1: {welcomeService1.GetWelcomeMessage()}";
        string message2 = $"Message2: {welcomeService2.GetWelcomeMessage()}";
        return $"{message1}\n{message2}";
    });

app.Run();

