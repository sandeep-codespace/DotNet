
namespace DotNetBasics.DesignPatterns.Structural.FlyWeight;
public class NotificationTemplate
{
    public string TemplateText { get; }

    public NotificationTemplate(string text) => TemplateText = text;

    public void Send(string user, double amount)
    {
        Console.WriteLine(TemplateText.Replace("{user}", user)
                                      .Replace("{amount}", amount.ToString()));
    }
}

// Flyweight Factory
public class NotificationTemplateFactory
{
    private readonly Dictionary<string, NotificationTemplate> _templates = new();

    public NotificationTemplate GetTemplate(string key, string text)
    {
        if (!_templates.ContainsKey(key))
            _templates[key] = new NotificationTemplate(text);
        return _templates[key];
    }
}

public class FlyWeightUsge
{
    
    public void Run()
    {
        var factory = new NotificationTemplateFactory();
var paymentTemplate = factory.GetTemplate("PaymentSuccess",
    "Dear {user}, your payment of ₹{amount} was successful!");

paymentTemplate.Send("User1", 5000);
paymentTemplate.Send("User2", 30000);
    }
}