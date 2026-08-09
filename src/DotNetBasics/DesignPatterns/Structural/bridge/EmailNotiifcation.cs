namespace   DotNetBasics.DesignPatterns.Structural.Bridge;

public class EmailNotification : INotification
{
    
    public void Send(string message)
    {
        Console.WriteLine($"Send email:{message}");
    }

}
