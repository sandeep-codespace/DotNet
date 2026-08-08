namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public interface IPaymentReceiptFormatter
{
    string Format(decimal amount);
}
