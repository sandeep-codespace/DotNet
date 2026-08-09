namespace DotNetBasics.DesignPatterns.Structural.Decorator;

public static class DecocartorUsageExample
{
    public static void Run()
    {
        INotifier notifier = new EmailNotifier();
        notifier = new SmsNotifierDecorator(notifier);
        notifier = new WhatsAppNotifierDecorator(notifier);

        notifier.Send("Your order has been shipped.");
    }
}
