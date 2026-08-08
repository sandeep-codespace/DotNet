namespace DotNetBasics.DesignPatterns.Creational;

public sealed class SmsPayload : INotificationPayload
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
