using MediatR;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Vendor.Infrastructure.Stores.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(swagger =>
{
    swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "Vendor API", Version = "v1" });
});

builder.Services.AddMediatR(typeof(GetStoreQueryHandler).Assembly);

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapSwagger();
});

app.UseSwaggerUI(swagger =>
{
    swagger.SwaggerEndpoint("v1/swagger.json", "Vednor API v1");
});

app.Run();
