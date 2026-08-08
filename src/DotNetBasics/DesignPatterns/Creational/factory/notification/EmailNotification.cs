namespace DotNetBasics.DesignPatterns.Creational;

public sealed class EmailNotification : INotification
{
    public string Send(INotificationPayload payload)
    {
        if (payload is not EmailPayload emailPayload)
        {
            throw new ArgumentException("Payload must be EmailPayload", nameof(payload));
        }

        return $"Sending email to {emailPayload.To} with subject '{emailPayload.Subject}' and body '{emailPayload.Body}'";
    }
}
