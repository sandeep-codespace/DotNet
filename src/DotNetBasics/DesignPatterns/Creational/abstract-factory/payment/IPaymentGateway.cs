namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public interface IPaymentGateway
{
    string Charge(decimal amount);
}
