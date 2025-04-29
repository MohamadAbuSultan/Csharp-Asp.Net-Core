namespace Dependency_Injection_DI.Services
{
    //* Logger تم حقنه من خلال الـ Constructor عن طريق DI (مش معمول له new).
    //* Logger من النوع ILogger<IWeatherForecastServices>، عشان الدوت نت يعرف يخزن اللوج بدقة.
    //* هاي الخدمة تم تسجيلها في Program.cs باستخدام AddScoped.
    //* GetForecasts() بتستخدم الـ Logger المحقون عشان تسجل حدث داخل اللوج.
    //* استخدام الانترفيس IWeatherForecastServices بيساعدنا نبدل الـ Implementation بسهولة لاحقًا.
    public class WeatherForecastServices : IWeatherForecastServices
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //* هنا عرفنا Logger كـ Dependency
        //* إحنا مش رح ننشئ Logger يدوي، رح نطلبه من DI Container
        private readonly ILogger<IWeatherForecastServices> _logger;

        //* Constructor Injection: بنطلب ILogger من خلال الكونستركتر
        //* الدوت نت بروح يحقن Logger تلقائياً لما ينشئ الكلاس
        public WeatherForecastServices(ILogger<IWeatherForecastServices> logger)
        {
            _logger = logger;
        }

        public IEnumerable<WeatherForecast> GetForecasts()
        {
            // استخدمنا Logger اللي Injected من DI
            _logger.LogInformation("Getting weather forecast data.");

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
