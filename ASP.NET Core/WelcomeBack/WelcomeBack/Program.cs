namespace WelcomeBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<MyService>();

            var app = builder.Build();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from 1nd delegate. ");
            //    await next.Invoke();
            //    await context.Response.WriteAsync(" Hello from 1nd delegate. after");
            //});

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/hello/{name:alpha}", (string name) => $"Hello {name}!");
            app.MapGet("/time", (MyService s) => s.GetTime());

            app.Run("http://localhost:3000");

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync(" Hello from 2nd delegate.");
            //});
        }

        public class MyService
        {
            public string GetTime() => DateTime.Now.ToString();
        }
    }
}
