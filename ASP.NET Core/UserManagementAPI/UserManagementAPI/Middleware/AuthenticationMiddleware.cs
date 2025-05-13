using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class AuthenticationMiddleware
{
    private readonly RequestDelegate _next;

    public AuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("AuthenticationMiddleware triggered");

        var token = context.Request.Headers["Authorization"].ToString();

        if (string.IsNullOrEmpty(token) || token != "ValidToken123")  // Replace with real validation
        {
            Console.WriteLine("Unauthorized access attempt!");
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Unauthorized request.");
            return;
        }

        Console.WriteLine("Authentication successful");
        await _next(context);
    }
}
