using DotNetBasics.DesignPatterns.Creational;
using DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;
using DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;
using DotNetBasics.DesignPatterns.Creational.Factory.Cloud;
using DotNetBasics.DesignPatterns.Creational.Factory.Payment;

namespace DotNetApi.Services;

public class DataService : IDataService
{
    private readonly INotificationFactory _notificationFactory;
    private readonly IPaymentProcessorFactory _paymentProcessorFactory;
    private readonly ICloudProviderFactory _cloudProviderFactory;

    public DataService(
        INotificationFactory notificationFactory,
        IPaymentProcessorFactory paymentProcessorFactory,
        ICloudProviderFactory cloudProviderFactory)
    {
        _notificationFactory = notificationFactory;
        _paymentProcessorFactory = paymentProcessorFactory;
        _cloudProviderFactory = cloudProviderFactory;
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

    public string ProcessPayment(string paymentType, decimal amount)
    {
        return _paymentProcessorFactory.Process(paymentType, amount);
    }

    public string DeployToCloud(string providerName, string applicationName)
    {
        return _cloudProviderFactory.Deploy(providerName, applicationName);
    }

    public string ProcessPaymentWithAbstractFactory(string factoryType, decimal amount)
    {
        IPaymentAbstractFactory factory = factoryType?.ToLowerInvariant() switch
        {
            "creditcard" or "credit-card" => new CreditCardPaymentFactory(),
            "paypal" => new PayPalPaymentFactory(),
            _ => throw new ArgumentException("Unknown payment factory type. Use 'creditcard' or 'paypal'.", nameof(factoryType))
        };

        var gateway = factory.CreateGateway();
        var receiptFormatter = factory.CreateReceiptFormatter();

        return $"{gateway.Charge(amount)} | {receiptFormatter.Format(amount)}";
    }

    public string DeployToCloudWithAbstractFactory(string providerName, string applicationName)
    {
        ICloudAbstractFactory factory = providerName?.ToLowerInvariant() switch
        {
            "azure" => new AzureCloudFactory(),
            "aws" => new AwsCloudFactory(),
            _ => throw new ArgumentException("Unknown cloud provider. Use 'azure' or 'aws'.", nameof(providerName))
        };

        var service = factory.CreateService();
        var monitoring = factory.CreateMonitoring();

        return $"{service.Provision(applicationName)} | {monitoring.Monitor(applicationName)}";
    }
}
