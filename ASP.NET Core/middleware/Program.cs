using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Purpose: Web application receives and responds to HTTP requests.
// Middleware: Components in ASP.NET Core that form a pipeline for processing HTTP requests.
// Implementation: Middleware is implemented as a delegate that takes a HttpContext object and returns a Task.
// HttpContext: Represents the current request and response.
// Chaining: Middleware components run in the order they are added to the pipeline.
// Terminal Middleware: Last middleware in the pipeline, doesn't call the next middleware (added with app.Run()).
// Nonterminal Middleware: Processes the request and calls the next middleware in the pipeline (added with app.Use()).
// app.Use(): Can add terminal or nonterminal middleware, expects HttpContext and RequestDelegate objects.
// app.Run(): Always adds terminal middleware, expects only HttpContext object.
// Built-in Middleware: ASP.NET Core provides built-in middleware for common functionality.
// Middleware Order: The order middleware is added to the pipeline is critical.
// Use vs Map: Use methods map middleware, Map methods map endpoints.

app.Use(async (context, next) =>
{
    await next();
    Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode}");
});

app.UseRewriter(new RewriteOptions().AddRedirect("history", "about"));

app.MapGet("/", () => "Welcome to Contoso!");
app.MapGet("/about", () => "Contoso was founded in 2000.");

// app.Use(async (context, next) =>
// {
//     await context.Response.WriteAsync("Hello from middleware 1. Passing to the next middleware!\r\n");

    // Call the next middleware in the pipeline
//     await next.Invoke();

//     await context.Response.WriteAsync("Hello from middleware 1 again!\r\n");
// });

// app.Run(async context =>
// {
//     await context.Response.WriteAsync("Hello from middleware 2!\r\n");
// });

app.Run();
