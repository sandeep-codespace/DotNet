using DotNetApi.Services;
using DotNetBasics.DesignPatterns.Creational;
using DotNetBasics.DesignPatterns.Creational.Factory.Cloud;
using DotNetBasics.DesignPatterns.Creational.Factory.Payment;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<IDataService, DataService>();
builder.Services.AddSingleton<INotificationFactory, NotificationFactory>();
builder.Services.AddSingleton<IPaymentProcessorFactory, PaymentProcessorFactory>();
builder.Services.AddSingleton<ICloudProviderFactory, CloudProviderFactory>();
builder.Services.AddSingleton<DotNetBasics.DesignPatterns.Creational.ILogger>(Logger.Instance);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();


