var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.UseWelcomePage();

app.UseStaticFiles();

app.Run();
