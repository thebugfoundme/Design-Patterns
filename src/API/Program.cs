using API.Interfaces;
using API.Partners;
using API.Partners.CapitalLegacy;
using API.Partners.iWyze;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IInsuranceFactory, CapitalLegacyInsuranceFactory>();
builder.Services.AddScoped<IInsuranceFactory, IWyzeInsuranceFactory>();
builder.Services.AddScoped<InsurancePartnerProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
// add partners from https://www.hippo.co.za/
app
    .MapGet(
        "/{partner}/insurance-offer",
        ([FromServices] InsurancePartnerProvider insurancePartnerProvider, string partner) =>
        {
            try
            {
                var factory = insurancePartnerProvider.GetPartnerInsuranceFactory(partner);

                var result = new PartnerInsuranceOfferings
                {
                    AutoInsurance = factory.CreateAutoInsurance(),
                    HomeInsurance = factory.CreateHomeInsurance(),
                    LifeInsurance = factory.CreateLifeInsurance(),
                    TravelInsurance = factory.CreateTravelInsurance()
                };

                return Results.Ok(result);
            }
            catch (InvalidDataException idex)
            {
                return Results.NotFound(idex.Message);
            }
            catch
            {
                return Results.StatusCode(500);
            }
        })
    .WithMetadata()
    .WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
