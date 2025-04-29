var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEmailSender();

var app = builder.Build();

app.MapGet("/register/{username}", RegisterEmail);

app.Run();

string RegisterEmail(string userName, IEmailSender emailSender)
{
    emailSender.SendEmail(userName);
    return $"Email Send to {userName}!";
}

public record EmailServerSettings(string Host, int Port);