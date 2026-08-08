namespace DotNetBasics.DesignPatterns.Creational.Factory.Payment;

public sealed class CreditCardPaymentProcessor : IPaymentProcessor
{
    public string Process(decimal amount)
        => $"Processing credit card payment for {amount:C}";
}
