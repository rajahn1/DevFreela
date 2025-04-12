using Application.Services.Implementations;
using Application.Services.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<DevFreelaDbContext>();
builder.Services.AddScoped<IProjectService,ProjectService>();
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

var dbContext =  app.Services.GetService<DevFreelaDbContext>();
dbContext.Database.OpenConnection();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();