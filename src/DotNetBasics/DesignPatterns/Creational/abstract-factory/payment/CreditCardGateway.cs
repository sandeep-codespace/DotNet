namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public sealed class CreditCardGateway : IPaymentGateway
{
    public string Charge(decimal amount)
        => $"Charging {amount:C} through the credit card gateway";
}
