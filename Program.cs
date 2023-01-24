using Microsoft.EntityFrameworkCore;
using WebAPI_Softek;
using WebAPI_Softek.Models;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<IVentaRepository, VentaRepository>();
builder.Services.AddControllers();
builder.Services.AddDbContext<VentasContext>(opt =>
    opt.UseInMemoryDatabase("VentasDb"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
