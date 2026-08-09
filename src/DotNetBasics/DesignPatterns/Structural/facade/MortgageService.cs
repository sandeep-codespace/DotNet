
namespace DotNetBasics.DesignPatterns.Structural.Facade;
// Facade
public class MortgageFacade
{
    private readonly ClientService _client = new ClientService();
    private readonly PropertyService _property = new PropertyService();
    private readonly BankService _bank = new BankService();

    public bool IsEligible(string clientId, string propertyId, double amount)
    {
        Console.WriteLine($"Mortgage eligibility check for {clientId}...");
        return _client.HasGoodCredit(clientId) &&
               _property.IsValuableEnough(propertyId, amount) &&
               _bank.CanApproveLoan(amount);
    }
}