using Dependency_Injection_DI.Services;
using Microsoft.AspNetCore.Mvc;

//* الـ Logger تم حقنه عن طريق الـ Constructor بشكل تلقائي.
//* الـ Service (IWeatherForecastServices) برضو Injected من الـ DI container.
//* ASP.NET Core بيتكفّل بإنشاء الكنترولر والـ Dependencies لوحده وقت الطلب.
//* احنا ما عملنا new لأي Object داخل الكنترولر، كل شيء جاينا جاهز عن طريق الـ DI.
//* الكنترولر ما بيعرفش كيف تم إنشاء الخدمة، بس بيطلبها وبيستخدمها، وهاي هي قوة الـ DI.

namespace Dependency_Injection_DI.Controllers;

[ApiController]
// هنا عرفنا مسار الوصول للكنترولر، تلقائياً بيكون /WeatherForecast
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // Logger خاص بالكنترولر، رح يتم Inject تلقائي
    private readonly ILogger<WeatherForecastController> _logger;

    // Inject لواجهة الخدمة بدل الكلاس المباشر
    private readonly IWeatherForecastServices _service;

    // Constructor Injection: هنا بنطلب الـ Logger والخدمة من ASP.NET Core
    // الدوت نت بروح يحقنهم لما يستقبل ريكوست وبدّه ينشئ الكنترولر
    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastServices service)
    {
        _logger = logger;
        _service = service;
    }

    // Endpoint بترجع بيانات الطقس
    // بنستعمل الخدمة اللي Injected عن طريق الكونستركتر
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _service.GetForecasts();
    }
}
