var builder = WebApplication.CreateBuilder(args);


// هنا بنضيف الكنترولرز، ومعاهم بنسجل الفلتر بشكل جلوبال
// يعني هذا الفلتر هيتنفذ على كل الأكشنز في كل الكنترولرز

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<LogActivityFilter>();
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

// الأكشن فلتر هو زي بوّاب واقف قبل الأكشن وبعدها، بتقدر تحط فيه شروط أو تسجل لوج.

// بتقدر تعمل منه جلوبال (على كل الكنترولرز)، أو سكوب (على كنترولر/أكشن معين).

//  جلوبال Filter:
// يعني الفلتر يتنفذ على كل الأكشنز في كل الكنترولرز، بدون ما تحط عليه أي Attribute.
//* هذا الكود في Program.cs
// builder.Services.AddControllersWithViews(options =>
// {
//     options.Filters.Add<LogActivityFilter>(); //* هيك بصير جلوبال
// });
//* يعني أي أكشن في أي كنترولر... هيتنفذ عليه هذا الفلتر.

//* سكوب (محلي):
//* يعني الفلتر بيتنفذ فقط على كنترولر أو أكشن معين، وبتستخدمه كـ Attribute:
// [LogSensitiveAction] // هنا فقط هذا الأكشن بيتأثر بالفلتر
// public IActionResult GetById(int id){}
//* أو تحطه على مستوى الكنترولر كامل:
// [LogSensitiveAction] // كل الأكشنز داخل الكنترولر هذا بس
// public class UsersController : Controller{}


// بيفيدك لما بدك تراقب أو تمنع الأكشن، أو تسجل معلومات حساسة.

// الفرق بينه وبين الميدل وير إنه بيعرف الأكشن اللي رايحلها الريكوست، بينما الميدل وير ما بعرف.