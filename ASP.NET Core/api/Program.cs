using api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();

// لماذا نحتاج APIs؟ لأن:
// هي طريقة آمنة للتفاعل مع قواعد البيانات.
// تمنع الوصول العشوائي إلى البيانات الحساسة.
// كل شركة تحتاج APIs وتدفع مبالغ طائلة لتطويرها.

// في هذا السياق، الـAPI هو:
// كود فوق قاعدة البيانات يسمح لنا بالتفاعل معها بطريقة منظمة وآمنة.


// لماذا تحتاج الشركات إلى قواعد بيانات Databases؟
// لأنها:
// تعمل كخزانة ملفات “Filing Cabinet” لتخزين البيانات.
// تخزن البيانات بسرعات عالية وبطرق مترابطة.
// تربط البيانات ببعضها من خلال مفاتيح أولية 
// Primary Keys ومفاتيح أجنبية Foreign Keys.

// في هذا التشبيه:
// الـDatabase = خزانة الملفات.
// الـModels = الأدراج أو النماذج داخل الخزانة.
// كل نموذج يحتوي على أوراق = بيانات مخزنة.

