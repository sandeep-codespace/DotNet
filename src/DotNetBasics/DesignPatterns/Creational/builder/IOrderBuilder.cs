namespace DotNetBasics.DesignPatterns.Creational.Builder
{
    public interface IOrderBuilder
    {
        IOrderBuilder SetOrderId(string orderId);
        IOrderBuilder SetCustomerName(string customerName);
        IOrderBuilder SetShippingAddress(string shippingAddress);
        IOrderBuilder SetGift(bool isGift);
        IOrderBuilder AddItem(string item);
        IOrderBuilder SetPaymentMethod(string paymentMethod);
        IOrderBuilder SetTotalAmount(decimal totalAmount);
        Order Build();
    }
}
