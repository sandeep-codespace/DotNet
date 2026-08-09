namespace DotNetBasics.DesignPatterns.Structural.Proxy;
public class OrderService : IOrderServiceProxy
{
    public async Task<OrderDto?> GetOrderAsync(int orderId)
    {
        // Actual DB logic in Service B
        return new OrderDto { Id = orderId, Status = "Pending" };
    }

    public async Task<bool> UpdateOrderStatusAsync(int orderId, string status)
    {
        // Actual DB update logic
        return true;
    }
}