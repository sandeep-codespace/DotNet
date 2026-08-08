namespace DotNetBasics.DesignPatterns.Creational;

public sealed class EmailPayload : INotificationPayload
{
    public string To { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}
