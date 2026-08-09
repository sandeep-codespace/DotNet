using System;

namespace DotNetBasics.DesignPatterns.Structural.Adapter;
public static class AdapterUsageExample
{
    public static void Run()
    {
        Console.WriteLine("=== Client -> Order adapter ===");
        var clientPayload = new ClientPayload
        {
            ReferenceId = 9001,
            OrderId = 42
        };

        IOrderPayload orderAdapter = new ClientOrderAdapter(clientPayload);
        Console.WriteLine($"OrderId (from client.ReferenceId): {orderAdapter.OrderId}");
        Console.WriteLine($"ClientTrackingId (from client.OrderId): {orderAdapter.ClientTrackingId}");

        orderAdapter.OrderId = 10001;
        orderAdapter.ClientTrackingId = 77;
        Console.WriteLine($"Updated client.ReferenceId: {clientPayload.ReferenceId}");
        Console.WriteLine($"Updated client.OrderId: {clientPayload.OrderId}");

        Console.WriteLine();
        Console.WriteLine("=== Order -> Client adapter ===");
        var orderPayload = new OrderPayload
        {
            OrderId = 3002,
            ClientTrackingId = 88
        };

        IClientPayload clientAdapter = new OrderClientAdapter(orderPayload);
        Console.WriteLine($"ReferenceId (from order.OrderId): {clientAdapter.ReferenceId}");
        Console.WriteLine($"OrderId (from order.ClientTrackingId): {clientAdapter.OrderId}");

        clientAdapter.ReferenceId = 5005;
        clientAdapter.OrderId = 99;
        Console.WriteLine($"Updated order.OrderId: {orderPayload.OrderId}");
        Console.WriteLine($"Updated order.ClientTrackingId: {orderPayload.ClientTrackingId}");
    }
}