namespace DotNetBasics.DesignPatterns.Creational.Factory.Payment;

public interface IPaymentProcessor
{
    string Process(decimal amount);
}
