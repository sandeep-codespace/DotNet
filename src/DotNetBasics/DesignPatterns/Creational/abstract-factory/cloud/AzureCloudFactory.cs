namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;

public sealed class AzureCloudFactory : ICloudAbstractFactory
{
    public ICloudService CreateService()
        => new AzureService();

    public ICloudMonitoring CreateMonitoring()
        => new AzureMonitoring();
}
