using Aplication;
using Aplication.Interfaces;
using Aplication.UseCase;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Querys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<IngredientesDBContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddScoped<IIngredienteCommand, IngredienteCommand>();
builder.Services.AddScoped<IIngredienteQuery, IngredienteQuery>();
builder.Services.AddScoped<IIngredienteService, IngredienteService>();

builder.Services.AddScoped<ITipoIngredienteCommand, TipoIngredienteCommand>();
builder.Services.AddScoped<ITipoIngredienteQuery, TipoIngredienteQuery>();
builder.Services.AddScoped<ITipoIngredienteService, TipoIngredienteService>();

builder.Services.AddScoped<ITipoMedidaCommand, TipoMedidaCommand>();
builder.Services.AddScoped<ITipoMedidaQuery, TipoMedidaQuery>();
builder.Services.AddScoped<ITipoMedidaService, TipoMedidaService>();

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
