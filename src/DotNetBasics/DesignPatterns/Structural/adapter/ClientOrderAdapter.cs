using System;

namespace DotNetBasics.DesignPatterns.Structural.Adapter; 
public class ClientOrderAdapter : IOrderPayload
{
    private readonly IClientPayload _clientPayload;

    public ClientOrderAdapter(IClientPayload clientPayload)
    {
        _clientPayload = clientPayload ?? throw new ArgumentNullException(nameof(clientPayload));
    }

    public long OrderId
    {
        get => _clientPayload.ReferenceId;
        set => _clientPayload.ReferenceId = value;
    }

    public long ClientTrackingId
    {
        get => _clientPayload.OrderId;
        set => _clientPayload.OrderId = value;
    }
}