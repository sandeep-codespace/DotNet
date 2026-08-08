namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public sealed class CreditCardReceiptFormatter : IPaymentReceiptFormatter
{
    public string Format(decimal amount)
        => $"Receipt for card payment: {amount:C}";
}
