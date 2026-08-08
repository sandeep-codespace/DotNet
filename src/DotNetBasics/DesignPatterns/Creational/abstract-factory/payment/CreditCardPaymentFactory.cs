namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public sealed class CreditCardPaymentFactory : IPaymentAbstractFactory
{
    public IPaymentGateway CreateGateway()
        => new CreditCardGateway();

    public IPaymentReceiptFormatter CreateReceiptFormatter()
        => new CreditCardReceiptFormatter();
}
