using Dependency_Injection_DI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// هنا بنسجل خدمة الـ WeatherForecast في الـ Container تبع الـ DI
// بنحكي للدوت نت: إذا حدا طلب IWeatherForecastServices، ابعتله نسخة من WeatherForecastServices
// AddScoped معناها: نسخة وحدة من الخدمة بتنعمل لكل Request جديد
builder.Services.AddScoped<IWeatherForecastServices, WeatherForecastServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// بنشغل التطبيق
app.Run();
