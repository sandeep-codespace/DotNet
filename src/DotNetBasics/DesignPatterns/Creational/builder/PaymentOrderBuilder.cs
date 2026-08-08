namespace DotNetBasics.DesignPatterns.Creational.Builder
{
    public class PaymentOrderBuilder : IOrderBuilder
    {
        private readonly Order _order = new();

        public IOrderBuilder SetOrderId(string orderId)
        {
            _order.OrderId = orderId;
            return this;
        }

        public IOrderBuilder SetCustomerName(string customerName)
        {
            _order.CustomerName = customerName;
            return this;
        }

        public IOrderBuilder SetShippingAddress(string shippingAddress)
        {
            _order.ShippingAddress = shippingAddress;
            return this;
        }

        public IOrderBuilder SetGift(bool isGift)
        {
            _order.IsGift = isGift;
            return this;
        }

        public IOrderBuilder AddItem(string item)
        {
            _order.Items.Add(item);
            return this;
        }

        public IOrderBuilder SetPaymentMethod(string paymentMethod)
        {
            _order.PaymentMethod = paymentMethod;
            return this;
        }

        public IOrderBuilder SetTotalAmount(decimal totalAmount)
        {
            _order.TotalAmount = totalAmount;
            return this;
        }

        public Order Build()
        {
            return _order;
        }
    }
}
