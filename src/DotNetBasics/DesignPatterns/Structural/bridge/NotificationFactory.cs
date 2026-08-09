namespace   DotNetBasics.DesignPatterns.Structural.Bridge;

public static class NotificationFactory
{
    
public static Notification Create(string notificationType, string channel)
    {
    var normalizedType = notificationType?.Trim().ToLowerInvariant();
    INotification sender = normalizedType switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            _ => throw new ArgumentException("Unknown notification type. Use 'email' or 'sms'.", nameof(notificationType))
        };

    var normalizedChannel = channel?.Trim();
    return normalizedChannel switch
        {
            "Alert" => new AlertNotification(sender),
            "Reminder" => new ReminderNotification(sender),
            _ => throw new ArgumentException("Unknown channel type. Use 'Alert' or 'Reminder'.", nameof(channel))
        };
    }

}

