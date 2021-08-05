using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

//TODO: Test OpenAPI support in minimal APIs
//After starting the project, go to this URL https://localhost:5001/swagger. The generated API should be shown


 var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Description = "Docs for my API", Version = "v1" });
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});
 
//TODO: Create new routing API
 /*
  The new routing APIs allow users to route to any type of method. hese methods can use controller-like parameter binding, JSON formatting, and action result execution.
  1. Run the project
  2. No errors should arise 
  */
app.MapGet("/", (Func<string>)(() => "Hello World!"));
app.Run();