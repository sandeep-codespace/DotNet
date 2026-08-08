namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public sealed class PayPalReceiptFormatter : IPaymentReceiptFormatter
{
    public string Format(decimal amount)
        => $"Receipt for PayPal payment: {amount:C}";
}
