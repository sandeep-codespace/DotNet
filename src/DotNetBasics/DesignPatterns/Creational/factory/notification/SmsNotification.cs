namespace DotNetBasics.DesignPatterns.Creational;

public sealed class SmsNotification : INotification
{
    public string Send(INotificationPayload payload)
    {
        if (payload is not SmsPayload smsPayload)
        {
            throw new ArgumentException("Payload must be SmsPayload", nameof(payload));
        }

        return $"Sending SMS to {smsPayload.PhoneNumber}: '{smsPayload.Message}'";
    }
}
