namespace DotNetBasics.DesignPatterns.Creational.Factory.Cloud;

public sealed class CloudProviderFactory : ICloudProviderFactory
{
    public ICloudProvider Create(string providerName)
    {
        return providerName?.ToLowerInvariant() switch
        {
            "azure" => new AzureCloudProvider(),
            "aws" => new AwsCloudProvider(),
            _ => throw new ArgumentException("Unknown cloud provider. Use 'azure' or 'aws'.", nameof(providerName))
        };
    }

    public string Deploy(string providerName, string applicationName)
    {
        var provider = Create(providerName);
        return provider.Deploy(applicationName);
    }
}
