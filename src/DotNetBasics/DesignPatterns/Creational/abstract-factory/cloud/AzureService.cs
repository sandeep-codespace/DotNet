namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;

public sealed class AzureService : ICloudService
{
    public string Provision(string resourceName)
        => $"Provisioning {resourceName} on Azure";
}
