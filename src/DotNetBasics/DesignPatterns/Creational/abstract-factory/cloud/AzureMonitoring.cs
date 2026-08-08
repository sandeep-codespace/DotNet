namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;

public sealed class AzureMonitoring : ICloudMonitoring
{
    public string Monitor(string resourceName)
        => $"Monitoring {resourceName} with Azure Monitor";
}
