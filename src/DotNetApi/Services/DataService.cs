using DotNetBasics.DesignPatterns.Creational;

namespace DotNetApi.Services;

public class DataService : IDataService
{
    private readonly INotificationFactory _notificationFactory;

    public DataService(INotificationFactory notificationFactory)
    {
        _notificationFactory = notificationFactory;
    }

    public IEnumerable<string> GetItems()
    {
        return new[]
        {
            "Item 1",
            "Item 2",
            "Item 3"
        };
    }

    public string SendEmail(EmailPayload payload)
    {
        return _notificationFactory.Send("email", payload);
    }

    public string SendSms(SmsPayload payload)
    {
        return _notificationFactory.Send("sms", payload);
    }
}
