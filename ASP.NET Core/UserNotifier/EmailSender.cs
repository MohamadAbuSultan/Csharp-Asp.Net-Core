public interface IEmailSender
{
    void SendEmail(string userName);
}

public class EmailSender : IEmailSender
{
    private readonly NetworkClient _networkClient;
    private readonly MessageFactory _messageFactory;
    public EmailSender(NetworkClient networkClient, MessageFactory messageFactory)
    {
        _networkClient = networkClient;
        _messageFactory = messageFactory;
    }
    public void SendEmail(string userName)
    {
        Console.WriteLine($"Email sent to {userName}");
    }
}

public class MessageFactory
{
}

public class NetworkClient
{
}