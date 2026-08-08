namespace DotNetBasics.DesignPatterns.Creational.Factory.Cloud;

public interface ICloudProviderFactory
{
    ICloudProvider Create(string providerName);
    string Deploy(string providerName, string applicationName);
}
