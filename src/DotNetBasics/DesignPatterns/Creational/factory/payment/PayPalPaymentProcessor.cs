namespace DotNetBasics.DesignPatterns.Creational.Factory.Payment;

public sealed class PayPalPaymentProcessor : IPaymentProcessor
{
    public string Process(decimal amount)
        => $"Processing PayPal payment for {amount:C}";
}
