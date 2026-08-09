namespace   DotNetBasics.DesignPatterns.Structural.Bridge;
public abstract class Notification
{
    protected INotification _sender;
    protected Notification(INotification sender) => _sender = sender;
    public abstract void Notify(string message);
}

public class AlertNotification : Notification
{
    public AlertNotification(INotification sender) : base(sender) { }
    public override void Notify(string message)
    {
        Console.WriteLine("ALERT:");
        _sender.Send(message);
    }
}

public class ReminderNotification : Notification
{
    public ReminderNotification(INotification sender) : base(sender) { }
    public override void Notify(string message)
    {
        Console.WriteLine("REMINDER:");
        _sender.Send(message);
    }
}