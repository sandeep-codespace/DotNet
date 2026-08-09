
namespace DotNetBasics.DesignPatterns.Structural.Adapter;
public interface IClientPayload
{
    long ReferenceId { get; set; }
    long OrderId { get; set; }
}