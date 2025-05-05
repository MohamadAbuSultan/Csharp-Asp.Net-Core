//  الميدل وير هو زي "حارس الأمن" تبع السيستم
// يعني قبل ما الريكوست يوصل للـ API لازم يمر من خلالهم
// كل واحد فيهم بعمل شغلة معينة: يتحقق من الهوية، 
// يسجل وقت التنفيذ، يشيّك على الصلاحيات... إلخ

// الميدل ويرز بتشتغل كـ Pipeline
// أول واحد يستقبل الريكوست، وبعدين يسلمه
// للي بعده، وبعدين اللي بعده
// وآخر واحد منهم بيوصل الريكوست للـ Endpoint الحقيقي
// وبعدين الـ Response برجع بنفس الطريقة، بس بالعكس 

using System.Diagnostics;

// مثال بسيط على custom ميدل وير اسمه ProfilingMiddleware
public class ProfilingMiddleware
{
    // هذا الحقل بنستخدمه علشان ننادي الميدل وير التالي
    private readonly RequestDelegate _next;
    private readonly ILogger<ProfilingMiddleware> _logger;
    // ضفت حقل جديد اسمه _logger علشان أستخدمه للتسجيل بدل ما أطبع مباشرة بالـ Console

    public ProfilingMiddleware(RequestDelegate next, ILogger<ProfilingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    // الميثود الرئيسية اللي ASP.NET بتناديها
    public async Task InvokeAsync(HttpContext context)
    {
        // بنستخدم Stopwatch علشان نقيس كم أخذ الريكوست وقت وهو بيتنفذ
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        // بنسلم الريكوست للميدل وير التالي ونستناه يخلص
        await _next(context);

        stopwatch.Stop();

        var executionTime = stopwatch.ElapsedMilliseconds;
        _logger.LogInformation($"Request to {context.Request.Path} took {executionTime} ms");
        // استخدمت _logger بدل Console.WriteLine لأنه بيعطيني تحكم أكبر في عملية التسجيل
    }
}

/*
الميدل وير: هو كود بوقف بين الريكوست وبين الـ API.
زي "حارس الأمن"، بقدر يعدّل أو يمنع الريكوست أو يضيف عليه أشياء.

الترتيب مهم: الريكوست بيمشي من أول
ميدل وير لآخر واحد، وبيرجع العكس بنفس الترتيب.

بتقدر تعمل Custom ميدل وير: بكلاس عادي فيه 
InvokeAsync، وتستعمل RequestDelegate علشان تمرّر الريكوست التالي.

لا تنسى تسجله: باستخدام app.UseMiddleware<>() جواا Program.cs.
*/
