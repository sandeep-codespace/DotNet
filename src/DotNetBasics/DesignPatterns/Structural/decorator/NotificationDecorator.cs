namespace DotNetBasics.DesignPatterns.Structural.Decorator;

public abstract class NotificationDecorator:INotifier
{
    private readonly INotifier _wrapee;
    public NotificationDecorator(INotifier wrapee)
    {
        _wrapee = wrapee;
    }

    public virtual void Send(string message)
    {
        _wrapee.Send(message);
    }
}