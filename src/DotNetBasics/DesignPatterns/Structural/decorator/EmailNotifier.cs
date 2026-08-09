namespace DotNetBasics.DesignPatterns.Structural.Decorator;

public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

