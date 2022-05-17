using TrampoWarren.Data;
using FluentValidation.AspNetCore;
using TrampoWarren.Validation; 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
        .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<Validation>());
            builder.Services.AddMemoryCache();
            builder.Services.AddSingleton<IRepository, Repository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
