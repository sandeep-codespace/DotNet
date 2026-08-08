namespace DotNetBasics.DesignPatterns.Creational.AbstractFactory.Cloud;

public interface ICloudAbstractFactory
{
    ICloudService CreateService();
    ICloudMonitoring CreateMonitoring();
}
