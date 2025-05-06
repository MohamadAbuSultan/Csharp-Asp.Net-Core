using System.Text.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

// هذا الفلتر بنسميه LogActivityFilter
// فكرته ببساطة إنه يراقب كل الأكشنز قبل وبعد ما تتنفذ
// وبسجل معلومات عنهم في اللوج – زي اسم الكنترولر، اسم الأكشن، والباراميترات

public class LogActivityFilter : IActionFilter
{
    private readonly ILogger<LogActivityFilter> _logger;


    // هنا بنستخدم الـ Dependency Injection عشان نجيب الـ ILogger
    // هي الأداة اللي بنسجل فيها الأحداث
    public LogActivityFilter(ILogger<LogActivityFilter> logger)
    {
        _logger = logger;
    }

    // هذا الميثود بينفذ قبل ما الأكشن تشتغل
    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Logic before the action executes
        // Console.WriteLine("Action is executing.");

        // مثال لو بدك تمنع تنفيذ الأكشن وترجع نتيجة معينة
        // context.Result = new NotFoundResult(); // Example of modifying the result

        _logger.LogInformation($"Action is executing. {context.ActionDescriptor.DisplayName} on Controller {context.Controller} with Arguments {JsonSerializer.Serialize(context.ActionArguments)}");
    }


    // هذا الميثود بينفذ بعد ما الأكشن تخلص
    public void OnActionExecuted(ActionExecutedContext context)
    {
        // Logic after the action executes
        // Console.WriteLine("Action has executed.");
        _logger.LogInformation($"Action has executed. {context.ActionDescriptor.DisplayName} on Controller {context.Controller}");
        // context.Result = new NotFoundResult(); 
    }
}