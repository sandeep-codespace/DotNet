using DotNetBasics.DesignPatterns.Creational;

namespace DotNetApi.Services;

public interface IDataService
{
    IEnumerable<string> GetItems();
    string SendEmail(EmailPayload payload);
    string SendSms(SmsPayload payload);
}
