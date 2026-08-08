namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public interface IPaymentAbstractFactory
{
    IPaymentGateway CreateGateway();
    IPaymentReceiptFormatter CreateReceiptFormatter();
}
