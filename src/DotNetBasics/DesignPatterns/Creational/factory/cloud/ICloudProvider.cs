namespace DotNetBasics.DesignPatterns.Creational.Factory.Cloud;

public interface ICloudProvider
{
    string Deploy(string applicationName);
}
