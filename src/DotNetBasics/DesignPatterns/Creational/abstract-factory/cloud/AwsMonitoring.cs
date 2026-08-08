namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;

public sealed class AwsMonitoring : ICloudMonitoring
{
    public string Monitor(string resourceName)
        => $"Monitoring {resourceName} with AWS CloudWatch";
}
