namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Payment;

public sealed class PayPalGateway : IPaymentGateway
{
    public string Charge(decimal amount)
        => $"Charging {amount:C} through the PayPal gateway";
}
