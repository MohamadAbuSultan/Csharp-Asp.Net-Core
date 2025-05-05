var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

app.UseMiddleware<RateLimitingMiddleware>();

// 📌 لازم تسجّل الميدل وير بالترتيب الصح حسب الحاجة
// هذا الميدل وير آمن ينضاف في أي مكان لأنه بس بقيس وقت التنفيذ
app.UseMiddleware<ProfilingMiddleware>();

app.MapControllers();
app.Run();
