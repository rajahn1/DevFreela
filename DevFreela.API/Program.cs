using Application.Services.Implementations;
using Application.Services.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DevFreelaContext") ?? throw new Exception("Connection string not found");

builder.Services.AddControllers();

builder.Services.AddScoped<IProjectService,ProjectService>();
builder.Services.AddScoped<ISkillService,SkillService>();
builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DevFreelaDbContext>(options => options.UseNpgsql(connString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();