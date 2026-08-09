namespace DotNetBasics.DesignPatterns.Structural.Decorator;

public class SmsNotifierDecorator : NotificationDecorator
{
    public SmsNotifierDecorator(INotifier notifier) : base(notifier)
    {
    }

    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS notification: {message}");
    }
}