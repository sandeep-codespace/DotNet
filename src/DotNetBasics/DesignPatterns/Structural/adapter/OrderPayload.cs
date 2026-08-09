
namespace DotNetBasics.DesignPatterns.Structural.Adapter;
public class OrderPayload : IOrderPayload
{
    public long OrderId { get; set; }
    public long ClientTrackingId { get; set; }
}