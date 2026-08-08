namespace DotNetBasics.DesignPatterns.Creational;
public sealed class Logger : ILogger
{
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

    private Logger()
    {
        // Private constructor to prevent instantiation from outside
    }

    public static Logger Instance => _instance.Value;

    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}
