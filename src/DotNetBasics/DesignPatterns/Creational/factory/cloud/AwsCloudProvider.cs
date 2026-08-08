namespace DotNetBasics.DesignPatterns.Creational.Factory.Cloud;

public sealed class AwsCloudProvider : ICloudProvider
{
    public string Deploy(string applicationName)
        => $"Deploying {applicationName} to AWS";
}
