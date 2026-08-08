namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;

public sealed class AwsService : ICloudService
{
    public string Provision(string resourceName)
        => $"Provisioning {resourceName} on AWS";
}
