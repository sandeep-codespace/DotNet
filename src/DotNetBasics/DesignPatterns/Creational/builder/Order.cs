using System.Collections.Generic;
using System.Text;

namespace DotNetBasics.DesignPatterns.Creational.Builder
{
    public class Order
    {
        public string OrderId { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string ShippingAddress { get; set; } = string.Empty;
        public bool IsGift { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public List<string> Items { get; } = new();

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"OrderId: {OrderId}");
            builder.AppendLine($"Customer: {CustomerName}");
            builder.AppendLine($"Shipping Address: {ShippingAddress}");
            builder.AppendLine($"Is Gift: {IsGift}");
            builder.AppendLine($"Payment Method: {PaymentMethod}");
            builder.AppendLine($"Total Amount: {TotalAmount:C}");
            builder.AppendLine("Items:");
            foreach (var item in Items)
            {
                builder.AppendLine($" - {item}");
            }
            return builder.ToString();
        }
    }
}
