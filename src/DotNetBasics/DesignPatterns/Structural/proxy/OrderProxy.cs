using System.Net.Http.Json;

namespace DotNetBasics.DesignPatterns.Structural.Proxy;
public class OrderServiceProxy : IOrderServiceProxy
{
    private readonly HttpClient _httpClient;

    public OrderServiceProxy(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<OrderDto?> GetOrderAsync(int orderId)
    {
        // Proxy adds logging, retries, etc.
        Console.WriteLine($"Calling Service B for order {orderId}");
        var response = await _httpClient.GetFromJsonAsync<OrderDto>($"api/orders/{orderId}");
        return response;
    }

    public async Task<bool> UpdateOrderStatusAsync(int orderId, string status)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/orders/{orderId}/status", status);
        return response.IsSuccessStatusCode;
    }
}