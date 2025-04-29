public static class EmailSenderServiceCollectionExtensions
{
    public static IServiceCollection AddEmailSender(this IServiceCollection services)
    {
        services.AddScoped<IEmailSender, EmailSender>();
        services.AddSingleton<MessageFactory>();
        services.AddScoped<NetworkClient>();
        services.AddScoped(provider =>
            new EmailServerSettings(
                Host: "smtp.server.com",
                Port: 25
            ));
        return services;
    }
}