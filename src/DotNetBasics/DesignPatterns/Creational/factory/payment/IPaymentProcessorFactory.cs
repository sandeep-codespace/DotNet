namespace DotNetBasics.DesignPatterns.Creational.Factory.Payment;

public interface IPaymentProcessorFactory
{
    IPaymentProcessor Create(string paymentType);
    string Process(string paymentType, decimal amount);
}
