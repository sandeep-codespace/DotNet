namespace DotNetBasics.DesignPatterns.Structural.Proxy;

public interface IOrderServiceProxy
{
    Task<OrderDto?> GetOrderAsync(int orderId);
    Task<bool> UpdateOrderStatusAsync(int orderId, string status);
}