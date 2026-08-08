namespace DotNetBasics.DesignPatterns.Creational;

public sealed class NotificationFactory : INotificationFactory
{
    public INotification Create(string notificationType)
    {
        return notificationType?.ToLowerInvariant() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            _ => throw new ArgumentException("Unknown notification type. Use 'email' or 'sms'.", nameof(notificationType))
        };
    }

    public string Send(string notificationType, INotificationPayload payload)
    {
        var notification = Create(notificationType);
        return notification.Send(payload);
    }
}
