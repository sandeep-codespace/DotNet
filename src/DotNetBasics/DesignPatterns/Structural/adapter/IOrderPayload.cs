
namespace DotNetBasics.DesignPatterns.Structural.Adapter;
public interface IOrderPayload
{
    long OrderId { get; set; }
    long ClientTrackingId { get; set; }
}

