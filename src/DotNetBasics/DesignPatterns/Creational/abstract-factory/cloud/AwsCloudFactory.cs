namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;

public sealed class AwsCloudFactory : ICloudAbstractFactory
{
    public ICloudService CreateService()
        => new AwsService();

    public ICloudMonitoring CreateMonitoring()
        => new AwsMonitoring();
}
