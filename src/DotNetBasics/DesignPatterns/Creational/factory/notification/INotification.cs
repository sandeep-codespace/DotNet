namespace DotNetBasics.DesignPatterns.Creational;

public interface INotification
{
    string Send(INotificationPayload payload);
}
