namespace WelcomeBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/hello/{name:alpha}", (string name) => $"Hello {name}!");

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from 1nd delegate. ");
                await next.Invoke();
                await context.Response.WriteAsync(" Hello from 1nd delegate. after");
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync(" Hello from 2nd delegate.");
            });

            app.Run();
        }
    }
}
