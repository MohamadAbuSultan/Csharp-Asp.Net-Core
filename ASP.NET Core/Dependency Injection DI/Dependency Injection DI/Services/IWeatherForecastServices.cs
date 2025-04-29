using Dependency_Injection_DI.Services;

public interface IWeatherForecastServices
{
    IEnumerable<WeatherForecast> GetForecasts();
}