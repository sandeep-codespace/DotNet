namespace   DotNetBasics.DesignPatterns.Structural.Bridge;

public class SmsNotification : INotification
{
    
    public void Send(string message)
    {
        Console.WriteLine($"Send sms:{message}");
    }

}
