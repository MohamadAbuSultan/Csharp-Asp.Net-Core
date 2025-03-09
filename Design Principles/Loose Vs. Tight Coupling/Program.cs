// See https://aka.ms/new-console-template for more information

// GOOD SOFTWARE
// FUNCTIONAL
// ROBUST
// MAINTAINABLE
// REUSABLE
// EXTENSIBLE
// TESTABLE

// Imagine two systems: one is rigidly connected, where every change creates a ripple of complications, and the other operates with flexibility, smoothly adapting to adjustments without disrupting the flow. Which do you think would work better in a dynamic environment?

// LOOSE COUPLING
// A LOOSELY COUPLED COMPONENTS ARE WEAKLY ASSOCIATED WITH
// AND SO, CHANGES IN ONE COMPONENT LEAST AFFECT EXISTENCE OR
// PERFORMANCE OF ANOTHER COMPONENT

// TIGHT COUPLING
// TIGHTLY COUPLED COMPONENTS ARE HIGHLY DEPENDENT ON EACH OTHER, 
// A CHANGE IN ONE COMPONENT USUALLY FORCES A RIPPLE EFFECT OF 
// CHANGES IN OTHER COMPONENT

enum NotificationType
{
    Email,
    SMS
}

class NotificationFactory
{
    public static INotificationService Create(NotificationType type)
    {
        switch (type)
        {
            case NotificationType.Email:
                return new EmailService();
            case NotificationType.SMS:
                return new SmsService();
            default:
                throw new Exception("Invalid Notification Type");
        }
    }
}
public interface INotificationService
{
    void SendNotification(string recipient, string message);
}

public class EmailService : INotificationService
{
    public void SendNotification(string recipient, string subject)
    {
        // Code to send email
        Console.WriteLine($"Email sent to {recipient} with subject: {subject}");
    }
}

public class SmsService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        // Code to send SMS
        Console.WriteLine($"SMS sent to {recipient} with message: {message}");
    }
}

public class NotificationService
{
    private readonly INotificationService _notificationService;

    public NotificationService(INotificationService notificationService)
    {
        this._notificationService = notificationService;
    }

    public void SendNotification(string recipient, string message)
    {
        _notificationService.SendNotification(recipient, message);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        EmailService emailService = new EmailService();
        SmsService smsService = new SmsService();
        // NotificationService notificationService = new NotificationService(emailService);

        string recipient = "test@test.com";
        string message = "This is a test notification.";

        // notificationService.SendNotification(recipient, message);
        // notificationService = new NotificationService(smsService);
        // notificationService.SendNotification(recipient, message);

        var service = NotificationFactory.Create(NotificationType.SMS);
        NotificationService notificationService = new NotificationService(service);
        notificationService.SendNotification(recipient, message);
    }
}