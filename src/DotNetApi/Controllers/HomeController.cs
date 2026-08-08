using DotNetBasics.DesignPatterns.Creational;
using Microsoft.AspNetCore.Mvc;
using DotNetApi.Services;

namespace DotNetApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly IDataService _dataService;

    public HomeController(IDataService dataService)
    {
        _dataService = dataService;
    }

    [HttpGet("index")]
    public IActionResult Index()
    {
        return Ok(new { message = "Welcome to the DotNetApi Home controller." });
    }

    [HttpGet("items")]
    public IActionResult GetItems()
    {
        var items = _dataService.GetItems();
        return Ok(items);
    }

    [HttpPost("notify/email")]
    public IActionResult NotifyEmail([FromBody] EmailPayload payload)
    {
        var result = _dataService.SendEmail(payload);
        return Ok(new { result });
    }

    [HttpPost("notify/sms")]
    public IActionResult NotifySms([FromBody] SmsPayload payload)
    {
        var result = _dataService.SendSms(payload);
        return Ok(new { result });
    }

    [HttpGet("payment/{paymentType}")]
    public IActionResult ProcessPayment(string paymentType, [FromQuery] decimal amount)
    {
        var result = _dataService.ProcessPayment(paymentType, amount);
        return Ok(new { result });
    }

    [HttpGet("cloud/{providerName}")]
    public IActionResult DeployToCloud(string providerName, [FromQuery] string applicationName)
    {
        var result = _dataService.DeployToCloud(providerName, applicationName);
        return Ok(new { result });
    }

    [HttpGet("payment/abstract/{factoryType}")]
    public IActionResult ProcessPaymentWithAbstractFactory(string factoryType, [FromQuery] decimal amount)
    {
        var result = _dataService.ProcessPaymentWithAbstractFactory(factoryType, amount);
        return Ok(new { result });
    }

    [HttpGet("cloud/abstract/{providerName}")]
    public IActionResult DeployToCloudWithAbstractFactory(string providerName, [FromQuery] string applicationName)
    {
        var result = _dataService.DeployToCloudWithAbstractFactory(providerName, applicationName);
        return Ok(new { result });
    }
}
