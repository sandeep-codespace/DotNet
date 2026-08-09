namespace DotNetBasics.DesignPatterns.Structural.Facade;

public static class FacadeUsageExample
{
    public static void Run()
    {
        var mortgage = new MortgageFacade();
        bool eligible = mortgage.IsEligible("Sandeep", "Property123", 500000);

        Console.WriteLine(eligible 
            ? "Mortgage Approved!" 
            : "Mortgage Denied!");
    }
}
