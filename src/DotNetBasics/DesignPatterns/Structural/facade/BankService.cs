
namespace DotNetBasics.DesignPatterns.Structural.Facade;
public class BankService
{
    public bool CanApproveLoan(double amount)
    {
        Console.WriteLine("Checking bank loan rules...");
        return amount <= 1000000; // simplified
    }
}