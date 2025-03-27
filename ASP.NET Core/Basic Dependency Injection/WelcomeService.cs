using MyWebApp.Interfaces;

namespace MyWebApp.Services;

public class WelcomeService : IWelcomeService
{

    DateTime _serviceCreated;
    Guid _serviceId;

    public WelcomeService()
    {
        _serviceCreated = DateTime.Now;
        _serviceId = Guid.NewGuid();
    }

    public string GetWelcomeMessage()
    {
        return $"Welcome to Egypt! The current time is {_serviceCreated}. This service instance has an ID of {_serviceId}";
    }
}