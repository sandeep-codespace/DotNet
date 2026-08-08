namespace DotNetBasics.DesignPatterns.Creational.Builder
{
    public static class OrderDirector
    {
        public static Order CreateStandardOrder(IOrderBuilder builder)
        {
            return builder
                .SetOrderId("ORD-1001")
                .SetCustomerName("Jordan Smith")
                .SetShippingAddress("456 Elm Street, Springfield")
                .AddItem("Premium Laptop")
                .AddItem("Wireless Mouse")
                .SetPaymentMethod("Credit Card")
                .SetTotalAmount(1599.95m)
                .Build();
        }

        public static Order CreateGiftOrder(IOrderBuilder builder)
        {
            return builder
                .SetOrderId("ORD-1002")
                .SetCustomerName("Morgan Lee")
                .SetShippingAddress("789 Oak Avenue, Lakeside")
                .SetGift(true)
                .AddItem("Smartwatch")
                .AddItem("Gift Box")
                .SetPaymentMethod("PayPal")
                .SetTotalAmount(299.90m)
                .Build();
        }
    }
}
