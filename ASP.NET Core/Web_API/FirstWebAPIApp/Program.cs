/* 
var: كلمة مفتاحية في C# تستخدم لتعريف متغير بدون تحديد نوعه بشكل صريح، حيث يقوم المترجم بتحديد النوع بناءً على القيمة المعطاة.
*/
var builder = WebApplication.CreateBuilder(args);
/* 
builder: اسم المتغير الذي سيتم تخزين كائن WebApplicationBuilder فيه.
WebApplication.CreateBuilder(args): استدعاء دالة CreateBuilder من فئة WebApplication لإنشاء كائن WebApplicationBuilder.
هذه الدالة تأخذ معلمة args وهي مصفوفة من السلاسل النصية تحتوي على المعاملات التي تم تمريرها إلى التطبيق عند تشغيله.
*/

/* 
var: نفس التفسير السابق.
*/
var app = builder.Build();
/* 
app: اسم المتغير الذي سيتم تخزين كائن WebApplication فيه.
builder.Build(): استدعاء دالة Build من كائن builder لإنشاء كائن WebApplication الذي يمثل التطبيق.
*/

/* 
app: المتغير الذي يحتوي على كائن WebApplication.
MapGet("/"): دالة من كائن app تستخدم لتحديد مسار HTTP GET. في هذه الحالة، المسار هو الجذر /.
() => "Root Path": تعبير لامبدا يمثل دالة مجهولة تعيد النص "Root Path". هذه الدالة سيتم استدعاؤها عندما يتم الوصول إلى المسار /.
*/
app.MapGet("/", () => "Root Path");
/* 
app.MapGet("/downloads", () => "Downloads"): تعيين مسار HTTP GET للمسار "/downloads" بحيث يعيد النص "Downloads" عند الوصول إليه.
*/
app.MapGet("/downloads", () => "Downloads");
/* 
app.MapPut("/", () => "This is a Put request"): تعيين مسار HTTP PUT للجذر "/" بحيث يعيد النص "This is a Put request" عند الوصول إليه.
*/
app.MapPut("/", () => "This is a Put request");
/* 
app.MapPost("/", () => "This is a Post request"): تعيين مسار HTTP POST للجذر "/" بحيث يعيد النص "This is a Post request" عند الوصول إليه.
*/
app.MapPost("/", () => "This is a Post request");
/* 
app.MapDelete("/", () => "This is a Delete request"): تعيين مسار HTTP DELETE للجذر "/" بحيث يعيد النص "This is a Delete request" عند الوصول إليه.
*/
app.MapDelete("/", () => "This is a Delete request");

/* 
app: نفس المتغير السابق.
Run(): دالة من كائن app تقوم بتشغيل التطبيق والاستماع للطلبات الواردة.
*/
app.Run();

/* 
هذا الكود يقوم بإنشاء تطبيق ويب بسيط باستخدام ASP.NET Core. عند تشغيل التطبيق، سيستمع للطلبات الواردة على المسار الجذر / ويعيد النص "Root Path" كاستجابة.
*/
