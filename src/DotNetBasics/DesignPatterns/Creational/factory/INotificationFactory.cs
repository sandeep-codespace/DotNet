namespace DotNetBasics.DesignPatterns.Creational;

public interface INotificationFactory
{
    INotification Create(string notificationType);
    string Send(string notificationType, INotificationPayload payload);
}
