namespace DotNetBasics.DesignPatterns.Creational.Factory.Cloud;

public sealed class AzureCloudProvider : ICloudProvider
{
    public string Deploy(string applicationName)
        => $"Deploying {applicationName} to Azure";
}
