using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;


// هنا عندنا فلتر تاني، اسمه LogSensitiveActionAttribute
// هذا معمول كـ Attribute يعني بتحطه مباشرة فوق الأكشن أو الكنترولر اللي بدك تراقبه
public class LogSensitiveActionAttribute : ActionFilterAttribute
{
    override public void OnActionExecuted(ActionExecutedContext context)
    {
        Debug.WriteLine($"Sensitive action executed!!");
    }
}