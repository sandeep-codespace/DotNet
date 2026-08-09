using System;
namespace DotNetBasics.DesignPatterns.Structural.Adapter;
public class OrderClientAdapter : IClientPayload
{
    private readonly IOrderPayload _orderPayload;

    public OrderClientAdapter(IOrderPayload orderPayload)
    {
        _orderPayload = orderPayload ?? throw new ArgumentNullException(nameof(orderPayload));
    }

    public long OrderId
    {
        get => _orderPayload.ClientTrackingId;
        set => _orderPayload.ClientTrackingId = value;
    }

    public long ReferenceId
    {
        get => _orderPayload.OrderId;
        set => _orderPayload.OrderId = value;
    }
}