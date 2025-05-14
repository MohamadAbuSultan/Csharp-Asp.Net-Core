using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEmailSender();
builder.Services.AddScoped<IMessageSender, EmailMessageSender>();
// سجل نسخة SMS فقط إذا ما تم تسجيل IMessageSender من قبل
builder.Services.TryAddScoped<IMessageSender, SmsSender>();
builder.Services.TryAddScoped<IMessageSender, FacebookSender>();


var app = builder.Build();

// app.MapGet("/register/{username}", RegisterEmail);
app.MapGet("/register/{username}", RegisterUser);

app.Run();

string RegisterEmail(string userName, IEmailSender emailSender)
{
    emailSender.SendEmail(userName);
    return $"Email Send to {userName}!";
}

string RegisterUser(string username, IEnumerable<IMessageSender> senders)
{
    foreach (var sender in senders)
    {
        sender.SendMessage($"Hello {username}!");
    }
    return $"Welcome message sent to {username}";
}

public record EmailServerSettings(string Host, int Port);

internal interface IMessageSender
{
    void SendMessage(string recipient);
}

internal class EmailMessageSender : IMessageSender
{
    public void SendMessage(string recipient)
    {
        Console.WriteLine($"Email sent to {recipient}");
    }
}

internal class SmsSender : IMessageSender
{
    public void SendMessage(string recipient)
    {
        Console.WriteLine($"Sms sent to {recipient}");
    }
}

internal class FacebookSender : IMessageSender
{
    public void SendMessage(string recipient)
    {
        Console.WriteLine($"Facebook sent to {recipient}");
    }
}