var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(o =>
{

});
var app = builder.Build();

// app.UseRouting
// app.UseRouting
// app.UseAthentication()
// app.UseAuthorization()
// app.UseExceptionHandler()

app.Use(async (context, next) =>
{
    Console.WriteLine("Logic before");
    await next.Invoke();
    Console.WriteLine("Logic after");
});

app.UseHttpLogging();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hello", () => "This is the hello route");

// app.UseEndpoints

app.Run();
