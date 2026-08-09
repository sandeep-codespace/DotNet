namespace DotNetBasics.DesignPatterns.Structural.Decorator;

public class WhatsAppNotifierDecorator : NotificationDecorator
{
    public WhatsAppNotifierDecorator(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"WhatsApp message: {message}");
    }
}