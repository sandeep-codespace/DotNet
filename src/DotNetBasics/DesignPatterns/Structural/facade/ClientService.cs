
namespace DotNetBasics.DesignPatterns.Structural.Facade;
public class ClientService
{
    public bool HasGoodCredit(string clientId)
    {
        Console.WriteLine("Checking client credit...");
        return true; // simplified
    }
}