using DotNetBasics.DesignPatterns.Creational;

namespace DotNetApi.Services;

public interface IDataService
{
    IEnumerable<string> GetItems();
    string SendEmail(EmailPayload payload);
    string SendSms(SmsPayload payload);
    string ProcessPayment(string paymentType, decimal amount);
    string DeployToCloud(string providerName, string applicationName);
    string ProcessPaymentWithAbstractFactory(string factoryType, decimal amount);
    string DeployToCloudWithAbstractFactory(string providerName, string applicationName);
}
