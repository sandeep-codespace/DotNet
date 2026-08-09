
namespace DotNetBasics.DesignPatterns.Structural.Adapter;
public class ClientPayload : IClientPayload
{
    public long ReferenceId { get; set; }
    public long OrderId { get; set; }
}