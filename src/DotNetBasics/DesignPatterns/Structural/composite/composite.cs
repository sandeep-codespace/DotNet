namespace DotNetBasics.DesignPatterns.Structural.Composite;

public interface INotifier
{
    void Send(string message);
}

public class EmailNotifier : INotifier
{
    public void Send(string message) => Console.WriteLine($"[Email] {message}");
}

public class SmsNotifier : INotifier
{
    public void Send(string message) => Console.WriteLine($"[SMS] {message}");
}

public class WhatsAppNotifier : INotifier
{
    public void Send(string message) => Console.WriteLine($"[WhatsApp] {message}");
}


public class NotificationGroup : INotifier
{
    private readonly List<INotifier> _children = new();

    public void Add(INotifier notifier) => _children.Add(notifier);

    public void Send(string message)
    {
        Console.WriteLine("Sending group notification...");
        foreach (var child in _children)
        {
            child.Send(message);
        }
    }
}

class Program
{
    static void Main()
    {
        // Individual notifiers
        var email = new EmailNotifier();
        var sms = new SmsNotifier();
        var whatsapp = new WhatsAppNotifier();

        // Composite group for payment success
        var paymentSuccessGroup = new NotificationGroup();
        paymentSuccessGroup.Add(email);
        paymentSuccessGroup.Add(sms);

        // Composite group for critical alerts
        var criticalAlertGroup = new NotificationGroup();
        criticalAlertGroup.Add(paymentSuccessGroup); // nested group
        criticalAlertGroup.Add(whatsapp);

        // Client treats both single and group uniformly
        Console.WriteLine("=== Payment Success ===");
        paymentSuccessGroup.Send("Payment of ₹5000 successful!");

        Console.WriteLine("\n=== Critical Alert ===");
        criticalAlertGroup.Send("System outage detected!");
    }
}