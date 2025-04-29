
using Basic_CRUD_Operations.Data;
using Microsoft.EntityFrameworkCore;

namespace Basic_CRUD_Operations
{
    //* اول اشي.. لازم تعرف شو يعني CRUD ؟
    //* - C: Create ➔ يعني إنشاء بيانات جديدة
    //* - R: Read ➔ يعني قراءة بيانات موجودة
    //* - U: Update ➔ يعني تعديل بيانات
    //* - D: Delete ➔ يعني حذف بيانات
    //* CRUD operations هي العمليات الأساسية اللي بتتعامل مع البيانات في أي تطبيق أو نظام.
    /* Note: This project focuses exclusively on back-end Web API development,
       requiring strong knowledge of Entity Framework Core and LINQ,
       while excluding MVC and front-end topics.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(builder => builder.UseSqlServer("server=.;database=Products;integrated security=true;trust server certificate=true"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

// يلا نبدأ خطوة خطوة 

//-----------------------
//* أول حاجة: الـ Project Setup
//-----------------------

// عملنا بروجكت ASP.NET Core جديد
// وأضفنا فيه الـ Packages المطلوبة:
// - Microsoft.EntityFrameworkCore
// - Microsoft.EntityFrameworkCore.SqlServer

// هدول علشان نقدر نتعامل مع SQL Server بشكل مريح 🛠

//-----------------------
//* ثاني حاجة: إعداد الـ DbContext
//-----------------------

/*
 * أنشأنا كلاس اسمه ApplicationDbContext
 * هذا الكلاس بيمثل الاتصال مع قاعدة البيانات
 * وميرث من DbContext الموجود في EF Core
 */


//-----------------------
//* ثالث حاجة: الكيان (Entity) نفسه
//-----------------------

/*
 * أنشأنا كلاس بسيط اسمه Product
 * يمثل منتج داخل التيبل "Products"
 */

//-----------------------
//* رابع حاجة: الربط مع قواعد البيانات
//-----------------------

/*
 * في ملف Program.cs
 * ضفنا DbContext عن طريق Service Container
 * وربطناه بـ Connection String لقاعدة البيانات
 */

// builder.Services.AddDbContext<ApplicationDbContext>(builder =>
//     builder.UseSqlServer("server=.;database=Products;integrated security=true;trust server certificate=true"));

//-----------------------
//* خامس حاجة: نبدأ بالكنترولر
//-----------------------

/*
 * عملنا كنترولر اسمه ProductsController
 * مربوط بالـ Route [controller]
 * يعني أي Request على /products بيروح على هذا الكنترولر
 */


//-----------------------
// هيك خلصنا ال CRUD Operations 🙌
//-----------------------

// شرح مبسط للعمليات:
// - Create ➔ POST ➔ إضافة سجل
// - Read ➔ GET ➔ قراءة سجل أو عدة سجلات
// - Update ➔ PUT ➔ تعديل سجل موجود
// - Delete ➔ DELETE ➔ حذف سجل من القاعدة

// كل عملية مربوطة بمثود واضحة في الكنترولر 🔥

// نصيحة: 
// - قبل لا تبدأ تتعمق أكثر، تأكد أنك فاهم Entity Framework كويس
// - وكمان شوف شرح LINQ لأنه هتحتاجهم كتير وانت بتتعامل مع البيانات