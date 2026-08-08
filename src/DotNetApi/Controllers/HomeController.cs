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
}
