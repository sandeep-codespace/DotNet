
namespace DotNetBasics.DesignPatterns.Structural.Facade;
public class PropertyService
{
    public bool IsValuableEnough(string propertyId, double amount)
    {
        Console.WriteLine("Checking property valuation...");
        return true; // simplified
    }
}