namespace Abstraction
{
    internal class Notifier : INotifier
    {
        public Notifier(string smtpServer, int port, string senderAddress, string senderPassword)
        {
            SmtpServer = smtpServer;
            Port = port;
            SenderAddress = senderAddress;
            SenderPassword = senderPassword;
        }

        public string SmtpServer { get; private set; }
        public int Port { get; private set; }
        public string SenderAddress { get; private set; }
        public string SenderPassword { get; private set; }
        public void Notify(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You've a new email from'{SenderAddress}' with subject '{subject}'");
            Console.WriteLine(body);
            Console.WriteLine($"Message sent successfuly to '{email}'");
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White; ;
        }
    }
}
