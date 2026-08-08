namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public sealed class PayPalPaymentFactory : IPaymentAbstractFactory
{
    public IPaymentGateway CreateGateway()
        => new PayPalGateway();

    public IPaymentReceiptFormatter CreateReceiptFormatter()
        => new PayPalReceiptFormatter();
}
