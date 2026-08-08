namespace DotNetBasics.DesignPatterns.Creational.Factory.Payment;

public sealed class PaymentProcessorFactory : IPaymentProcessorFactory
{
    public IPaymentProcessor Create(string paymentType)
    {
        return paymentType?.ToLowerInvariant() switch
        {
            "creditcard" or "credit-card" => new CreditCardPaymentProcessor(),
            "paypal" => new PayPalPaymentProcessor(),
            _ => throw new ArgumentException("Unknown payment type. Use 'creditcard' or 'paypal'.", nameof(paymentType))
        };
    }

    public string Process(string paymentType, decimal amount)
    {
        var processor = Create(paymentType);
        return processor.Process(amount);
    }
}
