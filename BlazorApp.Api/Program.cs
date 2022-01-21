using BlazorApp.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<BlazorDBContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBBlazor;Trusted_Connection=True;MultipleActiveResultsets=true"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
